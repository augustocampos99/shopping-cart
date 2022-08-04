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
    public class DeliveryAddressMap : IEntityTypeConfiguration<DeliveryAddress>
    {
        public void Configure(EntityTypeBuilder<DeliveryAddress> builder)
        {
            builder.ToTable("delivery_address");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Guid).HasColumnName("guid");
            builder.Property(e => e.Address).HasColumnName("address");
            builder.Property(e => e.PostCode).HasColumnName("post_code");
            builder.Property(e => e.Phone).HasColumnName("fone");
            builder.Property(e => e.Mail).HasColumnName("mail");
            builder.Property(e => e.UserId).HasColumnName("user_id");

            builder.HasOne(e => e.User)
                .WithOne(x => x.Address)
                .HasForeignKey<DeliveryAddress>(z => z.UserId);
        }
    }
}
