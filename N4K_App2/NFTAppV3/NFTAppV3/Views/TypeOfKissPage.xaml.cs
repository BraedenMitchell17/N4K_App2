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
    public partial class TypeOfKissPage : ContentPage
    {
        public TypeOfKissPage()
        {
            InitializeComponent();
        }

        async void OnNextPageButtonClickedHand(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KissPage("Hand"));
        }

        async void OnNextPageButtonClickedForehead(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KissPage("Forehead"));
        }

        async void OnNextPageButtonClickedLips(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KissPage("Lips"));
        }

        async void OnNextPageButtonClickedNeck(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KissPage("Neck"));
        }

        async void OnNextPageButtonClickedShoulder(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KissPage("Shoulder"));
        }

        async void OnNextPageButtonClickedFrenchKiss(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KissPage("FrenchKiss"));
        }
    }
}