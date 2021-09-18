using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu sisteme eklendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu sistemden silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncunun bilgileri güncellendi");
        }
    }
}
