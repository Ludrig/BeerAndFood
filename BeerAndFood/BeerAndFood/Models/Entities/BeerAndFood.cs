using System;
using System.Collections.Generic;

namespace BeerAndFood.Models.Entities
{
    public partial class BeerAndFood
    {
        public int Id { get; set; }
        public int IdBeer { get; set; }
        public int IdFood { get; set; }
    }
}
