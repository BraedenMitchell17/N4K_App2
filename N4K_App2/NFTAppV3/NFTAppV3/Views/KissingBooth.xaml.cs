using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Android.Views;

namespace NFTAppV3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //Testing this
    //[Activity(Label = "NFTAppV3", Icon = "@mipmap/icon", Theme = "@style/MainTheme")]
    public partial class KissingBooth : ContentPage
    {
        public KissingBooth()
        {
            InitializeComponent();
        }

        async void OnNextPageButtonClickedTypeOfKiss(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TypeOfKissPage());
        }

        async void OnNextPageButtonClickedKiss(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new KissPage("Forehead"));
            //Testing this
            await Navigation.PushAsync(new TestingCoverage("Forehead"));

            //GestureRecognizer gr = new GestureRecognizer();
            
            //ElementPropertyChanged.
            //await Navigation.PushAsync(gr);

        }

        async void OnNextPageButtonClickedShare(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotImplementedYetScreen());
        }
    }
}