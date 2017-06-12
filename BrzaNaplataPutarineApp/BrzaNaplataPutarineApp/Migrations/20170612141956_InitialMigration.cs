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
                name: "Administrator",
                columns: table => new
                {
                    AdministratorId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column(type: "TEXT", nullable: true),
                    Lozinka = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.AdministratorId);
                });
            migration.CreateTable(
                name: "Kartica",
                columns: table => new
                {
                    KarticaID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Broj_kartice = table.Column(type: "INTEGER", nullable: false),
                    Stanje_na_racunu = table.Column(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kartica", x => x.KarticaID);
                });
            migration.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Broj_kreditne_kartice = table.Column(type: "INTEGER", nullable: false),
                    Email = table.Column(type: "TEXT", nullable: true),
                    Kontakt_telefon = table.Column(type: "TEXT", nullable: true),
                    Stanje_na_racunu = table.Column(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikId);
                });
            migration.CreateTable(
                name: "Dostava",
                columns: table => new
                {
                    DostavaID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Adresa = table.Column(type: "TEXT", nullable: true),
                    Datum_dostave = table.Column(type: "TEXT", nullable: false),
                    Dostavljac = table.Column(type: "TEXT", nullable: true),
                    KarticaKarticaID = table.Column(type: "INTEGER", nullable: true),
                    Kolicina = table.Column(type: "INTEGER", nullable: false),
                    KorisnikKorisnikId = table.Column(type: "INTEGER", nullable: true),
                    Status_dostave = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostava", x => x.DostavaID);
                    table.ForeignKey(
                        name: "FK_Dostava_Kartica_KarticaKarticaID",
                        columns: x => x.KarticaKarticaID,
                        referencedTable: "Kartica",
                        referencedColumn: "KarticaID");
                    table.ForeignKey(
                        name: "FK_Dostava_Korisnik_KorisnikKorisnikId",
                        columns: x => x.KorisnikKorisnikId,
                        referencedTable: "Korisnik",
                        referencedColumn: "KorisnikId");
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Administrator");
            migration.DropTable("Dostava");
            migration.DropTable("Kartica");
            migration.DropTable("Korisnik");
        }
    }
}
