using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrzaNaplataPutarineApp.Helper;
using BrzaNaplataPutarineApp.View;

namespace BrzaNaplataPutarineApp.ViewModel
{
    class InformacijeSenzorVM : VMBase
    {
        
        public RelayCommand Nazad { get; set; }

        private NavigationService navigationService = new NavigationService();

        public InformacijeSenzorVM(NavigationService _navigationService)
        {
            
            Nazad = new RelayCommand(IzvrsiNazad);
        }

       
        private void IzvrsiNazad(object obj)
        {
            navigationService.Navigate(typeof(Naslovna));
        }

    }
}
