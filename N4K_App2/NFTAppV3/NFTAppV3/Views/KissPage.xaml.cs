using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Added this
//using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NFTAppV3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KissPage : ContentPage
    {
        Timer timer = new Timer();
        string typeOfKiss;
        int counter;
        bool pressed;

        public KissPage(string type)
        {
            InitializeComponent();
            typeOfKiss = type;
        }

        async void OnNextPageButtonClickedShare1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShareKissPage(counter.ToString(), typeOfKiss));
        }

        private void KissTest_Pressed(object sender, EventArgs e)
        {
            KissTest.BackgroundColor= Color.Red;
            pressed = true;
            Device.StartTimer(TimeSpan.FromMilliseconds(1), () =>
            {
                if(pressed == true)
                {
                    counter++;
                    //lblDuration.Text = counter.ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            });
        }

        private void KissTest_Released(object sender, EventArgs e)
        {
            pressed = false;
        }

        async void OnBackButtonPressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TypeOfKissPage());
        }
    }
}