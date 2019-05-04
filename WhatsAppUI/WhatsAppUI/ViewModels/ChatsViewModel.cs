using System.Collections.ObjectModel;
using WhatsApp.Models;

namespace WhatsApp.ViewModels
{
    public class ChatsViewModel: BaseViewModel
    {
        
        public ChatsViewModel()
        {
            Title = "CHATS";
            Contacts = new ObservableCollection<Contact>
                (Services.ContactService.GetAllContact());
        }


        private ObservableCollection<Contact> _contacts;
        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts;  }
            set { SetProperty(ref _contacts, value); }
        }
        
    }
}
