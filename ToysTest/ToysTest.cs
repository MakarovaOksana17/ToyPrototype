using ToyPrototype.Models;
namespace ToysTest
{
    [TestClass]
    public class ToysTest : BaseTestToys
    {
        [TestMethod]
        public void TestMyCloneToys()
        {
            var toys =  GetToys();
            var cloneToys = toys.CloneToys();
            Assert.IsNotNull(cloneToys);
            Assert.AreNotSame(toys, cloneToys);
            Assert.AreEqual(toys._productArticle?.Id, cloneToys._productArticle?.Id);
            cloneToys._cost = 20;
            cloneToys._productArticle = new ProductArticle(23, "dOLLSwer");
            Assert.AreNotEqual(toys._cost, cloneToys._cost);
            Assert.AreNotSame(toys._productArticle?.Id, cloneToys._productArticle.Id);
        }

        [TestMethod]
        public void TestMyClone()
        {
            var toys = GetToys();
            var cloneToys = (Toys)toys.Clone();
            Assert.IsNotNull(cloneToys);
            Assert.AreNotSame(toys, cloneToys);
            Assert.AreEqual(toys._productArticle?.Id, cloneToys._productArticle?.Id);
            cloneToys._cost = 20;
            cloneToys._productArticle = new ProductArticle(2, "DF");
            Assert.AreNotEqual(toys._cost, cloneToys._cost);
            Assert.AreNotSame(toys._productArticle?.Id, cloneToys._productArticle.Id);
        }

    }
}
