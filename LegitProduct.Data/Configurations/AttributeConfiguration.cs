using LegitProduct.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Attribute = LegitProduct.Data.Entities.Attribute;

namespace LegitProduct.Data.Configurations
{
    class AttributeConfiguration : IEntityTypeConfiguration<Attribute>
    {
        public void Configure(EntityTypeBuilder<Attribute> entity)
        {
            entity.ToTable("Attributes");

            entity.Property(e => e.CreatedUserId)
                   .IsRequired()
                   .HasMaxLength(25)
                   .HasDefaultValueSql("('')");

            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.DateDeleted).HasColumnType("datetime");

            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name).HasMaxLength(250);

            entity.HasOne(d => d.Product)
                .WithMany(p => p.Attributes)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attributes_Products");
        }
    }
}
