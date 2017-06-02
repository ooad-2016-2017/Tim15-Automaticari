using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarine.Model
{
    class Uredjaj
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int idUredjaja;
        private double stanje;

        public Uredjaj(int idUredjaja, double pocetnoStanje)
        {
            IdUredjaja = idUredjaja;
            Stanje = pocetnoStanje;
        }

        public int IdUredjaja
        {
            get
            {
                return idUredjaja;
            }

            set
            {
                idUredjaja = value;
            }
        }

        public double Stanje
        {
            get
            {
                return stanje;
            }

            set
            {
                stanje = value;
            }
        }
    }
}
