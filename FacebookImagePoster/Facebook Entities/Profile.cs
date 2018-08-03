using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookImagePoster.Facebook_Entities
{
    public class Profile
    {
        public string id { get; set; }
        public string name { get; set; }

        public Profile(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
