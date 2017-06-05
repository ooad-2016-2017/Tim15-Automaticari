using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Azure
{
    public class Korisnici
    {
        public string id_uredjaja
        {
            get;
            set;
        }
        public string ime_i_prezime
        {
            get;
            set;
        }
        public string vozilo
        {
            get;
            set;
        }
        public string registarske_oznake
        {
            get;
            set;
        }
        public double stanje_racuna
        {
            get;
            set;
        }
    }
}
