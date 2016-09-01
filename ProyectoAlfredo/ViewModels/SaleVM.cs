using ProyectoAlfredo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoAlfredo.ViewModels
{
    public class SaleVM
    {

        public DateTime DateSale { get; set; }

        public virtual Customer Customer { get; set; }

        public IList<ProductDetail> ProductDetails { get; set; }

        public decimal TotalSale { get; set; }
    }
}