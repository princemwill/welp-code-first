using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class User
    {

        public int UserID { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        public string Password { get; set; }
        //need to find how to use hashset for password
        //HashSet<string> PasswordHashset = new HashSet<string> { get; set; }
        //var Password = new HashSet<int>(Password.Users.Select(char => c.UserID));
        public string Email { get; set; }
        //Revisit for better variable type to store location
        public string Location { get; set; }

        //Navigation properties.... "virtual" means it can be overridden
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Business> Businesses { get; set; }


    }
}