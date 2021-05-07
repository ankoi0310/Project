using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;

namespace Project.Models
{
    public class Context : DbContext
    {
        private string connectionString;

        public Context() : base()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);

            var configuration = builder.Build();

            connectionString = configuration.GetConnectionString("MyConnection").ToString();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostCustomer>().HasKey(q => new { q.ID_Customer, q.ID_Post });
            modelBuilder.Entity<PrizeDetail>().HasKey(q => new { q.ID_Prize, q.ID_Competition });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCustomer> PostCustomers { get; set; }
        public DbSet<Prize> Prizes { get; set; }
        public DbSet<PrizeDetail> PrizeDetails { get; set; }
    }
}
