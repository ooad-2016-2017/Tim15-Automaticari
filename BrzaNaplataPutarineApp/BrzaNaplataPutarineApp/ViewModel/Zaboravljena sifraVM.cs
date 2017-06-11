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
    class Zaboravljena_sifraVM : VMBase
    {
        public RelayCommand Nazad { get; set; }

        public string Vasa_email_adresa { get; set; }
        public string Vas_broj_telefona { get; set; }

        private NavigationService navigationService = new NavigationService();

        public Zaboravljena_sifraVM(NavigationService _navigationService)
        {
            Nazad = new RelayCommand(IzvrsiNazad);
        }
        
        private void IzvrsiNazad(object obj)
        {
            navigationService.Navigate(typeof(Prijava_mobilna_app));
        }
    }
}
