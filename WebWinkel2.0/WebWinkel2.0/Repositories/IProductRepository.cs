using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebWinkel2._0.Model;

namespace WebWinkel2._0.Repositories
{
    interface IProductRepository
    {
        List<Product> ToList();
    }
}
