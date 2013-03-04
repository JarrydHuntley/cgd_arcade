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
    public partial class Form1 : Form
    {

        CGDArcadeDBHandler arcadeDBHandler;
        int currentCollectionID;

        public Form1()
        {
            InitializeComponent();
            this.arcadeDBHandler = new CGDArcadeDBHandler();
            this.arcadeDBHandler.InitializeValues(this.txt_SettingsServer.Text,
                this.txt_SettingsDB.Text, this.txt_SettingsUsername.Text, this.txt_SettingsPassword.Text);
        }





        //  =--==--==--==--==--==--==--==--==--==--==--==--=
        //  SETTINGS
        private void btn_SettingsTest_Click(object sender, EventArgs e)
        {
            this.arcadeDBHandler.Select();
        }


        //  =--==--==--==--==--==--==--==--==--==--==--==--=
        //  COLLECTIONS
        private void btn_CollectionsNew_Click(object sender, EventArgs e)
        {
            this.txt_CollectionsTitle.Text = "";
            this.txt_CollectionsDesc.Text = "";
            this.txt_CollectionsImg.Text = "";
            this.currentCollectionID = -1;
        }

        private void bnt_CollectionsOpen_Click(object sender, EventArgs e)
        {
            currentCollectionID = -1;
            RecordSelector recordSelect = new RecordSelector(this);
            recordSelect.LoadCollectionData(this.arcadeDBHandler.RetrieveListOfCollections());
        }

        private void LoadCollectionData(string id)
        {
            

            
        }



        private void btn_CollectionsSave_Click(object sender, EventArgs e)
        {
            this.arcadeDBHandler.CreateNewCollection(this.txt_CollectionsTitle.Text, this.txt_CollectionsDesc.Text, this.txt_CollectionsImg.Text);
        }

        private void btn_CollectionsDelete_Click(object sender, EventArgs e)
        {

        }

        private void btn_CollectionsImgBrowse_Click(object sender, EventArgs e)
        {

        }









    }
}
