using ENTIDADES.Data_Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Computadora : Response
    {
        public string Id { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal? Size { get; set; }
    }
}
