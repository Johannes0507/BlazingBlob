using BlazingBlob.Domain.Articles;
using Microsoft.EntityFrameworkCore;

namespace BlazingBlob.Infrastructure.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ApplicationDbContext _context;

        public ArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<List<Article>> GetAllArticlesAsync()
        {
            return _context.Articles.ToListAsync();
        }
    }
}
