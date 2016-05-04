using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Setup_Advisor
{
    public partial class Form1 : Form
    {
        // hotkeys:
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }


        private bool OUT_LAP = true; 
        private List<Run> runs = new List<Run>();
        private Run currentRun = new Run();
        private bool running = false;
        Telemetry telemetry = new Telemetry();

        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = runs;
            listBox1.DisplayMember = "title";
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
            RegisterHotKey(this.Handle, 0, (int)KeyModifier.None, Keys.Space.GetHashCode());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // TODO: telemetry fetching catch exceptions when pCars is not running
            telemetry = refreshTelemetry();
            // make sure track or car hasn't changed while running
            if (currentRun.times.Count != 0 && telemetry.gameStates.mGameState != 4 // ignore restarts
                && (currentRun.car != telemetry.vehicleInformation.mCarName 
                    || currentRun.trackLocation != telemetry.eventInformation.mTrackLocation
                    || currentRun.trackVariant != telemetry.eventInformation.mTrackVariation))
            {
                Invoke((MethodInvoker)delegate
                {
                    stopRun();
                });
                return;
            }

            float currentLapTime = telemetry.timings.mCurrentTime;

            if (currentLapTime == -1)
            {
                OUT_LAP = true;
            }
            else if (currentLapTime < 1) // crossed the line on a new lap
            {
                if (OUT_LAP == true) // don't record any times on out laps
                {
                    OUT_LAP = false;
                    Thread.Sleep(2000);
                }
                else // record the previous lap
                {
                    try
                    {
                        recordLap();
                    }
                    catch (Exception exc)
                    {
                        Console.Write(exc.StackTrace);
                        throw;
                    }

                }
            }
            // update other ui elements with each run of BackgroundWorker1
            this.Invoke((MethodInvoker)delegate
            {
                // update current lap time
                labelCurrentLap.Text = telemetry.timings.mCurrentTime.ToString();
            });
            
        }

        private void recordLap()
        {

            // on first lap, record car and track details
            if (currentRun.times.Count() == 0)
            {
                currentRun.trackLocation = telemetry.eventInformation.mTrackLocation;
                currentRun.trackVariant = telemetry.eventInformation.mTrackVariation;
                currentRun.car = telemetry.vehicleInformation.mCarName;
                // update UI with the new info
                Invoke((MethodInvoker)delegate
                {
                    updateRunInfo();
                });
                //runs.Add(currentRun);
            }
            // get lap data from telemetry
            float sector2 = telemetry.timings.mCurrentSector2Time;
            float sector3 = telemetry.timings.mCurrentSector3Time;
            float wholeLap = telemetry.timings.mLastLapTime;
            bool valid = !telemetry.timings.mLapInvalidated;
            LapTime lap = new LapTime(sector2, sector3, wholeLap, valid);

            // record lap data
            currentRun.times.Add(lap);
            // update lap-related ui elements
            Invoke((MethodInvoker)delegate
            {
                // add lap to chart
                addLapToChart(lap);
                // add lap to table
                dataGridView1.Rows.Add(currentRun.times.Count(), lap.sector1, lap.sector2, lap.sector3, lap.total, lap.valid, lap.total - currentRun.GetBestValid().total);
                updateLapStats();
                if (currentRun.GetBestValid().total == lap.total) // new best lap: update split times in table
                {
                    updateTableSplitTimes();
                }
            });
            Thread.Sleep(2000);
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(50);
            if (running)
                backgroundWorker1.RunWorkerAsync(); // keep running
        }

        public Telemetry refreshTelemetry()
        {
            string url = "http://localhost:8080/crest/v1/api";
            var tel = _download_serialized_json_data<Telemetry>(url);
            
            return tel;
        }

        private static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception)
                {
                    return default(T);
                }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }

        //hotkey actions
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                /* Note that the three lines below are not needed if you only want to register one hotkey.
                 * The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason. */

                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.


                //MessageBox.Show("Hotkey has been pressed!");
                // do something
                switch (id)
                {
                    case 0: if (running) stopRun(); else startRun(); break;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
        }

        private void addLapToChart(LapTime lap)
        {
            chart1.Series["Sector1"].Points.AddY(lap.sector1);
            chart1.Series["Sector2"].Points.AddY(lap.sector2);
            chart1.Series["Sector3"].Points.AddY(lap.sector3);
        }

        private void updateLapStats()
        {
            labelBestLap.Text = currentRun.GetBestValid().total.ToString();// update best lap
            labelAverageLap.Text = currentRun.Average().total.ToString(); // average total lap time
            // update consistencies for total time and each sector
            labelConsistencyTotal.Text = Math.Round(currentRun.CalculateStdDeviation(Run.Sector.ALL_SECTORS), 3).ToString();
            labelConsistencyS1.Text = Math.Round(currentRun.CalculateStdDeviation(Run.Sector.SECTOR_ONE), 3).ToString();
            labelConsistencyS2.Text = Math.Round(currentRun.CalculateStdDeviation(Run.Sector.SECTOR_TWO), 3).ToString();
            labelConsistencyS3.Text = Math.Round(currentRun.CalculateStdDeviation(Run.Sector.SECTOR_THREE), 3).ToString();
        }

        private void updateTableSplitTimes()
        {   
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Split"].Value = (float)Math.Round(Convert.ToDouble(row.Cells["LapTime"].Value) - currentRun.GetBestValid().total, 3);
            }
        }

        private void updateRunInfo()
        {
            labelCircuit.Text = currentRun.trackLocation;
            labelVariant.Text = currentRun.trackVariant;
            labelCar.Text = currentRun.car;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            startRun();
        }


        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopRun();
        }

        private void startRun()
        {
            telemetry = refreshTelemetry();
            if (telemetry != null)
            {
                if (telemetry.gameStates.mGameState < 5 && telemetry.gameStates.mGameState > 1)
                {
                    // track info exists but does not match - don't start run
                    // otherwise start run
                    // new runs do not need to be checked - any null values should be overwritten
                    if (currentRun.car != null && currentRun.trackLocation != null && currentRun.trackVariant != null)
                    {
                        // check car and track match current run before starting
                        if (currentRun.trackLocation != telemetry.eventInformation.mTrackLocation // locations do not match, or;
                            || currentRun.trackVariant != telemetry.eventInformation.mTrackVariation // variants do not match, or;
                            || currentRun.car != telemetry.vehicleInformation.mCarName) // cars do not match, then:
                        {
                            // show error dialog, do not start run
                            MessageBox.Show("Car and/or location do not match current run. Please select a different run or start a new run", "Wrong car or track", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    // start 
                    buttonStart.Enabled = false;
                    buttonNew.Enabled = false;
                    buttonStop.Enabled = true;
                    running = true;
                    backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Please load a game session before recording a run");
                }
            } else
            {
                MessageBox.Show("Please start Project Cars first. If the game is already running, ensure Shared Memory is enabled");
                return;
            }
        }

        private void stopRun()
        {
            buttonNew.Enabled = true;
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            running = false;
            // don't need to stop backgroundWorker1. It will not run again once it completes (see BackgroundWorker1_RunWorkerCompleted)
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
