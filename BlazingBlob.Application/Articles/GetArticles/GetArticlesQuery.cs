using BlazingBlob.Domain.Articles;
using MediatR;

namespace BlazingBlob.Application.Articles.GetArticles
{
    public class GetArticlesQuery : IRequest<List<Article>>
    {

    }
}
