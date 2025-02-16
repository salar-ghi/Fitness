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



                new Body { Id = 34, Name = "Lower Abdominals", ParentId = 31 },
                new Body { Id = 34, Name = "Upper Abdominals", ParentId = 31 },
                

                new Body { Id = 33, Name = "Calves", ParentId = 31 },
                new Body { Id = 33, Name = "Tibialis", ParentId = 31 },
                new Body { Id = 33, Name = "Soleus", ParentId = 31 },
                new Body { Id = 33, Name = "Gastrocnemius", ParentId = 31 },

                new Body { Id = 36, Name = "Forearms", ParentId = 31 },
                new Body { Id = 37, Name = "Wrist Extensors", ParentId = 31 },
                new Body { Id = 37, Name = "Wrist Flexors", ParentId = 31 },


                new Body { Id = 33, Name = "Glutes", ParentId = 31 },
                new Body { Id = 33, Name = "Gluteus Medius", ParentId = 31 },
                new Body { Id = 33, Name = "Gluteus Maximus", ParentId = 31 },
                new Body { Id = 33, Name = "Hamstrings", ParentId = 31 },
                new Body { Id = 33, Name = "Medial Hamstrings", ParentId = 31 },
                new Body { Id = 33, Name = "Lateral Hamstrings", ParentId = 31 },
                new Body { Id = 33, Name = "Lats", ParentId = 31 },

                new Body { Id = 33, Name = "Shoulders", ParentId = 31 },
                new Body { Id = 33, Name = "Lateral Deltoid", ParentId = 31 },
                new Body { Id = 33, Name = "Anterior Deltoid", ParentId = 31 },
                new Body { Id = 33, Name = "Posterior Deltoid", ParentId = 31 },
                
                new Body { Id = 33, Name = "Triceps", ParentId = 31 },
                new Body { Id = 33, Name = "Long Head Tricep", ParentId = 31 },
                new Body { Id = 33, Name = "Lateral Head Triceps", ParentId = 31 },
                new Body { Id = 33, Name = "Medial Head Triceps", ParentId = 31 },

                new Body { Id = 35, Name = "Traps"},
                new Body { Id = 35, Name = "Upper Traps"},
                new Body { Id = 34, Name = "Traps(mid-back)", ParentId = 31 },
                new Body { Id = 34, Name = "Lower back", ParentId = 31 },
                new Body { Id = 35, Name = "Lower Traps"},

                
                new Body { Id = 35, Name = "Quads"},
                new Body { Id = 35, Name = "Inner Quadriceps"},
                new Body { Id = 35, Name = "Outer Quadricep"},
                
                new Body { Id = 35, Name = "Rectus Femoris"},
                new Body { Id = 35, Name = "Chest"},
                new Body { Id = 35, Name = "Upper Pectoralis"},
                new Body { Id = 35, Name = "Mid and Lower Chest"},

                new Body { Id = 35, Name = "Obliques"},
                new Body { Id = 35, Name = "Hands"},
                new Body { Id = 35, Name = "Feet"},
                new Body { Id = 35, Name = "Front Shoulders"},

                new Body { Id = 35, Name = "Rear Shoulders"},
                new Body { Id = 35, Name = "Neck"},

            };
                await context.Bodies.AddRangeAsync(bodies);
                await context.SaveChangesAsync();
            }
        }


    }
}
