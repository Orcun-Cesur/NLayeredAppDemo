using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntitiyFramework
{
    public class NorthWindContext : DbContext
    {
        public NorthWindContext() : base("name=NorthWindContext")
        {
        }
        public DbSet<Products> Products { get; set; }
    }
}
