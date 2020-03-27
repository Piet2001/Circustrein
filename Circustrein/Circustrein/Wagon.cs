using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Wagon
    {
        private const int MaxPunten = 10;

        public List<Dier> DierenInWagon { get; private set; }

        private int GebruiktePunten => DierenInWagon.Sum(totaal => (int)totaal.Grote);

        public Wagon()
        {
            DierenInWagon = new List<Dier>();
        }

        public Wagon(Dier eersteDier)
        {
            DierenInWagon = new List<Dier>
            {
                eersteDier
            };
        }


        public bool IsMogelijk(Dier dier)
        {
            //Does the animal fit in the Wagon?
            if ((int)dier.Grote > MaxPunten - GebruiktePunten)
                return false;

            //Will the animal get eaten?
            IEnumerable<Dier> vleesetersInWagon = DierenInWagon.Where(dieren => dieren.Eten == Eten.Vlees);
            if (vleesetersInWagon.Any(vleeseter => dier.Grote <= vleeseter.Grote))
                return false;

            return true;
        }

        public string WagonUitslag()
        {
            string uitslag = string.Empty;
            foreach (Dier dier in DierenInWagon)
            {
                uitslag += dier.Naam + ", ";
            }
            int puntenover = MaxPunten - GebruiktePunten;
            return "\n   Aantal dieren: " + Convert.ToString(DierenInWagon.Count) + " \n   Dieren in wagon: " + uitslag + "\n   Gebruikte punten: " + Convert.ToString(GebruiktePunten) + "\n   Restpunten: " + Convert.ToString(puntenover);
        }
    }
}
