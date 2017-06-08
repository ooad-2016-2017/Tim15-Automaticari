using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Model
{
    class Dostava
    {
        private int kolicina;
        private string dostavljac;
        private string adresa;
        //private Datum datum_dostave;
        //private Kartica karica;
        //private StatusDostave status_dostave;
        //private Korisnik korisnik;

        public int Kolicina
        {
            get
            {
                return kolicina;
            }

            set
            {
                kolicina = value;
            }
        }

        public string Dostavljac
        {
            get
            {
                return dostavljac;
            }

            set
            {
                dostavljac = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }

    }
}
