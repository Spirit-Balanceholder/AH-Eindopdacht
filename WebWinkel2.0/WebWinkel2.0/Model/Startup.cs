using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWinkel2._0.Model
{
    public static class Startup
    {
        public static void AppLaunch()
        {
            TestWaarden ts = new TestWaarden();
            ts.EmptyFB();
            ts.InsertIntoDB();
        }
    }
}
