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
            var query = context
                .BeerAndFood
                .Where(baf => baf.IdBeer == beerId)
                .Select(baf => new FoodBoxVM { FoodType = baf.IdFoodNavigation.Food1 })
                .ToArray();

            return query;
            //{
            //    //Title = f != null ? f.Title : "Invalid Id",
            //    //Description = f != null ? f.Description : "",
            //    //Genre = f != null ? f.Genre : ""
            //};
        }
        //public FoodBoxVM GetFoodByBeerId(int beerId)
        //{
            
        //    var q = context.BeerAndFood.Select(b => b.IdBeer == beerId.CompareTo(b.IdFood));

        //    //var c = context.BeerAndFood.Select(m => m.IdFood == q);
        //    var f = context.Food.Select(m => m.Food1 == q.ToString());
        //    return new FoodBoxVM
        //    {
        //        FoodType = q.ToString()
        //    };

        //}
        
    }
}

