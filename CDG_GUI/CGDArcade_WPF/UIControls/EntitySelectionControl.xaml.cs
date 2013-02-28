﻿using System;
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
        public Window mainWindow;

        public EntitySelectionControl(Window mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }


        public void SetAssociatedEntity(GenericArcadeEntity entity)
        {
            this.arcadeEntity = entity;
            this.entityMediaElement.Source = new Uri(this.arcadeEntity.selectionControlMediaPath);
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

        private void entityControl_MouseUp(object sender, MouseButtonEventArgs e)
        {
            EntryDetailWindow win = new EntryDetailWindow();
            
            win.Show();
            win.Width = this.mainWindow.Width;
            win.Height = this.mainWindow.Height;
            win.WindowState = this.mainWindow.WindowState;

            win.UpdateValuesFromEntity(this.arcadeEntity);
        }




    }
}