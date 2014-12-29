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
        public int TotaalPrijs { get; set; }
        public virtual ICollection<Product> Producten { get; set; }

    }
}

