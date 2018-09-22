using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon
{
    public class Sundata
    {
        public string phen { get; set; }
        public string time { get; set; }
    }

    public class Moondata
    {
        public string phen { get; set; }
        public string time { get; set; }
    }

    public class Nextmoondata
    {
        public string phen { get; set; }
        public string time { get; set; }
    }

    public class Closestphase
    {
        public string phase { get; set; }
        public string date { get; set; }
        public string time { get; set; }
    }

    public class MoonJson
    {
        public bool error { get; set; }
        public string apiversion { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public string dayofweek { get; set; }
        public bool datechanged { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public string county { get; set; }
        public int tz { get; set; }
        public string isdst { get; set; }
        public List<Sundata> sundata { get; set; }
        public List<Moondata> moondata { get; set; }
        public List<Nextmoondata> nextmoondata { get; set; }
        public Closestphase closestphase { get; set; }
        public string fracillum { get; set; }
        public string curphase { get; set; }
    }
}
