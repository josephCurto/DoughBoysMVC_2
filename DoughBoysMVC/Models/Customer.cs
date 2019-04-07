using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DoughBoysMVC.Models
{
    public class Customer
    {
       [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", 
        ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
    }
}
