using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webwinkelAH.Model
{
    class Product
    {
        public int ProductID { get; set; }
        public String ProductNaam { get; set; }

        public virtual ICollection<Merk> Merken { get; set; }

        // ik neem aan dat hier geen koppeltabel voor nodig is aangezien een product maar een afdeling heeft, ongeacht van het merk. 
        [ForeignKey("Afdeling")]
        public int? AfdelingID { get; set; }

        //moet product ook een referentie hebben naar de kar waar hij in zit? 
        //er is maar een boodschappenkar dus dit lijkt me overbodig zolang de kar een lijst van producten kan hebben
    }
}
