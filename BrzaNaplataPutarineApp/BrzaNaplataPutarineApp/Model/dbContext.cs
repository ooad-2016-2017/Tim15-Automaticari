using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace BrzaNaplataPutarineApp.Model
{
    class dbContext : DbContext
    {
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Administrator> Administratori { get; set; }
        public DbSet<Dostava> Dostave { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string databaseFilePath = "Baza.db";
        try
        {
            //za tačnu putanju gdje se nalazi baza uraditi ovdje debug i procitati Path
            databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path,
            databaseFilePath);
        }catch(InvalidOperationException) { }
        //Sqlite baza
        optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //jedno od polja je image da se zna šta je zapravo predstavlja byte[]
        modelBuilder.Entity<Korisnik>().Property(p => p.KorisnikId).HasColumnType("INTEGER");
    }
    }
}
