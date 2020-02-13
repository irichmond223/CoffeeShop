﻿using System;
using System.Collections.Generic;

namespace CoffeeShop.Models
{
    [Serializable]
    public partial class Users
    {
        public Users()
        {
            UserItems = new HashSet<UserItems>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public decimal? Funds { get; set; }

        public virtual ICollection<UserItems> UserItems { get; set; }
    }
}
