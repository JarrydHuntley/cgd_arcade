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

        //public int id;
        public string entityTitle;
        public string entityAuthor;
        public string entityDescription;

        public string playPath = "";
        public string pathArgs = "";

        public string img1Path;
        public string img2Path;
        public string img3Path;
        public string logoImgPath;



	 	 	 	 	 	 	 
	 	 	 	 
/*
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
 */


    }
}
