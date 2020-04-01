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

        private void DierToevoegen(Dier dier)
        {
            foreach (Wagon wagon in Wagons)
            {
                if (wagon.IsMogelijk(dier))
                {
                    wagon.DierenInWagon.Add(dier);
                    return;
                }
            }
            Wagons.Add(new Wagon(dier));
        }

        public void DierenToevoegen(IEnumerable<Dier> dieren)
        {
            IEnumerable<Dier> vleeseters = dieren.Where(dier => dier.Eten == Eten.Vlees);
            List<Dier> planteneters = dieren.Where(dier => dier.Eten == Eten.Planten).OrderBy(dier => dier.Grote).ToList();
            foreach (Dier Vleeseter in vleeseters)
            {
                Wagon wagon = new Wagon();
                wagon.DierenInWagon.Add(Vleeseter);
                for (int i = planteneters.Count - 1; i >= 0; i--)
                {
                    if (wagon.IsMogelijk(planteneters[i]))
                    {
                        wagon.DierenInWagon.Add(planteneters[i]);
                        planteneters.RemoveAt(i);
                    }
                }
                this.Wagons.Add(wagon);
            }

            foreach (Dier planeteneter in planteneters)
            {
                DierToevoegen(planeteneter);
            }
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