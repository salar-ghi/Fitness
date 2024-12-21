using Infrastructure.Services;
using Microsoft.Extensions.AI;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
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
        
        // Exercise
        services.AddScoped<IExerciseRepository, ExerciseRepository>();
        services.AddScoped<IMusclePriorityRepository, MusclePriorityRepository>();
        services.AddScoped<IPlanDaysRepository, PlanDaysRepository>();
        services.AddScoped<IPlanImgsRepository, PlanImgsRepository>();
        services.AddScoped<IPlanRepository, PlanRepository>();

        // User
        services.AddScoped<IAthleteImgsRepository, AthleteImgsRepository>();
        services.AddScoped<IAthleteInjuriesRepository, AthleteInjuriesRepository>();
        services.AddScoped<IAthleteRepository, AthleteRepository>();
        services.AddScoped<IDiseaseRepository, DiseaseRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

        // Workout
        services.AddScoped<IWorkoutAgeRangeRepository, WorkoutAgeRangeRepository>();
        services.AddScoped<IBodyRepository, BodyRepository>();
        services.AddScoped<IBodyWorkoutRepository, BodyWorkoutRepository>();
        services.AddScoped<IEquipmentRepository, EquipmentRepository>();
        services.AddScoped<IWorkoutLevelRepository, WorkoutLevelRepository>();
        services.AddScoped<ISportRepository, SportRepository>();
        services.AddScoped<IWorkoutEquipmentRepository, WorkoutEquipmentRepository>();
        services.AddScoped<IWorkoutRepository, WorkoutRepository>();

        services.AddSingleton<IChatClient>(new OllamaChatClient(new
            Uri("http://localhost:11434/"), "llama3.2"));

        services.AddSingleton<OllamaResponseParser>();

        services.AddScoped<IChatService, OllamaChatService>();


        //services.AddTransient<,>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}
