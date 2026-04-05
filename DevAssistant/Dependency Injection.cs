namespace DevAssistant
{
    public static class Dependency_Injection
    {
        public static IServiceCollection SwaggerServices(this IServiceCollection services)
        {
            services.AddSwaggerGen();
            return services;
        }
    }
}
