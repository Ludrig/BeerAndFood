using System;
using System.Collections.Generic;

namespace BeerAndFood.Models.Entities
{
    public partial class Beer
    {
        public int Id { get; set; }
        public string Beername { get; set; }
        public string Sort { get; set; }
        public int Price { get; set; }
    }
}
