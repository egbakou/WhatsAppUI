using FFImageLoading.Forms;
using Rg.Plugins.Popup.Extensions;
using WhatsApp.PopupPages;
using WhatsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CallsView : ContentPage
	{
        private CallsViewModel viewModel;

		public CallsView()
		{
			InitializeComponent ();
            BindingContext = viewModel = new CallsViewModel();
		}

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("FAB", "You want to call someone ?", "Yes");
        }

        private async void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            var imageSender = (CachedImage)sender;
            await Navigation.PushPopupAsync(new ChatProfileSelectionPopupView(imageSender.Source));
        }
    }
}