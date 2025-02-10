using Microsoft.Extensions.Logging;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace Presentation.Seedک
{
    public static class BodyDbInitializer
    {
        public static async Task SeedAsync(FitnessContext context)
        {
            var bodies = new List<Body>();
            if (!context.Bodies.Any())
            {
                bodies = new List<Body>
            {
                new Body { Id = 31, Name = "Arms"},
                new Body { Id = 31, Name = "Biceps"}, // عضلات دو سر
                new Body { Id = 32, Name = "Long Head Bicep", ParentId = 31 },
                new Body { Id = 34, Name = "Short Head Bicep", ParentId = 31 }, // سر کوتاه عضله بازو
                
                new Body { Id = 33, Name = "Triceps Brachii", ParentId = 31 },

                new Body { Id = 36, Name = "Forearms", ParentId = 31 },
                new Body { Id = 37, Name = "Wrist Extensors", ParentId = 31 },
                new Body { Id = 37, Name = "Wrist Flexors", ParentId = 31 },

                new Body { Id = 35, Name = "Hands"},

            };
                await context.Bodies.AddRangeAsync(bodies);
                await context.SaveChangesAsync();
            }
        }


//Biceps
//Long Head Bicep
//Short Head Bicep
//Traps(mid-back)
//Lower back
//Abdominals
//Lower Abdominals
//Upper Abdominals
//Calves
//Tibialis
//Soleus
//Gastrocnemius
//Forearms
//Wrist Extensors
//Wrist Flexors
//Glutes
//Gluteus Medius
//Gluteus Maximus
//Hamstrings
//Medial Hamstrings
//Lateral Hamstrings
//Lats
//Shoulders
//Lateral Deltoid
//Anterior Deltoid
//Posterior Deltoid
//Triceps
//Long Head Tricep
//Lateral Head Triceps
//Medial Head Triceps
//Traps
//Upper Traps
//Lower Traps
//Quads
//Inner Thigh
//Inner Quadriceps
//Outer Quadricep
//Rectus Femoris
//Chest
//Upper Pectoralis
//Mid and Lower Chest
//Obliques
//Hands
//Feet
//Front Shoulders
//Rear Shoulders
//Neck


    }
}
