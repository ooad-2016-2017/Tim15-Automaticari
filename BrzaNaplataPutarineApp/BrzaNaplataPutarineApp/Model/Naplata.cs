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
        private string vrijednost;

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

        public string Vrijednost
        {
            get
            {
                return vrijednost;
            }

            set
            {
                vrijednost = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
