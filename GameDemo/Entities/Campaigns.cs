using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    class Campaigns : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int Discount { get; set; }
    }
}
