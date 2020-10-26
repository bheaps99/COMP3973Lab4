using System;
using System.Collections.Generic;
using System.Text;
using CityProvince.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CityProvince.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }


    }
}
