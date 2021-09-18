using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class SalesManager : ISalesService
    {
        IGamerCheckService _gamerCheckService;
        public SalesManager (IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Sale(Game game, Campaigns campaigns, Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                double total = game.Price - ((game.Price * campaigns.Discount) / 100);
                Console.WriteLine(gamer.FirstName + " oyunun " + campaigns.CampaignName + " ile " + game.Price + " TL yerine " + total + "TL ye satın aldı.");
            }
        }
    }
}
