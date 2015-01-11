using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWinkel2._0.Model
{
    //add viewmodel DONE
    //add listviewmodel DONE
    //add to locator DONE
    //bind to view 
    //add to manager

    public class Recept
    {
        public int ReceptID { get; set; }

        public String ReceptNaam { get; set; }

        public virtual ICollection<Recept_Has_Eindproduct> Recept_has_Eindproduct { get; set; }
    }
}
