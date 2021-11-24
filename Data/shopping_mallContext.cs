using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shopping_mall.Models;

namespace shopping_mall.Data
{
    public class shopping_mallContext : DbContext
    {
        public shopping_mallContext (DbContextOptions<shopping_mallContext> options)
            : base(options)
        {
        }

        public DbSet<shopping_mall.Models.Product> Product { get; set; }
    }
}
