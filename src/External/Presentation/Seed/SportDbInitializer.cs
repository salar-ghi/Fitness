namespace Presentation.Seed;

public static class SportDbInitializer
{
    public static async Task SportSeedAsync(FitnessContext context)
    {
        var sports = new List<Sport>();
        if (!await context.Sports.AnyAsync())
        {
            //using var transactions = await context.Database.BeginTransactionAsync();
            sports = new List<Sport>
            {
                new Sport{ Name = "Body Building",},
                new Sport{ Name = "Cross Fit",},
                new Sport{ Name = "Cardio",},
                new Sport{ Name = "Yoga",},
            };
            await context.Sports.AddRangeAsync(sports);
            await context.SaveChangesAsync();

            //await transactions.CommitAsync();
        };
    }

}
