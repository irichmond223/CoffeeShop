using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public partial class Users
    {
        public Users()
        {
            UserItems = new HashSet<UserItems>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
        public string Phone { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string Password { get; set; }
        public decimal? Funds { get; set; }

        public virtual ICollection<UserItems> UserItems { get; set; }
    }
}
