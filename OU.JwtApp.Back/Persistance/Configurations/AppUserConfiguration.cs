using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OU.JwtApp.Back.Core.Domain;

namespace OU.JwtApp.Back.Persistance.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(au => au.UserName).HasMaxLength(50)
                                               .IsRequired();

            builder.HasOne(au => au.AppRole)
                   .WithMany(au => au.AppUsers)
                   .HasForeignKey(au => au.AppRoleId);

           
        }
    }
}
