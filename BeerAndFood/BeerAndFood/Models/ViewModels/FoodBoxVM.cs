using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeerAndFood.Models.ViewModels
{
    public class FoodBoxVM
    {
        [Display(Name = "Passar till")]
        public string FoodType { get; set; }
    }
}
