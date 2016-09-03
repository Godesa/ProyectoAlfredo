using ProyectoAlfredo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlfredo.ViewModels
{
    class PurchaseVM
    {

        public int IdPurchase { get; set; }

        public Provider Provider { get; set; }

        public DateTime PurchaseDate { get; set; }

        public List<SaleLine> PurchaseLines { get; set; }

        public float PurchaseTotal { get; set; }

        public string Comments { get; set; }

    }
}
