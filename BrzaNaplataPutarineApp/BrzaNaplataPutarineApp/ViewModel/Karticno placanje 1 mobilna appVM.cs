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
    class Karticno_placanje_1_mobilna_appVM : VMBase
    {
        public RelayCommand Dalje { get; set; }
        public RelayCommand Nazad { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        private NavigationService navigationService = new NavigationService();

        public Karticno_placanje_1_mobilna_appVM(NavigationService _navigationService)
        {
            Dalje = new RelayCommand(IdiDalje);
            Nazad = new RelayCommand(IdiNazad);
        }

        private void IdiDalje(object obj)
        {
            navigationService.Navigate(typeof(Karticno_placanje_2_mobilna_app));
        }

        private void IdiNazad(object obj)
        {
            navigationService.Navigate(typeof(Profil_korisnika_mobilna_app));
        }
    }
}
