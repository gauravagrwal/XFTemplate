using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFTemplate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DIPS.Xamarin.UI.Library.Initialize();

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
