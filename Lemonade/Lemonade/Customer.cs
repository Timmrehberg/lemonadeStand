using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Customer
    {
        public string name;
        public double pricecap;
       
            public Customer(string Name, double PriceCap)
        {
            name = Name;
            pricecap = PriceCap;
           
        }
        public void Day1()
        {
            Console.WriteLine("Its 83 and sunny!");
            pricecap += 5.00;
        }
        public void Day2()
        {
            pricecap -= 0.5;
        }
       

        

    }
}
