using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlakeMockAssessment.Models;

namespace BlakeMockAssessment.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

      public IActionResult GetAge()
        {
            ViewBag.Name = "Name";
            ViewBag.Age = "Age";
            return View();
        }

        public IActionResult Result(string name, int age)
        {
            if(age >= 18)
            {
                ViewBag.CanVote = name + " You can vote.";
            }
            if(age >= 21)
            {
                ViewBag.CanDrink = name + " You can Drink.";
            }
            if (age >= 25)
            {
                ViewBag.CanRent = name + " You can drive";
            }
            else
            {
                ViewBag.ToYoung = name + " Your are still in highschool";
            }
            
            return View();
        }

        public IActionResult Goals()
        {

            return View();

        }

        
        
        
        public IActionResult LifeChoice(string choice)
        {
            if(choice == "Drop Out")
            {
                return RedirectToAction("PoorChoice", choice);
                
            
            }
            ViewBag.Choice = choice;
            return View();
        }

        public IActionResult PoorChoice(string choice)
        {
            ViewBag.PoorChoice = choice;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
