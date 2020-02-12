using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class ShoppingCart
    {
        private readonly ShopDBContext _shopDBContext;
       

        public int UserItemId { get; set; }
        public List<UserItems> UserItems { get; set; }
        public ShoppingCart(ShopDBContext shopDBContext)
        {
            _shopDBContext = shopDBContext;
        }

        /*public static ShoppingCart GetCart(IServiceProvider services)
        {
           *//* ISession session = services.GetRequiredService<IHttpContextAccessor>
                ()?.HttpContext.Session;

            var context = services.GetService<ShopDBContext>();
            var itemId = session.GetString("ItemId");
            var userItemId = session.GetString("UserItemId");

            return new ShoppingCart(context) {userItemId = itemId };*//*
            
        }*/
    }
}
