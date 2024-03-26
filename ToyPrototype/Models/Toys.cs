using System;
using ToyPrototype.Extentions;
using ToyPrototype.Interface;

namespace ToyPrototype.Models
{
    public class Toys: ICloneable,ICloneToys<Toys>
    {
        public int _cost;
        public ProductArticle? _productArticle;

        public Toys() { }
        public Toys(ProductArticle productArticle, int cost) {
        
            _productArticle = productArticle;
            _cost = cost;
        }

        public virtual object Clone()
        {
            return CloneToys();
        }

        public virtual Toys CloneToys()
        {            
            return this.DeepCopyXml();
        }

        public override string ToString()
        {
            return $"{nameof(_cost)}:{_cost},{nameof(_productArticle)}:{_productArticle}";
        }
    }
}
