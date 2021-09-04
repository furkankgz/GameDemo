using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class GameManager
    {
        public static void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi. Eklenen oyun: "+game.GameName);
        }
        public static void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi. Silinen oyun: " + game.GameName);
        }
        public static void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi. Güncellenen oyun: " + game.GameName);
        }
    }
}
