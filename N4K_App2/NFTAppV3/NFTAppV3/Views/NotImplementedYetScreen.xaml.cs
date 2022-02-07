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
    public partial class NotImplementedYetScreen : ContentPage
    {
        public NotImplementedYetScreen()
        {
            InitializeComponent();
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            //Just set to home page for now will change it
            //Set it to just to to the previous screen
            await Navigation.PushAsync(new HomePage());
        }
    }
}