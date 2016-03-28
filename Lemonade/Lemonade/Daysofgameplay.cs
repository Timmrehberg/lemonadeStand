using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Daysofgameplay
    {
        Purchase purchase = new Purchase();
        StoreManagement manage = new StoreManagement();
        Game gamedata = new Game();
        Weather dailyweather = new Weather();
        public void Dayonestart()
        {
            dailyweather.Dayone();
            gamedata.AddCustomers();
            gamedata.RaiseCap();
            purchase.BuyLemons(gamedata.Mainplayer);
            purchase.BuyCups(gamedata.Mainplayer);
            purchase.BuyIce(gamedata.Mainplayer);
            purchase.BuySugar(gamedata.Mainplayer);
            gamedata.Setprice(gamedata.Mainplayer);
            purchase.Checkinventory(gamedata.Mainplayer);
            purchase.Checkremainingsupplies(gamedata.Mainplayer);
        }
    }
}
