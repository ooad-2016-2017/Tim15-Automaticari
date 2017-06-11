using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Model
{
    class DefaultPodaci
    {
        public static void Initialize(dbContext context)
        {
            if (!context.Korisnici.Any())
            {
                context.Korisnici.AddRange(
                new Korisnik()
                {
                    Email = "dkfljs.com",
                    Kontakt_telefon = "062343344",
                    Broj_kreditne_kartice = 333,
                    Stanje_na_racunu =34.3

                }
                );
                context.SaveChanges();
            }
        }
    }
}
