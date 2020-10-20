using System;
using System.Windows.Forms;

namespace Acrelec_Assist_Companion
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
    }
}
