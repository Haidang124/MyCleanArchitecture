using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Model.Agents;
using Microsoft.EntityFrameworkCore;

namespace MyCleanArchitecture.Infrastructure.Persistence.ConnectDatabase.Context
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext() { }
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {
        }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<ProductLine> ProductLines { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.ConfigureFLuentAPI();
        }
    }
}