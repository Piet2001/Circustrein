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
                new Dier("Hond", Grote.Middel, Eten.Vlees),
                new Dier("Konijn", Grote.Klein, Eten.Planten),
                new Dier("Olifant",Grote.Groot, Eten.Planten),
                new Dier("Mier", Grote.Klein, Eten.Vlees),
                new Dier("Leeuw", Grote.Middel, Eten.Vlees),
                new Dier("Eend", Grote.Klein, Eten.Planten),
                new Dier("Cavia", Grote.Klein, Eten.Planten),
                new Dier("Paard", Grote.Middel, Eten.Planten),
                new Dier("Giraffe", Grote.Groot, Eten.Planten),
                new Dier("Ezel", Grote.Middel, Eten.Planten),
                new Dier("Hert", Grote.Middel, Eten.Planten),
                new Dier("Kat", Grote.Klein, Eten.Vlees),
                new Dier("Hamster", Grote.Klein, Eten.Planten),
                new Dier("Tijger", Grote.Middel, Eten.Vlees),
                new Dier("Uil", Grote.Middel, Eten.Vlees),
                new Dier("Nijlpaard", Grote.Groot, Eten.Planten),
                new Dier("krokodil", Grote.Groot, Eten.Vlees)
            };
            
            Trein trein = new Trein();
            trein.DierenToevoegen(dieren);
            Console.Write(trein.TreinUitslag());
            Console.ReadLine();
        }
    }
}