using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWinkel2._0.Model
{
    public class Recept_Has_Eindproduct
    {
        [Required]
        [Key]
        [ForeignKey("Eindproduct")]
        [Column(Order = 1)] 
        public int? EindproductID { get; set; }
        public virtual Eindproduct Eindproduct { get; set; }

        [Required]
        [Key]
        [ForeignKey("Recept")]
        [Column(Order = 2)] 
        public int? ReceptID { get; set; }

        public virtual Recept Recept { get; set; }
    }
}
