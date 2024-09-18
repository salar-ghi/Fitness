namespace Presentation;

public class Startup
{
    public IConfiguration Configuration { get; }
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public async void ConfigureServices(IServiceCollection services)
    {
        //services.AddExceptionHandler<GlobalErrorHandler>();
        services.AddProblemDetails();

        var connectionString = Configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<FitnessContext>(options =>
        {
            options.UseSqlServer(connectionString,
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 3,
                        maxRetryDelay: TimeSpan.FromMilliseconds(10),
                        errorNumbersToAdd: null);
                });
            options.EnableThreadSafetyChecks(true);
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });


        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }

    public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }


        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }

}
