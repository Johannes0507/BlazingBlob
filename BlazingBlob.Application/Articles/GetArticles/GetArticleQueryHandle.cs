using BlazingBlob.Domain.Articles;
using MediatR;

namespace BlazingBlob.Application.Articles.GetArticles
{
    public class GetArticleQueryHandle : IRequestHandler<GetArticlesQuery, List<Article>>
    {
        private readonly IArticleRepository _articleRepository;

        public GetArticleQueryHandle(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<List<Article>> Handle(GetArticlesQuery request, CancellationToken cancellationToken)
        {
            var articles = await _articleRepository.GetAllArticlesAsync();
            return articles;
        }
    }
}
