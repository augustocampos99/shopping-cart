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
    public class CartMap : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("cart");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Guid).HasColumnName("guid");
            builder.Property(e => e.Note).HasColumnName("note");
            builder.Property(e => e.DeliveryAddressId).HasColumnName("delivery_address_id");
            builder.Property(e => e.UserId).HasColumnName("user_id");
            builder.Property(e => e.CreatedAt).HasColumnName("created_at");
            builder.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            builder.Property(e => e.Status).HasColumnName("status");

            builder.HasMany(e => e.Items)
                .WithOne(x => x.Cart)
                .HasForeignKey(e => e.CartId)
                .OnDelete(DeleteBehavior.Cascade); ;
        }
    }
}
