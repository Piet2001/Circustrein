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

        private List<Dier> DierenInWagon;

        private int GebruiktePunten => DierenInWagon.Sum(totaal => (int)totaal.Grootte);

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
            if (DierKleinGenoeg(dier) == false || DierGroterDanVleeseter(dier) == false)
            {
                return false;
            }
            return true;
        }


        private bool DierGroterDanVleeseter(Dier dier)
        {
            IEnumerable<Dier> vleeseterInWagon = DierenInWagon.Where(dieren => dieren.Eten == Eten.Vlees);
            if (vleeseterInWagon.Any(vleeseter => dier.Grootte <= vleeseter.Grootte))
            {
                return false;
            }
            return true;
        }

        private bool DierKleinGenoeg(Dier dier)
        {
            if ((int)dier.Grootte > MaxPunten - GebruiktePunten)
            {
                return false;
            }
            return true;
        }

        public void DierToevoegen(Dier dier)
        {
            if(IsMogelijk(dier))
            {
                DierenInWagon.Add(dier);                
            }
        }

        public int GetRestPunten()
        {
            return MaxPunten - GebruiktePunten;
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
