using Microsoft.VisualStudio.TestTools.UnitTesting;
using formes_geometriques;

namespace formes_geometriques.Tests
{
    [TestClass] // Indique que c’est une classe de tests
    public class PointTests
    {
        [TestMethod] // Un test unitaire
        public void Distance_Point00Et34_DoitEtre5()
        {
            // Arrange : préparation des objets
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);

            // Act : action = calcul de la distance
            double distance = p1.Distance(p2);

            // Assert : vérification du résultat attendu
            Assert.AreEqual(5, distance);
        }
    }
}
