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

        public string entityTitle;
        public string entityAuthor;
        public string entityDescription;

        public string playPath = "";
        public string pathArgs = "";

        public string img1Path;
        public string img2Path;
        public string img3Path;
        public string logoImgPath;
    }
}
