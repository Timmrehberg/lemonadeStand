﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class StoreManagement
    {

        public int cups;
        public int lemons;
        public int sugar;
        public int ice;
        public int Addcups(Player name)
        {

            cups += 100;
            name.cash -= 2.50;
            return cups;
        }
        public int Addlemons(Player name)
        {
            lemons += 75;
            name.cash -= 4.00;
            return lemons;

        }
        public int Addsugar(Player name)
        {
            sugar += 20;
            name.cash -= 3.46;
            return sugar;
        }
        public int Addice(Player name)
        {
            ice += 250;
            name.cash -= 2.07;
            return ice;
        }






       
    }


}