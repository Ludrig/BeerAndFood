using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerAndFood.Models;
using BeerAndFood.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeerAndFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly Repository repository;

        public HomeController(Repository repository)
        {
            this.repository = repository;
        }

       
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            
            var viewModel = repository.GetAllBeers();
            
            
            return View(viewModel);
            
        }
       



        [HttpGet]
       public IActionResult FoodWithBeer(int id)
        {
            return PartialView("_FoodBox", repository.GetFoodByBeerId(id));
        }
    }
}
