using LegitProduct.Data.Entities;
using LegitProduct.Data.ObjectEnums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
