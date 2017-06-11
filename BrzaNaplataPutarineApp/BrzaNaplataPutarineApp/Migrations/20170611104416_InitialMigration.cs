using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace BrzaNaplataPutarineAppMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Kartica",
                columns: table => new
                {
                    KarticaID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Broj_Kartice = table.Column(type: "INTEGER", nullable: false),
                    Broj_kartice = table.Column(type: "INTEGER", nullable: false),
                    Stanje_na_racunu = table.Column(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kartica", x => x.KarticaID);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Kartica");
        }
    }
}
