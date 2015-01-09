using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWinkel2._0.Model
{
    
    //dit is als het ware de koppeltabel tussen de meer op meer relatie van merk en product, en hieraan wordt ook de prijs en de korting gekoppeld. 
   public class Eindproduct
    {
        public int EindproductID { get; set; }


        [ForeignKey("Product")]
        public int? ProductID { get; set; }
        public virtual Product Product { get; set; }


        [ForeignKey("Merk")]
        public int? MerkID { get; set; }

        public virtual Merk Merk { get; set; }


        [ForeignKey("Boodschappenlijst")]
        public int? BoodschappenlijstID { get; set; }

        public virtual Boodschappenlijst Boodschappenlijst { get; set; }

        [ForeignKey("Recept")]
        public int? ReceptID { get; set; }

        public virtual Recept Recept { get; set; }



        public virtual ICollection<Korting>  Kortingen{ get; set; }

    }
}
