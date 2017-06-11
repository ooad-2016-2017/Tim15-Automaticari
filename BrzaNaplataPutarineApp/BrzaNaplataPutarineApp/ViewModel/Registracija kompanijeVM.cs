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
    class Registracija_kompanijeVM : VMBase
    {
        public RelayCommand Registracija { get; set; }
        public RelayCommand Nazad { get; set; }
        public RelayCommand checkCommand { get; set; }
        public bool toggle = true;
        public string Ime_kompanije { get; set; }
        public string Broj_vozila { get; set; }
        public string Tip_vozila { get; set; }

        private NavigationService navigationService = new NavigationService();

        public Registracija_kompanijeVM(NavigationService _navigationService)
        {
            Registracija = new RelayCommand(IzvrsiRegistraciju);
            Nazad = new RelayCommand(IzvrsiNazad);
            checkCommand = new RelayCommand(postaviKvacicu);
            navigationService = _navigationService;
        }

        private void IzvrsiRegistraciju(object obj)
        {
            navigationService.Navigate(typeof(Korisnik));
        }
        private void postaviKvacicu(object _param)
        {
            toggle = !toggle;
            ((Windows.UI.Xaml.Controls.CheckBox)_param).IsEnabled = toggle;
        }
        private void IzvrsiNazad(object obj)
        {
            navigationService.Navigate(typeof(Naslovna));
        }
    }
}
