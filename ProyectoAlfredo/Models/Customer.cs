using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoAlfredo.Models
{
    public class Customer
    {

        [Key]
        public int IdCustomer { get; set; }

        [Display(Name = "Cliente")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string CustomerName { get; set; }

        [Display(Name = "Dirección")]
        public string AddressCustomer { get; set; }

        [Display(Name = "Teléfono")]
        public int PhoneCustomer { get; set; }

        public string EmailCustomer { get; set; }

        public string CuitCuil { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }


    }
}