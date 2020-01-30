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
            ShopDBContext db = new ShopDBContext();
        
            TempData["bool"] = false;

            return View(db);
        }

        
        public IActionResult AddUser(User u)
        {
            //use he RegisterTestContext object to access db data
            ShopDBContext db = new ShopDBContext();

            //Another way
            //db.User.Add(user);

            //we use our db object,
            //to access the table we want to write new data to
            db.User.Add(new User()
            {
                Username = u.Username,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                Password = u.Password,
                Phone = u.Phone

            });

            //we must save changes that we just made to our db
            db.SaveChanges();

            return View(u);
        }

        //need one action to load our RegistrationPage, also need a view
        public IActionResult RegistrationPage()
        {
            return View("RegistrationPage");
        }

        //need one action to take those user inputs, and display the user name, in a new view

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Validate(string Username)
        {
            ShopDBContext db = new ShopDBContext();

            //make an individual Person object to store my result in
            User foundResult = new User();

            //make a TempData object and set it to false
            //this allows  me to later set it to true if I find a match
            TempData["Registered"] = false;

            //i need to find my result in my DB
            foreach (User u in db.User)
            {
                //as i iterate through the collection, i want to find the correct result
                if (u.Username == Username)
                {
                    //if you find a match, assign that value to your temp Person object
                    foundResult = u;

                    //You found a match, set your TempData to true 
                    //This allows us to display certain HTML
                    //flip this value  
                    TempData["Registered"] = true;
                    return Shop();
                }
            }

            //if we made it this far we checked everyone in the database and didn't find a match
            return RegistrationPage();
        }
        public IActionResult Shop()
        {
            ShopDBContext db = new ShopDBContext();
            return View("Shop", db);

            //Use my context class to pull in my db data
        }

        //public IActionResult AddUser(string userName, string email, string password, int phone) //make a Person object as a param and let the framework map the values
        //{
        // make to Viewbag objects to hold my 4 prameters
        //ViewBag.UserName = userName;
        // ViewBag.Email = email;
        //ViewBag.Password = password;
        // ViewBag.Phone = phone;

        // return View();
        // }

        //public IActionResult Register()
        //{
        //    var testObj = new User();

        //    ShopDBContext db = new ShopDBContext();

        //    //foreach loop to pull out individual rows of data
        //    foreach (User u in db.User)
        //    {
        //        testObj = new User()
        //        {
        //            Username = u.Username,
        //            FirstName = u.FirstName,
        //            LastName = u.LastName,
        //            Email = u.Email,
        //            Password = u.Password,
        //            Phone = u.Phone
        //        };

        //    }
        //    return View();
        //}



        //public IActionResult AddUser(User use) //make a User object as a param and let the framework map the values
        //{
        //return View(use);
        //}

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
