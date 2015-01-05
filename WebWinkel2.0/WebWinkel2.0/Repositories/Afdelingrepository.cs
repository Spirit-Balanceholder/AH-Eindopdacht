using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebWinkel2._0.Model;

namespace WebWinkel2._0.Repositories
{
    class Afdelingrepository : IAfdelingRepository
    {
        public List<Afdeling> ToList()
        {
            var Afdelingen = new List<Afdeling>();

            Afdelingen.Add(new Afdeling {AfdelingId = 1, Naam = "Zuivel"});

            Afdelingen.Add(new Afdeling { AfdelingId = 2, Naam = "Vlees" });


            return Afdelingen;
        }
    }
}
