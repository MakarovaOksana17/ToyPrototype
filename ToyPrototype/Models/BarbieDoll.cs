using ToyPrototype.Extentions;

namespace ToyPrototype.Models
{
    public class BarbieDoll : Dolls
    {
        public int _weightPaking;
        public string? _colorBarbie;
        
        public BarbieDoll() { }

        public BarbieDoll(ProductArticle productArticle, int cost, string name, Manufacturer manufacturer, int weightPaking, string colorBarbie) : base(productArticle, cost, name, manufacturer)
        {
            _weightPaking = weightPaking;
            _colorBarbie = colorBarbie; 
        }

        public override object Clone()
        {
            return CloneToys();
        }

        public override BarbieDoll CloneToys()
        {
            return this.DeepCopyXml();
        }

        public override string ToString()
        {
            return $"{nameof(_weightPaking)}:{_weightPaking},{nameof(_colorBarbie)}:{_colorBarbie}";
        }
    }
}
