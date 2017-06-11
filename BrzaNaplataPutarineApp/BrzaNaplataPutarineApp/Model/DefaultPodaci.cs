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
            if (!context.Kartice.Any())
            {
                context.Kartice.AddRange(
                new Kartica()
                {
                    Broj_kartice = 123,
                    Stanje_na_racunu =10000,

                    
                }
                );
                context.SaveChanges();
            }
        }
    }
}
