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

        public EntryDetailWindow()
        {
            InitializeComponent();
            AddHandler(Keyboard.KeyDownEvent, (KeyEventHandler)KeyPressed);
        }

        private void img_btn_GridLayout_MouseDown(object sender, MouseButtonEventArgs e)
        {
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

            this.entityMediaElement.Source = new Uri(this.entity.selectionControlMediaPath);

            this.entityMedia1.Source = new Uri(this.entity.selectionControlMediaPath);
            this.entityMedia2.Source = new Uri(this.entity.entity2);
            this.entityMedia3.Source = new Uri(this.entity.selectionControlMediaPath);

            this.lbl_Title.Content = this.entity.entityTitle;
            this.lbl_Author.Content = "Created by " + this.entity.entityAuthor;
            this.lbl_Description.Text = this.entity.entityDescription;
        }


    }
}
