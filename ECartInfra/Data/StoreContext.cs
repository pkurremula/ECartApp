using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECartCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECartInfra.Data
{
    public class StoreContext : DbContext
    {


        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products{set; get;}

        
    }
}