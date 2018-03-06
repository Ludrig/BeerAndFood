using BeerAndFood.Models.Entities;
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
        private readonly SouthWindContext context;

        public Repository()
        {
        }

        public Repository(SouthWindContext context)
        {
            this.context = context;
        }

        //public HomeIndexVM GetAllBeer()
        //{

        //    var viewModel = new HomeIndexVM
        //    {
        //        Beername = new SelectListItem[]
        //        {
        //            new SelectListItem{ Value = "1", Text = "Carlsberg Hof"},
        //            new SelectListItem{ Value = "2", Text = "Carlsberg Export"},
        //            new SelectListItem{ Value = "3", Text = "Pripps"}

        //        }

        //    };
        //        return viewModel;
        //}
        public HomeIndexVM GetAllBeers()
        {

            var query = context.Beer.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Beername,
                Selected = c.Id.Equals(3)
            });

            var model = new HomeIndexVM
            {
                Beername = query.ToArray()
            };
            return model;
        }

        public FoodBoxVM[] GetFoodByBeerId(int beerId)
        {
            var query = context.BeerAndFood.Select(b => b.IdBeer == beerId);

            return new FoodBoxVM[]
            {
                //Title = f != null ? f.Title : "Invalid Id",
                //Description = f != null ? f.Description : "",
                //Genre = f != null ? f.Genre : ""
            };
        }
    }
}

