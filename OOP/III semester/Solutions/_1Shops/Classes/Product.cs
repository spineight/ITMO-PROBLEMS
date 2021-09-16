using System.Dynamic;
using Shops.Interfaces;

namespace Shops.Classes
{
    public class Product : IProduct
    {
        private readonly string _name;
        public Product(string productName, double productPrice = -1) { _name = productName; }
        public double Price { get; set; } = -1;
        public string Name => _name;

        // public override string ToString() { return _name + " " + Price.ToString(".##"); }
    }
}