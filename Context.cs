using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI
{
    public class Context : DbContext
    {
        public DbSet<Products> ProductTable { get; set; }
        public Context(DbContextOptions options):base(options)
        {

        }
    }
}
