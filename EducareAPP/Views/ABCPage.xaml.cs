using EducareAPP.Data;
using EducareAPP.Modles;
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
    public partial class ABCPage : ContentPage
    {
        private List<Alphabet> _alphabet;

        public List<Alphabet> AlphabetList
        {
            get
            {
                return _alphabet;
            }

            set
            {
                _alphabet = value;
            }
        } 


        public ABCPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var database = App.Database;

            AlphabetList = database.GetAlphabetList();

            BindingContext = this;
        }

    }
}
 