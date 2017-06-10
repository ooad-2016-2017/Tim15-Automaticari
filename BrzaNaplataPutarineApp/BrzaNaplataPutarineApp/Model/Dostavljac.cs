using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Model
{
    public class Dostavljac : INotifyPropertyChanged
    {
        private string ime;
        private string prezime;

        public string Ime
        {
            get
            {
                return ime;
            }
             
            set
            {
                ime = value;
                
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
