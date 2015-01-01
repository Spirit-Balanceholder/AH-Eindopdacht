using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webwinkelAH.Model
{
    class Merk_heeft_Product
    {

        [ForeignKey("Merk")]
        public int? MerkID { get; set; }

        [ForeignKey("Product")]
        public int? ProductID { get; set; }

        public int price { get; set; }
    }
}
