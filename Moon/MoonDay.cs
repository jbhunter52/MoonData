using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon
{
    class MoonDay
    {
        public DateTime Rise;
        public DateTime Set;

        public MoonDay(DateTime rise, DateTime set)
        {
            Rise = rise;
            Set = set;
        }
    }
}
