using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Model
{
    class Vozilo
    {
        //private enum TipVozila tip_vozila;
        private string model;
        private int broj_kartice;
        private string registarske_oznake;
        private double visina;

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public int Broj_kartice
        {
            get
            {
                return broj_kartice;
            }

            set
            {
                broj_kartice = value;
            }
        }

        public string Registarske_oznake
        {
            get
            {
                return registarske_oznake;
            }

            set
            {
                registarske_oznake = value;
            }
        }

        public double Visina
        {
            get
            {
                return visina;
            }

            set
            {
                visina = value;
            }
        }
    }
}
