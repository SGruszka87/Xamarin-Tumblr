using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tumblr.operation;
using Tumblr.viewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tumblr.view.Zakladki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tumblr_Avatar_Page : ContentPage
    {
        private TumblrViewModel viewModel { get; set; }
        private WebService webService { get; set; }
           

        public Tumblr_Avatar_Page()
        {   
            InitializeComponent();
            webService = new WebService();
            viewModel = new TumblrViewModel();
            BindingContext = viewModel;
        }

        private void btnSzukaj_Clicked(object sender, EventArgs e)
        {
            string blog = entrySzukaj.Text;

            string url = string.Format("https://api.tumblr.com/v2/blog/{0}.tumblr.com/avatar", blog);

            webService.GetInfo(url, 0);
            UruchomListe();
        }

        private void UruchomListe()
        {
            lv_Wyswietl.ItemsSource = viewModel.TumblAvatarList;
        }
    }
}