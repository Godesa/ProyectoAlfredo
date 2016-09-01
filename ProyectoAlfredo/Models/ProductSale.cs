using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoAlfredo.Models
{
    public class ProductSale
    {

        [Key]
        public int IdProductSale { get; set; }
        public int IdProduct { get; set; } //Clave Foránea Producto (Product)
        public int IdSale { get; set; } //Clave Foránea Venta (Sale)

        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }

    }
}