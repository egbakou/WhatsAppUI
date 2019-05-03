using Android.App;
using Android.Views;
using Plugin.CurrentActivity;
using WhatsApp.Controls;
using WhatsApp.Droid.Renders;
using Xamarin.Forms;

[assembly: Dependency(typeof(StatusBarImplementation))]
namespace WhatsApp.Droid.Renders
{
    public class StatusBarImplementation : IStatusBar
    {
        public StatusBarImplementation()
        {

        }

        WindowManagerFlags _originalFlags;

        public void HideStatusBar()
        {
            Activity activity = CrossCurrentActivity.Current.Activity;
            var attrs = activity.Window.Attributes;
            _originalFlags = attrs.Flags;
            attrs.Flags |= WindowManagerFlags.Fullscreen;
            activity.Window.Attributes = attrs;
        }

        public void ShowStatusBar()
        {
            var activity = CrossCurrentActivity.Current.Activity;
            var attrs = activity.Window.Attributes;
            attrs.Flags = _originalFlags;
            activity.Window.Attributes = attrs;
        }
    }
}