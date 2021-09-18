using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class GamerManager : BaseGamerManager
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                Console.WriteLine("Not a valid gamer");
            }
        }
    }
}
