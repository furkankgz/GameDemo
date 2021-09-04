using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class OrderManager : IOrderService
    {
        public void GameOrder(Player player, Game game)
        {
            Console.WriteLine(player.Name + " ("+ player.Nick+ ") " +" "+game.GameName + " adlı oyunu "+ game.GamePrice + " TL'ye satın aldı.");
        }

        public void CampaignOrder(Player player, Game game, Campaign campaign)
        {
            double indirim = game.GamePrice - (game.GamePrice * campaign.DiscountRate);
            Console.WriteLine(player.Name + " (" + player.Nick + ") " + " " + game.GameName + " adlı oyunu " +
                              campaign.DiscountRate + " indirim ile " + indirim + " TL'ye satın aldı.");
        }

    }
}
