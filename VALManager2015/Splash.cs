using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace VALManager2015
{
    public partial class Splash : Form
    {
        BackgroundWorker m_oWorker;

        public Splash()
        {
            InitializeComponent();
            m_oWorker = new BackgroundWorker();

            // Create a background worker thread that ReportsProgress &
            // SupportsCancellation
            // Hook up the appropriate events.
            m_oWorker.DoWork += new DoWorkEventHandler(m_oWorker_DoWork);
            m_oWorker.ProgressChanged += new ProgressChangedEventHandler(m_oWorker_ProgressChanged);
            m_oWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_oWorker_RunWorkerCompleted);
            m_oWorker.WorkerReportsProgress = true;
            m_oWorker.WorkerSupportsCancellation = true;
        }

        private void Splash_Load(object sender, EventArgs e)
        {
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            m_oWorker.RunWorkerAsync();
        }

        private void CheckForRequiredFiles()
        {
        }

        /// <summary>
        /// On completed do the appropriate task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_oWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Check to see if an error occurred in the background process.

            if (e.Error != null)
            {
                labelTask.Text = "Error while performing background operation.";
            }
            else
            {
                // Everything completed normally.
                labelTask.Text = "Task Completed...";
            }

            //Close this form
            Close();
        }

        /// <summary>
        /// Notification is performed here to the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_oWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            // This function fires on the UI thread so it's safe to edit

            // the UI control directly, no funny business with Control.Invoke :)

            // Update the progressBar with the integer supplied to us from the

            // ReportProgress() function.  

            progressBar.Value = e.ProgressPercentage;
            labelTask.Text = "Checking for integrity......" + progressBar.Value.ToString() + "%";
        }

        /// <summary>
        /// Time consuming operations go here </br>
        /// i.e. Database operations,Reporting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_oWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //these operations are real, not a fake so, let them here forever
            //if (!Directory.Exists(Path.Combine(Application.StartupPath, "Config")))
            //    Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Config"));
            m_oWorker.ReportProgress(1);

            //if (!File.Exists(Path.Combine(Application.StartupPath, "DigitalizeRobotCheck.dll")))
            //{
            //    Program.CloseApp = true;
            //    MyMessageBox.Show("There are mising files neded to the application works properly");
            //}
            m_oWorker.ReportProgress(2);
            //this loop is only to show the splash, put here the real functionalities
            for (int i = 3; i < 100; i++)
            {
                Thread.Sleep(10);

                // Periodically report progress to the main thread so that it can
                // update the UI.  In most cases you'll just need to send an
                // integer that will update a ProgressBar                    
                m_oWorker.ReportProgress(i);
                // Periodically check if a cancellation request is pending.
                // If the user clicks cancel the line
                // m_AsyncWorker.CancelAsync(); if ran above.  This
                // sets the CancellationPending to true.
                // You must check this flag in here and react to it.
                // We react to it by setting e.Cancel to true and leaving
                if (m_oWorker.CancellationPending)
                {
                    // Set the e.Cancel flag so that the WorkerCompleted event
                    // knows that the process was cancelled.
                    e.Cancel = true;
                    m_oWorker.ReportProgress(0);
                    return;
                }
            }

            //Report 100% completion on operation completed
            m_oWorker.ReportProgress(100);
        }
    }
}
