using System;
using GameDemo.Abstract;
using GameDemo.Adapters;
using GameDemo.Concrete;
using GameDemo.Entities;

namespace GameDemo
{
    class Program
    {
        static void Main()
        {
            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            Player player1 = new Player
            {
                Name = "Furkan",
                LastName = "KORKMAZGÖZ",
                Nick = "frknkgz",
                DateOfBirth = new DateTime(1999,08,04),
                NationalityId = "11111111111"
            };
            playerManager.Add(player1);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            Game game1 = new Game
            {
                Id = 1,
                GameName = "GTA V",
                GamePrice = 90
            };

            Game game2 = new Game
            {
                Id = 2,
                GameName = "PUBG",
                GamePrice = 60
            };

            Game game3 = new Game
            {
                Id = 2,
                GameName = "CS:GO",
                GamePrice = 70
            };

            Game.Add(game1);
            Game.Delete(game2);
            Game.Update(game3);

            Console.WriteLine("----------------------------------------------------------------------------------------------");


            Campaign campaign1 = new Campaign
            {
                Id = 1,
                Name = "Yüzde 45 indirim",
                DiscountRate = 0.45
            };
            Campaign campaign2 = new Campaign
            {
                Id = 2,
                Name = "Yüzde 50 İndirim",
                DiscountRate = 0.50
            };

            Campaign.Add(campaign1, game1);
            Campaign.Add(campaign2, game2);

            Console.WriteLine("----------------------------------------------------------------------------------------------");
            OrderManager orderManager = new OrderManager();
            orderManager.CampaignOrder(player1,game1,campaign1);
            orderManager.GameOrder(player1,game2);

        }
    }
}
