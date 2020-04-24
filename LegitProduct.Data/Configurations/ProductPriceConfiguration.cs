using LegitProduct.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Configurations
{
    class ProductPriceConfiguration : IEntityTypeConfiguration<ProductPrice>
    {
        public void Configure(EntityTypeBuilder<ProductPrice> entity)
        {
            entity.ToTable("ProductPrices");

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

            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

            entity.Property(e => e.PriceSell).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.AttributeValueId1Navigation)
                .WithMany(p => p.ProductPricesAttributeValueId1Navigation)
                .HasForeignKey(d => d.AttributeValueId1)
                .HasConstraintName("FK_ProductPrices_AttributeValues2");

            entity.HasOne(d => d.AttributeValueId2Navigation)
                .WithMany(p => p.ProductPricesAttributeValueId2Navigation)
                .HasForeignKey(d => d.AttributeValueId2)
                .HasConstraintName("FK_ProductPrices_AttributeValues1");

            entity.HasOne(d => d.Product)
                .WithMany(p => p.ProductPrices)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductPrices_Products");
        }
    }
}
