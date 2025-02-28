using OllamaSharp;

namespace Infrastructure;

public static class DependencyInjection
{

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        //services.AddDbContext<FitnessContext>(options => 
        //{
        //    options.UseSqlServer(configuration.GetConnectionString("MsSql.FitnessDb")
        //    //ServiceLifetime.Scoped
        //    //b => b.MigrationsAssembly(typeof(DataContext).Assembly.FullName)
        //    );
        //});

        // General
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        
        services.AddScoped<IBodyRepository, BodyRepository>();
        services.AddScoped<IDiseaseRepository, DiseaseRepository>();
        services.AddScoped<IBodyFatRepository, BodyFatRepository>();

        // Plan
        services.AddScoped<IExerciseRepository, ExerciseRepository>();
        services.AddScoped<IMusclePriorityRepository, MusclePriorityRepository>();
        services.AddScoped<IPlanDaysRepository, PlanDaysRepository>();
        services.AddScoped<IPlanEquipmentRepository, PlanEquipmentRepository>();
        services.AddScoped<IPlanGoalsRepository, PlanGoalsRepository>();
        services.AddScoped<IPlanImgsRepository, PlanImgsRepository>();
        services.AddScoped<IPlanRepository, PlanRepository>();
        services.AddScoped<IPrePostExerciseRepository, PrePostExerciseRepository>();

        // User
        services.AddScoped<IAthleteImgsRepository, AthleteImgsRepository>();
        services.AddScoped<IAthleteInjuriesRepository, AthleteInjuriesRepository>();
        services.AddScoped<IAthleteRepository, AthleteRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

        // Workout
        services.AddScoped<IBodyWorkoutRepository, BodyWorkoutRepository>();
        services.AddScoped<IEquipmentRepository, EquipmentRepository>();
        services.AddScoped<ISportRepository, SportRepository>();
        services.AddScoped<IWorkoutAgeRangeRepository, WorkoutAgeRangeRepository>();
        services.AddScoped<IWorkoutEquipmentRepository, WorkoutEquipmentRepository>();
        services.AddScoped<IWorkoutInstructionRepository, WorkoutInstructionRepository>();
        services.AddScoped<IWorkoutLevelRepository, WorkoutLevelRepository>();
        services.AddScoped<IWorkoutRepository, WorkoutRepository>();
        services.AddScoped<IWorkoutSexRepository, WorkoutSexRepository>();

        //services.AddSingleton<IChatClient>(new OllamaChatClient(new
        //    Uri("http://localhost:11434/"), "llama3.1:latest"));

        services.AddSingleton<IOllamaApiClient>(new OllamaApiClient(new
            Uri("http://localhost:11434/"), "llama3.1:8b"));


        services.AddSingleton<OllamaResponseParser>();

        services.AddScoped<IChatService, OllamaChatService>();
        services.AddScoped<IPlanManagingService, PlanManagingService>();
        services.AddScoped<IFitnessPlanParser, FitnessPlanParser>();
        services.AddScoped<IPlanParser, PlanParserService>();

        services.AddSingleton<TextProcessor>();
        services.AddSingleton<AzureTextAnalyticsService>(provider =>
            new AzureTextAnalyticsService(
                config["AzureTextAnalytics:Endpoint"],
                config["AzureTextAnalytics:Key"]
            ));

        
        services.AddHttpClient("OllamaClient", client =>
        {
            client.BaseAddress = new Uri("http://localhost:11434");
            client.Timeout = TimeSpan.FromMinutes(30);
        });
        services.AddHttpClient<GrokAiService>();
        services.AddScoped<IGrokAiService, GrokAiService>();

        //services.AddTransient<,>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
