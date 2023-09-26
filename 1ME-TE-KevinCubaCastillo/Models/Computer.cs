using System;
using System.Collections.Generic;

namespace _1ME_TE_KevinCubaCastillo.Models
{
    public partial class Computer
    {
        public string Id { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal? Size { get; set; }
    }
}
