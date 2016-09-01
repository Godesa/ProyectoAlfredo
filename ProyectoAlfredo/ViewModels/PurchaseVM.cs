using ProyectoAlfredo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoAlfredo.ViewModels
{
    public class PurchaseVM
    {
       
        public DateTime DatePurchase { get; set; }    

        public virtual Provider Provider { get; set; }

        public IList<ProductDetail> ProductDetails { get; set; }

        public decimal TotalPurchase { get; set; }

        

    }
}