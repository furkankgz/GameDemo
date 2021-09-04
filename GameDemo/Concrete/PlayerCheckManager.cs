using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Adapters;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class PlayerCheckManager : IPlayerCheckService
    {
        private IPlayerCheckService _checkService;
        public bool CheckPlayer(Player player)
        {
            _checkService = new MernisServiceAdapter();
            return _checkService.CheckPlayer(player);
        }
    }
}
