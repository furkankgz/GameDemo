using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Save(Player player)
        {
            Console.WriteLine("Oyuncu kayıt edildi." + player.Name);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu güncellendi." + player.Name);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi." + player.Name);
        }
    }
}
