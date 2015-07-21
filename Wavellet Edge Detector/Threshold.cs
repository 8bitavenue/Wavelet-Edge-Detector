using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WED
{
    public partial class ThresholdDlg : Form
    {
        String threshold = "1";

        public String Threshold
        {
            get 
            { 
                return threshold; 
            }

            set 
            { 
                threshold = value; 
            }
        }

        public ThresholdDlg()
        {
            InitializeComponent();

            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
        }

        private void btnthreshold_Click(object sender, EventArgs e)
        {
            this.Threshold = tbthreshold.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void ThresholdDlg_Load(object sender, EventArgs e)
        {
            tbthreshold.Text = this.Threshold.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}