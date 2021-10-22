using TestApp.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(NativeTabBarRenderer))]
namespace TestApp.iOS.Renderers
{
    public class NativeTabBarRenderer : TabbedRenderer
    {

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            TabBar.Translucent = true;
            EdgesForExtendedLayout = UIRectEdge.Bottom;
            ViewController.EdgesForExtendedLayout = UIRectEdge.Bottom;
            ViewController.ExtendedLayoutIncludesOpaqueBars = true;
        }
    }
}