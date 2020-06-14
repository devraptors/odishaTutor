
using Infra;
using Infra.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace OdishaAPP.API
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){
               }
        public DbSet<Product> Products {get;set;}

        public DbSet<ProductBand> ProductBands { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

      public DbSet<ProductCategories> ProductCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    //     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    // TODO GitHubIssue#57: Complete EF7 to EDM model mapping
    //    // Seems for now EF7 can't support named connection string like "name=NorthwindConnection",
    //    // find an equivalent approach when it's ready.
    //    optionsBuilder.UseSqlServer(@"data source=(localdb)\\mssqllocaldb;Database=myStoreNewDB;Trusted_Connection=True;MultipleActiveResultSets=true");

    //    base.OnConfiguring(optionsBuilder);
    //}

    }
   
}