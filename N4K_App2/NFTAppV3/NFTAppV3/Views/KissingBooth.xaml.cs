using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NFTAppV3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
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
        }

        async void OnNextPageButtonClickedShare(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotImplementedYetScreen());
        }
    }
}