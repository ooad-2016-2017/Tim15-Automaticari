using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Model
{
    public class Dostava : INotifyPropertyChanged
    {
      /*  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]*/
        public int DostavaID { get; set; }

        private int dostavaID;
        private int kolicina;
        private string dostavljac;
        private string adresa;
        private DateTime datum_dostave;
        private Kartica kartica;
        private string status_dostave;
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
                if (value != kolicina)
                {
                    kolicina = value;
                }
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
                if (value != dostavljac)
                {
                    dostavljac = value;
                }
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
                if (value != adresa)
                {
                    adresa = value;
                }
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
                if (value != datum_dostave)
                {
                    datum_dostave = value;
                }
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
                if (value != kartica)
                {

                    kartica = value;
                }
            }
        }

        public string Status_dostave
        {
            get
            {
                return status_dostave;
            }

            set
            {
                if (value != status_dostave)
                {
                    status_dostave = value;
                }
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
                if (value != korisnik)
                {
                    korisnik = value;
                }
            }
        }
    }
}
