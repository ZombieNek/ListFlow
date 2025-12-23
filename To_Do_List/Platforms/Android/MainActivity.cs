using Android.App;
using Android.Content.PM;
using Android.OS;

namespace To_Do_List
{
    [Activity(
        Theme = "@style/Maui.SplashTheme",
        MainLauncher = true,
        LaunchMode = LaunchMode.SingleTop,
        ConfigurationChanges = ConfigChanges.ScreenSize |
                               ConfigChanges.Orientation |
                               ConfigChanges.UiMode |
                               ConfigChanges.ScreenLayout |
                               ConfigChanges.SmallestScreenSize |
                               ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Полная прозрачность
            Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#212121"));
            Window.SetNavigationBarColor(Android.Graphics.Color.ParseColor("#212121"));



        }
    }
}