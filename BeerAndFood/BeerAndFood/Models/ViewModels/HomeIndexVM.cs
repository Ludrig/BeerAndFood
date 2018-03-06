using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeerAndFood.Models.ViewModels
{
    public class HomeIndexVM
    {
        [Display(Name = "Öl")]
        public SelectListItem[] Beername { get; set; }
        [Range(1, 7)]
        public int BeernameItem { get; set; }
        [Display(Name = "Typ")]
        public string Sort { get; set; }
        public int Pris { get; set; }

        //[Display(Name = "Passar till")]
        public FoodBoxVM[] FoodType { get; set; }

    }
}
