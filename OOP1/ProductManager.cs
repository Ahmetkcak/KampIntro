using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürününüz eklendi: " + product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ürününüz güncellendi: " + product.ProductName);
        }

        
    }
}
