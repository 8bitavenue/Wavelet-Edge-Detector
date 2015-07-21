using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
using System.IO;

namespace WED
{
    public partial class wedForm : Form
    {
        int m_threshold = 0;

        PictureBox pbEdge;

        int[,] orgred;
        int[,] orgblue;
        int[,] orggreen;

        int[,] rowred;
        int[,] rowblue;
        int[,] rowgreen;

        int[,] colred;
        int[,] colblue;
        int[,] colgreen;

        int[,] scalered;
        int[,] scaleblue;
        int[,] scalegreen;

        int[,] recrowred;
        int[,] recrowblue;
        int[,] recrowgreen;

        int[,] recorgred;
        int[,] recorgblue;
        int[,] recorggreen;

        
        bool CloseFlag = true;

        int m_imagesizemode = 0;

        int m_edgesizemode = 0;
        
        ToolStripProgressBar m_pb;

        ToolStripStatusLabel m_sl;

        private OpenFileDialog openDialog;

        public wedForm()
        {
            InitializeComponent();

            Thread th = new Thread(new ThreadStart(DoSplash));

            th.Start();

            Thread.Sleep(1000);

            th.Abort();

            this.openDialog = new OpenFileDialog();            
        }

        private void DoSplash()
        {
            Splash sp = new Splash();

            sp.ShowDialog();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            AboutDlg about = new AboutDlg();

            about.ShowDialog();

            about.DialogResult = DialogResult.OK;
        }

        private void tsbOpenImage_Click(object sender, EventArgs e)
        {            
            this.openDialog.Multiselect = true;

            this.openDialog.Title = "Wavelet Edge Detector - Open Images";

            this.openDialog.Filter = "Images (*.jpg)|*.jpg";

            this.openDialog.RestoreDirectory = true;

            this.openDialog.FileName = "";

            if (this.openDialog.ShowDialog() == DialogResult.OK)
            {
                this.ResetProgressBar();

                m_pb.Maximum = this.openDialog.FileNames.Length;

                foreach (string filename in this.openDialog.FileNames)
                {
                    bool skip = false;

                    foreach (TabPage t in this.tcImage.TabPages)
                    {
                        if (t.Text == Path.GetFileName(filename))
                        {
                            skip = true;
                        }
                    }

                    if (!skip)
                    {
                        PictureBox pbImage = new PictureBox();

                        pbImage.Dock = DockStyle.Fill;

                        pbImage.SizeMode = PictureBoxSizeMode.Normal;

                        pbImage.Image = Image.FromFile(filename);

                        TabPage tp = new TabPage(Path.GetFileName(filename));

                        tp.Controls.Add(pbImage);

                        this.tcImage.TabPages.Add(tp);

                        int i = tcImage.TabPages.IndexOf(tp);

                        if (i >= 0)
                        {
                            this.CloseFlag = false;
                            this.tcImage.SelectedIndex = i;
                            this.CloseFlag = true;
                        }
                    }

                    if (m_pb.Value < m_pb.Maximum)
                    {
                        m_pb.Increment(1);
                    }
                }
            }

            this.bmscMain.Cursor = Cursors.Arrow;
        }

        private void DoTransform(TabPage itp, int function)
        {
                Image img = ((PictureBox)itp.Controls[0]).Image;

                Bitmap bitmap = new Bitmap(img);

                BitmapData bitmapdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, img.PixelFormat);

                orgred = new int[bitmap.Height + 1, bitmap.Width + 1];
                orgblue = new int[bitmap.Height+1, bitmap.Width + 1];
                orggreen = new int[bitmap.Height+1, bitmap.Width + 1];

                rowred = new int[bitmap.Height+1, bitmap.Width + 1];
                rowblue = new int[bitmap.Height+1, bitmap.Width + 1];
                rowgreen = new int[bitmap.Height+1, bitmap.Width + 1];

                colred = new int[bitmap.Height+1, bitmap.Width + 1];
                colblue = new int[bitmap.Height+1, bitmap.Width + 1];
                colgreen = new int[bitmap.Height+1, bitmap.Width + 1];

                scalered = new int[bitmap.Height+1, bitmap.Width + 1];
                scaleblue = new int[bitmap.Height+1, bitmap.Width + 1];
                scalegreen = new int[bitmap.Height + 1, bitmap.Width + 1];

                recrowred = new int[bitmap.Height + 1, bitmap.Width + 1];
                recrowblue = new int[bitmap.Height + 1, bitmap.Width + 1];
                recrowgreen = new int[bitmap.Height + 1, bitmap.Width + 1];

                recorgred = new int[bitmap.Height + 1, bitmap.Width + 1];
                recorgblue = new int[bitmap.Height + 1, bitmap.Width + 1];
                recorggreen = new int[bitmap.Height + 1, bitmap.Width + 1];
     
                unsafe
                {
                    byte* imgPtr = (byte*)(bitmapdata.Scan0);

                    for (int i = 0; i < bitmapdata.Height; i++)
                    {
                        for (int j = 0; j < bitmapdata.Width; j++)
                        {
                            orgred[i, j] = (int)*(imgPtr + 0);
                            orggreen[i, j] = (int)*(imgPtr + 1);
                            orgblue[i, j] = (int)*(imgPtr + 2);

                            imgPtr += 3;
                        }

                        imgPtr += bitmapdata.Stride - bitmapdata.Width * 3;
                    }
                }

                //Transform rows

                    for (int r = 0; r < bitmapdata.Height; r++)
                    {
                        int k = 0;

                        for (int p = 0; p < bitmapdata.Width; p = p + 2)
                        {
                            rowred[r, k] = (int)((double)(orgred[r, p] + orgred[r, p + 1]) / 2);
                            rowred[r, k + (bitmapdata.Width / 2)] = (int)((double)(orgred[r, p] - orgred[r, p + 1]) / 2);

                            rowgreen[r, k] = (int)((double)(orggreen[r, p] + orggreen[r, p + 1]) / 2);
                            rowgreen[r, k + (bitmapdata.Width / 2)] = (int)((double)(orggreen[r, p] - orggreen[r, p + 1]) / 2);

                            rowblue[r, k] = (int)((double)(orgblue[r, p] + orgblue[r, p + 1]) / 2);
                            rowblue[r, k + (bitmapdata.Width / 2)] = (int)((double)(orgblue[r, p] - orgblue[r, p + 1]) / 2);

                            k++;
                        }

                    }
                   
                //Transform columns
                for (int c = 0; c < bitmapdata.Width; c++)
                {
                    int k = 0;

                    for (int p = 0; p < bitmapdata.Height; p = p + 2)
                    {
                        colred[k, c] = (int)((double)(rowred[p, c] + rowred[p + 1, c]) / 2);
                        colred[k + bitmapdata.Height / 2, c] = (int)((double)(rowred[p, c] - rowred[p + 1, c]) / 2);

                        colgreen[k, c] = (int)((double)(rowgreen[p, c] + rowgreen[p + 1, c]) / 2);
                        colgreen[k + bitmapdata.Height / 2, c] = (int)((double)(rowgreen[p, c] - rowgreen[p + 1, c]) / 2);

                        colblue[k, c] = (int)((double)(rowblue[p, c] + rowblue[p + 1, c]) / 2);
                        colblue[k + bitmapdata.Height / 2, c] = (int)((double)(rowblue[p, c] - rowblue[p + 1, c]) / 2);

                        k++;
                    }
                }
                
                //Scale col
                for (int r = 0; r < bitmapdata.Height; r++)
                {
                    for (int c = 0; c < bitmapdata.Width; c++)
                    {
                        if (r >= 0 && r < bitmapdata.Height / 2 && c >= 0 && c < bitmapdata.Width/2)
                        {
                            scalered[r, c] = colred[r, c];
                            scalegreen[r, c] = colgreen[r, c];
                            scaleblue[r, c] = colblue[r, c];
                        }
                        else
                        {
                            scalered[r, c] = Math.Abs((colred[r, c] - 127));
                            scalegreen[r, c] = Math.Abs((colgreen[r, c] - 127));
                            scaleblue[r, c] = Math.Abs((colblue[r, c] - 127));                            
                        }
                    }
                }

                //Set LL = 0
                for (int r = 0; r < bitmapdata.Height / 2; r++)
                {
                    for (int c = 0; c < bitmapdata.Width / 2; c++)
                    {
                        colred[r, c] = 0;
                        colgreen[r, c] = 0;
                        colblue[r, c] = 0;
                    }
                }
                
                //Set LL = 0
                for (int r = 0; r < bitmapdata.Height; r++)
                {
                    for (int c = 0; c < bitmapdata.Width; c++)
                    {
                        if (!(r >= 0 && r < bitmapdata.Height / 2 && c >= 0 && c < bitmapdata.Width / 2))
                        {
                            if (Math.Abs(colred[r, c]) <= m_threshold)
                            {
                                colred[r, c] = 0;
                            }
                            else
                            {
                                //colred[r, c] = 255;
                            }

                            if (Math.Abs(colgreen[r, c]) <= m_threshold)
                            {
                                colgreen[r, c] = 0;
                            }
                            else
                            {
                                //colgreen[r, c] = 255;
                            }

                            if (Math.Abs(colblue[r, c]) <= m_threshold)
                            {
                                colblue[r, c] = 0;
                            }
                            else
                            {
                                //colblue[r, c] = 255;
                            }
                        }
                    }
                }                
            
                //Inverse Transform columns
                for (int c = 0; c < bitmapdata.Width; c++)
                {
                    int k = 0;

                    for (int p = 0; p < bitmapdata.Height; p = p + 2)
                    {
                        recrowred[p, c] = (int)((colred[k, c] + colred[k + bitmapdata.Height / 2, c]));
                        recrowred[p + 1, c] = (int)((colred[k, c] - colred[k + bitmapdata.Height / 2, c]));

                        recrowgreen[p, c] = (int)((colgreen[k, c] + colgreen[k + bitmapdata.Height / 2, c]));
                        recrowgreen[p + 1, c] = (int)((colgreen[k, c] - colgreen[k + bitmapdata.Height / 2, c]));

                        recrowblue[p, c] = (int)((colblue[k, c] + colblue[k + bitmapdata.Height / 2, c]));
                        recrowblue[p + 1, c] = (int)((colblue[k, c] - colblue[k + bitmapdata.Height / 2, c]));

                        k++;
                    }
                }


                //Invers Transform rows

                for (int r = 0; r < bitmapdata.Height; r++)
                {
                    int k = 0;

                    for (int p = 0; p < bitmapdata.Width; p = p + 2)
                    {
                        recorgred[r, p] = (int)((recrowred[r, k] + recrowred[r, k + (bitmapdata.Width / 2)]));
                        recorgred[r, p + 1] = (int)((recrowred[r, k] - recrowred[r, k + (bitmapdata.Width / 2)]));

                        recorggreen[r, p] = (int)((recrowgreen[r, k] + recrowgreen[r, k + (bitmapdata.Width / 2)]));
                        recorggreen[r, p + 1] = (int)((recrowgreen[r, k] - recrowgreen[r, k + (bitmapdata.Width / 2)]));

                        recorgblue[r, p] = (int)((recrowblue[r, k] + recrowblue[r, k + (bitmapdata.Width / 2)]));
                        recorgblue[r, p + 1] = (int)((recrowblue[r, k] - recrowblue[r, k + (bitmapdata.Width / 2)]));

                        k++;
                    }

                }
              
                unsafe
                {
                    byte* imgPtr = (byte*)(bitmapdata.Scan0);

                    for (int i = 0; i < bitmapdata.Height; i++)
                    {
                        for (int j = 0; j < bitmapdata.Width; j++)

                        {
                            if (function == 0)
                            {
                                *(imgPtr + 0) = (byte)Math.Abs(recorgred[i, j] - 0);
                                *(imgPtr + 1) = (byte)Math.Abs(recorggreen[i, j] - 0);
                                *(imgPtr + 2) = (byte)Math.Abs(recorgblue[i, j] - 0);
                            }
                            else
                            {

                                *(imgPtr + 0) = (byte)scalered[i, j];
                                *(imgPtr + 1) = (byte)scalegreen[i, j];
                                *(imgPtr + 2) = (byte)scaleblue[i, j];
                            }
                            
                            imgPtr += 3;
                        }

                        imgPtr += bitmapdata.Stride - bitmapdata.Width * 3;
                    }
                }

                bitmap.UnlockBits(bitmapdata);

                bool skip = false;

                foreach (TabPage t in this.tcEdge.TabPages)
                {
                    if (t.Text == itp.Text)
                    {
                        skip = true;
                    }
                }
                    
                if (!skip)
                {
                    TabPage etp = new TabPage(itp.Text);                                                                  
                        
                    pbEdge = new PictureBox();
                        
                    pbEdge.Dock = DockStyle.Fill;
                        
                    pbEdge.SizeMode = PictureBoxSizeMode.Normal;
                        
                    pbEdge.Image = bitmap;
                        
                    etp.Controls.Add(pbEdge);

                    this.tcEdge.TabPages.Add(etp);

                    int index = tcEdge.TabPages.IndexOf(etp);

                    if (index >= 0)
                    {
                        this.tcEdge.SelectedIndex = index;
                    }
                }                   
        }
  
        private void tsbFindEdges_Click(object sender, EventArgs e)
        {
            this.tcEdge.TabPages.Clear();

            this.ResetProgressBar();

            m_pb.Maximum = this.tcImage.TabCount;

            foreach (TabPage itp in this.tcImage.TabPages)
            {
                this.DoTransform(itp, 0);

                if (m_pb.Value < m_pb.Maximum)
                {
                    m_pb.Increment(1);
                }

                //Thread.Sleep(500);
            }
        }

        private void CloseImage()
        {
            this.CloseFlag = false;

            if (this.tcImage.SelectedTab != null)
            {
                int i = tcImage.SelectedIndex;

                this.tcImage.TabPages.Remove(this.tcImage.SelectedTab);

                if (this.tcEdge.SelectedTab != null)
                {
                    this.tcEdge.TabPages.Remove(this.tcEdge.SelectedTab);
                }

                if (i - 1 >= 0)
                {
                    this.tcImage.SelectedIndex = i - 1;

                    this.tcEdge.SelectedIndex = i - 1;
                }

                if (this.tcImage.TabCount == 0)
                {
                    this.ResetProgressBar();
                }
            }

            this.CloseFlag = true;
        }

        private void tsbImageClose_Click(object sender, EventArgs e)
        {
            this.CloseImage();
        }

        private void ResetProgressBar()
        {
            m_sl = (ToolStripStatusLabel)this.ssMain.Items[0];

            m_pb = (ToolStripProgressBar)this.ssMain.Items[1];

            m_pb.Value = 0;

            m_pb.Step = 1;

            m_pb.Minimum = 0;

            m_pb.Maximum = 1;
        }

        private void tsbEdgeClose_Click(object sender, EventArgs e)
        {
            this.CloseImage();
        }

        private void tsbImageHide_Click(object sender, EventArgs e)
        {
            if (!this.bmscMain.Panel2Collapsed)
            {
                this.bmscMain.Panel2Collapsed = true;
            }
            else
            {
                this.bmscMain.Panel2Collapsed = false;
            }
        }

        private void tsbEdgeHide_Click(object sender, EventArgs e)
        {
            if (!this.bmscMain.Panel1Collapsed)
            {
                this.bmscMain.Panel1Collapsed = true;
            }
            else
            {
                this.bmscMain.Panel1Collapsed = false;
            }
        }

        private void wedForm_Resize(object sender, EventArgs e)
        {
            this.ssMain.Items[1].Size = new Size(this.Width - this.ssMain.Items[0].Size.Width - 11, 16);
        }

        private void tsbImageSizeMode_Click(object sender, EventArgs e)
        {
            if (this.tcImage.SelectedTab != null)
            {
                PictureBox pb = (PictureBox)this.tcImage.SelectedTab.Controls[0];

                this.m_imagesizemode++;

                if (this.m_imagesizemode == 3)
                {
                    this.m_imagesizemode = 0;
                }

                if (this.m_imagesizemode == 0)
                {
                    pb.SizeMode = PictureBoxSizeMode.Normal;
                    this.tsbImageSizeMode.Text = "- Normal";
                }
                else if (this.m_imagesizemode == 1)
                {
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    this.tsbImageSizeMode.Text = "- Zoom";
                }
                else if (this.m_imagesizemode == 2)
                {
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.tsbImageSizeMode.Text = "- Stretch";
                }
            }
        }

        private void mnuViewMain_Click(object sender, EventArgs e)
        {
            this.tsMain.Visible = !this.tsMain.Visible;

            this.mnuViewMain.Checked = !this.mnuViewMain.Checked;
        }

        private void mnuViewStatus_Click(object sender, EventArgs e)
        {
            this.ssMain.Visible = !this.ssMain.Visible;

            this.mnuViewStatus.Checked = !this.mnuViewStatus.Checked;
        }

        private void tcImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tcImage.SelectedTab != null)// && this.CloseFlag)
            {
                PictureBox pb = (PictureBox)this.tcImage.SelectedTab.Controls[0];

                if (pb.SizeMode == PictureBoxSizeMode.Normal)
                {
                    this.m_imagesizemode = 0;
                }
                else if (pb.SizeMode == PictureBoxSizeMode.Zoom)
                {
                    this.m_imagesizemode = 1;
                }
                else if (pb.SizeMode == PictureBoxSizeMode.StretchImage)
                {
                    this.m_imagesizemode = 2;
                }
                else
                {
                    this.m_imagesizemode = 0;
                }
            }

            if (this.m_imagesizemode == 0)
            {
                this.tsbImageSizeMode.Text = "- Normal";
            }
            else if (this.m_imagesizemode == 1)
            {
                this.tsbImageSizeMode.Text = "- Zoom";
            }
            else if (this.m_imagesizemode == 2)
            {
                this.tsbImageSizeMode.Text = "- Stretch";
            }

            if (this.tcEdge.TabCount > 0 && this.CloseFlag)
            {
                if (this.tcImage.SelectedIndex >= 0 && this.tcImage.SelectedIndex < this.tcEdge.TabCount)
                {
                    this.tcEdge.SelectedIndex = this.tcImage.SelectedIndex;
                }
            }
        }

        private void tsbEdgeSizeMode_Click(object sender, EventArgs e)
        {
            if (this.tcEdge.SelectedTab != null)
            {
                PictureBox pb = (PictureBox)this.tcEdge.SelectedTab.Controls[0];

                this.m_edgesizemode++;

                if (this.m_edgesizemode == 3)
                {
                    this.m_edgesizemode = 0;
                }

                if (this.m_edgesizemode == 0)
                {
                    pb.SizeMode = PictureBoxSizeMode.Normal;

                    this.tsbEdgeSizeMode.Text = "- Normal";
                }
                else if (this.m_edgesizemode == 1)
                {
                    pb.SizeMode = PictureBoxSizeMode.Zoom;

                    this.tsbEdgeSizeMode.Text = "- Zoom";
                }
                else if (this.m_edgesizemode == 2)
                {
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    this.tsbEdgeSizeMode.Text = "- Stretch";
                }
            }
        }

        private void mnuCloseAll_Click(object sender, EventArgs e)
        {
            this.tcImage.TabPages.Clear();

            this.tcEdge.TabPages.Clear();

            this.ResetProgressBar();
        }

        private void tcEdge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tcEdge.SelectedTab != null)// && this.CloseFlag)
            {
                PictureBox pb = (PictureBox)this.tcEdge.SelectedTab.Controls[0];

                if (pb.SizeMode == PictureBoxSizeMode.Normal)
                {
                    this.m_edgesizemode = 0;
                }
                else if (pb.SizeMode == PictureBoxSizeMode.Zoom)
                {
                    this.m_edgesizemode = 1;
                }
                else if (pb.SizeMode == PictureBoxSizeMode.StretchImage)
                {
                    this.m_edgesizemode = 2;
                }
                else
                {
                    this.m_edgesizemode = 0;
                }
            }

            if (this.m_edgesizemode == 0)
            {
                this.tsbEdgeSizeMode.Text = "- Normal";
            }
            else if (this.m_edgesizemode == 1)
            {
                this.tsbEdgeSizeMode.Text = "- Zoom";
            }
            else if (this.m_edgesizemode == 2)
            {
                this.tsbEdgeSizeMode.Text = "- Stretch";
            }

            if (this.tcImage.TabCount > 0 && this.CloseFlag)
            {
                if (this.tcEdge.SelectedIndex >= 0 && this.tcEdge.SelectedIndex < this.tcImage.TabCount)
                {
                    this.tcImage.SelectedIndex = this.tcEdge.SelectedIndex;
                }
            }
        }

        private void tsbwaveTrans_Click(object sender, EventArgs e)
        {
            this.tcEdge.TabPages.Clear();

            this.ResetProgressBar();

            m_pb.Maximum = this.tcImage.TabCount;

            foreach (TabPage itp in this.tcImage.TabPages)
            {
                this.DoTransform(itp, 1);

                if (m_pb.Value < m_pb.Maximum)
                {
                    m_pb.Increment(1);
                }

                //Thread.Sleep(500);
            }
        }

        private void tsbHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void threshold_Click(object sender, EventArgs e)
        {
            if (this.tcEdge.SelectedTab != null)
            {
                ThresholdDlg dlg = new ThresholdDlg();
                dlg.Threshold = this.m_threshold.ToString();
                dlg.ShowDialog();
                this.m_threshold = int.Parse(dlg.Threshold);

                this.tcEdge.TabPages.Clear();

                this.ResetProgressBar();

                m_pb.Maximum = this.tcImage.TabCount;

                foreach (TabPage itp in this.tcImage.TabPages)
                {
                    this.DoTransform(itp, 0);

                    if (m_pb.Value < m_pb.Maximum)
                    {
                        m_pb.Increment(1);
                    }

                    //Thread.Sleep(500);
                }
            }
        }
    }
}