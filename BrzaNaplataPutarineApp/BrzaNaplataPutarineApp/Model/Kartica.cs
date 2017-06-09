using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Model
{
    public class Kartica : INotifyPropertyChanged
    {
        private int broj_kartice;
        private double stanje_na_racunu;

        public int Broj_kartice
        {
            get
            {
                return broj_kartice;
            }

            set
            {
                broj_kartice = value;
            }
        }

        public double Stanje_na_racunu
        {
            get
            {
                return stanje_na_racunu;
            }

            set
            {
                stanje_na_racunu = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
