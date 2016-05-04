namespace Setup_Advisor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LapNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LapTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Split = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentLap = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBestLap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAverageLap = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.labelConsistencyS1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.labelConsistencyS2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.label12 = new System.Windows.Forms.Label();
            this.labelConsistencyS3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.labelConsistencyTotal = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.labelCircuit = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelVariant = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // chart1
            // 
            chartArea4.AxisX.Title = "Lap";
            chartArea4.AxisY.Title = "Time (s)";
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series10.Legend = "Legend1";
            series10.Name = "Sector1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series11.Legend = "Legend1";
            series11.Name = "Sector2";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series12.Legend = "Legend1";
            series12.Name = "Sector3";
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(797, 403);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(210, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 435);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LapNumber,
            this.Sector1,
            this.Sector2,
            this.Sector3,
            this.LapTime,
            this.Valid,
            this.Split});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(797, 403);
            this.dataGridView1.TabIndex = 0;
            // 
            // LapNumber
            // 
            this.LapNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LapNumber.FillWeight = 177.665F;
            this.LapNumber.HeaderText = "Lap#";
            this.LapNumber.Name = "LapNumber";
            this.LapNumber.ReadOnly = true;
            this.LapNumber.Width = 57;
            // 
            // Sector1
            // 
            this.Sector1.FillWeight = 87.05584F;
            this.Sector1.HeaderText = "Sector1";
            this.Sector1.Name = "Sector1";
            this.Sector1.ReadOnly = true;
            // 
            // Sector2
            // 
            this.Sector2.FillWeight = 87.05584F;
            this.Sector2.HeaderText = "Sector2";
            this.Sector2.Name = "Sector2";
            this.Sector2.ReadOnly = true;
            // 
            // Sector3
            // 
            this.Sector3.FillWeight = 87.05584F;
            this.Sector3.HeaderText = "Sector3";
            this.Sector3.Name = "Sector3";
            this.Sector3.ReadOnly = true;
            // 
            // LapTime
            // 
            this.LapTime.FillWeight = 87.05584F;
            this.LapTime.HeaderText = "Lap Time";
            this.LapTime.Name = "LapTime";
            this.LapTime.ReadOnly = true;
            // 
            // Valid
            // 
            this.Valid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Valid.FillWeight = 87.05584F;
            this.Valid.HeaderText = "Valid";
            this.Valid.Name = "Valid";
            this.Valid.ReadOnly = true;
            this.Valid.Width = 55;
            // 
            // Split
            // 
            this.Split.FillWeight = 87.05584F;
            this.Split.HeaderText = "Split";
            this.Split.Name = "Split";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chart View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(1084, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 217);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.splitContainer1);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.splitContainer2);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.splitContainer3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(160, 198);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelCurrentLap);
            this.splitContainer1.Size = new System.Drawing.Size(150, 54);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current";
            // 
            // labelCurrentLap
            // 
            this.labelCurrentLap.AutoSize = true;
            this.labelCurrentLap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurrentLap.Location = new System.Drawing.Point(0, 0);
            this.labelCurrentLap.Name = "labelCurrentLap";
            this.labelCurrentLap.Size = new System.Drawing.Size(62, 13);
            this.labelCurrentLap.TabIndex = 1;
            this.labelCurrentLap.Text = "Current Lap";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 2);
            this.label5.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 65);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.labelBestLap);
            this.splitContainer2.Size = new System.Drawing.Size(150, 54);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Best";
            // 
            // labelBestLap
            // 
            this.labelBestLap.AutoSize = true;
            this.labelBestLap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBestLap.Location = new System.Drawing.Point(0, 0);
            this.labelBestLap.Name = "labelBestLap";
            this.labelBestLap.Size = new System.Drawing.Size(49, 13);
            this.labelBestLap.TabIndex = 1;
            this.labelBestLap.Text = "Best Lap";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 2);
            this.label4.TabIndex = 8;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(3, 127);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label6);
            this.splitContainer3.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.labelAverageLap);
            this.splitContainer3.Size = new System.Drawing.Size(150, 54);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Average";
            // 
            // labelAverageLap
            // 
            this.labelAverageLap.AutoSize = true;
            this.labelAverageLap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAverageLap.Location = new System.Drawing.Point(0, 0);
            this.labelAverageLap.Name = "labelAverageLap";
            this.labelAverageLap.Size = new System.Drawing.Size(73, 13);
            this.labelAverageLap.TabIndex = 1;
            this.labelAverageLap.Text = "Average Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(1087, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 282);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consistency";
            this.toolTip1.SetToolTip(this.groupBox2, "Standard Deviation - Lower is better");
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.splitContainer4);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.splitContainer5);
            this.flowLayoutPanel2.Controls.Add(this.label11);
            this.flowLayoutPanel2.Controls.Add(this.splitContainer6);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.splitContainer7);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(160, 263);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            this.splitContainer4.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.labelConsistencyS1);
            this.splitContainer4.Size = new System.Drawing.Size(150, 54);
            this.splitContainer4.SplitterDistance = 25;
            this.splitContainer4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sector 1";
            // 
            // labelConsistencyS1
            // 
            this.labelConsistencyS1.AutoSize = true;
            this.labelConsistencyS1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelConsistencyS1.Location = new System.Drawing.Point(0, 0);
            this.labelConsistencyS1.Name = "labelConsistencyS1";
            this.labelConsistencyS1.Size = new System.Drawing.Size(80, 13);
            this.labelConsistencyS1.TabIndex = 1;
            this.labelConsistencyS1.Text = "S1 Consistency";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 2);
            this.label8.TabIndex = 7;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Location = new System.Drawing.Point(3, 65);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.label9);
            this.splitContainer5.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.labelConsistencyS2);
            this.splitContainer5.Size = new System.Drawing.Size(150, 54);
            this.splitContainer5.SplitterDistance = 25;
            this.splitContainer5.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sector 2";
            // 
            // labelConsistencyS2
            // 
            this.labelConsistencyS2.AutoSize = true;
            this.labelConsistencyS2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelConsistencyS2.Location = new System.Drawing.Point(0, 0);
            this.labelConsistencyS2.Name = "labelConsistencyS2";
            this.labelConsistencyS2.Size = new System.Drawing.Size(80, 13);
            this.labelConsistencyS2.TabIndex = 1;
            this.labelConsistencyS2.Text = "S2 Consistency";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(3, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 2);
            this.label11.TabIndex = 8;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Location = new System.Drawing.Point(3, 127);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.label12);
            this.splitContainer6.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.labelConsistencyS3);
            this.splitContainer6.Size = new System.Drawing.Size(150, 54);
            this.splitContainer6.SplitterDistance = 25;
            this.splitContainer6.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Sector 3";
            // 
            // labelConsistencyS3
            // 
            this.labelConsistencyS3.AutoSize = true;
            this.labelConsistencyS3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelConsistencyS3.Location = new System.Drawing.Point(0, 0);
            this.labelConsistencyS3.Name = "labelConsistencyS3";
            this.labelConsistencyS3.Size = new System.Drawing.Size(80, 13);
            this.labelConsistencyS3.TabIndex = 1;
            this.labelConsistencyS3.Text = "S3 Consistency";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(3, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 2);
            this.label7.TabIndex = 10;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Location = new System.Drawing.Point(3, 189);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.label10);
            this.splitContainer7.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.labelConsistencyTotal);
            this.splitContainer7.Size = new System.Drawing.Size(150, 54);
            this.splitContainer7.SplitterDistance = 25;
            this.splitContainer7.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Whole Lap";
            // 
            // labelConsistencyTotal
            // 
            this.labelConsistencyTotal.AutoSize = true;
            this.labelConsistencyTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelConsistencyTotal.Location = new System.Drawing.Point(0, 0);
            this.labelConsistencyTotal.Name = "labelConsistencyTotal";
            this.labelConsistencyTotal.Size = new System.Drawing.Size(85, 13);
            this.labelConsistencyTotal.TabIndex = 1;
            this.labelConsistencyTotal.Text = "Lap Consistency";
            // 
            // toolTip1
            // 
            this.toolTip1.UseAnimation = false;
            this.toolTip1.UseFading = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 368);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(93, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 42);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.buttonNew);
            this.flowLayoutPanel3.Controls.Add(this.buttonEdit);
            this.flowLayoutPanel3.Controls.Add(this.buttonStart);
            this.flowLayoutPanel3.Controls.Add(this.buttonStop);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 402);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(189, 102);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // buttonNew
            // 
            this.buttonNew.Enabled = false;
            this.buttonNew.Location = new System.Drawing.Point(3, 3);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(84, 42);
            this.buttonNew.TabIndex = 3;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(3, 51);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(84, 42);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(93, 51);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(84, 42);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel4);
            this.groupBox3.Location = new System.Drawing.Point(217, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 61);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Run Information";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label13);
            this.flowLayoutPanel4.Controls.Add(this.labelCircuit);
            this.flowLayoutPanel4.Controls.Add(this.label14);
            this.flowLayoutPanel4.Controls.Add(this.labelVariant);
            this.flowLayoutPanel4.Controls.Add(this.label16);
            this.flowLayoutPanel4.Controls.Add(this.labelCar);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(798, 42);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Circuit:";
            // 
            // labelCircuit
            // 
            this.labelCircuit.AutoSize = true;
            this.labelCircuit.Location = new System.Drawing.Point(48, 0);
            this.labelCircuit.Name = "labelCircuit";
            this.labelCircuit.Size = new System.Drawing.Size(80, 13);
            this.labelCircuit.TabIndex = 1;
            this.labelCircuit.Text = "Circuit Location";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(134, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Variant:";
            // 
            // labelVariant
            // 
            this.labelVariant.AutoSize = true;
            this.labelVariant.Location = new System.Drawing.Point(183, 0);
            this.labelVariant.Name = "labelVariant";
            this.labelVariant.Size = new System.Drawing.Size(71, 13);
            this.labelVariant.TabIndex = 3;
            this.labelVariant.Text = "Track Variant";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(260, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Car:";
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Location = new System.Drawing.Point(292, 0);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(54, 13);
            this.labelCar.TabIndex = 5;
            this.labelCar.Text = "Car Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 590);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Lap Times - Timing Logger";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelCurrentLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBestLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAverageLap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelConsistencyS1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelConsistencyS2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelConsistencyS3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelConsistencyTotal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelCircuit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelVariant;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn LapNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LapTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Split;
    }
}

