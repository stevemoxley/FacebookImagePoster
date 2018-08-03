using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookImagePoster.Facebook_Entities;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace FacebookImagePoster
{
    public class Facebook
    {
        private FacebookClient _client;
        private string _appID = "859185440793574";

        public string AccessToken { get; set; }

        public Facebook()
        {
                    
        }

        public string GetLoginURI()
        {
            FacebookClient fb = new FacebookClient();
            Dictionary<string,object> parameters = new Dictionary<string,object>();
            parameters["client_id"] = _appID;
            parameters["redirect_uri"] = "https://www.facebook.com/connect/login_success.html";
            parameters["response_type"] = "token";
            parameters["scope"] = "publish_actions,manage_pages,user_photos";

            var uri = fb.GetLoginUrl(parameters);

            return uri.ToString();
        }

        public bool IsLoggedIn()
        {
            if (string.IsNullOrEmpty(AccessToken))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Posts a photo with the provided path and caption
        /// </summary>
        /// <param name="path"></param>
        /// <param name="caption"></param>
        public void PostPhoto(CaptionedImage captionedImage, string albumID)
        {
       

            if (!string.IsNullOrEmpty(AccessToken))
            {
                _client = new FacebookClient(AccessToken);
                try
                {
                    string apiPath = string.Format("/{0}/photos", albumID);
                    dynamic request = _client.Post(apiPath, new
                    {
                        message = captionedImage.Caption,
                        file = new FacebookMediaObject
                        {
                            ContentType = "image/jpeg",
                            FileName = Path.GetFileName(captionedImage.Path)
                        }.SetValue(File.ReadAllBytes(captionedImage.Path))
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Application.Exit();

                }
            }
        }

        public string GetBusinessPageAccessToken(string userToken)
        {

            FacebookClient fb = new FacebookClient();
            Dictionary<string,object> parameters = new Dictionary<string,object>();
            parameters["access_token"] = userToken;

            var result = fb.Get("/me/accounts", parameters);
            JObject json = JObject.Parse(result.ToString());
            string token = json["data"][0]["access_token"].ToString();
            return token;
        }

        public string CreateAlbum(string name, string description)
        {
            _client = new FacebookClient(AccessToken);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["access_token"] = AccessToken;
            parameters["name"] = name;
            parameters["message"] = description;
            JsonObject privacyObject = new JsonObject();
            privacyObject.Add(new KeyValuePair<string,object>("value","EVERYONE"));
            parameters["privacy"] = privacyObject;
            var result = _client.Post("/me/albums", parameters);
            dynamic albumn = JsonConvert.DeserializeObject(result.ToString());
            string id = albumn.id;
            return id;
        }
    }
}
