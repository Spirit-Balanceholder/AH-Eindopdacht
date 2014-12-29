using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webwinkelAH.Model
{
    class Afdeling
    {
        public int AfdelingID { get; set; }
        public string naam { get; set; }


        public virtual ICollection<Product> Producten { get; set; }

    }
}
