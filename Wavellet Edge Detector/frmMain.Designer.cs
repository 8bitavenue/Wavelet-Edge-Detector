namespace WED
{
    partial class wedForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wedForm));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWaveletTrans = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindEdges = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbOpenImage = new System.Windows.Forms.ToolStripButton();
            this.tsbwaveTrans = new System.Windows.Forms.ToolStripButton();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDetectEdges = new System.Windows.Forms.ToolStripButton();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.bmscMain = new System.Windows.Forms.SplitContainer();
            this.tcImage = new System.Windows.Forms.TabControl();
            this.cmnuThreshold = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.threshold = new System.Windows.Forms.ToolStripMenuItem();
            this.tsImage = new System.Windows.Forms.ToolStrip();
            this.tsbImageClose = new System.Windows.Forms.ToolStripButton();
            this.tsbImageHide = new System.Windows.Forms.ToolStripButton();
            this.tsbImageSizeMode = new System.Windows.Forms.ToolStripButton();
            this.tcEdge = new System.Windows.Forms.TabControl();
            this.tsEdge = new System.Windows.Forms.ToolStrip();
            this.tsbEdgeClose = new System.Windows.Forms.ToolStripButton();
            this.tsbEdgeHide = new System.Windows.Forms.ToolStripButton();
            this.tsbEdgeSizeMode = new System.Windows.Forms.ToolStripButton();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.bwOpenImages = new System.ComponentModel.BackgroundWorker();
            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.bmscMain.Panel1.SuspendLayout();
            this.bmscMain.Panel2.SuspendLayout();
            this.bmscMain.SuspendLayout();
            this.cmnuThreshold.SuspendLayout();
            this.tsImage.SuspendLayout();
            this.tsEdge.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView,
            this.mnuAction,
            this.mnuWindow,
            this.mnuHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(738, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenImage});
            this.mnuFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuOpenImage
            // 
            this.mnuOpenImage.Image = ((System.Drawing.Image)(resources.GetObject("mnuOpenImage.Image")));
            this.mnuOpenImage.Name = "mnuOpenImage";
            this.mnuOpenImage.Size = new System.Drawing.Size(137, 22);
            this.mnuOpenImage.Text = "Open Images";
            this.mnuOpenImage.Click += new System.EventHandler(this.tsbOpenImage_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewMain,
            this.mnuViewStatus});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "View";
            // 
            // mnuViewMain
            // 
            this.mnuViewMain.Checked = true;
            this.mnuViewMain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewMain.Name = "mnuViewMain";
            this.mnuViewMain.Size = new System.Drawing.Size(148, 22);
            this.mnuViewMain.Text = "Main Tool Bar";
            this.mnuViewMain.Click += new System.EventHandler(this.mnuViewMain_Click);
            // 
            // mnuViewStatus
            // 
            this.mnuViewStatus.Checked = true;
            this.mnuViewStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewStatus.Name = "mnuViewStatus";
            this.mnuViewStatus.Size = new System.Drawing.Size(148, 22);
            this.mnuViewStatus.Text = "Status Bar";
            this.mnuViewStatus.Click += new System.EventHandler(this.mnuViewStatus_Click);
            // 
            // mnuAction
            // 
            this.mnuAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWaveletTrans,
            this.mnuFindEdges});
            this.mnuAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mnuAction.Name = "mnuAction";
            this.mnuAction.Size = new System.Drawing.Size(49, 20);
            this.mnuAction.Text = "Action";
            // 
            // mnuWaveletTrans
            // 
            this.mnuWaveletTrans.Image = ((System.Drawing.Image)(resources.GetObject("mnuWaveletTrans.Image")));
            this.mnuWaveletTrans.Name = "mnuWaveletTrans";
            this.mnuWaveletTrans.Size = new System.Drawing.Size(164, 22);
            this.mnuWaveletTrans.Text = "Wavelet Transform";
            this.mnuWaveletTrans.Click += new System.EventHandler(this.tsbwaveTrans_Click);
            // 
            // mnuFindEdges
            // 
            this.mnuFindEdges.Image = ((System.Drawing.Image)(resources.GetObject("mnuFindEdges.Image")));
            this.mnuFindEdges.Name = "mnuFindEdges";
            this.mnuFindEdges.Size = new System.Drawing.Size(164, 22);
            this.mnuFindEdges.Text = " Detect Edges";
            this.mnuFindEdges.Click += new System.EventHandler(this.tsbFindEdges_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCloseAll});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(63, 20);
            this.mnuWindow.Text = "Window";
            // 
            // mnuCloseAll
            // 
            this.mnuCloseAll.Image = ((System.Drawing.Image)(resources.GetObject("mnuCloseAll.Image")));
            this.mnuCloseAll.Name = "mnuCloseAll";
            this.mnuCloseAll.Size = new System.Drawing.Size(120, 22);
            this.mnuCloseAll.Text = "Close All";
            this.mnuCloseAll.Click += new System.EventHandler(this.mnuCloseAll_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContents,
            this.mnuAbout});
            this.mnuHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(41, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuContents
            // 
            this.mnuContents.Image = ((System.Drawing.Image)(resources.GetObject("mnuContents.Image")));
            this.mnuContents.Name = "mnuContents";
            this.mnuContents.Size = new System.Drawing.Size(116, 22);
            this.mnuContents.Text = "Contents";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Image = ((System.Drawing.Image)(resources.GetObject("mnuAbout.Image")));
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpenImage,
            this.tsbwaveTrans,
            this.sep1,
            this.tsbDetectEdges,
            this.sep2,
            this.tsbHelp});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(738, 55);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbOpenImage
            // 
            this.tsbOpenImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tsbOpenImage.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenImage.Image")));
            this.tsbOpenImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenImage.Name = "tsbOpenImage";
            this.tsbOpenImage.Size = new System.Drawing.Size(122, 52);
            this.tsbOpenImage.Text = "Open Images";
            this.tsbOpenImage.Click += new System.EventHandler(this.tsbOpenImage_Click);
            // 
            // tsbwaveTrans
            // 
            this.tsbwaveTrans.Image = ((System.Drawing.Image)(resources.GetObject("tsbwaveTrans.Image")));
            this.tsbwaveTrans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbwaveTrans.Name = "tsbwaveTrans";
            this.tsbwaveTrans.Size = new System.Drawing.Size(159, 52);
            this.tsbwaveTrans.Text = "Wavelet Transform";
            this.tsbwaveTrans.ToolTipText = "Wavelet Transform";
            this.tsbwaveTrans.Click += new System.EventHandler(this.tsbwaveTrans_Click);
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbDetectEdges
            // 
            this.tsbDetectEdges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tsbDetectEdges.Image = ((System.Drawing.Image)(resources.GetObject("tsbDetectEdges.Image")));
            this.tsbDetectEdges.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDetectEdges.Name = "tsbDetectEdges";
            this.tsbDetectEdges.Size = new System.Drawing.Size(124, 52);
            this.tsbDetectEdges.Text = "Detect Edges";
            this.tsbDetectEdges.Click += new System.EventHandler(this.tsbFindEdges_Click);
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbHelp
            // 
            this.tsbHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(123, 52);
            this.tsbHelp.Text = "Program Help";
            this.tsbHelp.Click += new System.EventHandler(this.tsbHelp_Click);
            // 
            // bmscMain
            // 
            this.bmscMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bmscMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmscMain.Location = new System.Drawing.Point(0, 79);
            this.bmscMain.Name = "bmscMain";
            // 
            // bmscMain.Panel1
            // 
            this.bmscMain.Panel1.Controls.Add(this.tcImage);
            this.bmscMain.Panel1.Controls.Add(this.tsImage);
            // 
            // bmscMain.Panel2
            // 
            this.bmscMain.Panel2.Controls.Add(this.tcEdge);
            this.bmscMain.Panel2.Controls.Add(this.tsEdge);
            this.bmscMain.Size = new System.Drawing.Size(738, 333);
            this.bmscMain.SplitterDistance = 366;
            this.bmscMain.TabIndex = 3;
            this.bmscMain.TabStop = false;
            // 
            // tcImage
            // 
            this.tcImage.ContextMenuStrip = this.cmnuThreshold;
            this.tcImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcImage.Location = new System.Drawing.Point(0, 25);
            this.tcImage.Name = "tcImage";
            this.tcImage.SelectedIndex = 0;
            this.tcImage.Size = new System.Drawing.Size(362, 304);
            this.tcImage.TabIndex = 3;
            this.tcImage.SelectedIndexChanged += new System.EventHandler(this.tcImage_SelectedIndexChanged);
            // 
            // cmnuThreshold
            // 
            this.cmnuThreshold.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threshold});
            this.cmnuThreshold.Name = "cmnuThreshold";
            this.cmnuThreshold.Size = new System.Drawing.Size(128, 26);
            // 
            // threshold
            // 
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(127, 22);
            this.threshold.Text = "Threshold";
            this.threshold.Click += new System.EventHandler(this.threshold_Click);
            // 
            // tsImage
            // 
            this.tsImage.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbImageClose,
            this.tsbImageHide,
            this.tsbImageSizeMode});
            this.tsImage.Location = new System.Drawing.Point(0, 0);
            this.tsImage.Name = "tsImage";
            this.tsImage.Size = new System.Drawing.Size(362, 25);
            this.tsImage.TabIndex = 4;
            this.tsImage.Text = "toolStrip1";
            // 
            // tsbImageClose
            // 
            this.tsbImageClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbImageClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImageClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbImageClose.Image")));
            this.tsbImageClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImageClose.Name = "tsbImageClose";
            this.tsbImageClose.Size = new System.Drawing.Size(23, 22);
            this.tsbImageClose.Text = "toolStripButton1";
            this.tsbImageClose.ToolTipText = "Close Source Image";
            this.tsbImageClose.Click += new System.EventHandler(this.tsbImageClose_Click);
            // 
            // tsbImageHide
            // 
            this.tsbImageHide.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbImageHide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImageHide.Image = ((System.Drawing.Image)(resources.GetObject("tsbImageHide.Image")));
            this.tsbImageHide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImageHide.Name = "tsbImageHide";
            this.tsbImageHide.Size = new System.Drawing.Size(23, 22);
            this.tsbImageHide.Text = "toolStripButton2";
            this.tsbImageHide.ToolTipText = "Maximize Image Panel";
            this.tsbImageHide.Click += new System.EventHandler(this.tsbImageHide_Click);
            // 
            // tsbImageSizeMode
            // 
            this.tsbImageSizeMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbImageSizeMode.Image")));
            this.tsbImageSizeMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImageSizeMode.Name = "tsbImageSizeMode";
            this.tsbImageSizeMode.Size = new System.Drawing.Size(75, 22);
            this.tsbImageSizeMode.Text = "- Normal";
            this.tsbImageSizeMode.ToolTipText = "Image Size Mode";
            this.tsbImageSizeMode.Click += new System.EventHandler(this.tsbImageSizeMode_Click);
            // 
            // tcEdge
            // 
            this.tcEdge.ContextMenuStrip = this.cmnuThreshold;
            this.tcEdge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcEdge.Location = new System.Drawing.Point(0, 25);
            this.tcEdge.Name = "tcEdge";
            this.tcEdge.SelectedIndex = 0;
            this.tcEdge.Size = new System.Drawing.Size(364, 304);
            this.tcEdge.TabIndex = 4;
            this.tcEdge.SelectedIndexChanged += new System.EventHandler(this.tcEdge_SelectedIndexChanged);
            // 
            // tsEdge
            // 
            this.tsEdge.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsEdge.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEdgeClose,
            this.tsbEdgeHide,
            this.tsbEdgeSizeMode});
            this.tsEdge.Location = new System.Drawing.Point(0, 0);
            this.tsEdge.Name = "tsEdge";
            this.tsEdge.Size = new System.Drawing.Size(364, 25);
            this.tsEdge.TabIndex = 5;
            this.tsEdge.Text = "toolStrip2";
            // 
            // tsbEdgeClose
            // 
            this.tsbEdgeClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEdgeClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdgeClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdgeClose.Image")));
            this.tsbEdgeClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdgeClose.Name = "tsbEdgeClose";
            this.tsbEdgeClose.Size = new System.Drawing.Size(23, 22);
            this.tsbEdgeClose.Text = "toolStripButton3";
            this.tsbEdgeClose.ToolTipText = "Close Edge Image";
            this.tsbEdgeClose.Click += new System.EventHandler(this.tsbEdgeClose_Click);
            // 
            // tsbEdgeHide
            // 
            this.tsbEdgeHide.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEdgeHide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdgeHide.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdgeHide.Image")));
            this.tsbEdgeHide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdgeHide.Name = "tsbEdgeHide";
            this.tsbEdgeHide.Size = new System.Drawing.Size(23, 22);
            this.tsbEdgeHide.Text = "toolStripButton4";
            this.tsbEdgeHide.ToolTipText = "Maximize Edge Panel";
            this.tsbEdgeHide.Click += new System.EventHandler(this.tsbEdgeHide_Click);
            // 
            // tsbEdgeSizeMode
            // 
            this.tsbEdgeSizeMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdgeSizeMode.Image")));
            this.tsbEdgeSizeMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdgeSizeMode.Name = "tsbEdgeSizeMode";
            this.tsbEdgeSizeMode.Size = new System.Drawing.Size(75, 22);
            this.tsbEdgeSizeMode.Text = "- Normal";
            this.tsbEdgeSizeMode.ToolTipText = "Edge Size Mode";
            this.tsbEdgeSizeMode.Click += new System.EventHandler(this.tsbEdgeSizeMode_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tspbProgress});
            this.ssMain.Location = new System.Drawing.Point(0, 412);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(738, 22);
            this.ssMain.SizingGrip = false;
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(72, 17);
            this.tsslStatus.Text = "Progress ...";
            // 
            // tspbProgress
            // 
            this.tspbProgress.Name = "tspbProgress";
            this.tspbProgress.Size = new System.Drawing.Size(200, 16);
            // 
            // wedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 434);
            this.Controls.Add(this.bmscMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "wedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wavelet Edge Detector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.wedForm_Resize);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.bmscMain.Panel1.ResumeLayout(false);
            this.bmscMain.Panel1.PerformLayout();
            this.bmscMain.Panel2.ResumeLayout(false);
            this.bmscMain.Panel2.PerformLayout();
            this.bmscMain.ResumeLayout(false);
            this.cmnuThreshold.ResumeLayout(false);
            this.tsImage.ResumeLayout(false);
            this.tsImage.PerformLayout();
            this.tsEdge.ResumeLayout(false);
            this.tsEdge.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenImage;
        private System.Windows.Forms.ToolStripMenuItem mnuAction;
        private System.Windows.Forms.ToolStripMenuItem mnuFindEdges;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuContents;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbOpenImage;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripButton tsbDetectEdges;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.SplitContainer bmscMain;
        private System.Windows.Forms.TabControl tcImage;
        private System.Windows.Forms.TabControl tcEdge;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripProgressBar tspbProgress;
        private System.Windows.Forms.ToolStrip tsImage;
        private System.Windows.Forms.ToolStripButton tsbImageClose;
        private System.Windows.Forms.ToolStripButton tsbImageHide;
        private System.Windows.Forms.ToolStrip tsEdge;
        private System.Windows.Forms.ToolStripButton tsbEdgeClose;
        private System.Windows.Forms.ToolStripButton tsbEdgeHide;
        private System.Windows.Forms.ToolStripButton tsbImageSizeMode;
        private System.Windows.Forms.ToolStripButton tsbEdgeSizeMode;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuViewMain;
        private System.Windows.Forms.ToolStripMenuItem mnuViewStatus;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseAll;
        private System.Windows.Forms.ToolStripButton tsbwaveTrans;
        private System.ComponentModel.BackgroundWorker bwOpenImages;
        private System.Windows.Forms.ToolStripMenuItem mnuWaveletTrans;
        private System.Windows.Forms.ContextMenuStrip cmnuThreshold;
        private System.Windows.Forms.ToolStripMenuItem threshold;

    }
}

