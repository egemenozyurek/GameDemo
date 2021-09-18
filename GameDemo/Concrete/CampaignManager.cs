using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaigns campaigns)
        {
            Console.WriteLine("Yeni Kampanya : " + campaigns.CampaignName);
        }

        public void Delete(Campaigns campaigns)
        {
            Console.WriteLine("Kampanya silindi : " + campaigns.CampaignName);
        }

        public void Update(Campaigns campaigns)
        {
            Console.WriteLine("Kampanya Güncellendi : " + campaigns.CampaignName);
        }
    }
}
