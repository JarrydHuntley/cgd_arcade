using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGDArcade_CommonLibrary
{
    public class GenericArcadeCollection
    {
        public int id = -1;
        public string collection_Title;
        public string collection_Description;
        public int collection_ImageID = -1;

        public byte[] collection_ImageData;
        public string recordSelectorText;

        public void SetRecordSelectorText()
        {
            this.recordSelectorText = string.Format("{0} - {1}", collection_ImageID, collection_Title);
        }
    }
}
