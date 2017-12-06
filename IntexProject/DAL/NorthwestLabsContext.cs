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
   
    }

}