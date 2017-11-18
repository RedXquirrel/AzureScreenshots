using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Azure.Screenshots.Droid
{
    [Activity(
        Label = "Azure.Screenshots"
        , MainLauncher = true
        , Icon = "@mipmap/ic_launcher"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
