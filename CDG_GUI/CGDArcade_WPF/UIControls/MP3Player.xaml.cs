using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

namespace CGDArcade_WPF.UIControls
{
    /// <summary>
    /// Interaction logic for MP3Player.xaml
    /// </summary>
    public partial class MP3Player : UserControl
    {
        MediaPlayer mplayer;
        Hashtable filePaths;
        string selectedTrack = "";
        EntryDetailWindow detailWindow;

        public MP3Player(EntryDetailWindow detailWindow)
        {
            this.detailWindow = detailWindow;

            InitializeComponent();
            this.mplayer = new MediaPlayer();
        }


        public void LaunchMP3Player(string albumTitle, string albumArtist, string albumLogoPath, string albumBasePath)
        {
            this.lbl_AlbumArtist.Content = albumArtist;
            this.lbl_AlbumTitle.Content = albumTitle;

            this.mediaLogo.Source = new Uri(albumLogoPath);

            RetrieveFilePaths(albumBasePath);
            PlayMusic(); //START PLAYING ON LOAD
        }

        private void RetrieveFilePaths(string basepath)
        {
            this.filePaths = new Hashtable();

            string[] paths = Directory.GetFiles(@basepath, "*.mp3");

            foreach(string path in paths)
            {
                string key = System.IO.Path.GetFileName(path);
                this.filePaths.Add(key, path);
                this.listbox_TrackList.Items.Add(key);
            }
            this.listbox_TrackList.SelectedIndex = 0;
        }
        

        

        private void PlayMusic()
        {
            this.mplayer.Open(new Uri(this.filePaths[this.selectedTrack].ToString(), UriKind.Relative));
            this.mplayer.Play();
        }

        public void StopMusic()
        {
            this.mplayer.Stop();
            
        }




        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            StopMusic();
            this.detailWindow.CloseMP3Player();
        }

        private void btn_Prev_Click(object sender, RoutedEventArgs e)
        {
            int index = this.listbox_TrackList.SelectedIndex;

            if (index > 0)
            {
                listbox_TrackList.SelectedIndex = index - 1;
            }
        }

        private void btn_Play_Click(object sender, RoutedEventArgs e)
        {
            PlayMusic();
        }

        private void btn_Stop_Click(object sender, RoutedEventArgs e)
        {
            StopMusic();
        }

        private void btn_Next_Click(object sender, RoutedEventArgs e)
        {
            int index = this.listbox_TrackList.SelectedIndex;

            if (index < listbox_TrackList.Items.Count - 1)
            {
                listbox_TrackList.SelectedIndex = index + 1;
            }
        }



        private void listbox_TrackList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.selectedTrack = listbox_TrackList.SelectedValue.ToString();
            PlayMusic();
        }








    }
}
