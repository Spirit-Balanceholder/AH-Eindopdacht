using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebWinkel2._0.Model;

namespace WebWinkel2._0.Repositories
{
    class Productrepository : IProductRepository
    {

        public List<Product> ToList()
        {
            var Producten = new List<Product>();

            Producten.Add(new Product { ProductID = 1, ProductNaam = "Cola" });

            Producten.Add(new Product { ProductID = 1, ProductNaam = "Kaas" });

            Producten.Add(new Product { ProductID = 2, ProductNaam = "Biefstuk" });

            Producten.Add(new Product { ProductID = 2, ProductNaam = "Kroket" });


            return Producten;
        }



    }
}
