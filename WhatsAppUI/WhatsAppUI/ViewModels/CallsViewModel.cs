using System.Collections.ObjectModel;
using WhatsApp.Models;

namespace WhatsApp.ViewModels
{
    public class CallsViewModel : BaseViewModel
    {
        public CallsViewModel()
        {
            Title = "CALLS";
            CallHistory = new ObservableCollection<Call>(Services.CallService
                .GetCallHistory());
        }

        private ObservableCollection<Call> _callHistory;
        public ObservableCollection<Call> CallHistory
        {
            get { return _callHistory; }
            set { SetProperty(ref _callHistory, value); }
        }
    }
}
