using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoAlfredo.Models
{
    public class ProductPurchase
    {

        [Key]
        public int IdProductPurchase { get; set; }
        public int IdProduct { get; set; } //Clave Foránea de Producto (Product)
        public int IdPurchase { get; set; } //Clave Foránea de Compra (Purchase)

        public virtual Purchase Purchase { get; set; }
        public virtual Product Product { get; set; }

    }
}