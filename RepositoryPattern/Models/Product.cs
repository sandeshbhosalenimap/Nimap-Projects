using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CategoryProduct.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }


        [Required]
        [Display(Name = "ProductName")]
        public string ProductName { get; set; }


        [Required]
        [Display(Name = "Prise")]
        public int Prise { get; set; }


        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        
        public int CategoryId { get; set; }


        [Required]
        [Display(Name = "ProductCreatedBy")]
        public string ProductCreatedBy { get; set; }    

    }
}