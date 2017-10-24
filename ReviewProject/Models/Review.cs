using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewProject.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Today's Date")]
        [DisplayFormat(DataFormatString = "{0:mm/dd/yyyy}")]
        public DateTime DateOfReview { get; set; }
        public string Email { get; set; }
        [Display(Name = "Product Reviews")]
        public string TypeOfProduct { get; set; }
        public string ReviewOfProduct { get; set; }
        [Required(ErrorMessage = "You must leave a rating")]
        [Range(1,10, ErrorMessage ="Controller Ratings must be between 1 and 10")]
        [Display(Name ="Controller Ratings")]
        public int ControllerRating { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }






    }
}