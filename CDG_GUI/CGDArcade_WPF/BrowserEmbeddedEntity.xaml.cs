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
    /// Interaction logic for BrowserEmbeddedEntity.xaml
    /// </summary>
    public partial class BrowserEmbeddedEntity : Window
    {

        EntryDetailWindow entryDetailWindow;
        GenericArcadeEntity entity;

        public BrowserEmbeddedEntity(EntryDetailWindow entryDetailWindow, GenericArcadeEntity entity)
        {
            InitializeComponent();
            this.entryDetailWindow = entryDetailWindow;
            this.entity = entity;
            this.lbl_titleBar.Content = "Now Playing: " + this.entity.entityTitle;

            LoadWebBrowser();
        }

        private void CloseThisWindow()
        {
            this.entryDetailWindow.Focus();
            this.Hide();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CloseThisWindow();
        }

        private void LoadWebBrowser()
        {
            this.webbrowser_Game.Navigate(new Uri(this.entity.playPath, UriKind.RelativeOrAbsolute));
            this.webbrowser_Game.Focus();

            //this.webbrowser_Game.Source = this.entity.playPath;
        }








    }
}
