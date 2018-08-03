using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Facebook;
using System.IO;

namespace FacebookImagePoster
{
    public partial class Main : Form
    {
        Captions _captionsScreen;
        private string _toProcessDirectory = @"ToProcess";
        Facebook _facebook = new Facebook();

        public Main()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadImagesFromDirectory(_toProcessDirectory);

            if(lstCaptionedImages.Items.Count > 0)
                lstCaptionedImages.SelectedIndex = 0;
     
        }

        private void captionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _captionsScreen = new Captions();
            _captionsScreen.Show();
        }

        private void LoadImagesFromDirectory(string path)
        {
            lstCaptionedImages.Items.Clear();
            string[] files = Directory.GetFiles(path);
            Captions _caption = new Captions();

            foreach(var file in files)
            {
                string extension = Path.GetExtension(file);
                if (extension.Equals(".jpg") || extension.Equals(".jpeg"))
                {
                    string caption = _caption.GetNextCaption();
                    CaptionedImage ci = new CaptionedImage(file, caption);
                    lstCaptionedImages.Items.Add(ci);
                }
            }
        }

        private void ChangeImage(CaptionedImage ci)
        {
            if(ci != null)
                picCurrentImage.Image = Image.FromFile(ci.Path);
        }

        private void lstCaptionedImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            CaptionedImage ci = lstCaptionedImages.SelectedItem as CaptionedImage;
            if (ci != null)
            {
                ChangeImage(ci);
                txtCaption.Text = ci.Caption;
            }

        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImagesFromDirectory(_toProcessDirectory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_facebook.IsLoggedIn())
            {
                Login login = new Login(_facebook);
                login.Show();
                return;
            }

            if(string.IsNullOrEmpty(txtAlbumName.Text))
            {
                MessageBox.Show("Please enter an album name.");
                return;
            }

            progress.Visible = true;
            progress.Step = 1;
            progress.Maximum = lstCaptionedImages.Items.Count;

            uploadWorker.RunWorkerAsync();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login(_facebook);
            login.Show();
        }

        private void uploadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int index = 0;
            int max = lstCaptionedImages.Items.Count;

            string albumnId = _facebook.CreateAlbum(txtAlbumName.Text, txtAlbumDescription.Text);

            foreach (CaptionedImage ci in lstCaptionedImages.Items)
            {

                _facebook.PostPhoto(ci, albumnId);
                index++;
                uploadWorker.ReportProgress((int)((index / max) * 100));  
            }
        }

        private void uploadWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress.PerformStep();
        }

        private void uploadWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progress.Visible = false;
            MessageBox.Show("All files uploaded.");
        }

        private void btnSaveCaption_Click(object sender, EventArgs e)
        {
            if(lstCaptionedImages.Items.Count > 0)
            {
                if(lstCaptionedImages.SelectedIndex > -1)
                {
                    int index = lstCaptionedImages.SelectedIndex;
                    CaptionedImage captionedImage = lstCaptionedImages.SelectedItem as CaptionedImage;
                    captionedImage.Caption = txtCaption.Text;
                    lstCaptionedImages.Items.RemoveAt(index);
                    lstCaptionedImages.Items.Insert(index, captionedImage);
                    lstCaptionedImages.SelectedIndex = index;
                }
            }
        }
    }
}
