using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NFTAppV3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MusicPlayScreen : ContentPage
    {
        Timer music = new Timer();
        public MusicPlayScreen()
        {
            InitializeComponent();
            music.Interval = 3000;
            music.Elapsed += Music_Elapsed;
            music.Start();
            btnHomePage.IsEnabled = false;
            prgSong.Progress += music.Interval;
        }

        private void Music_Elapsed(object sender, ElapsedEventArgs e)
        {
            btnHomePage.IsEnabled = true;

            music.Stop();
        }

        async void OnNextPageButtonClickedHomePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}