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
    class Prijava_mobilna_appVM : VMBase
    {
        public RelayCommand Prijava { get; set; }
        public RelayCommand Nazad { get; set; }
        public RelayCommand zaboravljena_sifra { get; set; }

        public string Email { get; set; }
        public string Lozinka { get; set; }

        private NavigationService navigationService = new NavigationService();

        public Prijava_mobilna_appVM(NavigationService _navigationService)
        {
            Prijava = new RelayCommand(IzvrsiPrijavu);
            Nazad = new RelayCommand(IzvrsiNazad);
            zaboravljena_sifra = new RelayCommand(IzvrsiSifru);
        }

        private void IzvrsiPrijavu(object obj)
        {
            navigationService.Navigate(typeof(Profil_korisnika_mobilna_app));
        }

        private void IzvrsiSifru(object obj)
        {
            navigationService.Navigate(typeof(ZaboravljenaSifra));
        }

        private void IzvrsiNazad(object obj)
        {
            navigationService.Navigate(typeof(Pocetni_meni_mobilna_app));
        }
    }
}
