using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using CollabLogin;
using CollabLogin.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace CollabLogin.Droid.CustomRenderers
{

    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context):base(context)
        {
            AutoPackage = false;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
               
                GradientDrawable gd = new GradientDrawable();
                Control.Background = new ColorDrawable(Android.Graphics.Color.Red);
        
               // gd.SetColor(Android.Graphics.Color.LightGray);
                gd.SetColor(Android.Graphics.Color.ParseColor("#1e1c24"));
                gd.SetCornerRadius(75);
                Control.SetBackgroundDrawable(gd);
              
                

            }
        }
    }
}