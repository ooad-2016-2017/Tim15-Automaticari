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
    class Registracija_mobilna_appVM :VMBase
    {
        public RelayCommand Fizicko_lice { get; set; }
        public RelayCommand Pravno_lice { get; set; }
        public RelayCommand Nazad { get; set; }
        
        private NavigationService navigationService = new NavigationService();

        public Registracija_mobilna_appVM(NavigationService _navigationService)
        {

            Fizicko_lice = new RelayCommand(RegistrujFizickoLice);
            Pravno_lice = new RelayCommand(RegistrujPravnoLice);
            Nazad = new RelayCommand(IzvrsiNazad);
        }

        private void RegistrujFizickoLice(object obj)
        {
            navigationService.Navigate(typeof(Registracija_korisnikaa));
        }
        private void RegistrujPravnoLice(object obj)
        {
            navigationService.Navigate(typeof(Registracija_kompanijee));
        }
        private void IzvrsiNazad(object obj)
        {
            navigationService.Navigate(typeof(Pocetni_meni_mobilna_app));
        }
    }
}
