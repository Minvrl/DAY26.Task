using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY26.Task
{
    internal class Product
    {
        public Product()
        {
            _no++;        
            No = _no;
        }
        public Product(string name, double  price, ProductType type):this()
        {
            Name = name;
            Price = price;
            Type = type;

        }

        static int _no;
        public readonly int No;
        public string Name;
        public double Price;
        public ProductType Type;

        public override string ToString()
        {
            return $"{No}. Name - {Name}, Price - {Price}, Type - {Type}";
        }
    }
}
