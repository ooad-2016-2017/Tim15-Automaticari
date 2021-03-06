using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrzaNaplataPutarineApp.ViewModel;
using BrzaNaplataPutarineApp.Helper;
using BrzaNaplataPutarineApp.View;

namespace BrzaNaplataPutarineApp.ViewModel
{
    class KorisnikVM : VMBase
    {
        public RelayCommand DopuniRacun { get; set; }
        public RelayCommand Nazad { get; set; }

        private NavigationService navigationService = new NavigationService();

        public KorisnikVM(NavigationService _navigationService)
        {
            DopuniRacun = new RelayCommand(IzvrsiDopunu);
            Nazad = new RelayCommand(IzvrsiNazad);
        }

        private void IzvrsiDopunu(object obj)
        {
            navigationService.Navigate(typeof(Karticno_placanje_1_mobilna_app));
        }
        private void IzvrsiNazad(object obj)
        {
            navigationService.Navigate(typeof(Naslovna));
        }
    }
}
