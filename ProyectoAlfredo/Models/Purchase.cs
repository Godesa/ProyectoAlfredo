using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoAlfredo.Models
{
    public class Purchase
    {
        [Key]
        public int IdPurchase { get; set; }

        [Display(Name = "Fecha de Compra")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DatePurchase { get; set; }

        public int IdProvider { get; set; } //Clave Foránea de Proveedor (Provider)

        public virtual Provider Provider { get; set; }
        public virtual ICollection<ProductPurchase> Products { get; set; }


        [Display(Name = "Total")]
        public decimal TotalPurchase { get; set; }

    }
}