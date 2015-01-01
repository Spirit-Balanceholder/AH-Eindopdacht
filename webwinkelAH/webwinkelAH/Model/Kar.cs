using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webwinkelAH.Model
{
    class Kar
    {
        public int KarID { get; set; }
        //dit kunnen we ook niet verwerken in de database en gewoon in view uitrekenen aan de hand van de opgegeven producten/kortingen 
        public int TotaalPrijs { get; set; }
        public virtual ICollection<Product> Producten { get; set; }

        
    }
}

