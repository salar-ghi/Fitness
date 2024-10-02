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

        services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<FitnessContext>()
            .AddDefaultTokenProviders();

        var jwtConfig = Configuration.GetSection("Jwt");
        var secretKey = Encoding.UTF8.GetBytes(jwtConfig["Secret"]);

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.RequireHttpsMetadata = true; // Set to false for development only
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(secretKey),
                ValidateIssuer = true,
                ValidIssuer = jwtConfig["Issuer"],
                ValidateAudience = true,
                ValidAudience = jwtConfig["FitnessPlan"],
            };
            options.Backchannel = services.BuildServiceProvider()
                .GetRequiredService<IHttpClientFactory>()
                .CreateClient("Proxy");
            options.Events = new JwtBearerEvents
            {
                OnMessageReceived = context =>
                {
                    var httpClientFactory = context.HttpContext.RequestServices.GetRequiredService<IHttpClientFactory>();
                    context.HttpContext.Items["Backchannel"] = httpClientFactory.CreateClient("Proxy");
                    return Task.CompletedTask;
                }
            };
        });

        services.AddInfrastructure();

        services.AddHttpClient("Proxy", client =>
        {
            client.BaseAddress = new Uri("https://your-proxy-url/");
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
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }

}
