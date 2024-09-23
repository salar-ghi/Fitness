using Domain.Models;

namespace Presentation.Seed;

public static class DbInitializer
{
    public static async Task SeedAsync(FitnessContext context)
    {
        if (!context.Bodies.Any())
        {
            var bodies = new List<Body>
            {
                // Chest
                //new Body { BodyPartId = 10, Name = "Torso" },
                new Body { BodyPartId = 11, Name = "Chest", Parent = 10 },
                new Body { BodyPartId = 12, Name = "Pectoralis Major", Parent = 11 },
                new Body { BodyPartId = 13, Name = "Pectoralis Minor", Parent = 12 },

                // Back
                new Body { BodyPartId = 20, Name = "Back", Parent = 10, ImgUrl = "" },
                new Body { BodyPartId = 21, Name = "Lower Back", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 22, Name = "Upper Back", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 22, Name = "Latissimus Dorsi (Lats)", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 22, Name = "Trapezius (Traps)", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 22, Name = "Rhomboids", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 22, Name = "Erector Spinae", Parent = 6, ImgUrl = "" },

                // Shoulders
                new Body { BodyPartId = 30 , Name = "Shoulders", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 30 , Name = "", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 30 , Name = "Anterior Deltoids", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 30 , Name = "Lateral Deltoids", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 30 , Name = "Posterior Deltoids", Parent = 6, ImgUrl = "" },

                // Arms
                new Body { BodyPartId = 40, Name = "Arms And Hands", ImgUrl = "" },
                new Body { BodyPartId = 41, Name = "Biceps Brachii", ImgUrl = "" },
                new Body { BodyPartId = 42, Name = "Triceps Brachii", ImgUrl = "" },
                new Body { BodyPartId = 43, Name = "Brachialis (Lower Biceps)", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 44, Name = "Forearm Muscles", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 45, Name = "Wrists", ImgUrl = "" },
                new Body { BodyPartId = 46, Name = "", ImgUrl = "" },

                // Abdominals
                new Body { BodyPartId = 60, Name = "Abdominals", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 60, Name = "Rectus Abdominis", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 60, Name = "Internal Obliques", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 60, Name = "External Obliques", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 60, Name = "Core", Parent = 6, ImgUrl = "" },

                // Legs
                new Body { BodyPartId = 70 , Name = "Legs", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 70 , Name = "Quadriceps", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 70 , Name = "Hamstrings", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 70 , Name = "Gluteus Maximus", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 70 , Name = "Gluteus Medius", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 70 , Name = "Gluteus Minimus", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 70 , Name = "Calves", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 70 , Name = "Gastrocnemius Calves", Parent = 6, ImgUrl = "" },
                new Body { BodyPartId = 70 , Name = "Soleus Calves", Parent = 6, ImgUrl = "" },
            };

            await context.Bodies.AddRangeAsync(bodies);
            await context.SaveChangesAsync();
        }
    }


    // Chest
    // Forearms
    // Lats
    // Middle Back
    // Lower Back
    // Neck
    // Quadriceps
    // Hamstrings

    // Calves
    // Traps

    // Shoulders
    // Abdominals
    // Glutes
    // Biceps
    // Adductors
    // Abductors

}
