using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class PlayerManager 
    {
        private readonly IPlayerCheckService _checkService;

        public PlayerManager(IPlayerCheckService checkService)
        {
            _checkService = checkService;
        }

        //public override void Save(Player player)
        //{
        //    if (_checkService.CheckPlayer(player))
        //    {
        //        base.Save(player);
        //    }
        //    else
        //    {
        //        throw new Exception("Not a valid player.");
        //    }
        //}
        public void Add(Player player)
        {
            if (_checkService.CheckPlayer(player))
            {
                Console.WriteLine(player.Name + "oyuncusu eklendi.");
            }
            else
            {
                throw new Exception("Not a valid player.");
            }
        }

        public void Update(Player player)
        {
            if(_checkService.CheckPlayer(player))
            {
                Console.WriteLine(player.Name + "oyuncusu güncellendi.");
            }
            else
            {
                throw new Exception("Not a valid player.");
            }
        }
            public void Delete(Player player)
        {
            Console.WriteLine(player.Name + "silindi.");
        }


    }
}
