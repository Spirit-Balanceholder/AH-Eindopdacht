using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWinkel2._0.Model
{
    //dit is als het ware de koppeltabel tussen de meer op meer relatie van merk en product, en hieraan wordt ook de prijs en de korting gekoppeld. 
    //add viewmodel DONE
    //add listviewmodel DONE
    //add to locator DONE
    //bind to view DONE
    //add to manager DONE

    public class Merk
    {
        public int MerkID { get; set; }
        public String MerkNaam { get; set; }
    }
}
