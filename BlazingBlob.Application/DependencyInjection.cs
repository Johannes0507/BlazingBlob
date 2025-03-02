using BlazingBlob.Application.Articles;
using Microsoft.Extensions.DependencyInjection;

namespace BlazingBlob.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IArticleService, ArticleService>();
            return services;
        }
    }
}
