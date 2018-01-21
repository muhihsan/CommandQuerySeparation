using Microsoft.AspNetCore.Http;

namespace CommandQuerySeparation.Queries
{
    sealed class QueryProcessor : IQueryProcessor
    {
        private readonly HttpContext _httpContext;

        public QueryProcessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContext = httpContextAccessor.HttpContext;
        }
        
        public TResult Process<TResult>(IQuery<TResult> query)
        {
            var handlerType =
                typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));

            dynamic handler = _httpContext.RequestServices.GetService(handlerType);

            return handler.Handle((dynamic)query);
        }
    }
}
