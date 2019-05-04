using Plugin.Media;
using Plugin.Media.Abstractions;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WhatsApp.Models;
using Xamarin.Forms;

namespace WhatsApp.ViewModels
{
    public class StatusViewModel : BaseViewModel
    {
        public Command TakePhotoCommand { get; private set; }

        public StatusViewModel()
        {
            Title = "STATUS";
            Me = Services.StatutsService.GetMyInfo();
            RecentUpdates = new ObservableCollection<Status>
                (Services.StatutsService.GetRecentUpdates());
            TakePhotoCommand = new Command(async () => await TakePhoto());
        }

        async Task TakePhoto()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DialogService.ShowAlertAsync("No Camrera available.", "Camera", "OK");
            }

            StoreCameraMediaOptions cameraMediaOptions = new StoreCameraMediaOptions
            {
                Directory = "WhatChatGram",
                SaveToAlbum = true                              
            };

            var file = await CrossMedia.Current.TakePhotoAsync(cameraMediaOptions);

            if (file == null)
                return;

            //await DialogService.ShowAlertAsync(file.Path, "File Location", "OK");

            var imageSelected = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }

        private Me _me;
        public Me Me
        {
            get { return _me; }
            set { SetProperty(ref _me, value); }
        }

        private ObservableCollection<Status> _recentUpdates;
        public ObservableCollection<Status> RecentUpdates
        {
            get { return _recentUpdates; }
            set { SetProperty(ref _recentUpdates, value); }
        }

    }
}
