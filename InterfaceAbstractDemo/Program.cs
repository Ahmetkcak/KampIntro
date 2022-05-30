using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerService(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2002, 1, 9), FirstName = "Ahmet", LastName = "Koçak", Id = 2, NationalityId = "69094178576" });

            Console.ReadLine();
        }
    }
}
