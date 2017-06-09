using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Model
{
    public class Naplata : INotifyPropertyChanged
    {
        private int broj_naplate;
        private Vrijednost vrijednost;

        public int Broj_naplate
        {
            get
            {
                return broj_naplate;
            }

            set
            {
                broj_naplate = value;
            }
        }

        /*public Vrijednost Vrijednost
        {
            get
            {
                return vrijednost;
            }

            set
            {
                vrijednost = value;
            }
        }*/

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
