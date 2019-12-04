using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EducareAPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WELLPage : ContentPage
    {
        public WELLPage()
        {
            InitializeComponent();
        }

        private void ABC(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ABCPage());
        }

        private void number(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NumbersPage());
        }

        private void Fruit(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FruitPage());
        }

        private void Animals(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AnimalPage());
        }

        private void colorwheel(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TheColourPage());
        }

        private void Music(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MusicPage());
        }

        
    }
}