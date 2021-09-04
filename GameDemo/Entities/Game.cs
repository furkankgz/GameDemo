using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Concrete;

namespace GameDemo.Entities
{
    public class Game : GameManager
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
    }
}
