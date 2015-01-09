using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWinkel2._0.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public String ProductNaam { get; set; }

        [ForeignKey("Afdeling")]
        public int? AfdelingID { get; set; }
        public virtual Afdeling Afdeling { get; set; }

    }
}
