using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        private readonly string[] _quotes;
        private int _counter;
        public QuotesPage()
        {
            InitializeComponent();

                _counter = 0;

             _quotes = new[]
            {
                "Love is the only force capable of transforming an enemy into a friend.",
                "Darkness cannot drive out darkness; only light can do that. Hate cannot drive out hate; only love can do that.",
                "The function of education is to teach one to think intensively and to think critically. Intelligence plus character - that is the goal of true education.",
                "I have a dream that my four little children will one day live in a nation where they will not be judged by the color of their skin, but by the content of their character."
            };

            LblQuote.Text = _quotes[0];
            //BindingContext = new ContentPageViewModel();
        }



        private void Next_OnClicked(object sender, EventArgs e)
        {
            _counter++;

            if (_counter <= _quotes.Length - 1 )
            {
                LblQuote.Text = _quotes[_counter];
            }
            else
            {

                LblQuote.Text = _quotes[0];
            }
        }
    }

  
}
