using WhatsApp.ViewModels;
using Xamarin.Forms;

namespace WhatsApp.PopupPages
{
    public class ChatProfileSelectionPopupViewModel : BaseViewModel
    {
        private ImageSource _selectedProfileImage;
        public ImageSource SelectedProfileImage
        {
            get { return _selectedProfileImage; }
            set { SetProperty(ref _selectedProfileImage, value); }
        }

        private string _contact;
        public string Contact
        {
            get { return _contact; }
            set { SetProperty(ref _contact, value); }
        }

        public ChatProfileSelectionPopupViewModel(ImageSource source)
        {
            SelectedProfileImage = source;
            // FileName to contact name; Example: Rita.jpg => Rita
            var fileName = source.ToString().Remove(0, 6);
            Contact = fileName.Remove(fileName.Length - 4, 4);
        }
    }
}
