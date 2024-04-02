using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OU.JwtApp.Back.Core.Domain;

namespace OU.JwtApp.Back.Persistance.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Definition).HasMaxLength(50)
                                               .IsRequired();
        }
    }
}
