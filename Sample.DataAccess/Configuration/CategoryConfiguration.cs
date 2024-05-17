using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Entities;
using Sample.Entities.Model;

namespace Sample.DataAccess.Configuration
{
    internal sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
           builder.ToTable("Category");
            builder.HasKey(x => x.ID_Category);
            builder.Property(x=>x.Category_Name).IsRequired();
            builder.Property(x => x.Category_Name).HasColumnType("varchar(100)");
        }
    }
}
