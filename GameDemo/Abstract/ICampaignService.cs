using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface ICampaignService
    {
        void Add(Campaigns campaigns);
        void Delete(Campaigns campaigns);
        void Update(Campaigns campaigns);
    }
}
