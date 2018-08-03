using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookImagePoster
{
    public class CaptionedImage
    {
        public string Path { get; set; }
        public string Caption {  get; set;}


        public CaptionedImage(string path, string caption)
        {
            Path = path;
            Caption = caption;
        }

        public override string ToString()
        {
            return Caption;
        }

        public void Delete()
        {
            File.Delete(Path);
        }
 

    }
}
