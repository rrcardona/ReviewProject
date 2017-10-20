using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewProject.Models
{
    public class Review
    {
        [Key]
        public string Name { get; set; }
        public DateTime DateOfReview { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }




    }
}