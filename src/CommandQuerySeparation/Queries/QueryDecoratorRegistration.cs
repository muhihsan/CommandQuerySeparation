using CommandQuerySeparation.Queries.Decorators;
using Microsoft.Extensions.DependencyInjection;

namespace CommandQuerySeparation.Queries
{
    public static class QueryDecoratorRegistration
    {
        public static IServiceCollection RegisterQueryDecorator<TQueryHandler, TQuery, TResult>(
            this IServiceCollection services)
            where TQuery : IQuery<TResult>
            where TQueryHandler : class, IQueryHandler<TQuery, TResult>
        {
            services.AddScoped<TQueryHandler>();
            services.AddScoped<IQueryHandler<TQuery, TResult>>(x => 
                new ValidationQueryHandlerDecorator<TQuery, TResult>(x.GetService<TQueryHandler>()));

            return services;
        }
    }
}
