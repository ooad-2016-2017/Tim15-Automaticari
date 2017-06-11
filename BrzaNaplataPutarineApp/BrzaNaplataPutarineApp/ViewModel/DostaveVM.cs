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
    class DostaveVM : VMBase
    {
        public RelayCommand Nazad { get; set; }
        public RelayCommand checkCommand { get; set; }
        public bool toggle = true;

        private NavigationService navigationService = new NavigationService();

        public DostaveVM(NavigationService _navigationService)
        {
            Nazad = new RelayCommand(IzvrsiNazad);
            checkCommand = new RelayCommand(postaviKvacicu);
            navigationService = _navigationService;
        }

        private void IzvrsiNazad(object obj)
        {
            navigationService.Navigate(typeof(View.Naslovna));
        }

        private void postaviKvacicu(object _param)
        {
            toggle = !toggle;
            ((Windows.UI.Xaml.Controls.CheckBox)_param).IsEnabled = toggle;
        }
    }
}
