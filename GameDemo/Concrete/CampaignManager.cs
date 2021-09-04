using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class CampaignManager
    {
        public static void Add(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya eklendi. Eklenen kampanya: " + campaign.Name + " oyun ismi " +
                              game.GameName);
        }
    }
}
