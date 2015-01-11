using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWinkel2._0.Model
{
    public class Boodschappenlijst
    {
        public int BoodschappenlijstID { get; set; }
        public virtual ICollection<Eindproduct> Eindproducten { get; set; }

    }
}
