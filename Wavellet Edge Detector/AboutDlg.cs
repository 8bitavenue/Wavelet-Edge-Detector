using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WED
{
    public partial class AboutDlg : System.Windows.Forms.Form
    {
        public AboutDlg()
        {
            InitializeComponent();

            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }

        private void lblUniversity_Click(object sender, EventArgs e)
        {

        }
    }
}