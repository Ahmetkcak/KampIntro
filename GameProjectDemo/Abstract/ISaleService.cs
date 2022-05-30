using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    interface ISaleManager
    {
        void Sale(Customer customer, Game game, Campaign campaign);
        void Sale(Customer customer, Game game);
    }
}
