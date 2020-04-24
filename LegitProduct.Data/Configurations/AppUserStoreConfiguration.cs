using LegitProduct.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Configurations
{
    public class AppUserStoreConfiguration : IEntityTypeConfiguration<AppUserStore>
    {
        public void Configure(EntityTypeBuilder<AppUserStore> entity)
        {
            entity.ToTable("AppUserStores");

            entity.HasKey(e => new { e.StoreId, e.AppUserId });

            entity.ToTable("AppUser_Stores");

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

            entity.HasOne(d => d.AppUser)
                .WithMany(p => p.AppUserStores)
                .HasForeignKey(d => d.AppUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppUser_Stores_AppUsers");

            entity.HasOne(d => d.Store)
                .WithMany(p => p.AppUserStores)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppUser_Stores_Stores");
        }
    }

}
