using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Adapter
{
    class EGovernmentServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            EGovernmentManager eGovernmentManager = new EGovernmentManager();
            return eGovernmentManager.IdentifyNationalityId(gamer.FirstName, gamer.LastName, gamer.NationalityId, gamer.DateofBirth);
        }
    }
}
