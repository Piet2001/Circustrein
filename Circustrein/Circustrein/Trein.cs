using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Trein
    {
        private List<Wagon> Wagons;

        public Trein()
        {
            Wagons = new List<Wagon>();
        }

        public void DierenToevoegen(IEnumerable<Dier> dieren)
        {
            var dierengesorteerd = dieren.OrderBy(dier => dier.Eten).ThenByDescending(dier => dier.Grootte);
            foreach (Dier dier in dierengesorteerd)
            {
                if (dier.Eten == Eten.Vlees)
                {
                    VleeseterToevoegen(dier);
                }
                else if (dier.Eten == Eten.Planten)
                {
                    PlanteneterToevoegen(dier);
                }
            }
        }

        private void VleeseterToevoegen(Dier dier)
        {
            Wagon wagon = new Wagon(dier);
            Wagons.Add(wagon);
        }

        private void PlanteneterToevoegen(Dier dier)
        {
            foreach (Wagon wagon in Wagons)
            {
                if (wagon.IsMogelijk(dier))
                {
                    wagon.DierToevoegen(dier);
                    return;
                }
            }
            Wagons.Add(new Wagon(dier));
        }

        public string TreinUitslag()
        {
            string uitslag = string.Empty;
            int i = 1;
            foreach (Wagon wagon in Wagons)
            {
                uitslag += "Wagon " + i + ": " + wagon.WagonUitslag() + "\n";
                i++;
            }
            return uitslag;
        }
    }
}