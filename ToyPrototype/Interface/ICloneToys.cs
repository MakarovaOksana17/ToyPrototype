using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyPrototype.Interface
{
    internal interface ICloneToys<T> where T : class
    {
        public T CloneToys();
    }
}
