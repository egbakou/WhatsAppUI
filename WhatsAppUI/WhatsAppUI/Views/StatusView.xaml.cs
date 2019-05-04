using FFImageLoading.Forms;
using System;
using WhatsApp.Models;
using WhatsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StatusView  : ContentPage
	{
        private StatusViewModel viewModel;
		public StatusView()
		{
            InitializeComponent();
            BindingContext = viewModel = new StatusViewModel();
		}

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var item = (Status)e.Item;
                await Navigation.PushModalAsync(new StatusDetailView(item));
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var imageSender = (CachedImage)sender;
            Status s = new Status
            {
                Image = imageSender.Source.ToString().Remove(0, 6)
            };
            await Navigation.PushModalAsync(new StatusDetailView(s));

        }

    }
}