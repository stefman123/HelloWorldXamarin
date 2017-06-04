using HelloWorld.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


//This use to remove shadowa from buttons
[assembly: ExportRenderer(typeof(Button), typeof(FlatButtonRenderer))]
namespace HelloWorld.Droid
{
    public class FlatButtonRenderer : ButtonRenderer
    {
    }
}