using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoAlfredo.Models
{
    public class ProductDetail: Product
    {

        [Required]
        public float Quantity { get; set; }

        public int Discount { get; set; }

        public decimal TotalDetail { get; set; }

    }
}