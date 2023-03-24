using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Nastaveni
    {
        public static int Sirka { get; set; }
        public static int Vyska { get; set; }
        public static string smer;

        public Nastaveni()
        {
            Sirka = 20;
            Vyska = 20;
            smer = "right";
        }
    }
}
