using System.Threading.Tasks;
using Microsoft.Azure.KeyVault.Models;

namespace DBRepository.Repositories
{
    public class BlogRepository : BaseRepository, IBlogRepository
    {
        public BlogRepository(string connectionString, IRepositoryContextFactory contextFactory) 
            : base(connectionString, contextFactory) { }
        
    }
}