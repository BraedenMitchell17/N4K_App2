using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NFTAppV3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestingCoverage : ContentPage
    {
        Timer timer = new Timer();
        Timer masterTimer = new Timer();
        int counter;
        int masterCounter;
        bool pressed = true;
        public TestingCoverage(string location)
        {
            InitializeComponent();

            //Master timer for the synthetic pressure data metric
            Device.StartTimer(TimeSpan.FromMilliseconds(1), () =>
            {
                masterCounter++;

                if(pressed == false)
                {
                    int timeMaster = masterCounter;
                    return false;
                }

                return true;
            });
        }

        private void KissTest_Pressed(object sender, EventArgs e)
        {
            KissTest.BackgroundColor = Color.Red;
            //pressed = true;
            Device.StartTimer(TimeSpan.FromMilliseconds(1), () =>
            {
                if (pressed == true)
                {
                    System.Console.WriteLine("DEBUG - KissTest Pressed!");
                    counter++;
                    lblDuration.Text = counter.ToString();
                    return true;
                }
                else
                {
                    System.Console.WriteLine("DEBUG - KissTest Released!");
                    //File.WriteAllLines("NFT.txt", lblDuration.Text);
                    return false;
                }
            });
        }

        private void KissTest_Released(object sender, EventArgs e)
        {
            pressed = false;
        }
    }
}