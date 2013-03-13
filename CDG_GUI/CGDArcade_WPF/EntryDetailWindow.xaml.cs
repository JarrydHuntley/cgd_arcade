using CGDArcade_CommonLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.IO;

using System.Diagnostics;
using System.Runtime.InteropServices;



namespace CGDArcade_WPF
{
    /// <summary>
    /// Interaction logic for EntryDetailWindow.xaml
    /// </summary>
    public partial class EntryDetailWindow : Window
    {
        GenericArcadeEntity entity;
        MainWindow mainWindow;
        private Process gameProcess;

        [DllImport("User32")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);


        public EntryDetailWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            AddHandler(Keyboard.KeyDownEvent, (KeyEventHandler)KeyPressed);
        }

        private void img_btn_GridLayout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CloseThisWindow();
        }


        private void CloseThisWindow()
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

                case Key.Escape:
                    this.mainWindow.selectionChangeSFX.Play();
                    CloseThisWindow();
                    break;

                case Key.Enter:
                    this.mainWindow.selectionMadeSFX.Play();
                    Image_MouseDown_1(null, null);
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
            string exePath = AppDomain.CurrentDomain.BaseDirectory;// .Replace(@"\\EXEPATH\", exePath);

            this.entityMediaElement.Source = new Uri(this.entity.logoImgPath.Replace(@"\\EXEPATH\", exePath));

            try
            {
                if (this.entity.img1Path != "") { this.entityMedia1.Source = new Uri(this.entity.img1Path.Replace(@"\\EXEPATH\", exePath)); }
                if (this.entity.img2Path != "") { this.entityMedia2.Source = new Uri(this.entity.img2Path.Replace(@"\\EXEPATH\", exePath)); }
                if (this.entity.img3Path != "") { this.entityMedia3.Source = new Uri(this.entity.img3Path.Replace(@"\\EXEPATH\", exePath)); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            string tempString = this.entity.entityTitle;
            this.lbl_Title.Text = tempString.Replace(@"\\r\\n", System.Environment.NewLine);
            
            tempString = this.entity.entityAuthor;
            this.lbl_Author.Text = "Created by " + tempString.Replace(@"\\r\\n", System.Environment.NewLine);

            tempString = this.entity.entityDescription;
            this.lbl_Description.Text = tempString.Replace(@"\\r\\n", System.Environment.NewLine);
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.mainWindow.selectionChangeSFX.Play();

            this.gameProcess = new Process();

            try
            {
                string exePath = AppDomain.CurrentDomain.BaseDirectory;

                string tempString = this.entity.playPath;
                this.gameProcess.StartInfo.FileName = tempString.Replace(@"\\EXEPATH\", exePath);

                tempString = this.entity.pathArgs;
                this.gameProcess.StartInfo.Arguments = tempString.Replace(@"\\EXEPATH\", exePath);

                this.gameProcess.StartInfo.CreateNoWindow = true;
                this.gameProcess.EnableRaisingEvents = true;
                //this.gameProcess.Exited += new EventHandler(gameProcess_Exited);
                this.gameProcess.Start();
                //this.gameProcess.WaitForExit();
                //int hWnd = this.gameProcess.MainWindowHandle.ToInt32();
                //ShowWindow(hWnd, 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred trying to launch game. {0} :\n {1}" + ex.Message, this.entity.playPath));
            }
        }


        /* Handle Exited event and display process information. 
        private void gameProcess_Exited(object sender, System.EventArgs e)
        {

            //this.eventHandled = true;
           // this.Focus();

            //Console.WriteLine("Exit time:    {0}\r\n" + 
            //    "Exit code:    {1}\r\nElapsed time: {2}", myProcess.ExitTime, myProcess.ExitCode, elapsedTime);

            MessageBox.Show("TEST OK");
        }*/




    }
}
