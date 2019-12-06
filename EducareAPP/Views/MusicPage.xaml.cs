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

        private async void TeaPot(object sender, EventArgs e)
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                //When No Internet Access
                Device.OpenUri(new Uri("https://www.youtube.com/watch?v=B6en-O5yF0o "));
            }
            else
            {
                //Display
                await DisplayAlert("NO Internet Connection", "Check your Network Settings", " and Retry");

            }
        }

       

        private async void Bus(object sender, EventArgs e)
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                //When No Internet Access
                Device.OpenUri(new Uri("https://www.youtube.com/watch?v=e_04ZrNroTo"));
            }
            else
            {
                //Display
                await DisplayAlert("NO Internet Connection", "Check your Network Settings", " and Retry");

            }
        }

        private async void RowBoat(object sender, EventArgs e)
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                //When No Internet Access
                Device.OpenUri(new Uri("https://www.youtube.com/watch?v=7otAJa3jui8"));
            }
            else
            {
                //Display
                await DisplayAlert("NO Internet Connection", "Check your Network Settings", " and Retry");

            }
        }

        private async void cowjump(object sender, EventArgs e)
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                //When No Internet Access
                Device.OpenUri(new Uri(" https://www.youtube.com/watch?v=Lsbr7a5MVOk"));
            }
            else
            {
                //Display
                await DisplayAlert("NO Internet Connection", "Check your Network Settings", " and Retry");

            }
        }
    }






}