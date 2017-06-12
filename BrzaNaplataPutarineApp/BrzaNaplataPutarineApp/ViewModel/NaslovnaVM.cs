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
    class NaslovnaVM : VMBase
    {
        public RelayCommand RegistracijaKorisnika { get; set; }
        public RelayCommand RegistracijaKompanije { get; set; }
        public RelayCommand Dostave { get; set; }
        public RelayCommand Nazad { get; set; }
        

        private NavigationService navigationService = new NavigationService();

        public NaslovnaVM(NavigationService _navigationService)
        {
            RegistracijaKorisnika = new RelayCommand(IzvrsiRegistracijuKorisnika);
            RegistracijaKompanije = new RelayCommand(IzvrsiRegistracijuKompanije);
            Dostave = new RelayCommand(IdiNaDostave);
            Nazad = new RelayCommand(IdiNazad);
        }
        // ne radi ovaj
        private void IzvrsiRegistracijuKorisnika(object obj)
        {
            navigationService.Navigate(typeof(Registracija_korisnikaa));
        }
        // ni ovaj
        private void IzvrsiRegistracijuKompanije(object obj)
        {
            navigationService.Navigate(typeof(Registracija_kompanijee));
        }
        private void IdiNazad(object obj)
        {
            navigationService.Navigate(typeof(Pocetni_meni_mobilna_app)); 
        }
        private void IdiNaDostave(object obj)
        {
            navigationService.Navigate(typeof(Dostave));
        }
    }
}
