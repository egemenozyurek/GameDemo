using GameDemo.Abstract;
using GameDemo.Adapter;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                FirstName = "Egemen",
                LastName = "Özyürek",
                NationalityId = "12345678910",
                DateofBirth = 1996
            };

            Game game = new Game() { Name = "Assassins Creed: Valhalla", Price =799.0};

            Campaigns campaigns = new Campaigns() { CampaignName = "Halloween Campaign", Discount = 42 };

            BaseGamerManager gamerManager = new GamerManager(new EGovernmentServiceAdapter());
            gamerManager.Add(gamer);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaigns);

            SalesManager salesManager = new SalesManager(new EGovernmentServiceAdapter());
            salesManager.Sale(game, campaigns, gamer);
        }
    }
}
