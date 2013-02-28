using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CGDArcade_CommonLibrary
{
    /*GameID
        Title
        Author
        Desc
        img1
        img2 
     */

    public class GenericArcadeEntity
    {
        public string selectionControlMediaPath = "";
        public string selectionControlMediaType = "";
        public Image selectionControlMediaImage;

        public string entity2 = "http://www.youtube.com/embed/lnwABVxcl3s"; 


        public string entityTitle = "TITLE TEST HERE";
        public string entityAuthor = "M PERRIN";
        public string entityDescription = "A wacky funny way to test this amazingly cool app";

        public void SetSelectionControlMedia(string path, string type)
        {
            this.selectionControlMediaPath = path;
            this.selectionControlMediaType = type;

            switch (type.ToUpper())
            {
                case "IMAGE":
                    this.selectionControlMediaImage = RetrieveImageFromPath(this.selectionControlMediaPath);
                    break;
            }
        }

        public void SetEntityTitle(string title)
        {
            this.entityTitle = title;
        }


        //  =--==--==--==--==--==--==--==--==--==--==--==--=
        //  ASSET RETRIEVAL
        public Image RetrieveImageFromPath(string path)
        {
            Image newImage = new Image();
            newImage.Source = (new ImageSourceConverter()).ConvertFromString(this.selectionControlMediaPath) as ImageSource;
            return newImage;
        }


    }
}
