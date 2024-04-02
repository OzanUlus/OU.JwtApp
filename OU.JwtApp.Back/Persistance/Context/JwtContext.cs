using Microsoft.EntityFrameworkCore;
using OU.JwtApp.Back.Core.Domain;
using System.Reflection;

namespace OU.JwtApp.Back.Persistance.Context
{
    public class JwtContext : DbContext
    {
        public JwtContext(DbContextOptions<JwtContext> options) : base(options)
        {

        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
       
    }
}
