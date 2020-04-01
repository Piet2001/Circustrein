using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dier> dieren = new List<Dier>
            {
                new Dier("Hond", Grootte.Middel, Eten.Vlees),
                new Dier("Konijn", Grootte.Klein, Eten.Planten),
                new Dier("Olifant",Grootte.Groot, Eten.Planten),
                new Dier("Mier", Grootte.Klein, Eten.Vlees),
                new Dier("Leeuw", Grootte.Middel, Eten.Vlees),
                new Dier("Eend", Grootte.Klein, Eten.Planten),
                new Dier("Cavia", Grootte.Klein, Eten.Planten),
                new Dier("Paard", Grootte.Middel, Eten.Planten),
                new Dier("Giraffe", Grootte.Groot, Eten.Planten),
                new Dier("Ezel", Grootte.Middel, Eten.Planten),
                new Dier("Hert", Grootte.Middel, Eten.Planten),
                new Dier("Kat", Grootte.Klein, Eten.Vlees),
                new Dier("Hamster", Grootte.Klein, Eten.Planten),
                new Dier("Tijger", Grootte.Middel, Eten.Vlees),
                new Dier("Uil", Grootte.Middel, Eten.Vlees),
                new Dier("Nijlpaard", Grootte.Groot, Eten.Planten),
                new Dier("krokodil", Grootte.Groot, Eten.Vlees)
            };
            
            Trein trein = new Trein();
            trein.DierenToevoegen(dieren);
            Console.Write(trein.TreinUitslag());
            Console.ReadLine();
        }
    }
}