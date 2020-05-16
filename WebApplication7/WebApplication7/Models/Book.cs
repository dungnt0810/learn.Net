using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Book
    {
        [MaxLength(10)]
        [MinLength(5)]
        [Required]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        
        public double Price { get; set; }

        [Range(0,5)]
        public double Rating { get; set; }

        [Range(20, 2000)]
        public double Page { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
