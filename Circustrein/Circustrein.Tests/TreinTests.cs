using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Circustrein.Tests
{
    [TestClass]
    public class TreinTests
    {
        private Trein _Trein;

        [TestInitialize]
        public void Setup()
        {
            _Trein = new Trein();
        }

        [TestMethod]
        public void GeenWagons()
        {
            int aantalWagon = _Trein.GetWagonCount();
            Assert.AreEqual(aantalWagon, 0);
        }

        [TestMethod]
        public void twee_wagon_bij_twee_vleeseter()
        {
            List<Dier> dieren = new List<Dier>
            {
                new Dier("Hond", Grootte.Middel, Eten.Vlees),
                new Dier("Mier", Grootte.Klein, Eten.Vlees),
             };

            _Trein.DierenToevoegen(dieren);
            Assert.AreEqual(_Trein.GetWagonCount(), 2);
        }

        [TestMethod]
        public void planteneter_bij_kleinere_vleeseter()
        {
            List<Dier> dieren = new List<Dier>
            {
                new Dier("Paart", Grootte.Middel, Eten.Planten),
                new Dier("Mier", Grootte.Klein, Eten.Vlees),
             };

            _Trein.DierenToevoegen(dieren);
            Assert.AreEqual(_Trein.GetWagonCount(), 1);
        }

        [TestMethod]
        public void planteneter_bij_grotere_vleeseter()
        {
            List<Dier> dieren = new List<Dier>
            {
                new Dier("Cavia", Grootte.Klein, Eten.Planten),
                new Dier("Leeuw", Grootte.Middel, Eten.Vlees),
             };

            _Trein.DierenToevoegen(dieren);
            Assert.AreEqual(_Trein.GetWagonCount(), 2);
        }

        [TestMethod]
        public void extra_wagon_bij_meer_dan_max()
        {
            List<Dier> dieren = new List<Dier>
            {
                new Dier("PlatenEter", Grootte.Groot, Eten.Planten),
                new Dier("PlatenEter", Grootte.Groot, Eten.Planten),
                new Dier("PlatenEter", Grootte.Middel, Eten.Planten),
            };
            _Trein.DierenToevoegen(dieren);
            Assert.AreEqual(_Trein.GetWagonCount(), 2);
        }

        [TestMethod]
        public void twee_keer_groot_in_een_wagon()
        {
            List<Dier> dieren = new List<Dier>
            {
                new Dier("PlatenEter", Grootte.Groot, Eten.Planten),
                new Dier("PlatenEter", Grootte.Groot, Eten.Planten),
            };
            _Trein.DierenToevoegen(dieren);
            Assert.AreEqual(_Trein.GetWagonCount(), 1);
        }
    }
}
