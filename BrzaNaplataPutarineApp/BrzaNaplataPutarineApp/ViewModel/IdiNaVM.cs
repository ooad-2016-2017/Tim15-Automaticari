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
    class IdiNaVM : VMBase
    {
        public RelayCommand Profil { get; set; }
        public RelayCommand NadopuniRacun { get; set; }
        public RelayCommand Kontakt { get; set; }
        public RelayCommand Odjava { get; set; }
        public RelayCommand Nazad { get; set; }

        private NavigationService navigationService = new NavigationService();

        public IdiNaVM(NavigationService _navigationService)
        {
            Profil = new RelayCommand(IdiNaProfil);
            NadopuniRacun = new RelayCommand(IdiNaNadopunuRacuna);
            Kontakt = new RelayCommand(IdiNaKontakt);
            Odjava = new RelayCommand(OdjaviSe);
            Nazad = new RelayCommand(IdiNazad);

        }

        private void IdiNazad(object obj)
        {
            navigationService.Navigate(typeof(Profil_korisnika_mobilna_app));
        }

        private void OdjaviSe(object obj)
        {
            navigationService.Navigate(typeof(Pocetni_meni_mobilna_app));
        }

        private void IdiNaKontakt(object obj)
        {
            navigationService.Navigate(typeof(Kontakt));
        }

        private void IdiNaNadopunuRacuna(object obj)
        {
            navigationService.Navigate(typeof(Karticno_placanje_1_mobilna_app));
        }

        private void IdiNaProfil(object obj)
        {
            navigationService.Navigate(typeof(Profil_korisnika_mobilna_app));
        }

    }
}
