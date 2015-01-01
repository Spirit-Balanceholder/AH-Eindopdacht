using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace webwinkelAH.Model
{
    class MyContext : DbContext
    {
        public DbSet<Afdeling> Afdelingen { get; set; }
        public DbSet<Kar> Kar { get; set; }
        public DbSet<Korting> Kortingen { get; set; }
        public DbSet<Merk> Merken { get; set; }
        public DbSet<Product> Producten { get; set; }

      
       
       
    }
}
