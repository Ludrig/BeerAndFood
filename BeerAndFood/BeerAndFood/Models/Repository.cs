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
                Text = c.Beername +" Pris: " + c.Price + " kr" + " Typ: " + c.Sort,
                Selected = c.Id.Equals(3)
            });
            var queryFood = context.Food.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Food1,
                Selected = c.Id.Equals(3)
            });

            var model = new HomeIndexVM
            {
                Beername = query.ToArray(),
                Foodname = queryFood.ToArray()
                
            };
            return model;
        }

        public void AddBeer(CreateBeerVM model)
        {
            

              var newBeer = new Beer
            {
                Beername = model.Beer,
                Price = model.Pris,
                Sort = model.Sort,
                
            };
            foreach (var foodId in model.selectedFoodIds)
            {
                newBeer.BeerAndFood.Add(new BeerAndFood.Models.Entities.BeerAndFood { IdFood = foodId });
            }
            context.Beer.Add(newBeer);
            context.SaveChanges();
        }

        public FoodBoxVM[] GetFoodByBeerId(int beerId)
        {
            var query = context
                .BeerAndFood
                .Where(baf => baf.IdBeer == beerId)
                .Select(baf => new FoodBoxVM { FoodType = baf.IdFoodNavigation.Food1 })
                .ToArray();

            return query;
           
        }
        public FoodBoxVM[] GetBeerByFoodId(int foodId)
        {
            var query = context
                .BeerAndFood
                .Where(baf => baf.IdFood == foodId)
                .Select(baf => new FoodBoxVM { FoodType = baf.IdBeerNavigation.Beername})
                .ToArray();

            return query;

        }


    }
}

