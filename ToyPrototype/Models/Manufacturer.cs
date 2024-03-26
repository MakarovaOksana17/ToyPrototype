namespace ToyPrototype.Models
{
    public class Manufacturer
    {
        public string? _address;
        public string? _nameCompany;

        public Manufacturer() { }

        public Manufacturer(string address, string nameCompany)
        {
            _address = address;
            _nameCompany = nameCompany; 
        }

        public override string ToString()
        {
            return $"{nameof(_address)}:{_address},{nameof(_nameCompany)}:{_nameCompany}";
        }
    }
}
