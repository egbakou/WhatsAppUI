using System.Collections.ObjectModel;
using WhatsApp.Models;

namespace WhatsApp.ViewModels
{
    public class StatusViewModel : BaseViewModel
    {
        public StatusViewModel()
        {
            Title = "STATUS";
            Me = Services.StatutsService.GetMyInfo();
            RecentUpdates = new ObservableCollection<Status>
                (Services.StatutsService.GetRecentUpdates());
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
