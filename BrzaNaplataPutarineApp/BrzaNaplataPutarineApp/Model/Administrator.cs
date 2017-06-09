using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Model
{
    public class Administrator : INotifyPropertyChanged
    {
        private string ime;
        private string prezime;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                if (value != prezime)
                {
                    prezime = value;
                }
            }
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                if (value != ime)
                {
                    ime = value;
                }
            }
        }
    }
}
