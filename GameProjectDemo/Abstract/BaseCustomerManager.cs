using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    abstract class BaseCustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Başarıyla kayıt oldu: " + customer.FirstName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Kayıt silindi: " + customer.FirstName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Kayıt Güncellendi: " + customer.FirstName);
        }
    }
}
