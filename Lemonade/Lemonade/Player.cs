using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Player
    {
        public double cash = 20;
        StoreManagement manage = new StoreManagement();
        //public Player()
        //{



        public Player(int Cups, int Lemons, int Sugar, int Ice)
        {
            manage.cups = Cups;
            manage.lemons = Lemons;
            manage.sugar = Sugar;
            manage.ice = Ice;

        }


    }
}
   