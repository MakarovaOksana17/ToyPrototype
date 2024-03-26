using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyPrototype.Models;

namespace ToysTest
{
    [TestClass]
    public class BarbieDoolsTest: BaseTestToys
    {
        [TestMethod]
        public void TestMyCloneBarbieDool()
        {
            var barbieDoll = GetBarbieDoll();
            var copyBarbieDoll = barbieDoll.CloneToys();
            Assert.IsNotNull(copyBarbieDoll);
            Assert.AreEqual(copyBarbieDoll._cost, barbieDoll._cost);
            Assert.AreEqual(copyBarbieDoll._manufacturer?._nameCompany, barbieDoll._manufacturer?._nameCompany);
            Assert.AreEqual(copyBarbieDoll._weightPaking, barbieDoll._weightPaking);
            Assert.AreEqual(copyBarbieDoll._productArticle?.Title, barbieDoll._productArticle?.Title);

            copyBarbieDoll._cost = 2500;
            copyBarbieDoll._manufacturer._nameCompany = "Barbie Company";
            copyBarbieDoll._weightPaking = 1;
            copyBarbieDoll._productArticle = new ProductArticle(2, "Barbie Light");
            copyBarbieDoll._colorBarbie = "white";

            Assert.AreNotEqual(copyBarbieDoll._cost, barbieDoll._cost);
            Assert.AreNotEqual(copyBarbieDoll._manufacturer._nameCompany, barbieDoll._manufacturer?._nameCompany);
            Assert.AreNotEqual(copyBarbieDoll._weightPaking, barbieDoll._weightPaking);
            Assert.AreNotEqual(copyBarbieDoll._productArticle.Title, barbieDoll._productArticle?.Title);
            Assert.AreNotEqual(copyBarbieDoll._productArticle.Id, barbieDoll._productArticle.Id);
            Assert.AreNotEqual(copyBarbieDoll._colorBarbie, barbieDoll._colorBarbie);
        }

        [TestMethod]
        public void TestCloneBarbieDool()
        {
            var barbieDoll = GetBarbieDoll();
            var copyBarbieDoll = (BarbieDoll)barbieDoll.Clone();
            Assert.IsNotNull(copyBarbieDoll);
            Assert.AreEqual(copyBarbieDoll._cost, barbieDoll._cost);
            Assert.AreEqual(copyBarbieDoll._manufacturer?._nameCompany, barbieDoll._manufacturer?._nameCompany);
            Assert.AreEqual(copyBarbieDoll._weightPaking, barbieDoll._weightPaking);
            Assert.AreEqual(copyBarbieDoll._productArticle?.Title, barbieDoll._productArticle?.Title);

            copyBarbieDoll._cost = 2500;
            copyBarbieDoll._manufacturer!._nameCompany = "Barbie Company";
            copyBarbieDoll._weightPaking = 1;
            copyBarbieDoll._productArticle = new ProductArticle(2, "Barbie Light");
            copyBarbieDoll._colorBarbie = "white";

            Assert.AreNotEqual(copyBarbieDoll._cost, barbieDoll._cost);
            Assert.AreNotEqual(copyBarbieDoll._manufacturer._nameCompany, barbieDoll._manufacturer?._nameCompany);
            Assert.AreNotEqual(copyBarbieDoll._weightPaking, barbieDoll._weightPaking);
            Assert.AreNotEqual(copyBarbieDoll._productArticle.Title, barbieDoll._productArticle?.Title);
            Assert.AreNotEqual(copyBarbieDoll._productArticle.Id, barbieDoll._productArticle?.Id);
            Assert.AreNotEqual(copyBarbieDoll._colorBarbie, barbieDoll._colorBarbie);

        }
    }
}
