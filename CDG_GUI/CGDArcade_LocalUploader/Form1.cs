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
        RecordSelector recordSelector;

        public Form1()
        {
            InitializeComponent();
            this.arcadeDBHandler = new CGDArcadeDBHandler();
            this.arcadeDBHandler.InitializeValues(this.txt_SettingsServer.Text,
                this.txt_SettingsDB.Text, this.txt_SettingsUsername.Text, this.txt_SettingsPassword.Text);
            
            this.recordSelector = new RecordSelector(this);
        }





        //  =--==--==--==--==--==--==--==--==--==--==--==--=
        //  SETTINGS
        private void btn_SettingsTest_Click(object sender, EventArgs e)
        {
            this.arcadeDBHandler.DBConnectionTest();
        }




        //  =--==--==--==--==--==--==--==--==--==--==--==--=
        //  ENTITY
        private void btn_EntityNew_Click(object sender, EventArgs e)
        {
            this.txt_entityTitle.Text = "";
            this.txt_entityAuthor.Text = "";
            this.txt_entityDesc.Text = "";
            this.cbox_EntityProcessType.SelectedIndex = 0;
            this.txt_entityProcessPath.Text = "";
            this.txt_entityLogoImgPath.Text = "";
            this.txt_entityImg1Path.Text = "";
            this.txt_entityImg2Path.Text = "";
            this.txt_entityImg3Path.Text = "";
        }

        private void btn_EntityOpen_Click(object sender, EventArgs e)
        {
            
            //this.recordSelector.LoadEntityData(this.arcadeDBHandler.RetrieveEntitiesFromDB);
            
        }

        private void btn_EntitySave_Click(object sender, EventArgs e)
        {

        }

        private void btn_EntityDelete_Click(object sender, EventArgs e)
        {

        }







    }
}
