namespace FacebookImagePoster
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lstCaptionedImages = new System.Windows.Forms.ListBox();
            this.picCurrentImage = new System.Windows.Forms.PictureBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadWorker = new System.ComponentModel.BackgroundWorker();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.btnSaveCaption = new System.Windows.Forms.Button();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlbumDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCaptionedImages
            // 
            this.lstCaptionedImages.FormattingEnabled = true;
            this.lstCaptionedImages.Location = new System.Drawing.Point(13, 39);
            this.lstCaptionedImages.Name = "lstCaptionedImages";
            this.lstCaptionedImages.Size = new System.Drawing.Size(386, 173);
            this.lstCaptionedImages.TabIndex = 0;
            this.lstCaptionedImages.SelectedIndexChanged += new System.EventHandler(this.lstCaptionedImages_SelectedIndexChanged);
            // 
            // picCurrentImage
            // 
            this.picCurrentImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCurrentImage.Location = new System.Drawing.Point(417, 39);
            this.picCurrentImage.Name = "picCurrentImage";
            this.picCurrentImage.Size = new System.Drawing.Size(651, 402);
            this.picCurrentImage.TabIndex = 1;
            this.picCurrentImage.TabStop = false;
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(12, 218);
            this.txtCaption.Multiline = true;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(386, 168);
            this.txtCaption.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Post All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagesToolStripMenuItem,
            this.captionsToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imagesToolStripMenuItem
            // 
            this.imagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem});
            this.imagesToolStripMenuItem.Name = "imagesToolStripMenuItem";
            this.imagesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.imagesToolStripMenuItem.Text = "Images";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // captionsToolStripMenuItem
            // 
            this.captionsToolStripMenuItem.Name = "captionsToolStripMenuItem";
            this.captionsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.captionsToolStripMenuItem.Text = "Captions";
            this.captionsToolStripMenuItem.Click += new System.EventHandler(this.captionsToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // uploadWorker
            // 
            this.uploadWorker.WorkerReportsProgress = true;
            this.uploadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.uploadWorker_DoWork);
            this.uploadWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.uploadWorker_ProgressChanged);
            this.uploadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.uploadWorker_RunWorkerCompleted);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(13, 575);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(305, 23);
            this.progress.TabIndex = 5;
            this.progress.Visible = false;
            // 
            // btnSaveCaption
            // 
            this.btnSaveCaption.Location = new System.Drawing.Point(295, 392);
            this.btnSaveCaption.Name = "btnSaveCaption";
            this.btnSaveCaption.Size = new System.Drawing.Size(104, 23);
            this.btnSaveCaption.TabIndex = 6;
            this.btnSaveCaption.Text = "Save Caption";
            this.btnSaveCaption.UseVisualStyleBackColor = true;
            this.btnSaveCaption.Click += new System.EventHandler(this.btnSaveCaption_Click);
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(12, 421);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(386, 20);
            this.txtAlbumName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Album Name";
            // 
            // txtAlbumDescription
            // 
            this.txtAlbumDescription.Location = new System.Drawing.Point(12, 467);
            this.txtAlbumDescription.Multiline = true;
            this.txtAlbumDescription.Name = "txtAlbumDescription";
            this.txtAlbumDescription.Size = new System.Drawing.Size(386, 101);
            this.txtAlbumDescription.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Album Description";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(904, 451);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 150);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlbumDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlbumName);
            this.Controls.Add(this.btnSaveCaption);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.picCurrentImage);
            this.Controls.Add(this.lstCaptionedImages);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "The Watering Bowl - Facebook Image Poster";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCaptionedImages;
        private System.Windows.Forms.PictureBox picCurrentImage;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker uploadWorker;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnSaveCaption;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlbumDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

