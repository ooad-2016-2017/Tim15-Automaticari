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
    class PocetniMeni_mobilna_appVM : VMBase
    {
        public RelayCommand Prijava { get; set; }
        public RelayCommand PrijaviSeKaoAdministrator { get; set; }
        public RelayCommand RegistracijaZaNoveKorisnike { get; set; }

        private NavigationService navigationService = new NavigationService();

        public PocetniMeni_mobilna_appVM(NavigationService _navigationService) 
        {
            Prijava = new RelayCommand(IzvrsiPrijavu);
            PrijaviSeKaoAdministrator = new RelayCommand(IzvrsiPrijavuKaoAdministrator);
            RegistracijaZaNoveKorisnike = new RelayCommand(IzvrsiRegistracijuZaNoveKorisnike);
        }

        private void IzvrsiPrijavu(object obj)
        {
            navigationService.Navigate(typeof(Prijava_mobilna_app));
        }

        private void IzvrsiPrijavuKaoAdministrator(object obj)
        {
            navigationService.Navigate(typeof(Prijava_administrator));
        }
        private void IzvrsiRegistracijuZaNoveKorisnike(object obj)
        {
            navigationService.Navigate(typeof(Registracija_mobilna_app));
        }

        
    }
}
