using Plugin.Media;
using Plugin.Media.Abstractions;
using WhatsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Camera : ContentPage
	{
        private CameraViewModel viewModel;

		public Camera ()
		{
			InitializeComponent ();
            BindingContext = viewModel = new CameraViewModel();
		}

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camrera available.", "Camera", "OK");
            }

            StoreCameraMediaOptions cameraMediaOptions = new StoreCameraMediaOptions
            {
                Directory = "WhatChatGram",
                Name = "whatchat_img.JPG",
                SaveToAlbum = true
            };

            var file = await CrossMedia.Current.PickPhotoAsync();

            if (file == null)
                return;

            await DisplayAlert(file.Path, "File Location", "OK");

            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }
        
    }
}