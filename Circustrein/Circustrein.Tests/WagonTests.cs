using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Circustrein.Tests
{
    [TestClass]
    public class WagonTests
    {
        private Wagon _wagon;

        [TestInitialize]
        public void Setup()
        {
            _wagon = new Wagon();
        }

        [TestMethod]
        public void Geen_plantenEter_bij_grotere_vleeseter()
        {
            Dier vleesEter = new Dier("Vleeseter", Grootte.Groot, Eten.Vlees);
            _wagon.DierToevoegen(vleesEter);

            Dier plantenEter = new Dier("PlatenEter", Grootte.Middel, Eten.Planten);
            bool mogelijk = _wagon.IsMogelijk(plantenEter);

            Assert.IsFalse(mogelijk);
        }

        [TestMethod]
        public void Maxpunten_bij_geen_dieren()
        {
            Assert.AreEqual(10, _wagon.GetRestPunten());
        }

        [TestMethod]
        public void Minder_punten_vrij_bij_dier_in_wagon()
        {
            Dier vleesEter = new Dier("Vleeseter", Grootte.Groot, Eten.Vlees);
            _wagon.DierToevoegen(vleesEter);

            Assert.AreEqual(5, _wagon.GetRestPunten());
        }

        [TestMethod]
        public void Geen_2_vleeseters()
        {
            Dier vleesEter = new Dier("Vleeseter", Grootte.Groot, Eten.Vlees);
            _wagon.DierToevoegen(vleesEter);
            Dier vleesEter2 = new Dier("Vleeseter2", Grootte.Middel, Eten.Vlees);
            Assert.IsFalse(_wagon.IsMogelijk(vleesEter2));
        }

        [TestMethod]
        public void Niet_meer_dan_max()
        {
            Dier plantenEter1 = new Dier("PlatenEter", Grootte.Groot, Eten.Planten);
            Dier plantenEter2 = new Dier("PlatenEter", Grootte.Groot, Eten.Planten);
            Dier plantenEter3 = new Dier("PlatenEter", Grootte.Middel, Eten.Planten);

            _wagon.DierToevoegen(plantenEter1);
            _wagon.DierToevoegen(plantenEter2);

            Assert.IsFalse(_wagon.IsMogelijk(plantenEter3));
        }
    }
}
