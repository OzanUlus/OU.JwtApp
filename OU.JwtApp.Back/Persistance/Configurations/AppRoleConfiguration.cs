using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OU.JwtApp.Back.Core.Domain;

namespace OU.JwtApp.Back.Persistance.Configurations
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.Property(ap => ap.Definition).HasMaxLength(50)
                                                 .IsRequired();
        }
    }
}
