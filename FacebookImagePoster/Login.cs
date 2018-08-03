using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookImagePoster
{
    public partial class Login : Form
    {
        Facebook _facebook;

        public Login(Facebook facebook)
        {
            _facebook = facebook;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(_facebook.GetLoginURI());
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Uri url = webBrowser1.Url;
            if(url.LocalPath.Contains("success"))
            {
                string query = url.Fragment;
                string splitter = "=";
                string[] split = query.Split(splitter.ToCharArray());
                string accessTokenFull = split[1];
                string splitter2 = "&";
                string[] split2 = accessTokenFull.Split(splitter2.ToCharArray());
                string access_token = split2[0];
                _facebook.AccessToken = access_token;

                string businessToken = _facebook.GetBusinessPageAccessToken(access_token);
                _facebook.AccessToken = businessToken;  

                this.Hide();
                MessageBox.Show("Log In Successful");
              
            }
        }
    }
}
