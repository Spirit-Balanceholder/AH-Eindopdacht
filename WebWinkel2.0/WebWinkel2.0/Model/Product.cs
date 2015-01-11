using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWinkel2._0.Model
{
    //add viewmodel DONE
    //add listviewmodel DONE
    //add to locator DONE
    //bind to view DONE
    //add to manager
    public class Product
    {
        public int ProductID { get; set; }
        public String ProductNaam { get; set; }

        [ForeignKey("Afdeling")]
        public int? AfdelingID { get; set; }
        public virtual Afdeling Afdeling { get; set; }

    }
}
