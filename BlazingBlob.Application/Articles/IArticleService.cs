using BlazingBlob.Domain.Articles;
namespace BlazingBlob.Application.Articles
{
    public interface IArticleService
    {
        public Task<List<Article>> GetAllArticlesAsync();
    }
}
