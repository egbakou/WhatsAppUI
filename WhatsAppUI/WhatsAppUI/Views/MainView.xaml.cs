
using Plugin.Media;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainView : TabbedPage
    {
		public MainView ()
		{
			InitializeComponent ();
            MoveToChatsPage();
		}

        private void MoveToChatsPage()
        {
            var pages = Children.GetEnumerator();
            pages.MoveNext();
            pages.MoveNext();
            CurrentPage = pages.Current;
        }  
    }
}