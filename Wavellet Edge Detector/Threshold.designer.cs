namespace WED
{
    partial class ThresholdDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThresholdDlg));
            this.gbthreshold = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbthreshold = new System.Windows.Forms.TextBox();
            this.pbthreshold = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbthreshold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbthreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLine
            // 
            this.gbthreshold.Controls.Add(this.btnOK);
            this.gbthreshold.Controls.Add(this.tbthreshold);
            this.gbthreshold.Controls.Add(this.pbthreshold);
            this.gbthreshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbthreshold.Location = new System.Drawing.Point(0, 0);
            this.gbthreshold.Name = "gbLine";
            this.gbthreshold.Size = new System.Drawing.Size(200, 51);
            this.gbthreshold.TabIndex = 1;
            this.gbthreshold.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(118, 19);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(70, 21);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnthreshold_Click);
            // 
            // tbLine
            // 
            this.tbthreshold.Location = new System.Drawing.Point(42, 19);
            this.tbthreshold.Name = "tbLine";
            this.tbthreshold.Size = new System.Drawing.Size(70, 20);
            this.tbthreshold.TabIndex = 0;
            // 
            // pbLine
            // 
            this.pbthreshold.Image = ((System.Drawing.Image)(resources.GetObject("pbLine.Image")));
            this.pbthreshold.Location = new System.Drawing.Point(12, 19);
            this.pbthreshold.Name = "pbLine";
            this.pbthreshold.Size = new System.Drawing.Size(24, 20);
            this.pbthreshold.TabIndex = 2;
            this.pbthreshold.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(57, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(22, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BMGo2LineDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(200, 51);
            this.Controls.Add(this.gbthreshold);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMGo2LineDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Threshold";
            this.Load += new System.EventHandler(this.ThresholdDlg_Load);
            this.gbthreshold.ResumeLayout(false);
            this.gbthreshold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbthreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbthreshold;
        private System.Windows.Forms.PictureBox pbthreshold;
        private System.Windows.Forms.TextBox tbthreshold;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}