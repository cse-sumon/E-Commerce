using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repository
{
    public class ApplicationContext : IdentityDbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
                .Property(a => a.IsActive)
                .HasDefaultValue(1);

            //modelBuilder.Entity<Category>()
            //    .Property(c =>c.IsActive )
            //    .HasDefaultValue(1);

            //modelBuilder.Entity<Brand>()
            //    .Property(b => b.IsActive)
            //    .HasDefaultValue(1);
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        //public DbSet<Gender> Genders { get; set; }
        //public DbSet<Color> Colors { get; set; }
        //public DbSet<Brand> Bands { get; set; }
        //public DbSet<Category> Categories { get; set; }
    }
}
