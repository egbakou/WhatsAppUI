using System;
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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Chat Button", "Select contact and ...", "OK");
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await DisplayAlert("Item", "Item tapped", "OK");
        }
    }
}