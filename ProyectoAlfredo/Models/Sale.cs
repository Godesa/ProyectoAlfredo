using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoAlfredo.Models
{
    public class Sale
    {

        [Key]
        public int IdSale { get; set; }

        [Display(Name = "Fecha de Venta")]        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime SaleDate { get; set; }

        [Display(Name = "Fecha de Carga")]       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime UploadDate { get; set; }

        public int IdCustomer { get; set; } //Clave Foránea de Cliente (Customer)
        public virtual Customer Customer { get; set; }

        public virtual ICollection<ProductSale> Products { get; set; }

        [Display(Name = "Total")]
        public float TotalSale { get; set; }

    }
}