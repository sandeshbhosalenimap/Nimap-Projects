using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Web;

namespace CategoryProduct.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }


        [Required]
        [Display(Name = "CategoryName")]
        public string CategoryName { get; set; }




        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; }   

        public List<Product> Products { get; set; } 
    }
}