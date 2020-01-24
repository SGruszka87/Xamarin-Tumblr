using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;
using Tumblr.Model;
using Tumblr.viewModel;
using Xamarin.Forms;

namespace Tumblr.operation
{
    public class WebService
    {
        private TumblrViewModel viewModel;
        public WebService()
        {
            viewModel = new TumblrViewModel();
        }

        public bool GetInfo(string url, int Opcja)
        {
            
            try
            {
                string TmblrUrl = url;
                using (var handler = new HttpClientHandler { })
                using (var client = new HttpClient(handler))
                {
                    HttpResponseMessage response = client.GetAsync(TmblrUrl).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        if (Opcja == 0)
                        {
                            var resp = response.Content.ReadAsStreamAsync().Result;

                            using (StreamReader sr= new StreamReader(resp))
                            {
                                var json = sr.ReadToEnd();
                            
                                var items = JsonConvert.DeserializeObject<TumblAvatarModel>(json);
                               
                                
                                //viewModel.DodajAwatarDoListy(awatar);                             
                            }
                        }
                        if (Opcja == 1)
                        {
                            var resp = response.Content.ReadAsStreamAsync().Result;

                            using (StreamReader sr = new StreamReader(resp))
                            {
                                var json = sr.ReadToEnd();

                                var items = JsonConvert.DeserializeObject<TumblrModel>(json);
                                
                                viewModel.DodajDoListy(items.Tytul,items.Opis);

                                
                            }
                        }
                    }
                }

            }
            catch (Exception )
            {
                 Device.BeginInvokeOnMainThread(async () => { await Application.Current.MainPage.DisplayAlert("Uwaga", "Błąd podczas pobierania danych z Tumblr.", "OK"); });
            }
            return false;
        }

       
    }
}
