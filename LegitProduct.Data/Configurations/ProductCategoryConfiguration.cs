using LegitProduct.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> entity)
        {
            entity.ToTable("ProductCategories");

            entity.HasKey(e => new { e.CategoryId, e.ProductId });

            entity.ToTable("Product_Categories");

            entity.HasIndex(e => e.ProductId);

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

            entity.HasOne(d => d.Category)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(d => d.ProductId);
        }
    }
}
