using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager2
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        #region Method
        void LoadTable()
        {

        }
        #endregion

        #region Events
        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount fAcc = new fAccount();
            fAcc.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin fAd = new fAdmin();
            fAd.ShowDialog();
        }
        #endregion
    }
}
