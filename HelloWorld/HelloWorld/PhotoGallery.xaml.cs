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
    public partial class PhotoGallery : ContentPage
    {
        private int id;

        public PhotoGallery()
        {
            id = 1;

            InitializeComponent();
        }

        private void RightButton_OnClicked(object sender, EventArgs e)
        {
           

            if (id == 10)
            {
                id = 1;
            }
            else
            {
                id += 1;
            }


            Image.Source = $"http://lorempixel.com/1920/1080/city/{id}";
        }

        private void LeftButton_OnClicked(object sender, EventArgs e)
        {
           

            if (id == 1)
            {
                id = 10;
            }
            else
            {
                id -= 1;
            }

            var image = $"http://lorempixel.com/1920/1080/city/{id}";

            Image.Source = new UriImageSource
            {
                Uri = new Uri(image),
                CachingEnabled = false
            };
        }
    }
}