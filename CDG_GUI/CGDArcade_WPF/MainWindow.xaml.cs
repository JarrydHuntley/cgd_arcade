using CGDArcade_CommonLibrary;
using CGDArcade_WPF.UIControls;
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

namespace CGDArcade_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArcadeEntryManager arcadeEntityManager;
        EntitySelectionControl activeEntity;
        int activeRow;
        int activeCol;

        int panelRows;
        int panelCols;

        public MainWindow()
        {
            InitializeComponent();
            AddHandler(Keyboard.KeyDownEvent, (KeyEventHandler)KeyPressed);
            this.arcadeEntityManager = new ArcadeEntryManager();

            foreach (GenericArcadeEntity entity in this.arcadeEntityManager.arcadeEntities)
            {
                EntitySelectionControl newSelectionControl = new EntitySelectionControl(this);
                newSelectionControl.SetAssociatedEntity(entity);
                newSelectionControl.SetAsInactiveEntity();
                this.mainWrapPanel.Children.Add(newSelectionControl);
            }

            //SET ACTIVE ENTITYSELECTIONCONTROL
            this.activeEntity = this.mainWrapPanel.Children[0] as EntitySelectionControl;
            this.activeEntity.SetAsActiveEntity();
            this.activeRow = 1;
            this.activeCol = 1;
        }
               
        private void KeyPressed(object sender, KeyEventArgs e)
        {
              switch (e.Key)
              {
                  case Key.Escape:
                      ToggleFullScreen();
                      break;

                  case Key.F1:
                      KillThisApp();
                      break;

                  case Key.Up:
                      MoveActiveEntityMarker(-1, 0);
                      break;
                  
                  case Key.Down:
                      MoveActiveEntityMarker(1, 0);
                      break;
                  
                  case Key.Left:
                      MoveActiveEntityMarker(0, -1);
                      break;
            
                  case Key.Right:
                      MoveActiveEntityMarker(0, 1);
                      break;
              }
        }


        private void MoveActiveEntityMarker(int vertical, int horizontal)
        {
            int activeIndex = this.mainWrapPanel.Children.IndexOf(this.activeEntity);

            int newIndex = activeIndex + (this.panelCols * vertical) + horizontal;
            debugLog.Content = "NEW INDEX: " + newIndex.ToString();

            if ((newIndex < 0) || (newIndex >= this.mainWrapPanel.Children.Count))
            {
                return;
            }

            this.activeEntity.SetAsInactiveEntity();
            this.activeEntity = this.mainWrapPanel.Children[newIndex] as EntitySelectionControl;
            this.activeEntity.SetAsActiveEntity();
            this.activeEntity.BringIntoView();
        }




        private void KillThisApp()
        {
            Application.Current.Shutdown();
        }

        private void ToggleFullScreen()
        {
            if (this.WindowState == System.Windows.WindowState.Maximized)
            {
                this.WindowState = System.Windows.WindowState.Normal;
            }
            else if (this.WindowState == System.Windows.WindowState.Normal)
            {
                this.WindowState = System.Windows.WindowState.Maximized;
            }

            ResetWarpPanelPositionalSizing();
        }

        private void Window_SizeChanged_1(object sender, SizeChangedEventArgs e)
        {
            this.mainWrapPanel.Width = this.Width - 100;
            ResetWarpPanelPositionalSizing();
        }


        private void ResetWarpPanelPositionalSizing()
        {
            this.panelRows = 1 + (int)(this.mainWrapPanel.ActualHeight / this.activeEntity.ActualHeight);
            this.panelCols = (int)(this.mainWrapPanel.ActualWidth / this.activeEntity.ActualWidth);
            this.activeEntity.BringIntoView();
        }

        private void img_btn_PagedLayout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            EntryDetailWindow win = new EntryDetailWindow();
            win.Show();
            win.Width = this.Width;
            win.Height = this.Height;
            win.WindowState = this.WindowState;

            win.UpdateValuesFromEntity(this.activeEntity.arcadeEntity);
        }



    }
}
