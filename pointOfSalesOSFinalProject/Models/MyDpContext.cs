using Microsoft.EntityFrameworkCore;
using pointOfSalesFinalProjectsEntities.Models;

namespace pointOfSalesOSFinalProject.Models
{
    public class MyDpContext:DbContext
    {
        public MyDpContext(DbContextOptions<MyDpContext> options) : base(options) { 
        
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Prouducts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
