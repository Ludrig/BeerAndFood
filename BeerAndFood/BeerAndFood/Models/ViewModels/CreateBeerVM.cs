using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeerAndFood.Models.ViewModels
{
    public class CreateBeerVM
    {
        [Display(Name = "Öl")]
        public string Beer { get; set; }
        public string Sort { get; set; }
        public int Pris { get; set; }
        public int[] selectedFoodIds { get; set; }
    }
}
