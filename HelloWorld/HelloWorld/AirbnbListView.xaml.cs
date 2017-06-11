using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.BL;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirbnbListView : ContentPage
    {
        public AirbnbListView()
        {
            InitializeComponent();

            var searchService = new SearchService();

            SearchListView.ItemsSource = searchService.GetSearches();
        }
    }
}