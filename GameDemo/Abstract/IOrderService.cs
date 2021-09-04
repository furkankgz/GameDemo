using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface IOrderService
    {
        void GameOrder(Player player, Game game);
        void CampaignOrder(Player player, Game game, Campaign campaign);
    }
}
