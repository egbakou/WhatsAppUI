using System.Threading.Tasks;
using WhatsApp.Services.Navigation;
using WhatsApp.ViewModels.Base;
using WhatsApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace WhatsAppUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            InitApp();

            if (Device.RuntimePlatform == Device.UWP)
            {
                InitNavigation();
            }

            MainPage = new NavigationPage(new MainView());
        }



        private Task InitNavigation()
        {
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        private void InitApp()
        {
            ViewModelLocator.RegisterDependencies(false);
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}
