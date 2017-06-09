using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Model
{
    public class Dostava : INotifyPropertyChanged
    {
        private int kolicina;
        private string dostavljac;
        private string adresa;
        private DateTime datum_dostave;
        private Kartica kartica;
        private StatusDostave status_dostave;
        private Korisnik korisnik;

        public event PropertyChangedEventHandler PropertyChanged;

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

        public DateTime Datum_dostave
        {
            get
            {
                return datum_dostave;
            }

            set
            {
                datum_dostave = value;
            }
        }

        public Kartica Kartica
        {
            get
            {
                return kartica;
            }

            set
            {
                kartica = value;
            }
        }

        public StatusDostave Status_dostave
        {
            get
            {
                return status_dostave;
            }

            set
            {
                status_dostave = value;
            }
        }

        public Korisnik Korisnik
        {
            get
            {
                return korisnik;
            }

            set
            {
                korisnik = value;
            }
        }
    }
}
