namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<FitnessContext>(options => 
        {
            options.UseSqlServer(configuration.GetConnectionString("MsSql.FitnessDb")
            //ServiceLifetime.Scoped
            //b => b.MigrationsAssembly(typeof(DataContext).Assembly.FullName)
            );
        });

        //services.AddTransient<,>();

        return services;
    }
}
