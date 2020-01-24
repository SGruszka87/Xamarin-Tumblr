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
    public partial class Tumblr_Info_Page : ContentPage
    {
        private TumblrViewModel viewModel { get; set; }
        private WebService webService { get; set; }
        public Tumblr_Info_Page()
        {
            InitializeComponent();
            webService = new WebService();
            viewModel = new TumblrViewModel();
            BindingContext = viewModel;
            lv_Wyswietl.ItemsSource = viewModel.TmblrList;
        }

        private void btnSzukaj_Clicked(object sender, EventArgs e)
        {
            string blog = entrySzukaj.Text;
            string key = "PyezS3Q4Smivb24d9SzZGYSuh--IaMfAkE";

            string url = string.Format("api.tumblr.com/v2/blog/{0}/info?api_key={1}", blog, key);
            

            webService.GetInfo(url,1);
        }
    }
}