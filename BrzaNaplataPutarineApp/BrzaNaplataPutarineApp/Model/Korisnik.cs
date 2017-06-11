using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Model
{
    public class Korisnik : INotifyPropertyChanged 
    {
        
        private int broj_kreditne_kartice;
        private string email;
        private string kontakt_telefon;
        private double stanje_na_racunu;

        public event PropertyChangedEventHandler PropertyChanged;

        //public Korisnik() { }

        public string Email
        { 
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Kontakt_telefon
        {
            get
            {
                return kontakt_telefon;
            }

            set
            {
                kontakt_telefon = value;
            }
        }

        public int Broj_kreditne_kartice
        {
            get
            {
                return broj_kreditne_kartice;
            }

            set
            {
                broj_kreditne_kartice = value;
            }
        }

        public double Stanje_na_racunu
        {
            get
            {
                return stanje_na_racunu;
            }

            set
            {
                stanje_na_racunu = value;
            }
        }

    }
}
