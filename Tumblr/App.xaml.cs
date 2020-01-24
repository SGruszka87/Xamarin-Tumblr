using System;
using Tumblr.view;
using Tumblr.view.Menu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tumblr
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Strona_Glowna_Page());
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
