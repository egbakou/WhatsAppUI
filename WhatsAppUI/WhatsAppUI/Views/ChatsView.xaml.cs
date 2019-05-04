using FFImageLoading.Forms;
using Rg.Plugins.Popup.Extensions;
using System;
using WhatsApp.PopupPages;
using WhatsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChatsView : ContentPage
	{
        public ChatsViewModel viewModel;
		public ChatsView ()
		{
			InitializeComponent ();
            BindingContext = viewModel = new ChatsViewModel();
		}

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var imageSender = (CachedImage)sender;
            await Navigation.PushPopupAsync(new ChatProfileSelectionPopupView(imageSender.Source));

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("FAB Clicked!", "Congrats on creating your FAB!", "Thanks!");
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await DisplayAlert("Item", "Item tapped", "OK");
        }
    }
}