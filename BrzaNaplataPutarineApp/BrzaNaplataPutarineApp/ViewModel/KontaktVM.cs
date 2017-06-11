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
    class KontaktVM : VMBase
    {
        public RelayCommand Nazad { get; set; }
        

        private NavigationService navigationService = new NavigationService();

        public KontaktVM(NavigationService _navigationService)
        {
            Nazad = new RelayCommand(IzvrsiNazad);
        }
        private void IzvrsiNazad(object obj)
        {
            navigationService.Navigate(typeof(Profil_korisnika_mobilna_app));
        }
    }
}
