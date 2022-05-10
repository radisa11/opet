using Microsoft.EntityFrameworkCore;

namespace opet.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        
        public DbSet<Music> Music {get;set;}
    }
}
