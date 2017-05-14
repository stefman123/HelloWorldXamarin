using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Greetings : ContentPage
    {
        public Greetings()
        {
            InitializeComponent();

            slider.Value = 0.1;
        }

        private void Handle_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Title","Hello World","OK");
        }
    }
}
