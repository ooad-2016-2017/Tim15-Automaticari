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
            get { return "20170611104416_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("BrzaNaplataPutarineApp.Model.Kartica", b =>
                {
                    b.Property<int>("KarticaID")
                        .ValueGeneratedOnAdd()
                        .Annotation("Relational:ColumnType", "INTEGER");

                    b.Property<int>("Broj_Kartice");

                    b.Property<int>("Broj_kartice");

                    b.Property<double>("Stanje_na_racunu");

                    b.Key("KarticaID");
                });
        }
    }
}
