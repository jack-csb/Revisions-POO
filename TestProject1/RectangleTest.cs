using Microsoft.VisualStudio.TestTools.UnitTesting;
using formes_geometriques;

namespace formes_geometriques.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Aire_Rectangle4x6_DoitEtre24()
        {
            Point centre = new Point(0, 0);
            Rectangle r = new Rectangle(4, 6, centre);
            Assert.AreEqual(24, r.Aire());
        }

        [TestMethod]
        public void Perimetre_Rectangle4x6_DoitEtre20()
        {
            Point centre = new Point(0, 0);
            Rectangle r = new Rectangle(4, 6, centre);
            Assert.AreEqual(20, r.Perimetre());
        }
    }
}