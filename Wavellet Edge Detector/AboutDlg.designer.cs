namespace WED
{
    partial class AboutDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDlg));
            this.pbSnake = new System.Windows.Forms.PictureBox();
            this.gpMain = new System.Windows.Forms.GroupBox();
            this.lblBy = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake)).BeginInit();
            this.gpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSnake
            // 
            this.pbSnake.Image = ((System.Drawing.Image)(resources.GetObject("pbSnake.Image")));
            this.pbSnake.Location = new System.Drawing.Point(2, 1);
            this.pbSnake.Name = "pbSnake";
            this.pbSnake.Size = new System.Drawing.Size(290, 232);
            this.pbSnake.TabIndex = 27;
            this.pbSnake.TabStop = false;
            // 
            // gpMain
            // 
            this.gpMain.Controls.Add(this.lblBy);
            this.gpMain.Controls.Add(this.btnOK);
            this.gpMain.Controls.Add(this.btnCancel);
            this.gpMain.Controls.Add(this.lblProduct);
            this.gpMain.Location = new System.Drawing.Point(2, 229);
            this.gpMain.Name = "gpMain";
            this.gpMain.Size = new System.Drawing.Size(290, 100);
            this.gpMain.TabIndex = 0;
            this.gpMain.TabStop = false;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Location = new System.Drawing.Point(143, 24);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(126, 13);
            this.lblBy.TabIndex = 31;
            this.lblBy.Text = "By: Mohammed Abualrob";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(213, 73);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(70, 21);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(213, 73);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 21);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(27, 24);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(119, 13);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Wavelet Edge Detector";
            this.lblProduct.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // AboutDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(293, 331);
            this.Controls.Add(this.gpMain);
            this.Controls.Add(this.pbSnake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wavelet Edge Detector";
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake)).EndInit();
            this.gpMain.ResumeLayout(false);
            this.gpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSnake;
        private System.Windows.Forms.GroupBox gpMain;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblBy;
    }
}