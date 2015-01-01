using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webwinkelAH.Model
{
    class Afdeling
    {
        //zuivel
        //vlees
        //Groenten en Fruit
        //Droge Kruideniers Waren
        //Frisdrank
        //Alcoholische Drank
        public int AfdelingID { get; set; }
        public string naam { get; set; }

        //bevat meerdere producten,deze zijn dan weer gekoppeld aan merken. 
        public virtual ICollection<Product> Producten { get; set; }

    }
}
