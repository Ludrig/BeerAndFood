using BeerAndFood.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerAndFood.Models
{
     public class Repository
    {
        public HomeIndexVM GetAllBeer()
        {

        var viewModel = new HomeIndexVM
        {
            Beername = new SelectListItem[]
            {
                new SelectListItem{ Value = "1", Text = "Carlsberg Hof"},
                new SelectListItem{ Value = "2", Text = "Carlsberg Export"},
                new SelectListItem{ Value = "3", Text = "Pripps"}

            }
            
        };
            return viewModel;
        }
    }
}
