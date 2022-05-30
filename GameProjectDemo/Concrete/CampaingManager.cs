using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    class CampaingManager : ICampaignService
    {
        public void Add(Campaign campaing)
        {
            Console.WriteLine("Kampanya başarıyla eklendi. " + campaing.Name);
        }

        public void Delete(Campaign campaing)
        {
            Console.WriteLine("Kampanya başarıyla silindi. " + campaing.Name);
        }

        public void Update(Campaign campaing)
        {
            Console.WriteLine("Kampanya başarıyla güncellendi. " + campaing.Name);
        }
    }
}
