﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Model
{
    public class Uposlenik : INotifyPropertyChanged
    {
        private string ime;
        private string prezime;
        private string funkcija_uposlenika;

        public event PropertyChangedEventHandler PropertyChanged;

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

        public string Funkcija_uposlenika
        {
            get
            {
                return funkcija_uposlenika;
            }

            set
            {
                funkcija_uposlenika = value;
            }
        }
    }
}
