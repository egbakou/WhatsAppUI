using FFImageLoading.Forms;
using Rg.Plugins.Popup.Extensions;
using WhatsApp.PopupPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CallsViewTemplate : ContentView
    {
        public CallsViewTemplate()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            var imageSender = (CachedImage)sender;
            await Navigation.PushPopupAsync(new ChatProfileSelectionPopupView(imageSender.Source));
        }
    }
}