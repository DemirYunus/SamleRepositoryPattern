using Microsoft.EntityFrameworkCore;
using Sample.Entities.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sample.DataAccess.Configuration
{
    internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.ID_Product);
            builder.Property(x => x.Product_Name).IsRequired();
            builder.Property(x => x.Product_Name).HasColumnType("varchar(100)");
        }
    }
}
