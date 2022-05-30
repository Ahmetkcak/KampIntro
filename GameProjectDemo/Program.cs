using GameProjectDemo.Adapter;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varlıklar için entities(varlıklar) katmanı
            //somut sınıflar çıplak kalmamalı

            Customer customer = new Customer
            {
                FirstName = "Ahmet",
                LastName = "Koçak",
                DateOfBirth = new DateTime(2002, 1, 9),
                NationalityId = "10000000000"
            };

            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            customerManager.Add(customer);
            customerManager.Update(customer);
            customerManager.Delete(customer);

            Console.WriteLine("--------------");

            Campaign campaign = new Campaign { Name = "Oyunla kazan", Discount = 20 };
            CampaingManager campaignManager = new CampaingManager();
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            Console.WriteLine("--------------");

            Game game = new Game { Name = "Forza Horizon 4", Price = 120 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Delete(game);

            Console.WriteLine("--------------");

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(customer, game, campaign);
            saleManager.Sale(customer, game);
        }
    }
}
