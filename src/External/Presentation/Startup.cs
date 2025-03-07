﻿using Microsoft.OpenApi.Models;

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
        services.AddHttpClient();
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

        var jwtConfig = Configuration.GetSection("Jwt");
        var secretKey = Encoding.UTF8.GetBytes(jwtConfig["Secret"]);

        services.AddInfrastructure(Configuration);
        services.AddHealthChecks().AddCheck("Ollama Server", () =>
            new HealthCheckResult(HealthStatus.Healthy, "Ollama server is running"));

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Fitness API", Version = "v1" });
        });
    }


    public async Task SeedData(FitnessContext dbContext)
    {
        //await BodyDbInitializer.BodySeedAsync(dbContext);
        //await EquipmentDbInitializer.EquipmentSeedAsync(dbContext);
        //await SportDbInitializer.SportSeedAsync(dbContext);
        await BicepsWorkoutDbInitializer.WorkoutSeedAsync(dbContext);
    }

    public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Fitness API V1");
                //c.RoutePrefix = string.Empty; // Sets Swagger UI at root (e.g., http://localhost:5000/)

            });
        }
        else
        {
            app.UseExceptionHandler("/error");
            app.UseHsts();
        }


        app.UseHttpsRedirection();
        app.UseRouting();

        using var scope = app.ApplicationServices.CreateScope();
        var services = scope.ServiceProvider;
        var dbContext = services.GetRequiredService<FitnessContext>();
        await SeedData(dbContext);

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }

}
