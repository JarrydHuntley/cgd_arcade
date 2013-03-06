using CGDArcade_CommonLibrary;
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
    /// Interaction logic for EntryDetailWindow.xaml
    /// </summary>
    public partial class EntryDetailWindow : Window
    {
        GenericArcadeEntity entity;
        MainWindow mainWindow;

        public EntryDetailWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            AddHandler(Keyboard.KeyDownEvent, (KeyEventHandler)KeyPressed);
        }

        private void img_btn_GridLayout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.mainWindow.Focus();

            this.Hide();
            this.Close();
        }

        private void KeyPressed(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F1:
                    KillThisApp();
                    break;
            }
        }

        private void KillThisApp()
        {
            Application.Current.Shutdown();
        }

        public void UpdateValuesFromEntity(GenericArcadeEntity entity)
        {
            this.entity = entity;

            this.entityMediaElement.Source = new Uri(this.entity.logoImgPath);

            this.entityMedia1.Source = new Uri(this.entity.img1Path);
            this.entityMedia2.Source = new Uri(this.entity.img2Path);
            this.entityMedia3.Source = new Uri(this.entity.img3Path);

            this.lbl_Title.Content = this.entity.entityTitle;
            this.lbl_Author.Content = "Created by " + this.entity.entityAuthor;
            this.lbl_Description.Text = this.entity.entityDescription;
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            BrowserEmbeddedEntity newEmbed = new BrowserEmbeddedEntity(this, this.entity);

            newEmbed.Show();
            newEmbed.Width = this.Width;
            newEmbed.Height = this.Height;
            newEmbed.WindowState = this.WindowState;
        }


    }
}
