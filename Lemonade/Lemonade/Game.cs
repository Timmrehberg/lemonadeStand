using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Game 
    {

       public Player Mainplayer = new Player(0, 0, 0, 0);
       
        StoreManagement management = new StoreManagement();
       Purchase purchase = new Purchase();
        Customer badOrGoodDay = new Customer("None",0);
       
        
     



        public double Setprice(Player player)
            {
                Customer Bob = new Customer("Bob", 0.30);
            
                Customer Joe = new Customer("Joe", 0.35);
                Customer Kim = new Customer("Kim", 0.25);
                Customer Timmy = new Customer("Tim", 0.25);
                Customer Poe = new Customer("Poe", 0.30);
                Customer Moe = new Customer("Moe", 0.30);
                Customer Loe = new Customer("Loe", 0.30);
                Customer Boe = new Customer("Boe", 0.25);
                Customer Tom = new Customer("Tom", 0.40);
                Customer Pit = new Customer("Pit", 0.30);
                Customer Mitt = new Customer("Mitt", 0.20);
                Customer Kimm = new Customer("Kimm", 0.25);
                Customer Fin = new Customer("Fin", 0.30);
                Customer Jimmy = new Customer("Jimmy", 0.40);
                Customer Mooe = new Customer("Mooe", 0.30);
                Customer Loell = new Customer("Loell", 0.30);
                Customer Bohem = new Customer("Bohem", 0.25);
                Customer Rodger = new Customer("Rodger", 0.40);
                StoreManagement Player = new StoreManagement();
                List<double> customersCaps = new List<double>();
                customersCaps.Add(Bob.pricecap);
                customersCaps.Add(Joe.pricecap);
                customersCaps.Add(Kim.pricecap);
                customersCaps.Add(Timmy.pricecap);
                customersCaps.Add(Poe.pricecap);
                customersCaps.Add(Moe.pricecap);
                customersCaps.Add(Loe.pricecap);
                customersCaps.Add(Boe.pricecap);
                customersCaps.Add(Tom.pricecap);
                customersCaps.Add(Pit.pricecap);
                customersCaps.Add(Mitt.pricecap);
                customersCaps.Add(Kimm.pricecap);
                customersCaps.Add(Fin.pricecap);
                customersCaps.Add(Jimmy.pricecap);
                customersCaps.Add(Moe.pricecap);
                customersCaps.Add(Loell.pricecap);
                customersCaps.Add(Bohem.pricecap);
                customersCaps.Add(Rodger.pricecap);
            Console.WriteLine("You are low on money and decide to sell lemonade because you know everybody will love your grandmothers secret lemonade recipe");
                Console.WriteLine("How much would you like to sell it for?");
                double priceperglass = 0;
                try
                {
                    priceperglass = Convert.ToDouble(Console.ReadLine());

                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(e);
                    Console.Clear();
                    Setprice(Mainplayer);

                }
                finally
                {
                    Console.WriteLine(priceperglass);
                    foreach (double priceCap in customersCaps)
                    {
                        if (priceperglass > priceCap)
                        {
                            Console.WriteLine("Missed sale");

                        }
                        else if (priceperglass <= priceCap)
                        {
                            Console.WriteLine("Made a sale");
                        player.cash += priceperglass;
                        Console.WriteLine(player.cash);
                        purchase.subtractMaterials(player);
                        }
                    }

                }
                return priceperglass;
            }

        public void Start()
        {
            badOrGoodDay.Day1();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies();
            

        }
        public void StartDay2()
        {
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies();

        }

    }
         
    }
        

    

    




            

        
    

