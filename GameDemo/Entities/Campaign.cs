using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Concrete;

namespace GameDemo.Entities
{
    public class Campaign : CampaignManager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DiscountRate { get; set; }

    }
}
