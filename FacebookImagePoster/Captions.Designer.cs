namespace FacebookImagePoster
{
    partial class Captions
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
            this.lstCaptions = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNewCaption = new System.Windows.Forms.TextBox();
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.btnDeleteCaption = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCaptions
            // 
            this.lstCaptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCaptions.FormattingEnabled = true;
            this.lstCaptions.Location = new System.Drawing.Point(0, 1);
            this.lstCaptions.Name = "lstCaptions";
            this.lstCaptions.Size = new System.Drawing.Size(517, 407);
            this.lstCaptions.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNewCaption);
            this.panel1.Controls.Add(this.btnSaveAndExit);
            this.panel1.Controls.Add(this.btnDeleteCaption);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 121);
            this.panel1.TabIndex = 5;
            // 
            // txtNewCaption
            // 
            this.txtNewCaption.Location = new System.Drawing.Point(20, 31);
            this.txtNewCaption.Name = "txtNewCaption";
            this.txtNewCaption.Size = new System.Drawing.Size(456, 20);
            this.txtNewCaption.TabIndex = 8;
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Location = new System.Drawing.Point(371, 60);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(105, 23);
            this.btnSaveAndExit.TabIndex = 7;
            this.btnSaveAndExit.Text = "Save and Exit";
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click_1);
            // 
            // btnDeleteCaption
            // 
            this.btnDeleteCaption.Location = new System.Drawing.Point(101, 60);
            this.btnDeleteCaption.Name = "btnDeleteCaption";
            this.btnDeleteCaption.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCaption.TabIndex = 6;
            this.btnDeleteCaption.Text = "Delete";
            this.btnDeleteCaption.UseVisualStyleBackColor = true;
            this.btnDeleteCaption.Click += new System.EventHandler(this.btnDeleteCaption_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Captions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstCaptions);
            this.Name = "Captions";
            this.Text = "Captions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Captions_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCaptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNewCaption;
        private System.Windows.Forms.Button btnSaveAndExit;
        private System.Windows.Forms.Button btnDeleteCaption;
        private System.Windows.Forms.Button btnAdd;
    }
}