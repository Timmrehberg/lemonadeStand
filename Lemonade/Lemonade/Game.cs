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

        Purchase purchase = new Purchase();
        public List<double> customersCaps = new List<double>();
        Weather dailyweather = new Weather();


        Customer Bob = new Customer("Bob", 0.75);

        Customer Joe = new Customer("Joe", 0.50);
        Customer Kim = new Customer("Kim", 0.65);
        Customer Timmy = new Customer("Tim", 0.80);
        Customer Poe = new Customer("Poe", 0.85);
        Customer Moe = new Customer("Moe", 1.00);
        Customer Loe = new Customer("Loe", 1.00);
        Customer Boe = new Customer("Boe", 0.65);
        Customer Tom = new Customer("Tom", 0.75);
        Customer Pit = new Customer("Pit", 0.45);
        Customer Mitt = new Customer("Mitt", 0.75);
        Customer Kimm = new Customer("Kimm", 0.95);
        Customer Fin = new Customer("Fin", 0.90);
        Customer Jimmy = new Customer("Jimmy", 1.00);
        Customer Mooe = new Customer("Mooe", 0.70);
        Customer Loell = new Customer("Loell", 0.90);
        Customer Bohem = new Customer("Bohem", 0.85);
        Customer Rodger = new Customer("Rodger", 1.00);
        StoreManagement Player = new StoreManagement();
        List<Customer> customers = new List<Customer>();


        public void AddCustomers()
        {
            
            customers.Add(Mooe);
            customers.Add(Jimmy);
            customers.Add(Fin);
            customers.Add(Bob);
            customers.Add(Timmy);
            customers.Add(Poe);
            customers.Add(Moe);
            customers.Add(Loe);
            customers.Add(Boe);
            customers.Add(Tom);
            customers.Add(Pit);
            customers.Add(Mitt);
            customers.Add(Kim);
            customers.Add(Kimm);
            customers.Add(Loell);
            customers.Add(Bohem);
            customers.Add(Rodger);
        }

        public double Setprice(Player player)
        {
           

            
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
                foreach (Customer customer in customers)
                {
                    if (priceperglass > customer.pricecap)
                    {
                        Console.WriteLine("Missed sale");
                        

                    }
                    else if (priceperglass <= customer.pricecap)
                    {
                        Console.WriteLine("Made a sale");
                        
                        Mainplayer.cash += priceperglass;
                        Console.WriteLine(Mainplayer.cash);
                        purchase.subtractMaterials(Mainplayer);
                        purchase.Checkremainingsupplies(Mainplayer);
                    }
                }

            }
            return priceperglass;
        }
        public void RaiseCap()
        {
            foreach(Customer customer in customers)
            {
                customer.pricecap += .10;
                
            }
        }
        public void LowerCap()
        {
            foreach(Customer customer in customers)
            {
                customer.pricecap -= .10;
                
            }
        }
        public void RevertCapFromRaise()
        {
            foreach(Customer customer in customers)
            {
                customer.pricecap -= .10;
            }
        }
        public void RevertCapFromLower()
        {
            foreach (Customer customer in customers)
            {
                customer.pricecap += .10;
            }
        }



        public void StartDay1()
        {
            dailyweather.Dayone();
            AddCustomers();
            RaiseCap();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies(Mainplayer);


        }
        public void StartDay2()
        {
            RevertCapFromRaise();
            dailyweather.Daytwo();
            AddCustomers();
            LowerCap();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies(Mainplayer);
        }
        public void StartDay3()
        {
            RevertCapFromLower();
            dailyweather.Daythree();
            AddCustomers();
            LowerCap();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies(Mainplayer);
        }
        public void StartDay4()
        {
            RevertCapFromLower();
            dailyweather.Dayfour();
            AddCustomers();
            LowerCap();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies(Mainplayer);
        }
        public void StartDay5()
        {
            RevertCapFromLower();
            dailyweather.Dayfive();
            AddCustomers();
            RaiseCap();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies(Mainplayer);

        }
        public void StartDay6()
        {
            RevertCapFromRaise();
            dailyweather.Daysix();
            AddCustomers();
            RaiseCap();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies(Mainplayer);
        }
        public void StartDay7()
        {
            RevertCapFromRaise();
            dailyweather.Dayseven();
            AddCustomers();
            this.RaiseCap();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies(Mainplayer);
        }

    }

}














