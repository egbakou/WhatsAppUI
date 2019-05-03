using System;
using System.ComponentModel;
using Android.Content;
using Android.Content.Res;
using WhatsApp.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using FAB = Android.Support.Design.Widget.FloatingActionButton;


[assembly: ExportRenderer(typeof(WhatsApp.Controls.FloatingActionButton), typeof(FloatingActionButtonRenderer))]
namespace WhatsApp.Droid.Renders
{
    public class FloatingActionButtonRenderer : Xamarin.Forms.Platform.Android.AppCompat.ViewRenderer<Controls.FloatingActionButton, FAB>
    {
        public FloatingActionButtonRenderer(Context context) : base(context)
        {

        }

        public FloatingActionButtonRenderer() : base(null)
        {
            throw new Exception("This constructor should not actually ever be used");
        }

        public static void Initialize() { /* used only for helping ensure the renderer is not linked out */ }
        protected override void OnElementChanged(ElementChangedEventArgs<WhatsApp.Controls.FloatingActionButton> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
                return;

            var fab = new FAB(Context);
            // set the bg
            Android.Support.V4.View.ViewCompat.SetBackgroundTintList(fab, ColorStateList.ValueOf(Element.ButtonColor.ToAndroid()));
            fab.UseCompatPadding = true;

            // set the icon
            var elementImage = Element.Image;
            var imageFile = elementImage?.File;

            if (imageFile != null)
            {
                fab.SetImageDrawable(ResourceManager.GetDrawable(Context, imageFile));
            }
            fab.Click += Fab_Click;
            SetNativeControl(fab);

        }
        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
            Control.BringToFront();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var fab = Control;
            if (e.PropertyName == nameof(Element.ButtonColor))
            {
                Android.Support.V4.View.ViewCompat.SetBackgroundTintList(fab, ColorStateList.ValueOf(Element.ButtonColor.ToAndroid()));
            }
            if (e.PropertyName == nameof(Element.Image))
            {
                var elementImage = Element.Image;
                var imageFile = elementImage?.File;

                if (imageFile != null)
                {
                    fab.SetImageDrawable(ResourceManager.GetDrawable(Context, imageFile));
                }
            }
            base.OnElementPropertyChanged(sender, e);

        }

        private void Fab_Click(object sender, EventArgs e)
        {
            // proxy the click to the element
            ((IButtonController)Element).SendClicked();
        }
    }
}