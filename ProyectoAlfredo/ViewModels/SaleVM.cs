using ProyectoAlfredo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlfredo.ViewModels
{
    public class SaleVM
    {

        public int IdSale { get; set; }

        public Customer Customer { get; set; }        

        public DateTime SaleDate { get; set; }

        public List<SaleLine> SaleLines { get; set; }
        
        public float SaleTotal { get; set; }

        public string Comments { get; set; }
        
    }
}
