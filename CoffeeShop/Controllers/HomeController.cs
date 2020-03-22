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
using System.Net.Http;

namespace CoffeeShop.Controllers
{
  
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //these private fields will be used as a way to load in the user and item data
       // private List<Items> itemList;
        //private List<Users> userList;
        //private ShopDBContext db;



        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //GetData();
        }

        //[AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        //need one action to load our RegistrationPage, also need a view
        //This is for identity
        public IActionResult Register()
        {
            //ShopDBContext db = new ShopDBContext();
            //db.SaveChanges();
            //return View("Register", db);
            return View();
        }


        //Get data is used for Identity
        //private async void GetData()
        //{
        //    db = new ShopDBContext();
        //    itemList = await GetItems();
        //    userList = db.Users.ToList();
        //}

        //make a private method to call our CofeeShop API and get a list of items
        private async Task<List<Items>> GetItems()
        {
            using(var httpClient = new HttpClient())
            {
                using (var response = await httpClient
                .GetAsync("https://localhost:44385/api/CoffeeShop/getItems"))
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();
                    //return new List<Items>();
                    return JsonSerializer.Deserialize<List<Items>>(stringResponse);
                }
            }
        }
        private async void AddItems(string hello = "Hello")
        {
            //var tempJson = JsonSerializer.Serialize()
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient
                    .GetAsync($"https://localhost:44385/api/CoffeeShop/addItems?Item={hello}"))
                {

                }
            }
        }
        public IActionResult MakeNewUser(Users u)
        {
            //use this object to access db data
            ShopDBContext db = new ShopDBContext();
            db.Add(u);
            db.SaveChanges();
            return View(u);
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult RegistrationPage()
        {
            return View();
        }


        //[HttpPost]
        //[AllowAnonymous]
        public IActionResult Validate(string username, string password)
        {
            ShopDBContext db = new ShopDBContext();
            //use object to access Users table
            Users users = new Users();

            HttpContext.Session.SetString("UserInSession", "false");
            var searchedUser = db.AspNetUsers.SingleOrDefault(u => u.UserName == username);

            foreach (Users user in db.Users)
            {
                if (user.UserName == username && user.Password == password)
                {
                    //declare users (Users table) to match the user 
                    users = user;

                    HttpContext.Session.SetString("UserInSession", "true");
                    HttpContext.Session.SetString("Funds", users.Funds.ToString());
                    HttpContext.Session.SetString("User", users.UserName.ToString());
                    HttpContext.Session.SetString("Id", users.Id.ToString());
                    return RedirectToAction("Shop");

                }
                else
                {
                    return RedirectToAction("Login");

                }
            }
            return View(users);
        }

        public IActionResult Shop()
        {
            ShopDBContext db = new ShopDBContext();
            return View(db);

        }

        //public IActionResult MakeNewUser(decimal? Price, Users u)
        //{
        //    ShopDBContext db = new ShopDBContext();
        //    List<AspNetUsers> userList = db.AspNetUsers.ToList();
        //    List<Items> itemList = db.Items.ToList();

        //    u = JsonSerializer.Deserialize<Users>(HttpContext.Session.GetString("Users"));

        //    if (u.Funds >= Price)
        //    {
        //        u.Funds = u.Funds - Price;
        //        db.Update(u);
        //        db.SaveChanges();
        //        return View("Summary");
        //    }
        //    return View("Shop");
        //}
        public IActionResult Purchase(decimal? Price, string Name)
        {
            ShopDBContext db = new ShopDBContext();

            Users currentUser = new Users();
            Items boughtItem = new Items();

            foreach (Users user in db.Users)
            {
                if (user.UserName == HttpContext.Session.GetString("User"))
                {
                    currentUser = user;
                }
            }

            if (currentUser.Funds - Price < 0)
            {
                return View("LowFunds", currentUser);
            }
            else
            {
                foreach (Items item in db.Items)
                {
                    if (item.Name == Name)
                    {
                        boughtItem = item;
                        boughtItem.Quantity -= 1;
                        currentUser.Funds -= Price;

                        db.UserItems.Add(new UserItems { UserId = currentUser.Id, ItemId = boughtItem.Id });
                    }
                }

                db.SaveChanges();

                return View("Shop", db);
            }

            }

        public IActionResult LowFunds(decimal price)
        {
            ViewBag.Price = price;
            return View();
        }

        public IActionResult List()
        {
            ShopDBContext db = new ShopDBContext();

            return View(db);
        }

        public IActionResult Details(int id)
        {
            ShopDBContext db = new ShopDBContext();
            Items foundItem = new Items();

            foreach (Items item in db.Items)
            {
                if (item.Id == id)
                {
                    foundItem = item;
                }
            }
            return View(foundItem);
        }

        public IActionResult Delete(int id)
        {
            ShopDBContext db = new ShopDBContext();
            UserItems foundItem = new UserItems();

            foreach (UserItems item in db.UserItems)
            {
                if (item.UserItemId == id)
                {
                    foundItem = item;
                }
            }

            db.UserItems.Remove(foundItem);
            db.SaveChanges();

            return View("List", db);
        }

        public IActionResult Summary()
        {
            

            return View();
        }


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
