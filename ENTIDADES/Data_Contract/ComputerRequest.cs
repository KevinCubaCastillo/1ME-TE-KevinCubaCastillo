using System;
using System.Collections.Generic;

namespace ENTIDADES.Request
{
    public partial class ComputerReq
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public decimal? Size { get; set; }
    }
}
