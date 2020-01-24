using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Tumblr.Model;
using Tumblr.operation;
using Xamarin.Forms;

namespace Tumblr.viewModel
{
    public class TumblrViewModel : BaseViewModel
    {
        #region Listy
        private ObservableCollection<TumblrModel> tmblrList;
        public ObservableCollection<TumblrModel> TmblrList
        {
            get
            {
                return tmblrList;
            }
            set
            {
                tmblrList = value;
                RaisePropertyChanged(nameof(TmblrList));
            }
        }
        private ObservableCollection<TumblAvatarModel> tumblAvatarList;
        public ObservableCollection<TumblAvatarModel> TumblAvatarList
        {
            get
            {
                return tumblAvatarList;
            }
            set
            {
                tumblAvatarList = value;
                RaisePropertyChanged(nameof(TumblAvatarList));
            }
        }
        
        #endregion


        public TumblrViewModel()
        {
            

            DodajDoListy(null, null);
          
        }


        #region Wypełnianie List
        public void DodajAwatarDoListy(string link)
        {
            TumblAvatarList.Add(new TumblAvatarModel() {Avatar = link });
        }
        public void DodajDoListy(string sTytul, string sOpis)
        {
            TmblrList = new ObservableCollection<TumblrModel>();            

            TmblrList.Clear();

            TumblrModel tm = new TumblrModel
            {
                Tytul = "Test",
                Opis = "Opis",
                NazwaUzytkownika = "ja",
                
            };
            TmblrList.Add(tm);
        }

        
        #endregion


       


    }
}
