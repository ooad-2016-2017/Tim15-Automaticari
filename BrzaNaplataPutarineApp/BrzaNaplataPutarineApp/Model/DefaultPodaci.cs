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
                    Email = "mirza.hodovic@hotmail.com",
                    Kontakt_telefon = "033333333",
                    Broj_kreditne_kartice = 67347,
                    Stanje_na_racunu = 34.3

                }
            );
                context.SaveChanges();
            }

            if (!context.Administratori.Any())
            {
                context.Administratori.AddRange(
                new Administrator()
                {
                    Email = "administrator@mail.com",
                    Lozinka = "papapapa"

                }
                );
                context.SaveChanges();
            }

            
            
        }
    }
}
