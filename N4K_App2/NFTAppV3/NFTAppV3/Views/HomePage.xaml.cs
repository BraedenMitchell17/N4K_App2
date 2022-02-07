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
    public partial class HomePage : ContentPage
    {
        //public Xamarin.Forms.ImageSource ImageSource { get; set; }
        public HomePage()
        {
            InitializeComponent();
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KissingBooth());
        }

        async void OnNextPageButtonClicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GalleryPage());
        }

        async void OnNextPageButtonClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MarketplacePage());
        }
    }
}