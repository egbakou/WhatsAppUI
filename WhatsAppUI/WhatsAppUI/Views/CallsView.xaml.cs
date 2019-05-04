using WhatsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CallsView : ContentPage
	{
        private CallsViewModel viewModel;

		public CallsView()
		{
			InitializeComponent ();
            BindingContext = viewModel = new CallsViewModel();
		}

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Call Button", "Select contact and ...", "OK");
        }       
    }
}