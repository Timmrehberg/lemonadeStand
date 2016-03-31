using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Purchase 

    {

        List<Player> Playerstats = new List<Player>();
        StoreManagement store = new StoreManagement();
        






        public void BuyLemons(Player player)
        {
            


            Console.WriteLine("Do you want to buy lemons Y/N?");
            string buylemons = Console.ReadLine();
            if (buylemons.Equals("Y"))



            {
                store.Addlemons(player);
                Checkinventory(player);
            }
            else
            {
                Console.Write("Okay ");
                Checkinventory(player);
            }
        }

        public void BuyCups(Player player)
        {
            Console.WriteLine("Do you want to buy cups Y/N?");
            string buycups = Console.ReadLine();
            if (buycups.Equals("Y"))

            {
                store.Addcups(player);
                Checkinventory(player);
            }
            else {
                Console.WriteLine("Okay ");
                Checkinventory(player);
            }
            

        }
        public void BuySugar(Player player)
        {
            Console.WriteLine("Do you want to buy sugar Y/N?");
            string buysugar = Console.ReadLine();
            if (buysugar.Equals("Y"))
            {
                store.Addsugar(player);
                Checkinventory(player);
            }
            else
            {
                Console.WriteLine("You have ");
                Checkinventory(player);
            }
        }
        public void BuyIce(Player player)
        {
            Console.WriteLine("Do you want to buy ice Y/N?");
            string buyice = Console.ReadLine();
            if (buyice.Equals("Y"))
            {
                store.Addice(player);
                Checkinventory(player);
            }
            else
            {
                Checkinventory(player);


            }
        }
        public void subtractMaterials(Player name)
        {
            store.cups -= 1;
            store.lemons -= 1;
            store.ice -= 3;
            store.sugar -= 1;
            
        }
        public void Checkinventory(Player name)
        {
            Console.WriteLine("You have " + store.cups + " cups ");
            Console.WriteLine("You have " + store.lemons + " Lemons");
            Console.WriteLine("You have " + store.sugar + " sugar");
            Console.WriteLine("You have " + store.ice + " ice cubes");
            Console.WriteLine("You have " + name.cash + " cash");
            if (name.cash <= 0)
                
            {
                Console.WriteLine("The lemonade business is not for everybody you have to sell remaining supplies and retire");
                Console.ReadLine();
                Environment.Exit(0);
                
            }
        }
        public void Checkremainingsupplies(Player player)
        {
            if (store.lemons > 0 && store.cups > 0 && store.sugar > 0 && store.ice > 0)
            {
                Console.WriteLine("Time to make lemonade");
               




            }
            else if (store.lemons <= 0 || store.cups <= 0 || store.sugar <= 0 || store.ice <= 0)
            {
                Console.WriteLine("You need materials scream until your mom goes to the store daylight is burning!");
                BuyCups(player);
                BuyIce(player);
                BuyLemons(player);
                BuySugar(player);

                
                

            }




        }

    }
}













