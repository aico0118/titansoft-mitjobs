using System;
using System.Collections.Generic;

namespace RouletteGame.Models.Models
{
    public partial class Game
    {
        public int Id { get; set; }
        public string CardName { get; set; }
        public decimal? Result { get; set; }

        public int? Winner { get; set; }

        public int? CardPosition { get; set; }
        public int RoomId { get; set; }
        public DateTime CreDate { get; set; }
        public DateTime? UpdDate { get; set; }

        public Room Room { get; set; }
    }
}
