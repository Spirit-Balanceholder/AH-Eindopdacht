using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webwinkelAH.Model
{
    class Korting
    {
        public int KortingID { get; set; }
        public DateTime GeldigVan { get; set; }
        public DateTime GeldigTot { get; set; }
    }
}
