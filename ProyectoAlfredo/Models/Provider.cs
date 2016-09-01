using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoAlfredo.Models
{
    public class Provider
    {

        [Key]
        public int IdProvider { get; set; }

        [Display(Name = "Proveedor")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string NameProvider { get; set; }

        [Display(Name = "Dirección")]
        public string AddressProvider { get; set; }

        [Display(Name = "Teléfono")]
        public int PhoneProvider { get; set; }

        public string EmailProvider { get; set; }

        public virtual ICollection<ProductProvider> Products { get; set; }


    }
}