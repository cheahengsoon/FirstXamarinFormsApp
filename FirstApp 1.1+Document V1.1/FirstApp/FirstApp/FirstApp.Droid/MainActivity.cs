using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Microsoft.Azure.Mobile;
using HockeyApp.Android;
namespace FirstApp.Droid
{
    [Activity(Label = "FirstApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            MobileCenter.Configure("a5b4c324-e8c7-4384-ac82-c1e4ba4700a1");
            LoadApplication(new App());

            //Hockey App integration problems. Please Check 20161218
          CrashManager.Register(this, "792f64eea52a4da4820ad477b587904d");
        }
    }
}

