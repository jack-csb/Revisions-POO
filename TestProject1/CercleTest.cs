using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using formes_geometriques;

namespace formes_geometriques.Tests
{
    [TestClass]
    public class CercleTests
    {
        [TestMethod]
        public void Aire_Rayon1_DoitEtrePI()
        {
            Cercle c = new Cercle(1);
            Assert.AreEqual(Math.PI, c.Aire(), 0.001); // marge d’erreur 0.001
        }

        [TestMethod]
        public void Perimetre_Rayon1_DoitEtre2PI()
        {
            Cercle c = new Cercle(1);
            Assert.AreEqual(2 * Math.PI, c.Perimetre(), 0.001);
        }
    }
}
