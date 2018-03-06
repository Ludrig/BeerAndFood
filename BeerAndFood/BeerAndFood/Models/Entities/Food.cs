using System;
using System.Collections.Generic;

namespace BeerAndFood.Models.Entities
{
    public partial class Food
    {
        public Food()
        {
            BeerAndFood = new HashSet<BeerAndFood>();
        }

        public int Id { get; set; }
        public string Food1 { get; set; }

        public ICollection<BeerAndFood> BeerAndFood { get; set; }
    }
}
