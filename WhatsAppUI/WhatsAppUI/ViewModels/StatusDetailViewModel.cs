using WhatsApp.Models;

namespace WhatsApp.ViewModels
{
    public class StatusDetailViewModel : BaseViewModel
    {
        public StatusDetailViewModel(Status status)
        {
            Status = status;
        }

        private Status _status;
        public Status Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }
    }
}
