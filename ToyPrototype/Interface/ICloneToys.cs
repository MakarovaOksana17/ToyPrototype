namespace ToyPrototype.Interface
{
    internal interface ICloneToys<T> where T : class
    {
        public T CloneToys();
    }
}
