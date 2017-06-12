using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.SerialCommunication;

namespace BrzaNaplataPutarineApp.Model
{
    public class SerijskiUredjajIIme
    {
        SerialDevice uredjaj;
        String ime;

        public SerijskiUredjajIIme(SerialDevice uredjaj, string ime)
        {
            this.Uredjaj = uredjaj;
            this.Ime = ime;
        }
        public SerialDevice Uredjaj
        {
            get
            {
                return uredjaj;
            }

            set
            {
                uredjaj = value;
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
                ime = value;
            }
        }
    }
}