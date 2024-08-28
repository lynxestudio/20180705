using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Samples.Data.WinOracleHelper
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnQueryClick(object sender, EventArgs e)
        {
            FrmQuery q = new FrmQuery();
            q.ShowDialog(this);
        }

        private void BtnUpdateClick(object sender, EventArgs e)
        {
            FrmUpdate u = new FrmUpdate();
            u.ShowDialog(this);
        }

        private void BtnCreateClick(object sender, EventArgs e)
        {
            FrmCreate c = new FrmCreate();
            c.ShowDialog(this);
        }
    }
}
