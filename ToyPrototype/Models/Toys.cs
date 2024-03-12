using System;
using ToyPrototype.Extentions;
using ToyPrototype.Interface;

namespace ToyPrototype.Models
{
    public class Toys: ICloneable,ICloneToys<Toys>
    {
        public int _summ;
        public ProductArticle  _productArticle;

        public Toys() { }
        public Toys(ProductArticle productArticle, int summ) {
        
            _productArticle = productArticle;
            _summ = summ;
        }

        public virtual object Clone()
        {
            return CloneToys();
        }

        public virtual Toys CloneToys()
        {
            Toys toys = new Toys(_productArticle, _summ);
             return toys.DeepCopyXml();
        }

        public override string ToString()
        {
            return $"{nameof(_summ)}:{_summ},{nameof(_productArticle)}:{_productArticle}";
        }
    }
}
