using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace Setup_Advisor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process Crest = new Process();
            Process[] P = Process.GetProcessesByName("CREST-1.0.2");
            if (P.Length > 1)
            {
                Crest = P.First();
            }
            else if (P.Length == 1) // crest already running - assign process
            {
                Crest = P.First();
            }
            else // start crest
            {
                Crest.StartInfo.FileName = "C:/Users/nicmo/Documents/visual studio 2015/Projects/Setup Advisor/Setup Advisor/bin/Debug/CREST-1.0.2/CREST-1.0.2.exe";
                Crest.Start();
                Thread.Sleep(100); // prevent crest opening on top of timing logger
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            if (!Crest.HasExited)
            {
                Crest.CloseMainWindow();
                Crest.Close();
            }

        }
    }
}
