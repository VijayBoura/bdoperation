using Microsoft.EntityFrameworkCore;
namespace dboperation.Data
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions<AppdbContext> options) : base(options) 
        { 
        
        
        }
    }
}
