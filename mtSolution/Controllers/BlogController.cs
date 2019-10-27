using DBRepository;
using Microsoft.AspNetCore.Mvc;

namespace mtSolution.Controllers
{
    [Route("api/[controller]")]
    public class BlogController
    {
        IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
    }
}