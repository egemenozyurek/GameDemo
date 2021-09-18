using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface ISalesService
    {
        void Sale(Game game, Campaigns campaigns, Gamer gamer);
    }
}
