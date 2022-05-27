using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models.Agents;
using Infrastructure.Data.Persistence.Models.Blogs;
using Infrastructure.Data.Persistence.Models.Chats;
using Infrastructure.Data.Persistence.Models.Orders;
using Infrastructure.Data.Persistence.Models.Payments;
using Infrastructure.Data.Persistence.Models.Products;
using Infrastructure.Data.Persistence.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyCleanArchitecture.Infrastructure.Persistence.ConnectDatabase.Context
{
    public class EcommerceDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public EcommerceDbContext() { }
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {
        }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<ProductLine> ProductLines { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<AgentProduct> AgentProducts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryBlog> CategoryBlogs { get; set; }
        public DbSet<WishList> Wishlists { get; set; }
        public DbSet<Chat> Chats { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entity.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    modelBuilder.Entity(entity.Name).ToTable(tableName.Substring(6));
                }
            }
            // modelBuilder.ConfigureFLuentAPI();
        }
    }
}