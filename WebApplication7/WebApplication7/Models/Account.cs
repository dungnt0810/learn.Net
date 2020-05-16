using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Account
    {   
        [MinLength(3)]
        [Required]      //Required la vadidate khong duoc rong
        public string Username { get; set; }

        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
        [Required]
        //aBc22@
        public string Password { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Url]
        public string Website { get; set; }

        [Range(18, 60)]
        [Required]
        public int Age { get; set; }
    }
}
