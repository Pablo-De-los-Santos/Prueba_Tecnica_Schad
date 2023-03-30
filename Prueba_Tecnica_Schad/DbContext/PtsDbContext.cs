using Microsoft.EntityFrameworkCore;
using Prueba_Tecnica_Schad.Models;

namespace Prueba_Tecnica_Schad.Context
{
    public class PtsDbContext: DbContext
    {
        public PtsDbContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<CustomerTypes> CustomerTypes { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
