using LegitProduct.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Configurations
{
    public class ProductBranchConfiguration : IEntityTypeConfiguration<ProductBranch>
    {
        public void Configure(EntityTypeBuilder<ProductBranch> entity)
        {
            entity.HasKey(e => new { e.ProductId, e.BranchId });

            entity.ToTable("Product_Branches");

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

            entity.HasOne(d => d.Branch)
                .WithMany(p => p.ProductBranches)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Branches_Branches");

            entity.HasOne(d => d.Product)
                .WithMany(p => p.ProductBranches)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Branches_Products");
        }
    }
}
