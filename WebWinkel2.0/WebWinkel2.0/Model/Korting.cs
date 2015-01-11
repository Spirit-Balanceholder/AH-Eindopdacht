using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWinkel2._0.Model
{
    public class Korting
    {
        public int KortingID { get; set; }

        public DateTime StartDatum { get; set; }

        public DateTime EindDatum { get; set; }

        public int Hoeveelheid { get; set; }

        [ForeignKey("Eindproduct")]
        public int? EindproductID { get; set; }
        public virtual Eindproduct Eindproduct { get; set; }
    }
}
