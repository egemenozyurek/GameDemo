using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface IGamerCheckService
    {
        bool CheckIfRealGamer(Gamer gamer);
    }
}
