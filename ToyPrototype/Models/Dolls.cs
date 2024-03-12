using ToyPrototype.Extentions;
using ToyPrototype.Interface;

namespace ToyPrototype.Models
{
    public class Dolls: Toys, ICloneable
    {
        public string _name;
        public Manufacturer _manufacturer;

        public Dolls() { }

        public Dolls(ProductArticle productArticle, int summ, string name, Manufacturer manufacturer) : base(productArticle, summ)
        {
            _name = name;
            _manufacturer = manufacturer;
        }

        public override Dolls CloneToys()
        {
            return new Dolls(_productArticle,_summ,_name,_manufacturer).DeepCopyXml();
        }

        public override object Clone()
        {
            return CloneToys();
        }

        public override string ToString()
        {
            return $"{nameof(_name)}:{_name},{nameof(_manufacturer)}:{_manufacturer}";
        }
    }
}
