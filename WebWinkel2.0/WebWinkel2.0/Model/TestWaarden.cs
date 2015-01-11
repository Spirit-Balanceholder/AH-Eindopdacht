using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWinkel2._0.Model
{
    class TestWaarden
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            dbSet.RemoveRange(dbSet);
        }

        public void EmptyFB()
        {
            using (var dbCtx = new DataContext())
            {

            }
        }

        public void InsertIntoDB()
        {
            // create new Student entity object in disconnected scenario (out of the scope of DbContext)
            Boodschappenlijst bs = new Boodschappenlijst();
            Merk[] m = new Merk[3];
            m[0] = new Merk();
            m[0].MerkNaam = "Euroshopper";
            m[1] = new Merk();
            m[1].MerkNaam = "AH Huismerk";
            m[2] = new Merk();
            m[2].MerkNaam = "A-merk";

            Prijs[] ps = new Prijs[5];
            ps[0] = new Prijs();
            ps[0].Hoeveelheid = 2;
            ps[1] = new Prijs();
            ps[1].Hoeveelheid = 3;
            ps[2] = new Prijs();
            ps[2].Hoeveelheid = 1;
            ps[3] = new Prijs();
            ps[3].Hoeveelheid = 5;
            ps[4] = new Prijs();
            ps[4].Hoeveelheid = 8;

            Afdeling[] ad = new Afdeling[2];
            ad[0] = new Afdeling();
            ad[0].Naam = "Frisdrank";
            ad[1] = new Afdeling();
            ad[1].Naam = "Brood";

            Product[] pd = new Product[3];
            pd[0] = new Product();
            pd[0].Afdeling = ad[0];
            pd[0].ProductNaam = "Cola";
            pd[1] = new Product();
            pd[1].Afdeling = ad[0];
            pd[1].ProductNaam = "Sinas";
            pd[2] = new Product();
            pd[2].Afdeling = ad[1];
            pd[2].ProductNaam = "Volkoren";

            Eindproduct[] ep = new Eindproduct[5];
            ep[0] = new Eindproduct();
            ep[0].Merk = m[0];
            ep[0].Product = pd[0];
            ep[0].Boodschappenlijst = bs;
            ep[1] = new Eindproduct();
            ep[1].Merk = m[0];
            ep[1].Product = pd[2];
            ep[2] = new Eindproduct();
            ep[2].Merk = m[1];
            ep[2].Boodschappenlijst = bs;
            ep[2].Product = pd[2];
            ep[3] = new Eindproduct();
            ep[3].Merk = m[1];
            ep[3].Product = pd[1];
            ep[4] = new Eindproduct();
            ep[4].Merk = m[2];
            ep[4].Boodschappenlijst = bs;
            ep[4].Product = pd[1];

            Recept[] rc = new Recept[2];
            rc[0] = new Recept();
            rc[1] = new Recept();

            Korting[] kt = new Korting[2];
            kt[0] = new Korting();
            kt[0].StartDatum = DateTime.Parse("09/01/2015");
            kt[0].EindDatum = DateTime.Parse("09/02/2015");
            kt[0].Eindproduct = ep[1];
            kt[1] = new Korting();
            kt[1].StartDatum = DateTime.Parse("12/01/2015");
            kt[1].EindDatum = DateTime.Parse("19/01/2015");
            kt[1].Eindproduct = ep[3];

            //create DBContext object
            using (var dbCtx = new DataContext())
            {
                dbCtx.Boodschappenlijst.Add(bs);
                foreach (Merk mi in m)
                    dbCtx.Merken.Add(mi);
                foreach (Prijs pi in ps)
                    dbCtx.Prijzen.Add(pi);
                foreach (Afdeling ai in ad)
                    dbCtx.Afdelingen.Add(ai);
                foreach (Product pi in pd)
                    dbCtx.Producten.Add(pi);
                foreach (Eindproduct ei in ep)
                    dbCtx.Eindproducten.Add(ei);
                foreach (Recept ri in rc)
                    dbCtx.Recepten.Add(ri);
                foreach (Korting ki in kt)
                    dbCtx.Kortingen.Add(ki);

                //call SaveChanges method to save student into database
                dbCtx.SaveChanges();
            }
        }
    }
}
