using System.Data.Entity;

namespace profilecf.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<User> Users { get; set; }
    }
}
