using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerAndFood.Models;
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

        //Repository repository = new Repository();
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            var matLista = repository.GetFoodByBeerId(1);
            var viewModel = repository.GetAllBeers();
            return View(viewModel);
        }
    }
}
