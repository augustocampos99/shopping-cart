using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingCart.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("product");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Guid).HasColumnName("guid");
            builder.Property(e => e.Name).HasColumnName("name");
            builder.Property(e => e.Description).HasColumnName("description");
            builder.Property(e => e.Price).HasColumnName("price");
            builder.Property(e => e.quantity).HasColumnName("quantity");
        }
    }
}
