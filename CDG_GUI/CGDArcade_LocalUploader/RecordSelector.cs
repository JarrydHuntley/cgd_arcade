using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGDArcade_CommonLibrary;

namespace CGDArcade_LocalUploader
{
    public partial class RecordSelector : Form
    {
        Form1 uploaderForm;

        public RecordSelector(Form1 uploaderForm)
        {
            InitializeComponent();
            this.uploaderForm = uploaderForm;
            this.Hide();
        }


        //  =--==--==-==--==--==-==--==--==-==--==--==-=
        //DATA LOADER

        public void LoadCollectionData(List<GenericArcadeCollection> arcadeCollectionList)
        {
            this.cBox_RecordSelector.Items.Clear();
            foreach (GenericArcadeCollection collection in arcadeCollectionList)
            {
                this.cBox_RecordSelector.Items.Add(collection.recordSelectorText);
            }
            this.Show();
        }

        public void LoadEntityData(List<GenericArcadeEntity> arcadeEntityList)
        {
            this.cBox_RecordSelector.Items.Clear();
            foreach (GenericArcadeEntity entity in arcadeEntityList)
            {

                this.cBox_RecordSelector.Items.Add(entity.recordSelectorText);
            }
            this.Show();
        }


        //  =--==--==-==--==--==-==--==--==-==--==--==-=

        private void btn_Open_Click(object sender, EventArgs e)
        {
            this.Hide();
            string cboxText = this.cBox_RecordSelector.Text;

            //this.uploaderForm.LoadCollectionData(
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }


    }
}
