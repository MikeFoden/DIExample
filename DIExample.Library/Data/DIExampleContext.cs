using DIExample.Library.Models;
using System.Data.Entity;

namespace DIExample.Library.Data
{
    public class DIExampleDbContext : DbContext
    {
        public DIExampleDbContext() : base("DIExampleDb") { }

        public DbSet<Product> Products { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductConfiguration());
        }
    }
}
