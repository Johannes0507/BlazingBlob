using BlazingBlob.Application.Articles;
using Microsoft.Extensions.DependencyInjection;

namespace BlazingBlob.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                // Automatically register all handlers from the assembly of the specified type
                configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
            });

            return services;
        }
    }
}
