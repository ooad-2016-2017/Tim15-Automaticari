using BrzaNaplataPutarineApp.Helper;
using BrzaNaplataPutarineApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BrzaNaplataPutarineApp.ViewModel
{
    class KorisnikVM
    {
        public static Korisnik korisnik { get; set; }
        public INavigationService NavigationService { get; set; }
        public ICommand FillWithUserData { get; set; }
        public KorisnikVM()
        {
            korisnik = new Korisnik();
            korisnik.Stanje_na_racunu = 500;
            NavigationService = new NavigationService();
            FillWithUserData = new RelayCommand<object>(prikazKorisnika, showUserData);
        }
        public bool showUserData(object parameter)
        {
            return true;
        }
        public void prikazKorisnika(object parameter)
        {
            NavigationService.GoBack();

        }
        
    }
}
