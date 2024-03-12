using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyPrototype.Models;

namespace ToysTest
{
    public class BaseTestToys
    {
        public Toys GetToys()
        {
            return new Toys(new ProductArticle(1,"FFFDolss"), 2000);
        }

        public Dolls GetDolls()
        {
            return new Dolls(new ProductArticle(1, "FFFDolss"), 2000, "Alice", new Manufacturer("University street", "Manufacture_1"));
        }

        public BarbieDoll GetBarbieDoll() 
        {
            return new BarbieDoll(new ProductArticle(1, "FFFDolss"), 2000, "Alice", new Manufacturer("University street", "Manufacture_1"), 200, "blue");
        }
    }
}
