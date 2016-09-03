using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoAlfredo.Context
{
    public class AlfredoContext : DbContext
    {
        public System.Data.Entity.DbSet<ProyectoAlfredo.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<ProyectoAlfredo.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<ProyectoAlfredo.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<ProyectoAlfredo.Models.Sale> Sales { get; set; }

        public System.Data.Entity.DbSet<ProyectoAlfredo.Models.SaleLine> SaleLines { get; set; }
    }
}