namespace BlazingBlob.Domain.Articles
{
    public interface IArticleRepository
    {
        public Task<List<Article>> GetAllArticlesAsync();
    }
}
