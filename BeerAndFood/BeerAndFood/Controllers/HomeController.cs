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
        Repository repository = new Repository();
        
        [Route("")]
        public IActionResult Index()
        {
            var viewModel = repository.GetAllBeer();
            return View(viewModel);
        }
    }
}
