using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun başarıyla eklendi. " + game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun başarıyla silindi. " + game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun başarıyla güncellendi. " + game.Name);
        }
    }
}
