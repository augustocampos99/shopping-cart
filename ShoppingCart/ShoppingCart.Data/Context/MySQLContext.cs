using Microsoft.EntityFrameworkCore;
using ShoppingCart.Data.Mapping;
using ShoppingCart.Domain.Entity;

namespace ShoppingCart.Data.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){ }
        public MySQLContext(){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new CartMap());
            modelBuilder.ApplyConfiguration(new CartItemMap());
            modelBuilder.ApplyConfiguration(new DeliveryAddressMap());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<DeliveryAddress> DeliveryAddress { get; set; }
    }
}
