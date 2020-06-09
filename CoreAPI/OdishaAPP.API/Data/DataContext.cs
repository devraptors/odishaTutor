
using Microsoft.EntityFrameworkCore;
using OdishaAPP.API.Models;
using OdishaAPP.API.Entities;
namespace OdishaAPP.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}
        public DbSet<Product> Products {get;set;}
       
    }
}