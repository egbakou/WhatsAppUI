using WhatsApp.Models;
using WhatsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StatusView  : ContentPage
	{
        private StatusViewModel viewModel;
		public StatusView()
		{
            InitializeComponent();
            BindingContext = viewModel = new StatusViewModel();
		}

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var item = (Status)e.Item;
                Navigation.PushModalAsync(new StatusDetailView(item));
            }
        }
       
    }
}