using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using BrzaNaplataPutarineApp.Model;

namespace BrzaNaplataPutarineAppMigrations
{
    [ContextType(typeof(dbContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20170611145913_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("BrzaNaplataPutarineApp.Model.Administrator", b =>
                {
                    b.Property<int>("AdministratorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Lozinka");

                    b.Key("AdministratorId");
                });

            builder.Entity("BrzaNaplataPutarineApp.Model.Dostava", b =>
                {
                    b.Property<int>("DostavaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<DateTime>("Datum_dostave");

                    b.Property<string>("Dostavljac");

                    b.Property<int?>("KarticaKarticaID");

                    b.Property<int>("Kolicina");

                    b.Property<int?>("KorisnikKorisnikId");

                    b.Property<string>("Status_dostave");

                    b.Key("DostavaID");
                });

            builder.Entity("BrzaNaplataPutarineApp.Model.Kartica", b =>
                {
                    b.Property<int>("KarticaID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Broj_kartice");

                    b.Property<double>("Stanje_na_racunu");

                    b.Key("KarticaID");
                });

            builder.Entity("BrzaNaplataPutarineApp.Model.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .Annotation("Relational:ColumnType", "INTEGER");

                    b.Property<int>("Broj_kreditne_kartice");

                    b.Property<string>("Email");

                    b.Property<string>("Kontakt_telefon");

                    b.Property<double>("Stanje_na_racunu");

                    b.Key("KorisnikId");
                });

            builder.Entity("BrzaNaplataPutarineApp.Model.Dostava", b =>
                {
                    b.Reference("BrzaNaplataPutarineApp.Model.Kartica")
                        .InverseCollection()
                        .ForeignKey("KarticaKarticaID");

                    b.Reference("BrzaNaplataPutarineApp.Model.Korisnik")
                        .InverseCollection()
                        .ForeignKey("KorisnikKorisnikId");
                });
        }
    }
}
