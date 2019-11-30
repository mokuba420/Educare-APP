using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EducareAPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MusicPage : ContentPage
    {
        public MusicPage()
        {
            InitializeComponent();
        }

        private async void cowjumps(object sender, EventArgs e)
        {

            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                //When No Internet Access
                Device.OpenUri(new Uri("https://www.youtube.com/watch?v=sJiw-edttDY"));
            }
            else
            {
                //Display
                await DisplayAlert("NO Internet Connection", "Check your Network Settings", " and Retry");

            }


        }

        private async void blindmics(object sender, EventArgs e)
        {

            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                //When No Internet Access
                Device.OpenUri(new Uri(" https://www.youtube.com/watch?v=MfaChKSV8kg"));
            }
            else
            {
                //Display
                await DisplayAlert("NO Internet Connection", "Check your Network Settings", " and Retry");

            }







        }
    }






}