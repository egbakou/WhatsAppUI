using Plugin.Media;
using Plugin.Media.Abstractions;
using System.Threading.Tasks;
using WhatsApp.Services.Dialog;
using Xamarin.Forms;

namespace WhatsApp.ViewModels
{
    public class CameraViewModel : BaseViewModel
    {
        DialogService dialog;

        public Command TakePhotoCommand { get; private set; }
        public CameraViewModel()
        {
            Title = "camera.png";
            dialog = new DialogService();
            //TakePhotoCommand = new Command(async () => await PickIamge());
        }

       
        async Task PickIamge()
        {
             await CrossMedia.Current.Initialize();

            if(!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await dialog.ShowAlertAsync("No Camrera available.", "Camera", "OK");
            }

            StoreCameraMediaOptions cameraMediaOptions = new StoreCameraMediaOptions
            {
                Directory = "WhatChatGram",
                Name = "profileOO1.JPG",
                SaveToAlbum = true
            };

            var file = await CrossMedia.Current.TakePhotoAsync(cameraMediaOptions);

            if (file == null)
                return;

            await dialog.ShowAlertAsync(file.Path, "File Location", "OK");

            ImageSelected = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }


        private ImageSource _imageSelected;
        public ImageSource ImageSelected
        {
            get { return _imageSelected; }
            set { SetProperty(ref _imageSelected, value); }
        }
    }
}
