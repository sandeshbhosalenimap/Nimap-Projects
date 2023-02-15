using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CategoryProduct.Models
{
    public class Report
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string Description { get; set; }
        public int Prise { get; set; }

        public string ProductCreatedBy { get; set; }
        public string ProductName { get; set; }
    }
}