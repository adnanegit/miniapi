using miniapi.core;
using miniapi.core.Database;

namespace miniapi.Extensions
{
    public static class ServiceExtensions
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddGraphQLServer()
                .AddQueryType<Query>();
        }
    }
}
