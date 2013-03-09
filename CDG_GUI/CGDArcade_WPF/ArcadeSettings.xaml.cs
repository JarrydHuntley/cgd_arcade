using CGDArcade_CommonLibrary;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CGDArcade_WPF
{
    /// <summary>
    /// Interaction logic for ArcadeSettings.xaml
    /// </summary>
    public partial class ArcadeSettings : Window
    {
        MainWindow mainWindow;
        ArcadeEntityManager entityManager;
        GenericArcadeEntity arcadeEntity;

        public ArcadeSettings(MainWindow mainWindow, ArcadeEntityManager entityManager)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.entityManager = entityManager;
            this.arcadeEntity = new GenericArcadeEntity();
            RefreshListEntries();
        }

        private void btn_New_Click(object sender, RoutedEventArgs e)
        {
            this.arcadeEntity = new GenericArcadeEntity();

            this.txt_Title.Text = "";
            this.txt_Author.Text = "";
            this.txt_Description.Text = "";

            this.txt_Path.Text = "";
            this.txt_Args.Text = "";

            this.txt_LogoImgPath.Text = "";
            this.txt_img1Path.Text = "";
            this.txt_img2Path.Text = "";
            this.txt_img3Path.Text = "";

        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            this.arcadeEntity.entityTitle = this.txt_Title.Text;
            this.arcadeEntity.entityAuthor = this.txt_Author.Text;
            this.arcadeEntity.entityDescription = this.txt_Description.Text;

            this.arcadeEntity.playPath = this.txt_Path.Text;
            this.arcadeEntity.pathArgs = this.txt_Args.Text;

            this.arcadeEntity.logoImgPath = this.txt_LogoImgPath.Text;
            this.arcadeEntity.img1Path = this.txt_img1Path.Text;
            this.arcadeEntity.img2Path = this.txt_img2Path.Text;
            this.arcadeEntity.img3Path = this.txt_img3Path.Text;

            this.entityManager.AddEntityToManifest(this.arcadeEntity);

            RefreshListEntries();
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            this.entityManager.DeleteEntityFromManifest(this.arcadeEntity);
            RefreshListEntries();
            btn_New_Click(null, null);            
        }





        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.mainWindow.Focus();
            this.mainWindow.CreateEntitySelectionControls();
            this.Hide();
            this.Close();
        }

        private void list_Entries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list_Entries.SelectedItem != null)
            {
                this.arcadeEntity = this.entityManager.CreateEntityFromXmlNode(this.entityManager.RetrieveEntityFromManifest(list_Entries.SelectedItem.ToString()));
                UpdateUIFromArcadeEntity();
            }
        }

        private void UpdateUIFromArcadeEntity()
        {
            this.txt_Title.Text = this.arcadeEntity.entityTitle;
            this.txt_Author.Text = this.arcadeEntity.entityAuthor;
            this.txt_Description.Text = this.arcadeEntity.entityDescription;

            this.txt_Path.Text = this.arcadeEntity.playPath;
            this.txt_Args.Text = this.arcadeEntity.pathArgs;

            this.txt_LogoImgPath.Text = this.arcadeEntity.logoImgPath;
            this.txt_img1Path.Text = this.arcadeEntity.img1Path;
            this.txt_img2Path.Text = this.arcadeEntity.img2Path;
            this.txt_img3Path.Text = this.arcadeEntity.img3Path;
        }

        private void RefreshListEntries()
        {
            this.list_Entries.Items.Clear();

            foreach (GenericArcadeEntity entity in this.entityManager.arcadeEntities)
            {
                this.list_Entries.Items.Add(entity.entityTitle);
            }            
        }

        private void btn_PathBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.ShowDialog();
            this.txt_Path.Text = fileDlg.FileName;
        }

        private void btn_LogoBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.ShowDialog();
            this.txt_LogoImgPath.Text = fileDlg.FileName;
        }

        private void btn_Img1Browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.ShowDialog();
            this.txt_img1Path.Text = fileDlg.FileName;
        }

        private void btn_Img2Browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.ShowDialog();
            this.txt_img2Path.Text = fileDlg.FileName;
        }

        private void btn_Img3Browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.ShowDialog();
            this.txt_img3Path.Text = fileDlg.FileName;
        }




    }
}
