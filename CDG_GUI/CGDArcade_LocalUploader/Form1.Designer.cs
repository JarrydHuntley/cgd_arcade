namespace CGDArcade_LocalUploader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_EntityNew = new System.Windows.Forms.Button();
            this.btn_EntityTest = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_EntityDelete = new System.Windows.Forms.Button();
            this.btn_EntityOpen = new System.Windows.Forms.Button();
            this.btn_EntitySave = new System.Windows.Forms.Button();
            this.txt_entityImg3Path = new System.Windows.Forms.TextBox();
            this.txt_entityImg2Path = new System.Windows.Forms.TextBox();
            this.txt_entityImg1Path = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_entityLogoImgPath = new System.Windows.Forms.TextBox();
            this.txt_entityProcessPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox_EntityProcessType = new System.Windows.Forms.ComboBox();
            this.txt_entityDesc = new System.Windows.Forms.TextBox();
            this.txt_entityAuthor = new System.Windows.Forms.TextBox();
            this.txt_entityTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_SettingsPassword = new System.Windows.Forms.TextBox();
            this.txt_SettingsUsername = new System.Windows.Forms.TextBox();
            this.txt_SettingsDB = new System.Windows.Forms.TextBox();
            this.txt_SettingsServer = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_SettingsTest = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.btn_EntityNew);
            this.tabPage2.Controls.Add(this.btn_EntityTest);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.btn_EntityDelete);
            this.tabPage2.Controls.Add(this.btn_EntityOpen);
            this.tabPage2.Controls.Add(this.btn_EntitySave);
            this.tabPage2.Controls.Add(this.txt_entityImg3Path);
            this.tabPage2.Controls.Add(this.txt_entityImg2Path);
            this.tabPage2.Controls.Add(this.txt_entityImg1Path);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txt_entityLogoImgPath);
            this.tabPage2.Controls.Add(this.txt_entityProcessPath);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbox_EntityProcessType);
            this.tabPage2.Controls.Add(this.txt_entityDesc);
            this.tabPage2.Controls.Add(this.txt_entityAuthor);
            this.tabPage2.Controls.Add(this.txt_entityTitle);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(591, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Entities";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_EntityNew
            // 
            this.btn_EntityNew.Location = new System.Drawing.Point(11, 389);
            this.btn_EntityNew.Name = "btn_EntityNew";
            this.btn_EntityNew.Size = new System.Drawing.Size(75, 23);
            this.btn_EntityNew.TabIndex = 61;
            this.btn_EntityNew.Text = "New";
            this.btn_EntityNew.UseVisualStyleBackColor = true;
            this.btn_EntityNew.Click += new System.EventHandler(this.btn_EntityNew_Click);
            // 
            // btn_EntityTest
            // 
            this.btn_EntityTest.Location = new System.Drawing.Point(510, 389);
            this.btn_EntityTest.Name = "btn_EntityTest";
            this.btn_EntityTest.Size = new System.Drawing.Size(75, 23);
            this.btn_EntityTest.TabIndex = 60;
            this.btn_EntityTest.Text = "Test";
            this.btn_EntityTest.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(410, 249);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 59;
            this.button11.Text = "Browse";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(410, 223);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 58;
            this.button10.Text = "Browse";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(410, 197);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 57;
            this.button9.Text = "Browse";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(410, 171);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 56;
            this.button8.Text = "Browse";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(410, 128);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 55;
            this.button7.Text = "Browse";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btn_EntityDelete
            // 
            this.btn_EntityDelete.Location = new System.Drawing.Point(254, 389);
            this.btn_EntityDelete.Name = "btn_EntityDelete";
            this.btn_EntityDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_EntityDelete.TabIndex = 54;
            this.btn_EntityDelete.Text = "Delete";
            this.btn_EntityDelete.UseVisualStyleBackColor = true;
            this.btn_EntityDelete.Click += new System.EventHandler(this.btn_EntityDelete_Click);
            // 
            // btn_EntityOpen
            // 
            this.btn_EntityOpen.Location = new System.Drawing.Point(92, 389);
            this.btn_EntityOpen.Name = "btn_EntityOpen";
            this.btn_EntityOpen.Size = new System.Drawing.Size(75, 23);
            this.btn_EntityOpen.TabIndex = 53;
            this.btn_EntityOpen.Text = "Open";
            this.btn_EntityOpen.UseVisualStyleBackColor = true;
            this.btn_EntityOpen.Click += new System.EventHandler(this.btn_EntityOpen_Click);
            // 
            // btn_EntitySave
            // 
            this.btn_EntitySave.Location = new System.Drawing.Point(173, 389);
            this.btn_EntitySave.Name = "btn_EntitySave";
            this.btn_EntitySave.Size = new System.Drawing.Size(75, 23);
            this.btn_EntitySave.TabIndex = 52;
            this.btn_EntitySave.Text = "Save";
            this.btn_EntitySave.UseVisualStyleBackColor = true;
            this.btn_EntitySave.Click += new System.EventHandler(this.btn_EntitySave_Click);
            // 
            // txt_entityImg3Path
            // 
            this.txt_entityImg3Path.Location = new System.Drawing.Point(87, 251);
            this.txt_entityImg3Path.Name = "txt_entityImg3Path";
            this.txt_entityImg3Path.Size = new System.Drawing.Size(317, 20);
            this.txt_entityImg3Path.TabIndex = 49;
            // 
            // txt_entityImg2Path
            // 
            this.txt_entityImg2Path.Location = new System.Drawing.Point(87, 225);
            this.txt_entityImg2Path.Name = "txt_entityImg2Path";
            this.txt_entityImg2Path.Size = new System.Drawing.Size(317, 20);
            this.txt_entityImg2Path.TabIndex = 48;
            // 
            // txt_entityImg1Path
            // 
            this.txt_entityImg1Path.Location = new System.Drawing.Point(87, 199);
            this.txt_entityImg1Path.Name = "txt_entityImg1Path";
            this.txt_entityImg1Path.Size = new System.Drawing.Size(317, 20);
            this.txt_entityImg1Path.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Logo Image:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Screenshot 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Screenshot 2:";
            // 
            // txt_entityLogoImgPath
            // 
            this.txt_entityLogoImgPath.Location = new System.Drawing.Point(87, 173);
            this.txt_entityLogoImgPath.Name = "txt_entityLogoImgPath";
            this.txt_entityLogoImgPath.Size = new System.Drawing.Size(317, 20);
            this.txt_entityLogoImgPath.TabIndex = 34;
            // 
            // txt_entityProcessPath
            // 
            this.txt_entityProcessPath.Location = new System.Drawing.Point(87, 130);
            this.txt_entityProcessPath.Name = "txt_entityProcessPath";
            this.txt_entityProcessPath.Size = new System.Drawing.Size(317, 20);
            this.txt_entityProcessPath.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Screenshot 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Process Path:";
            // 
            // cbox_EntityProcessType
            // 
            this.cbox_EntityProcessType.FormattingEnabled = true;
            this.cbox_EntityProcessType.Items.AddRange(new object[] {
            "BROWSER",
            "EXE"});
            this.cbox_EntityProcessType.Location = new System.Drawing.Point(87, 100);
            this.cbox_EntityProcessType.Name = "cbox_EntityProcessType";
            this.cbox_EntityProcessType.Size = new System.Drawing.Size(116, 21);
            this.cbox_EntityProcessType.TabIndex = 43;
            // 
            // txt_entityDesc
            // 
            this.txt_entityDesc.Location = new System.Drawing.Point(87, 59);
            this.txt_entityDesc.Name = "txt_entityDesc";
            this.txt_entityDesc.Size = new System.Drawing.Size(317, 20);
            this.txt_entityDesc.TabIndex = 42;
            // 
            // txt_entityAuthor
            // 
            this.txt_entityAuthor.Location = new System.Drawing.Point(87, 32);
            this.txt_entityAuthor.Name = "txt_entityAuthor";
            this.txt_entityAuthor.Size = new System.Drawing.Size(317, 20);
            this.txt_entityAuthor.TabIndex = 41;
            // 
            // txt_entityTitle
            // 
            this.txt_entityTitle.Location = new System.Drawing.Point(87, 6);
            this.txt_entityTitle.Name = "txt_entityTitle";
            this.txt_entityTitle.Size = new System.Drawing.Size(317, 20);
            this.txt_entityTitle.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Process Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Title:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_SettingsPassword);
            this.tabPage3.Controls.Add(this.txt_SettingsUsername);
            this.tabPage3.Controls.Add(this.txt_SettingsDB);
            this.tabPage3.Controls.Add(this.txt_SettingsServer);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.btn_SettingsTest);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(591, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_SettingsPassword
            // 
            this.txt_SettingsPassword.Location = new System.Drawing.Point(91, 120);
            this.txt_SettingsPassword.Name = "txt_SettingsPassword";
            this.txt_SettingsPassword.Size = new System.Drawing.Size(342, 20);
            this.txt_SettingsPassword.TabIndex = 8;
            this.txt_SettingsPassword.Text = "Rustbelt!123";
            // 
            // txt_SettingsUsername
            // 
            this.txt_SettingsUsername.Location = new System.Drawing.Point(91, 94);
            this.txt_SettingsUsername.Name = "txt_SettingsUsername";
            this.txt_SettingsUsername.Size = new System.Drawing.Size(342, 20);
            this.txt_SettingsUsername.TabIndex = 7;
            this.txt_SettingsUsername.Text = "CgdArcade";
            // 
            // txt_SettingsDB
            // 
            this.txt_SettingsDB.Location = new System.Drawing.Point(91, 68);
            this.txt_SettingsDB.Name = "txt_SettingsDB";
            this.txt_SettingsDB.Size = new System.Drawing.Size(342, 20);
            this.txt_SettingsDB.TabIndex = 6;
            this.txt_SettingsDB.Text = "CgdArcade";
            // 
            // txt_SettingsServer
            // 
            this.txt_SettingsServer.Location = new System.Drawing.Point(91, 42);
            this.txt_SettingsServer.Name = "txt_SettingsServer";
            this.txt_SettingsServer.Size = new System.Drawing.Size(342, 20);
            this.txt_SettingsServer.TabIndex = 5;
            this.txt_SettingsServer.Text = "CgdArcade.db.10636309.hostedresource.com";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Database:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Username:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Password:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Server:";
            // 
            // btn_SettingsTest
            // 
            this.btn_SettingsTest.Location = new System.Drawing.Point(318, 146);
            this.btn_SettingsTest.Name = "btn_SettingsTest";
            this.btn_SettingsTest.Size = new System.Drawing.Size(115, 23);
            this.btn_SettingsTest.TabIndex = 0;
            this.btn_SettingsTest.Text = "Connection Test";
            this.btn_SettingsTest.UseVisualStyleBackColor = true;
            this.btn_SettingsTest.Click += new System.EventHandler(this.btn_SettingsTest_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Local",
            "MySql"});
            this.comboBox1.Location = new System.Drawing.Point(87, 303);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Workspace:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CGDArcade Uploader";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_entityLogoImgPath;
        private System.Windows.Forms.TextBox txt_entityProcessPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbox_EntityProcessType;
        private System.Windows.Forms.TextBox txt_entityDesc;
        private System.Windows.Forms.TextBox txt_entityAuthor;
        private System.Windows.Forms.TextBox txt_entityTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_entityImg3Path;
        private System.Windows.Forms.TextBox txt_entityImg2Path;
        private System.Windows.Forms.TextBox txt_entityImg1Path;
        private System.Windows.Forms.Button btn_EntityDelete;
        private System.Windows.Forms.Button btn_EntityOpen;
        private System.Windows.Forms.Button btn_EntitySave;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_EntityTest;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_SettingsTest;
        private System.Windows.Forms.TextBox txt_SettingsPassword;
        private System.Windows.Forms.TextBox txt_SettingsUsername;
        private System.Windows.Forms.TextBox txt_SettingsDB;
        private System.Windows.Forms.TextBox txt_SettingsServer;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_EntityNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}

