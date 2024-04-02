using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OU.JwtApp.Back.Core.Domain;

namespace OU.JwtApp.Back.Persistance.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(50)
                                         .IsRequired();

            builder.Property(p => p.Stock).IsRequired();

            builder.Property(p => p.Price).HasPrecision(18,2);

            builder.HasOne(p => p.Category)
                   .WithMany(p => p.Products)
                   .HasForeignKey(p => p.CategoryId);
        }
    }
}
