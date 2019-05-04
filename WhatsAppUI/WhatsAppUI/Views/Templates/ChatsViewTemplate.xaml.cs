using FFImageLoading.Forms;
using Rg.Plugins.Popup.Extensions;
using System;
using WhatsApp.PopupPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatsViewTemplate : ContentView
    {
        public ChatsViewTemplate()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var imageSender = (CachedImage)sender;
            await Navigation.PushPopupAsync(new ChatProfileSelectionPopupView(imageSender.Source));

        }
    }
}