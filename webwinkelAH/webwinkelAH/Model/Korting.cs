using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webwinkelAH.Model
{
    class Korting
    {
        //is gekoppeld aan 1 specifiek merk en 1 product. De combinatie dan deze 2 id's vormen het unieke product. 
        public int KortingID { get; set; }
        public DateTime GeldigVan { get; set; }
        public DateTime GeldigTot { get; set; }

       
    }
}
