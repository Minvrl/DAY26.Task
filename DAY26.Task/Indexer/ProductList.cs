using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class ProductList
    {
        public ProductList()
        {

        }

        public ProductList(Product[] products)
        {
            _products = products;
        }
        private Product[] _products = new Product[10];

        public Product this[int i]
        {
            get => _products[i];
            set
            {
                if (!CheckNo(value.No))
                    _products[i] = value;
                else
                    Console.WriteLine("This No already exists !");

            }
        }

        public bool CheckNo(int no)
        {
            foreach (var item in _products)
            {
                if (item.No == no) return true;
            }
            return false;
        }
    }
}
