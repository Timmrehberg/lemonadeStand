using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Game 
    {
        List<int> Missedsales = new List<int>();
        List<int> Glassessold = new List<int>();

        public Player Mainplayer = new Player(0, 0, 0, 0);

        Purchase purchase = new Purchase();
        public List<double> customersCaps = new List<double>();
        Weather dailyweather = new Weather();


        Customer Bob = new Customer("Bob", 0.75);

        Customer Joe = new Customer("Joe", 0.50);
        Customer Kim = new Customer("Kim", 0.65);
        Customer Timmy = new Customer("Tim", 0.50);
        Customer Poe = new Customer("Poe", 0.65);
        Customer Moe = new Customer("Moe", 0.55);
        Customer Loe = new Customer("Loe", 0.75);
        Customer Boe = new Customer("Boe", 0.65);
        Customer Tom = new Customer("Tom", 0.75);
        Customer Pit = new Customer("Pit", 0.50);
        Customer Mitt = new Customer("Mitt", 0.65);
        Customer Kimm = new Customer("Kimm", 0.70);
        Customer Fin = new Customer("Fin", 0.65);
        Customer Jimmy = new Customer("Jimmy", 0.60);
        Customer Mooe = new Customer("Mooe", 0.70);
        Customer Loell = new Customer("Loell", 0.85);
        Customer Bohem = new Customer("Bohem", 0.85);
        Customer Rodger = new Customer("Rodger", 0.70);
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
                        Missedsales.Add(Missedsales.Count + 1);
                        
                        
                       


                    }
                    else if (priceperglass <= customer.pricecap)
                    {
                        Console.WriteLine("Made a sale");
                        Mainplayer.cash += priceperglass;
                        Console.WriteLine(Mainplayer.cash);
                        purchase.subtractMaterials(Mainplayer);
                        purchase.Checkremainingsupplies(Mainplayer);
                        Glassessold.Add(Glassessold.Count + 1);

                        
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
        public void RestartList()
        {
            Missedsales.Clear();
            Glassessold.Clear();
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
            Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
            RestartList();


        }
        public void StartDay2()
        {
            RevertCapFromRaise();
            dailyweather.Daytwo();
            LowerCap();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies(Mainplayer);
            Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
            RestartList();
        }
        public void StartDay3()
        {
            RevertCapFromLower();
            dailyweather.Daythree();
            //AddCustomers();
            LowerCap();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies(Mainplayer);
            Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
            RestartList();
        }
        public void StartDay4()
        {
            RevertCapFromLower();
            dailyweather.Dayfour();
            Console.WriteLine("Youre business is starting to get bigger expect more customers!");
            Console.ReadLine();
            AddCustomers();
            RaiseCap();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies(Mainplayer);
            Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
            RestartList();
        }
        public void StartDay5()
        {
            RevertCapFromRaise();
            dailyweather.Dayfive();
            RaiseCap();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies(Mainplayer);
            Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
            RestartList();

        }
        public void StartDay6()
        {
            RevertCapFromRaise();
            dailyweather.Daysix();
            RaiseCap();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies(Mainplayer);
            Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
            RestartList();
        }
        public void StartDay7()
        {
            RevertCapFromRaise();
            dailyweather.Dayseven();
            RaiseCap();
            purchase.BuyLemons(Mainplayer);
            purchase.BuyCups(Mainplayer);
            purchase.BuyIce(Mainplayer);
            purchase.BuySugar(Mainplayer);
            Setprice(Mainplayer);
            purchase.Checkinventory(Mainplayer);
            purchase.Checkremainingsupplies(Mainplayer);
            Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
            RestartList();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Do you want to continue playing? Y or N");
            string extendgameplay = Console.ReadLine();
            switch (extendgameplay)
            {
                case "N":
                    if(Mainplayer.cash > 100)
                    {
                        Console.WriteLine("You killed it");
                    }
                    else if (Mainplayer.cash > 40)
                    {
                        Console.WriteLine("Your a lemonade guru");
                    }
                    else if(Mainplayer.cash < 30)
                    {
                        Console.WriteLine("You barely made it!");
                    }
                    break;
                case "Y":
                    Console.WriteLine("Gameplay extended 7 more days!" );
                    RevertCapFromRaise();
                    dailyweather.Dayeight();
                    RaiseCap();
                    purchase.BuyLemons(Mainplayer);
                    purchase.BuyCups(Mainplayer);
                    purchase.BuyIce(Mainplayer);
                    purchase.BuySugar(Mainplayer);
                    Setprice(Mainplayer);
                    purchase.Checkinventory(Mainplayer);
                    purchase.Checkremainingsupplies(Mainplayer);
                    Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
                    RestartList();

                    dailyweather.Daynine();
                    RevertCapFromRaise();
                    RaiseCap();
                    purchase.BuyLemons(Mainplayer);
                    purchase.BuyCups(Mainplayer);
                    purchase.BuyIce(Mainplayer);
                    purchase.BuySugar(Mainplayer);
                    Setprice(Mainplayer);
                    purchase.Checkinventory(Mainplayer);
                    purchase.Checkremainingsupplies(Mainplayer);
                    Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
                    RestartList();

                    dailyweather.Dayten();
                    Console.WriteLine("Youre business is becoming so well known people are starting to come out of the way to check it out!");
                    Console.ReadLine();
                    RevertCapFromRaise();
                    AddCustomers();
                    LowerCap();
                    purchase.BuyLemons(Mainplayer);
                    purchase.BuyCups(Mainplayer);
                    purchase.BuyIce(Mainplayer);
                    purchase.BuySugar(Mainplayer);
                    Setprice(Mainplayer);
                    purchase.Checkinventory(Mainplayer);
                    purchase.Checkremainingsupplies(Mainplayer);
                    Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
                    RestartList();

                    dailyweather.Dayeleven();
                    RevertCapFromLower();
                    LowerCap();
                    purchase.BuyLemons(Mainplayer);
                    purchase.BuyCups(Mainplayer);
                    purchase.BuyIce(Mainplayer);
                    purchase.BuySugar(Mainplayer);
                    Setprice(Mainplayer);
                    purchase.Checkinventory(Mainplayer);
                    purchase.Checkremainingsupplies(Mainplayer);
                    Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
                    RestartList();

                    dailyweather.Daytwelve();
                    RevertCapFromLower();
                    RaiseCap();
                    purchase.BuyLemons(Mainplayer);
                    purchase.BuyCups(Mainplayer);
                    purchase.BuyIce(Mainplayer);
                    purchase.BuySugar(Mainplayer);
                    Setprice(Mainplayer);
                    purchase.Checkinventory(Mainplayer);
                    purchase.Checkremainingsupplies(Mainplayer);
                    Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
                    RestartList();

                    dailyweather.Daythirteen();
                    AddCustomers();
                    Console.WriteLine("Even more customers are coming now so prepare!");
                    RevertCapFromRaise();
                    RaiseCap();
                    purchase.BuyLemons(Mainplayer);
                    purchase.BuyCups(Mainplayer);
                    purchase.BuyIce(Mainplayer);
                    purchase.BuySugar(Mainplayer);
                    Setprice(Mainplayer);
                    purchase.Checkinventory(Mainplayer);
                    purchase.Checkremainingsupplies(Mainplayer);
                    Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
                    RestartList();

                    dailyweather.Dayfourteen();
                    RevertCapFromRaise();
                    RaiseCap();
                    purchase.BuyLemons(Mainplayer);
                    purchase.BuyCups(Mainplayer);
                    purchase.BuyIce(Mainplayer);
                    purchase.BuySugar(Mainplayer);
                    Setprice(Mainplayer);
                    purchase.Checkinventory(Mainplayer);
                    purchase.Checkremainingsupplies(Mainplayer);
                    Console.WriteLine("You missed " + Missedsales.Count + " You sold " + Glassessold.Count);
                    RestartList();
                    Console.WriteLine("Thanks for playing!");
                    if (Mainplayer.cash > 100)
                    {
                        Console.WriteLine("You killed it");
                    }
                    else if (Mainplayer.cash > 40)
                    {
                        Console.WriteLine("Your a lemonade guru");
                    }
                    else if (Mainplayer.cash < 30)
                    {
                        Console.WriteLine("You barely made it!");
                    }

                    break;
                default:
                    Console.WriteLine("Thanks for playing");
                    break;

            }
                   
            }
    
            

            }
    }
     
         














