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
    class Karticno_placanje_2_mobilna_appVM : VMBase
    {
        public RelayCommand Plati { get; set; }
        public RelayCommand Nazad { get; set; }

        public string Ime_i_prezime { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public int Postanski_broj { get; set; }
        public string Drzava { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }

        private NavigationService navigationService = new NavigationService();

        public Karticno_placanje_2_mobilna_appVM(NavigationService _navigationService)
        {
            Nazad = new RelayCommand(IdiNazad);
        }


        private void IdiNazad(object obj)
        {
            navigationService.Navigate(typeof(Karticno_placanje_1_mobilna_app));
        }
    }
}
