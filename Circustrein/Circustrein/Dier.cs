using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Dier
    {
        public string Naam { get; private set; }
        public Grootte Grootte { get; private set; } 
        public Eten Eten { get; private set; }

        public Dier(string naam, Grootte grote, Eten eten)
        {
            Naam = naam;
            Grootte = grote;
            Eten = eten;
        }
    }
}
