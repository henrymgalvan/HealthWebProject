using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HealthWebApp.Models;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Models.Person;

namespace HealthWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People {get; set;}
        public DbSet<Barangay> Barangay { get; set; }        
        public DbSet<HouseholdMember> HouseholdMember { get; set; }
        public DbSet<HouseholdProfile> HouseholdProfile { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        
        public DbSet<HealthWebApp.Models.Person.PersonCreateModel> PersonCreateModel { get; set; }
        
        public DbSet<HealthWebApp.Models.Person.PersonEditModel> PersonEditModel { get; set; }
    }
}
