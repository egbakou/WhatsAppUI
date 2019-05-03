using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FloatingActionButton : Button
    {
        public static BindableProperty ButtonColorProperty = BindableProperty.Create(nameof(ButtonColor), typeof(Color), typeof(FloatingActionButton), Color.Accent);
        public Color ButtonColor
        {
            get
            {
                return (Color)GetValue(ButtonColorProperty);
            }
            set
            {
                SetValue(ButtonColorProperty, value);
            }
        }
        public FloatingActionButton()
        {
            InitializeComponent();
        }
    }
}