using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NERC.Objects
{
    class Test
    {
        public DateTime Date { get; set; }
        public int Type { get; set; }
        public bool OnRoute { get; set; }

        Test(DateTime date, int type, bool onRoute)
        {
            Date = date;
            Type = type;
            OnRoute = onRoute;
        }

        Test(int month, int day, int year, int type, bool onRoute)
        {
            Date = new DateTime(year, month, day);
            Type = type;
            OnRoute = onRoute;
        }
    }
}
