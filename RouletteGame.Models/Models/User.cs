﻿using System;
using System.Collections.Generic;

namespace RouletteGame.Models.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Coin { get; set; }
        public int? RoomId { get; set; }
        public DateTime CreDate { get; set; }
        public DateTime? UpdDate { get; set; }

        public Room Room { get; set; }
    }
}
