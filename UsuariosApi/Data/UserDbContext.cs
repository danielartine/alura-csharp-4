using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using UsuariosApi.Models;

namespace UsuariosApi.Data
{
    public class UserDbContext : IdentityDbContext<CustomIdentityUser, IdentityRole<int>, int>
    {

        public UserDbContext(DbContextOptions<UserDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            IdentityUser<int> admin = new CustomIdentityUser()
            {
                Id = 99999,
                UserName = "admin",
                Email = "admin@admin.com",
                EmailConfirmed = true,
                NormalizedEmail = "ADMIN@ADMIN.COM",
                NormalizedUserName = "ADMIN",
                SecurityStamp = Guid.NewGuid().ToString(),
                DataNascimento = DateTime.Parse("1000-01-01T00:00:00")
            };

            PasswordHasher<IdentityUser<int>> passwordHasher = new PasswordHasher<IdentityUser<int>>();
            admin.PasswordHash = passwordHasher.HashPassword(admin, "Admin123!");

            builder.Entity<CustomIdentityUser>().HasData(admin);

            builder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int>() { Id = 99999, Name = "admin", NormalizedName = "ADMIN" }
                );

            builder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int>() { Id = 99998, Name = "regular", NormalizedName = "REGULAR" }
                );

            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int>() { RoleId = 99999, UserId = 99999 }
                );
        }
    }

}