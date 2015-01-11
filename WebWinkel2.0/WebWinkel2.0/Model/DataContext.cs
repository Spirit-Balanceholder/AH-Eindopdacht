using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWinkel2._0.Model
{
    class DataContext : DbContext
    {
     
          public DataContext()
            : base("name=DatabaseContext")
        {
        }

          protected override void OnModelCreating(DbModelBuilder modelBuilder)
          {

          }



        
        public DbSet<Afdeling> Afdelingen { get; set; }

        public DbSet<Boodschappenlijst> Boodschappenlijst { get; set; }

        public DbSet<Eindproduct> Eindproducten { get; set; }

        //volgesmij niet nodig want eindproduct heeft een lijst van kortingen. 
        public DbSet<Korting> Kortingen { get; set; }

        public DbSet<Merk> Merken { get; set; }

        public DbSet<Prijs> Prijzen { get; set; }

        public DbSet<Product> Producten { get; set; }

        public DbSet<Recept> Recepten { get; set; }

        public DbSet<Recept_Has_Eindproduct> Recept_Has_Eindproduct { get; set; }




    }
}
