using Microsoft.EntityFrameworkCore;
using Models;

namespace DBRepository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }
        
        public DbSet<User> Users { get; set; }
    }
}