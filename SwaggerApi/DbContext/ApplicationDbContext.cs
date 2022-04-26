using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SwaggerApi.IdentityAuth;
using SwaggerApi.Models;

namespace SwaggerApi.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<RestaurantModel> Restaurants { get; set; }
        public DbSet<MenuModel> Menus { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>(entity => entity.Property(m => m.NormalizedEmail).HasMaxLength(200));
            modelBuilder.Entity<ApplicationUser>(entity => entity.Property(m => m.Id).HasMaxLength(200));
            modelBuilder.Entity<ApplicationUser>(entity => entity.Property(m => m.NormalizedUserName).HasMaxLength(200));


            modelBuilder.Entity<IdentityRole>(entity => entity.Property(m => m.NormalizedName).HasMaxLength(200));
            modelBuilder.Entity<IdentityRole>(entity => entity.Property(m => m.Id).HasMaxLength(200));


            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(200));
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(200));
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.ProviderKey).HasMaxLength(200));


            modelBuilder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(200));
            modelBuilder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(200));


            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(200));
            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(200));
            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.Name).HasMaxLength(200));

            modelBuilder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(200));
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(200));

            base.OnModelCreating(modelBuilder);
        }
    }
}
