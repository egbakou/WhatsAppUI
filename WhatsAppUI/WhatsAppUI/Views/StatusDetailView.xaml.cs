using WhatsApp.Controls;
using WhatsApp.Models;
using WhatsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StatusDetailView : ContentPage
	{
        private StatusDetailViewModel viewModel;
        public StatusDetailView(Status status)
		{
            DependencyService.Get<IStatusBar>().HideStatusBar();
            //NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = viewModel = new StatusDetailViewModel(status);
		}

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            DependencyService.Get<IStatusBar>().ShowStatusBar();
        }
    }
}