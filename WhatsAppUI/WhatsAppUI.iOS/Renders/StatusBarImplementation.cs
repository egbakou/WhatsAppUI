using UIKit;
using WhatsApp.Controls;
using WhatsApp.iOS.Renders;
using Xamarin.Forms;

[assembly: Dependency(typeof(StatusBarImplementation))]
namespace WhatsApp.iOS.Renders
{
    public class StatusBarImplementation : IStatusBar
    {
        public StatusBarImplementation()
        {

        }

        public void HideStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = true;
        }

        public void ShowStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = false;
        }
    }
}