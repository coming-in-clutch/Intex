using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using IntexProject.Models;

namespace IntexProject.DAL
{
    public class NorthwestLabsContext : DbContext
    {

        public NorthwestLabsContext() : base("NorthwestLabsContext")
        {

        }

        public DbSet<Catalog> Catalogs { get; set; }

        public System.Data.Entity.DbSet<IntexProject.Models.WorkOrder> WorkOrders { get; set; }

        public System.Data.Entity.DbSet<IntexProject.Models.Orders> Orders { get; set; }
    }

}