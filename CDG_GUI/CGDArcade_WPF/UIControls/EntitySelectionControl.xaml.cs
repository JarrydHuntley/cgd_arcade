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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CGDArcade_CommonLibrary;

namespace CGDArcade_WPF.UIControls
{
    /// <summary>
    /// Interaction logic for EntitySelectionControl.xaml
    /// </summary>
    public partial class EntitySelectionControl : UserControl
    {
        public GenericArcadeEntity arcadeEntity;
        public MainWindow mainWindow;

        public EntitySelectionControl(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }


        public void SetAssociatedEntity(GenericArcadeEntity entity)
        {
            this.arcadeEntity = entity;

            if (this.arcadeEntity.logoImgPath != "")
            {
                this.entityMediaElement.Source = new Uri(this.arcadeEntity.logoImgPath); //TODO ACCESS IT LIKE THIS
            }
            
            this.entityTitle.Content = this.arcadeEntity.entityTitle;
        }

        public void SetAsActiveEntity()
        {

            this.entityControl.BorderThickness = new Thickness(2.0);

        }

        public void SetAsInactiveEntity()
        {
            this.entityControl.BorderThickness = new Thickness(0.0);
        }

        public void entityControl_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.mainWindow.SwapActiveEntity(this);

            EntryDetailWindow win = new EntryDetailWindow(this.mainWindow);
            
            win.Show();
            win.Width = this.mainWindow.Width;
            win.Height = this.mainWindow.Height;
            win.WindowState = this.mainWindow.WindowState;

            win.UpdateValuesFromEntity(this.arcadeEntity);
        }




    }
}
