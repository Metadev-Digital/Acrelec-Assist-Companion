using Acrelec_Assist_Companion.Properties;
using System;
using System.Windows.Forms;


/*Acrelec Assist Companion Version 0.5
 * Created: 10/21/2020
 * Updated: 10/21/2020
 * Designed by: Kevin Sherman at Acrelec America
 * Contact at: Kevin@Metadevllc.com
 * 
 * Copyright MIT License - Enjoy boys, keep updating without me. Fork to your hearts content
 */

//---------------FOR VERSION 1.0------------------
//Additional Features:
//

//Processes:
//Import and Process Excel doc
//Reach out to db
//Run procss on DB to see what is out of spec
//Run report with visuals

//Content & Visuals
//

namespace Acrelec_Assist_Companion
{

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }


        /// <summary>
        /// Sets up the application for use
        /// </summary>
        /// <param name="sender">frmMain</param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version " + Settings.Default.version;
        }


        /// <summary>
        /// Start up processes after the form has already loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Shown(object sender, EventArgs e)
        {
            establishConnection();
        }


        /// <summary>
        /// Properly closes the application 
        /// </summary>
        /// <param name="sender">frmMain</param>
        /// <param name="e">mnuFileExit</param>
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Launches the frmAbout window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout aboutFrame = new frmAbout();
            aboutFrame.ShowDialog();
        }

        /// <summary>
        /// Establishes a connection to the database, providing a visual context to the user.
        /// </summary>
        private void establishConnection()
        {
            lblConnectionEstablishing.Visible = true;

            wait(10000);
            lblConnectionEstablishing.Visible = false;
            lblConnectionFailed.Visible = true;

        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }


    }
}
