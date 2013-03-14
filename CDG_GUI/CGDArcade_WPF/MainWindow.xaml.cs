using CGDArcade_CommonLibrary;
using CGDArcade_WPF.UIControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
        bool readyToDisplayEntities = false;
        ArcadeEntityManager arcadeEntityManager;
        public EntitySelectionControl activeEntity;
        int activeRow;
        int activeCol;

        int panelRows;
        int panelCols;

        public SoundPlayer selectionChangeSFX;
        public SoundPlayer selectionMadeSFX;

        public MainWindow()
        {
            InitializeComponent();
            //AddHandler(Keyboard.KeyDownEvent, (KeyEventHandler)KeyPressed);
            this.arcadeEntityManager = new ArcadeEntityManager();
            this.arcadeEntityManager.CreateArcadeEntitiesList();
            CreateEntitySelectionControls();

            this.selectionChangeSFX = new SoundPlayer("Assets\\Sfx\\Pickup_Coin17.wav");
            this.selectionMadeSFX = new SoundPlayer("Assets\\Sfx\\Blip_Select12.wav");
        }


        public void CreateEntitySelectionControls()
        {
            this.mainWrapPanel.Children.Clear();

            foreach (GenericArcadeEntity entity in this.arcadeEntityManager.arcadeEntities)
            {
                EntitySelectionControl newSelectionControl = new EntitySelectionControl(this);
                newSelectionControl.SetAssociatedEntity(entity);
                newSelectionControl.SetAsInactiveEntity();
                this.mainWrapPanel.Children.Add(newSelectionControl);
            }

            //SET ACTIVE ENTITYSELECTIONCONTROL

            if (this.mainWrapPanel.Children.Count > 0)
            {
                this.activeEntity = this.mainWrapPanel.Children[0] as EntitySelectionControl;
                this.activeEntity.SetAsActiveEntity();
                this.activeRow = 1;
                this.activeCol = 1;
                this.readyToDisplayEntities = true;
            }
            else
            {
                MessageBox.Show("Error - No entities found in XML");
            }
        }


               
        private void KeyPressed(object sender, KeyEventArgs e)
        {
              switch (e.Key)
              {
                  case Key.Enter:
                      this.selectionMadeSFX.Play();
                      this.activeEntity.entityControl_MouseUp(null, null);
                      break;

                  case Key.Escape:
                      KillThisApp();
                      break;

                  case Key.F1:
                      this.selectionChangeSFX.Play();
                      ToggleFullScreen();
                      break;

                  case Key.F5:
                      DiagnosticStuff("F5");
                      break;

                  case Key.C:
                      DiagnosticStuff("C");
                      break;

                  case Key.Up:
                      MoveActiveEntityMarker(-1, 0);
                      break;
                  
                  case Key.Down:
                      MoveActiveEntityMarker(1, 0);
                      break;
                  
                  case Key.Left:
                      debugLog.Content = "LEFT!";
                      MoveActiveEntityMarker(0, -1);
                      break;
            
                  case Key.Right:
                      debugLog.Content = "RIGHT!";
                      MoveActiveEntityMarker(0, 1);
                      break;
              }
        }

        private void DiagnosticStuff(string debugmsg)
        {
            // Keyboard.FocusedElement;
            debugLog.Content = debugmsg;
        }

        private void MoveActiveEntityMarker(int vertical, int horizontal)
        {


            this.selectionChangeSFX.Play();

            if (this.readyToDisplayEntities)
            {
                int activeIndex = this.mainWrapPanel.Children.IndexOf(this.activeEntity);

                int newIndex = activeIndex + (this.panelCols * vertical) + horizontal;
                // debugLog.Content = "NEW INDEX: " + newIndex.ToString();

                if ((newIndex < 0) || (newIndex >= this.mainWrapPanel.Children.Count))
                {
                    return;
                }

                SwapActiveEntity(this.mainWrapPanel.Children[newIndex] as EntitySelectionControl);
            }
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
            if (this.readyToDisplayEntities)
            {
                this.mainWrapPanel.Width = this.Width - 100;
                ResetWarpPanelPositionalSizing();
            }
        }


        private void ResetWarpPanelPositionalSizing()
        {
            if (this.readyToDisplayEntities)
            {
                this.panelRows = 1 + (int)(this.mainWrapPanel.ActualHeight / this.activeEntity.ActualHeight);
                this.panelCols = (int)(this.mainWrapPanel.ActualWidth / this.activeEntity.ActualWidth);
                this.activeEntity.BringIntoView();
            }
        }

        private void img_btn_PagedLayout_MouseDown(object sender, MouseButtonEventArgs e)
        {


            this.selectionMadeSFX.Play();
            EntryDetailWindow win = new EntryDetailWindow(this);
            win.Show();
            win.Width = this.Width;
            win.Height = this.Height;
            win.WindowState = this.WindowState;

            win.UpdateValuesFromEntity(this.activeEntity.arcadeEntity);
        }


        public void SwapActiveEntity(EntitySelectionControl newEntity)
        {
            if (this.readyToDisplayEntities)
            {
                this.activeEntity.SetAsInactiveEntity();

                this.activeEntity = newEntity;
                this.activeEntity.SetAsActiveEntity();
                this.activeEntity.BringIntoView();
            }
        }

        private void Window_PreviewKeyUp_1(object sender, KeyEventArgs e)
        {
            KeyPressed(sender, e);
        }



        private void btn_Settings_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ArcadeSettings win = new ArcadeSettings(this, this.arcadeEntityManager);
            win.Show();
            win.Width = this.Width;
            win.Height = this.Height;
            win.WindowState = this.WindowState;

            //  win.UpdateValuesFromEntity(this.activeEntity.arcadeEntity);
        }

        private void btn_Close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KillThisApp();
        }

        
    }
}
