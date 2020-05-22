using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_middleware.Models
{
    public class AccountMetaData
    {
        //noi dat validation
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }

    [ModelMetadataType(typeof(AccountMetaData))]
    public partial class Account
    {

    }
}

