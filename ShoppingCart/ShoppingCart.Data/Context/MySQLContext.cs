using Microsoft.EntityFrameworkCore;
using ShoppingCart.Data.Mapping;
using ShoppingCart.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){ }
        public MySQLContext(){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        public virtual DbSet<User> Users { get; set; }

    }
}
