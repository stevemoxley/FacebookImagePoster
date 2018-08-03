using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FacebookImagePoster
{
    public partial class Captions : Form
    {
        List<string> _captions = new List<string>();
        string _captionFileName = "cap.mox";
        public static readonly Random random = new Random();
        SimpleAES _simpleAES;


        public List<string> CaptionsList
        {
            get
            {
                return _captions;
            }
        }



        public Captions()
        {
           
            InitializeComponent();

            _simpleAES = new SimpleAES();


            LoadCaptionsFromFile();
        }


        #region Private Methods
        private void LoadCaptionsFromFile()
        {
            if (File.Exists(_captionFileName))
            {

                byte[] data = File.ReadAllBytes(_captionFileName);

                var json = _simpleAES.Decrypt(data);

                var serializer = new JsonSerializer();
                var _listObjects = JsonConvert.DeserializeObject<List<string>>(json.ToString());
                if (_listObjects != null)
                {
                    foreach (string caption in _listObjects)
                    {
                        lstCaptions.Items.Add(caption);
                        _captions.Add(caption);
                    }
                }
            }
            else
            {
                File.CreateText(_captionFileName);
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Retuns the next random caption
        /// </summary>
        /// <returns></returns>
        public string GetNextCaption()
        {
            if (_captions.Count > 0)
            {
                int randomCaption = random.Next(_captions.Count);
                string caption = _captions[randomCaption];
                _captions.RemoveAt(randomCaption);
                return caption;
            }
            else
            {
                LoadCaptionsFromFile();
                return GetNextCaption();
            }
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            _captions.Add(txtNewCaption.Text);
            lstCaptions.Items.Add(txtNewCaption.Text);
            txtNewCaption.Text = "";
        }

        private void btnDeleteCaption_Click_1(object sender, EventArgs e)
        {
            if (lstCaptions.Items.Count > 0)
            {
                int selectedIndex = lstCaptions.SelectedIndex;

                if (selectedIndex > -1)
                {
                    _captions.Remove((string)lstCaptions.Items[selectedIndex]);
                    lstCaptions.Items.RemoveAt(selectedIndex);

                }
            }
        }

        private void btnSaveAndExit_Click_1(object sender, EventArgs e)
        {
            SaveCaptions();
            Hide();
        }

        private void SaveCaptions()
        {
            var json = JsonConvert.SerializeObject(_captions);
            byte[] encryptedBytes = _simpleAES.Encrypt(json);
            File.WriteAllBytes(_captionFileName, encryptedBytes);
           
        }

        private void Captions_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCaptions();
        }

    }
}
