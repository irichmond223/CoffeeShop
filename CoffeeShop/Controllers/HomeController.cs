using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoffeeShop.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace CoffeeShop.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<Items> itemList;
        private List<Users> userList;
        private ShopDBContext db;



        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            GetData();
        }

        [AllowAnonymous]
        public IActionResult Index()
        {

            ShopDBContext db = new ShopDBContext();
            GetData();
            var userList = db.Users.ToList();


            //make a session object and store data in it for later retrieval
            HttpContext.Session.SetString("TempKey", "Hello World");
            var y = db.UserItems.Where(userItems => userItems.UserId == 1).ToList();

            //use get string to retrieve the data in the session
            var testSession = HttpContext.Session.GetString("TempKey");

            //loop through Users, and find attached UserItems
            foreach (var item in db.Users)
            {
                var tempObj = item;
                var x = "hi";
            }
            //grab user items and add to a list
            var userItems = db.UserItems.ToList();

            TempData["Registered"] = false;

            return View();
        }

        private void GetData()
        {
            db = new ShopDBContext();
            itemList = db.Items.ToList();
            userList = db.Users.ToList();
        }

        public IActionResult MakeNewUser(Users u)
        {
            //use he RegisterTestContext object to access db data
            ShopDBContext db = new ShopDBContext();


            db.Add(u);
            db.SaveChanges();
            return View(u);

        }

        //need one action to load our RegistrationPage, also need a view
        public IActionResult Register()
        {
            return View("Register");
        }

        //need one action to take those user inputs, and display the user name, in a new view
 
        public IActionResult Login()
        {
            return View();
        }

  

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Validate(Users u)
        {
            ShopDBContext db = new ShopDBContext();
            var validateEmail = db.Users.Where(b => b.UserName == u.UserName).FirstOrDefault();
            var validatePw = db.Users.Where(b => b.UserName == u.UserName && b.Password == u.Password).FirstOrDefault();
            if (validateEmail != null && validatePw != null)
            {
                HttpContext.Session.SetInt32("current", validatePw.Id);

                return RedirectToAction("Shop");
            }
            else if (validateEmail == null)
            {
                TempData["IncorrectEmail"] = true;
                return View("Login");
            }
            else if (validatePw == null)
            {
                TempData["IncorrectPw"] = true;
                return View("Login");
            }
            else
            {
               
              
                return RedirectToAction("Login");
            }



        }

        [HttpPost]
        [Authorize]
        public ActionResult Logout()
        {
           
            return RedirectToAction("Index");
        }



        public IActionResult Shop()
        {
            ShopDBContext db = new ShopDBContext();
            return View("Shop", db);

            //Use my context class to pull in my db data
        }
        public IActionResult Buy(decimal? Price, string Name, int Quantity)
        {
            ShopDBContext db = new ShopDBContext();
            /*List<AspNetUsers> userList = db.AspNetUsers.ToList();
            List<Items> itemList = db.Items.ToList();

            u = JsonSerializer.Deserialize<Users>(HttpContext.Session.GetString("Users"));

            if (u.Funds >= Price)
            {
                u.Funds = u.Funds - Price;
                db.Update(u);
                db.SaveChanges();
                return View("Summary");
            }
            return View("Shop");*/

            List<Users> userList = db.Users.ToList();
            List<Items> itemList = db.Items.ToList();

            foreach (Items item in itemList)
            {
                if (item.Name == Name)
                {
                    item.Quantity = Quantity;
                    //db.Items.Update(item);
                    db.SaveChanges();
                }
            }
        

            foreach(Users users in userList)
            {
                if (users.Email == User.Identity.Name)
                {
                    users.Funds -= Price;
                    db.Users.Update(users);
                    db.SaveChanges();

                    return View("Shop", db);
    }
}
            return View("Shop", db);
        }
        public IActionResult Summary()
        {
            return View();
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
            //use get string to retrieve the data in the session
            var testSession = HttpContext.Session.GetString("TempKey");
            var user = User.Identity;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
