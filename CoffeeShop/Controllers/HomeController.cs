using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //need one action to load our RegistrationPage, also need a view
        public IActionResult RegistrationPage()
        {
            return View();
        }
        //need one action to take those user inputs, and display the user name, in a new view



        //public IActionResult AddUser(string userName, string email, string password, int phone) //make a Person object as a param and let the framework map the values
        //{
            // make to Viewbag objects to hold my 4 prameters
            //ViewBag.UserName = userName;
           // ViewBag.Email = email;
            //ViewBag.Password = password;
           // ViewBag.Phone = phone;


           // return View();

       // }


        public IActionResult AddUser(User use) //make a User object as a param and let the framework map the values
        {
        

        return View(use);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
