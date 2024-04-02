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
        public DbSet<AppUser> AppUsers => this.Set<AppUser>();
       
        public DbSet<AppRole> AppRoles => this.Set<AppRole>();
        
        public DbSet<Product> Products => this.Set<Product>();
      
        public DbSet<Category> Categories => this.Set<Category>();
       

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
