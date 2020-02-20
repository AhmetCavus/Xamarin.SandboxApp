using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SandboxApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            AppCenter.Start("android=6aa10396-157b-43e2-883d-19241d2bd259;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
