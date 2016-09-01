using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoAlfredo.Models
{
    public class ProductProvider
    {

        [Key]
        public int IdProductProvider { get; set; }
        public int IdProduct { get; set; } //Clave Foránea de Producto (Product)
        public int IdProvider { get; set; } //Clave Foránea de Proveedor (Provider)

        public virtual Product Product { get; set; }
        public virtual Provider Provider { get; set; }

    }
}