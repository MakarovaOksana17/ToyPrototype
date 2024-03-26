using ToyPrototype.Extentions;
using ToyPrototype.Interface;

namespace ToyPrototype.Models
{
    public class Dolls: Toys
    {
        public string? _name;
        public Manufacturer? _manufacturer;

        public Dolls() { }

        public Dolls(ProductArticle productArticle, int cost, string name, Manufacturer manufacturer) : base(productArticle, cost)
        {
            _name = name;
            _manufacturer = manufacturer;
        }

        public override Dolls CloneToys()
        {
            return this.DeepCopyXml();
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
