using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ToyPrototype.Models;

namespace ToysTest
{
    [TestClass]
    public class DollsTest :BaseTestToys
    {
        [TestMethod]
        public void TestMyCloneDolls()
        {
            var doll = GetDolls();
            var copyDoll =  doll.CloneToys();
            Assert.IsNotNull(copyDoll);
            Assert.AreEqual(copyDoll._cost, doll._cost);
            Assert.AreEqual(copyDoll._manufacturer._nameCompany, doll._manufacturer._nameCompany);


            copyDoll._cost = 300;
            copyDoll._manufacturer._nameCompany = "Brasser";

            Assert.AreNotEqual(copyDoll._manufacturer._nameCompany, doll._manufacturer._nameCompany);
            Assert.AreNotEqual(copyDoll._manufacturer._nameCompany, doll._manufacturer._nameCompany);
        }

        [TestMethod]
        public void TestCloneDolls()
        {
            var doll = GetDolls();
            var copyDoll = (Dolls)doll.Clone();
            Assert.IsNotNull(copyDoll);
            Assert.AreEqual(copyDoll._cost, doll._cost);
            Assert.AreEqual(copyDoll._manufacturer._nameCompany, doll._manufacturer._nameCompany);


            copyDoll._cost = 300;
            copyDoll._manufacturer._nameCompany = "Brasser";

            Assert.AreNotEqual(copyDoll._manufacturer._nameCompany, doll._manufacturer._nameCompany);
            Assert.AreNotEqual(copyDoll._manufacturer._nameCompany, doll._manufacturer._nameCompany);

        }
    }
}
