using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using DB_codeFirst.Confugurations;
using DB_codeFirst.DbModels;

namespace DB_codeFirst
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Office> Office { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Title> Title { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<EmployeeProject> EmployeeProjects { get; set; }

        public DbSet<Client> Client { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OfficeConfuguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfuguration());
            modelBuilder.ApplyConfiguration(new TitleConfuguration());
            modelBuilder.ApplyConfiguration(new ProjectConfuguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfuguration());
            modelBuilder.ApplyConfiguration(new ClientConfuguration());
        }
    }
}
