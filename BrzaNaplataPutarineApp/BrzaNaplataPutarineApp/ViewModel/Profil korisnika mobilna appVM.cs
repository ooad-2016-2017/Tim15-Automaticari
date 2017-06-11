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
    class Profil_korisnika_mobilna_appVM
    {
        public RelayCommand Dopuna { get; set; }
        public RelayCommand Nazad { get; set; }
        public RelayCommand Meni { get; set; }
        
        private NavigationService navigationService = new NavigationService();

        public Profil_korisnika_mobilna_appVM(NavigationService _navigationService)
        {
            Dopuna = new RelayCommand(IzvrsiDopunu);
            Nazad = new RelayCommand(IzvrsiNazad);
            Meni = new RelayCommand(IdiNaMeni);
        }

        private void IzvrsiDopunu(object obj)
        {
            navigationService.Navigate(typeof(Karticno_placanje_1_mobilna_app));
        }

        private void IdiNaMeni(object obj)
        {
            navigationService.Navigate(typeof(Idi_na));
        }

        private void IzvrsiNazad(object obj)
        {
            navigationService.Navigate(typeof(Prijava_mobilna_app));
        }
    }
}
