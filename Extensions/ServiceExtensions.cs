using miniapi.core;

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
