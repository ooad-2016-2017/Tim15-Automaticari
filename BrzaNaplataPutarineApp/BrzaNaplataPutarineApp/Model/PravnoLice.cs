using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Model 
{
    public class PravnoLice : INotifyPropertyChanged
    {
        private string naziv;
        private int id_broj;
        private int broj_vozila;
        private string tip_vozila;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public int Id_broj
        {
            get
            {
                return id_broj;
            }

            set
            {
                id_broj = value;
            }
        }

        public int Broj_vozila
        {
            get
            {
                return broj_vozila;
            }

            set
            {
                broj_vozila = value;
            }
        }
        public string Tip_Vozila
         {
             get
             {
                 return tip_vozila;
             }
             set
             {
                 tip_vozila = value;
             }
         }
    }
}
