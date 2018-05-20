﻿using System;
using System.Collections.Generic;

namespace RouletteGame.Models.Models
{
    public partial class Card
    {
        public int Id { get; set; }
        public decimal Reward { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
        public int Position { get; set; }
        public string Colour { get;set; }
        public DateTime CreDate { get; set; }
        public DateTime? UpdDate { get; set; }
    }
}
