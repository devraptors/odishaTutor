
using Microsoft.EntityFrameworkCore;

namespace OdishaAPP.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}
       
    }
}