using Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.Metrics;

namespace Presentation.Seed;

// Workout Strategies
// 1- Supersets: Pair floor presses with other exercises like push-ups or overhead presses for increased intensity and muscle fatigue.
// 2- Drop Sets: After reaching failure with a heavier weight, immediately reduce the weight and continue until failure again.
// 3- Pyramid Sets: Gradually increase weight with each set until reaching a peak, then decrease back down for added volume.
// 4- Cluster Sets: Perform multiple mini-sets with short rest periods in between to maximize muscle engagement and strength gains.
// 5- Countdown Sets: Perform a set number of reps followed by isometric holds (e.g., 5 reps followed by a 5-second hold) to increase endurance and strength.

public static class DbInitializer
{
    public static async Task SeedAsync(FitnessContext context)
    {
        var bodies = new List<Body>();
        if (!context.Bodies.Any())
        {
            bodies = new List<Body>
            {
                // Chest
                //new Body { BodyPartId = 10, Name = "Torso" },
                new Body { Id = 1, Name = "Chest" },
                new Body { Id = 2, Name = "Pectoralis Major", ParentId = 1 },
                new Body { Id = 3, Name = "Pectoralis Minor", ParentId = 1 },

                // Back
                new Body { Id = 11, Name = "Back"},
                new Body { Id = 12, Name = "Upper Back", ParentId = 11 },
                new Body { Id = 13, Name = "Middle Back", ParentId = 11 },
                new Body { Id = 14, Name = "Lower Back", ParentId = 11 },
                new Body { Id = 15, Name = "Latissimus Dorsi (Lats)", ParentId = 11 },
                new Body { Id = 16, Name = "Trapezius (Traps)", ParentId = 11 },
                new Body { Id = 17, Name = "Rhomboids", ParentId = 11 },
                new Body { Id = 18, Name = "Erector Spinae", ParentId = 11 },

                // Shoulders
                new Body { Id = 21, Name = "Shoulders" },
                new Body { Id = 22, Name = "Anterior Deltoids", ParentId = 21 },
                new Body { Id = 23, Name = "Lateral Deltoids", ParentId = 21 },
                new Body { Id = 24, Name = "Posterior Deltoids", ParentId = 21 },

                // Arms
                new Body { Id = 31, Name = "Arms And Hands"},
                new Body { Id = 32, Name = "Biceps Brachii", ParentId = 31 },
                new Body { Id = 33, Name = "Triceps Brachii", ParentId = 31 },
                new Body { Id = 34, Name = "Brachialis (Lower Biceps)", ParentId = 31 },
                new Body { Id = 35, Name = "Forearm", ParentId = 31 },
                new Body { Id = 36, Name = "Wrists", ParentId = 31 },

                // Abdominals
                new Body { Id = 41, Name = "Abdominals" },
                new Body { Id = 42, Name = "Rectus Abdominis", ParentId = 41 },
                new Body { Id = 43, Name = "Internal Obliques", ParentId = 41 },
                new Body { Id = 44, Name = "External Obliques", ParentId = 41 },
                new Body { Id = 45, Name = "Core", ParentId = 41 },

                // Legs
                new Body { Id = 51, Name = "Legs" },
                new Body { Id = 52, Name = "Quadriceps", ParentId = 51 },
                new Body { Id = 53, Name = "Hamstrings", ParentId = 51 },
                new Body { Id = 54, Name = "Gluteus Maximus", ParentId = 51 },
                new Body { Id = 55, Name = "Gluteus Medius", ParentId = 51 },
                new Body { Id = 56, Name = "Gluteus Minimus", ParentId = 51 },
                new Body { Id = 57, Name = "Calves", ParentId = 51 },
                new Body { Id = 58, Name = "Gastrocnemius Calves", ParentId = 51 },
                new Body { Id = 59, Name = "Soleus Calves", ParentId = 51 },
            };
            await context.Bodies.AddRangeAsync(bodies);
            await context.SaveChangesAsync();
        }

        var equipments = new List<Equipment>();
        if (!context.Equipments.Any())
        {
            equipments = new List<Equipment>
            {
                // None

                // Index => 0
                new Equipment { Name = "Body Only", EquipmentType = EquipmentType.Body, Description= "" }, 

                // Free Weights
                // Index => 1
                new Equipment { Name = "Dumbells", EquipmentType = EquipmentType.Machine, Description= "Versatile weights for various exercises targeting multiple muscle groups"},
                // Index => 2
                new Equipment { Name = "Barbells", EquipmentType = EquipmentType.Machine, Description= "Long bars used for heavy lifting, ideal for compound movements"},
                // Index => 3
                new Equipment { Name = "KettleBells", EquipmentType = EquipmentType.Machine, Description= "Cast iron weights used for dynamic exercises that combine strength and cardio"},

                // Machines
                //new Equipment { Name = "Machine", EquipmentType = EquipmentType.Machine},
                // Index => 4
                new Equipment { Name = "Smith Machine", EquipmentType = EquipmentType.Machine, Description= "A barbell fixed within steel rails, providing stability for various lifts"},
                // Index => 5
                new Equipment { Name = "Leg Press Machine", EquipmentType = EquipmentType.Machine, Description= "Targets the quadriceps, hamstrings, and glutes"},
                // Index => 6
                new Equipment { Name = "Chest Press Machine", EquipmentType = EquipmentType.Machine, Description= "Focuses on the chest muscles with guided movements"},
                // Index => 7
                new Equipment { Name = "Lat Pulldown Machine", EquipmentType = EquipmentType.Machine, Description= "Targets the latissimus dorsi muscles in the back"},
                // Index => 8
                new Equipment { Name = "Leg Curl Machine", EquipmentType = EquipmentType.Machine, Description= "Isolates the hamstrings for targeted strengthening"},
                // Index => 9
                new Equipment { Name = "Leg Extension Machine", EquipmentType = EquipmentType.Machine, Description= "Focuses on the quadriceps"},
                // Index => 10
                new Equipment { Name = "Cable Machine", EquipmentType = EquipmentType.Machine, Description= "Versatile machines that allow for a wide range of exercises using adjustable cables"},

                // Index => 11
                new Equipment { Name = "Bench Press", EquipmentType = EquipmentType.Machine, Description = " Performed lying on a bench, allowing for a full range of motion as the barbell can descend below the chest level"},                
                // Index => 12
                new Equipment { Name = "Floor Press", EquipmentType = EquipmentType.Machine, Description = "Executed lying on the floor, which limits the range of motion since the elbows stop descending when they touch the ground"},

                // Cardiovascular Equipment
                new Equipment { Name = "Treadmill", EquipmentType = EquipmentType.Equipment, Description= "Ideal for running or walking to improve cardiovascular fitness"},
                new Equipment { Name = "Rowing Machine", EquipmentType = EquipmentType.Equipment, Description= "Provides a full-body workout simulating rowing motions"},
                new Equipment { Name = "stationary Bike", EquipmentType = EquipmentType.Equipment, Description= "Great for low-impact cardiovascular workouts"},
                new Equipment { Name = "Stair Climber", EquipmentType = EquipmentType.Equipment, Description= "Targets lower body muscles while providing cardio benefits"},

                // Specialty Equipment
                new Equipment { Name = "Power Rack", EquipmentType = EquipmentType.Equipment, Description= "Essential for performing squats and bench presses safely with a spotter"},
                new Equipment { Name = "Battle Ropes", EquipmentType = EquipmentType.Equipment, Description= "Used for high-intensity interval training, engaging multiple muscle groups"},
                new Equipment { Name = "Bands", EquipmentType = EquipmentType.Equipment, Description= ""},
                new Equipment { Name = "Resistance Bands", EquipmentType = EquipmentType.Equipment, Description= "Portable bands that provide resistance for various exercises"},
                new Equipment { Name = "Stability Ball", EquipmentType = EquipmentType.Equipment, Description= "Used to enhance core strength and stability during workouts"},

                // Other 
                new Equipment { Name = "Foam Roll", EquipmentType = EquipmentType.Equipment, Description= "For muscle recovery and myofascial release post-workout"},
                new Equipment { Name = "Abdominal Bench", EquipmentType = EquipmentType.Equipment, Description= "Designed specifically for core workouts, targeting abdominal muscles"},
                new Equipment { Name = "Pull-Up Bar", EquipmentType = EquipmentType.Equipment, Description= "Essential for upper body strength training through pull-ups and chin-ups"},
                new Equipment { Name = "Cable", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Medicine Ball", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "E-Z Curl Bar", EquipmentType = EquipmentType.Machine, Description= ""},

                new Equipment { Name = "Trap Bar (Hex Bar)", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Cambered Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Safety Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Axle Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Swiss Bar", EquipmentType = EquipmentType.Machine, Description= ""},

                new Equipment { Name = "Buffalo Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Fixed Barbells", EquipmentType = EquipmentType.Machine, Description= ""},

                new Equipment { Name = "Abdominal", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Other", EquipmentType = EquipmentType.Machine, Description= ""},
            };
            await context.Equipments.AddRangeAsync(equipments);
            await context.SaveChangesAsync();
        }

        var sports = new List<Sport>();
        if (!context.Sports.Any())
        {
            sports = new List<Sport>
            {
                new Sport { Id = 1, Name = "BodyBuilding", Description = ""},
                new Sport { Id = 1, Name = "Cardio", Description = ""},
                new Sport { Id = 1, Name = "Yoga", Description = ""},
            };
            await context.Sports.AddRangeAsync(sports);
            await context.SaveChangesAsync();
        }


        // Workout Models
        #region Workout Models

        var workouts = new List<Workout>();
        if (!context.Workouts.Any())
        {
            // Instruction // Body // AgeRange // Equipments // Level // Sex
            workouts = new List<Workout>
            {
                #region Dumbells	
                // Chest
                //Index => 0
                new Workout { Id = 1, Name = "Dumbbell Bench Press", Description = "Targets the chest; can be done flat, incline, or decline.", SportId = sports[0].Id },
                //Index => 1
                new Workout { Id = 2, Name = "Dumbbell Fly", Description = "Focuses on the upper and lateral pec muscles", SportId = sports[0].Id },
                //Index => 2
                new Workout { Id = 3, Name = "Dumbbell Floor Press", Description ="Similar to bench press but performed on the floor.", SportId= sports[0].Id },


                // Back
                //Index 3
                new Workout { Id = 4, Name = "Dumbbell Bent-Over Rows", Description ="Engages the entire back.", SportId= sports[0].Id },
                //Index 4
                new Workout { Id = 5, Name = "Dumbbell Pullover", Description ="Works the lats and upper chest.", SportId= sports[0].Id },
                //Index 5                
                new Workout { Id = 6, Name = "Renegade Row", Description ="Combines a plank with a row for core and back strength.", SportId= sports[0].Id },

                // Shoulders
                //Index 6
                new Workout { Id = 7, Name = "Standing Dumbbell Press", Description ="Builds shoulder strength while engaging the core.", SportId= sports[0].Id },
                //Index 7
                new Workout { Id = 8, Name = "Dumbbell Lateral Raise", Description ="Isolates the lateral deltoids.", SportId= sports[0].Id },
                //Index 8
                new Workout { Id = 9, Name = "Dumbbell Arnold Press", Description ="Targets multiple shoulder muscles through rotation.", SportId= sports[0].Id },

                // Arms
                //Index 9
                new Workout { Id = 10, Name = "Dumbbell Bicep Curls", Description ="Essential for bicep development.", SportId= sports[0].Id },
                //Index 10
                new Workout { Id = 11, Name = "Hammer Curls", Description ="Targets the brachialis and brachioradialis.", SportId= sports[0].Id },
                //Index 11
                new Workout { Id = 12, Name = "Dumbbell Tricep Kickbacks", Description ="Isolates the triceps effectively.", SportId= sports[0].Id },

                // Lower Body
                //Index 12
                new Workout { Id = 13, Name = "Dumbbell Squats (Goblet Squats)", Description ="Fundamental for leg strength.", SportId= sports[0].Id },
                //Index 13
                new Workout { Id = 14, Name = "Dumbbell Lunges (Walking Lunges)", Description ="Focuses on single-leg strength and stability.", SportId= sports[0].Id },
                //Index 14
                new Workout { Id = 15, Name = "Dumbbell Deadlifts (Stiff-Legged Deadlifts)", Description ="Engages the posterior chain, especially hamstrings and glutes.", SportId= sports[0].Id },
                //Index 15
                new Workout { Id = 16, Name = "Dumbbell Step-Ups", Description ="Improves leg strength and balance.", SportId= sports[0].Id },

                // Core Workouts
                //Index 16
                new Workout { Id = 17, Name = "Weighted Crunches", Description ="Targets the rectus abdominis.", SportId= sports[0].Id },
                //Index 17
                new Workout { Id = 18, Name = "Russian Twists", Description ="Engages obliques for rotational strength.", SportId= sports[0].Id },
                //Index 18
                new Workout { Id = 19, Name = "Plank with Dumbbells", Description ="Enhances core stability while incorporating shoulder work.", SportId= sports[0].Id },

                // Full Body Workouts
                //Index 19
                new Workout { Id = 20, Name = "Devil's Press", Description ="Combines a burpee with dumbbells for a full-body workout.", SportId= sports[0].Id },
                //Index 20
                new Workout { Id = 21, Name = "Farmer’s Carry", Description ="Enhances grip strength and overall conditioning while working multiple muscle groups.", SportId= sports[0].Id },
                //Index 21
                new Workout { Id = 22, Name = "Dumbbell High Pulls", Description ="Targets shoulders, traps, and upper back.", SportId= sports[0].Id },
                #endregion

                #region Barbells
                // Chest
                //Index => 22
                new Workout { Id = 23, Name = "Barbell Bench Press", Description ="A fundamental exercise for overall chest development.", SportId= sports[0].Id },
                //Index => 23
                new Workout { Id = 24, Name = "Incline Barbell Press", Description ="Targets the upper chest, performed on an inclined bench.", SportId= sports[0].Id },
                //Index => 24
                new Workout { Id = 25, Name = "Decline Barbell Press", Description ="Focuses on the lower chest, done on a declined bench.", SportId= sports[0].Id },
                //Index => 25
                new Workout { Id = 26, Name = "Barbell Pullover", Description ="Engages the chest and lats, performed lying on a bench.", SportId= sports[0].Id },


                // Back
                //Index => 26
                new Workout { Id = 27, Name = "Barbell Bent-Over Row", Description ="A classic exercise for building thickness in the back.", SportId= sports[0].Id },
                //Index => 27
                new Workout { Id = 28, Name = "Pendlay Row", Description ="An explosive variation of the bent-over row focusing on strength.", SportId= sports[0].Id },
                //Index => 28
                new Workout { Id = 29, Name = "T-Bar Row", Description ="Targets the middle back and lats; requires a T-bar setup.", SportId= sports[0].Id },
                //Index => 29
                new Workout { Id = 30, Name = "Barbell Deadlift", Description ="A compound movement that works the entire posterior chain.", SportId= sports[0].Id },
                //Index => 30
                new Workout { Id = 31, Name = "Barbell Shrug", Description ="Isolates the upper trapezius muscles.", SportId= sports[0].Id },

                // Shoulders
                //Index => 31
                new Workout { Id = 32, Name = "Barbell Overhead Press", Description ="A primary shoulder exercise that also engages the core.", SportId= sports[0].Id },
                //Index => 32
                new Workout { Id = 33, Name = "Barbell Upright Row", Description ="Targets the shoulders and traps by lifting the bar to chin height.", SportId= sports[0].Id },
                //Index => 33
                new Workout { Id = 34, Name = "Barbell Front Raise", Description ="Isolates the front deltoids by lifting the bar in front of you.", SportId= sports[0].Id },

                // Arms
                //Index => 34
                new Workout { Id = 35, Name = "Barbell Bicep Curl", Description ="A staple for building bicep mass.", SportId= sports[0].Id },
                //Index => 35
                new Workout { Id = 36, Name = "Close-Grip Barbell Bench Press", Description ="Primarily targets the triceps while also engaging the chest.", SportId= sports[0].Id },
                //Index => 36
                new Workout { Id = 37, Name = "Skull Crushers", Description ="Focuses on triceps development using a barbell.", SportId= sports[0].Id },
                
                // Core Workouts
                //Index => 37
                new Workout { Id = 38, Name = "Barbell Squat", Description ="A fundamental exercise for overall leg development.", SportId= sports[0].Id },
                //Index => 38
                new Workout { Id = 39, Name = "Barbell Deadlift (Conventional)", Description ="Engages hamstrings, glutes, and lower back.", SportId= sports[0].Id },
                //Index => 39
                new Workout { Id = 40, Name = "Barbell Lunges", Description ="Targets quads and glutes; can be performed forward or backward.", SportId= sports[0].Id },
                //Index => 40
                new Workout { Id = 41, Name = "Barbell Romanian Deadlift", Description ="Focuses on hamstrings and glutes with a hip hinge movement.", SportId= sports[0].Id },

                // Lower Body Workouts
                //Index => 41
                new Workout { Id = 42, Name = "Barbell Rollout", Description ="Engages core muscles through an extended rollout motion.", SportId= sports[0].Id },
                //Index => 42
                new Workout { Id = 43, Name = "Landmine Anti-Rotation Press", Description ="Strengthens core stability while pressing a barbell anchored at one end.", SportId= sports[0].Id },


                // Full Body Workouts
                //Index => 43
                new Workout { Id = 44, Name = "Barbell Clean and Press", Description ="A dynamic movement that works multiple muscle groups including legs, back, shoulders, and arms.", SportId= sports[0].Id },
                //Index => 44
                new Workout { Id = 45, Name = "Barbell Thruster", Description =" Thruster: Combines a front squat with an overhead press for a full-body workout.", SportId= sports[0].Id },

                #endregion

                #region KettleBells
                // Lower Body Exercises
                //Index => 45
                new Workout { Id = 46, Name = "Kettlebell Goblet Squat", Description ="A fundamental squat variation that enhances leg strength and mobility", SportId= sports[0].Id },
                //Index => 46
                new Workout { Id = 47, Name = "Kettlebell Swing", Description ="A ballistic movement targeting the glutes and hamstrings", SportId= sports[0].Id },
                //Index => 47
                new Workout { Id = 48, Name = "Kettlebell Deadlift", Description ="Effective for developing posterior chain strength", SportId= sports[0].Id },
                //Index => 48
                new Workout { Id = 49, Name = "Kettlebell Single-Leg Deadlift", Description ="Improves balance and engages the core", SportId= sports[0].Id },
                //Index => 49
                new Workout { Id = 50, Name = "Kettlebell Racked Lunge", Description ="", SportId= sports[0].Id },
                //Index => 50
                new Workout { Id = 51, Name = "Kettlebell Reverse Lunge", Description ="", SportId= sports[0].Id },
                //Index => 51
                new Workout { Id = 52, Name = "Kettlebell Side Lunge", Description ="", SportId= sports[0].Id },
                //Index => 52
                new Workout { Id = 53, Name = "Kettlebell Walking Lunge", Description ="", SportId= sports[0].Id },
                //Index => 53
                new Workout { Id = 54, Name = "Kettlebell Overhead Squat", Description ="Enhances shoulder stability and lower body strength.", SportId= sports[0].Id },

                // Upper Body Exercises
                // Index => 54
                new Workout { Id = 55, Name = "Kettlebell Overhead Press", Description ="Builds shoulder strength and stability.", SportId= sports[0].Id },
                // Index => 55
                new Workout { Id = 56, Name = "Kettlebell Snatch", Description ="A full-body power exercise that requires technique and explosiveness.", SportId= sports[0].Id },
                // Index => 56
                new Workout { Id = 57, Name = "Kettlebell Renegade Row", Description ="Engages the core while working the back and arms.", SportId= sports[0].Id },
                // Index => 57
                new Workout { Id = 58, Name = "Kettlebell Push Press", Description ="Combines a squat with an overhead press for total-body engagement.", SportId= sports[0].Id },
                // Index => 58
                new Workout { Id = 59, Name = "Kettlebell High Pulls", Description ="Focuses on the upper back and shoulders.", SportId= sports[0].Id },
                
                // Core Exercises
                // Index => 59
                new Workout { Id = 60, Name = "Turkish Get-Up", Description ="A complex movement that builds core strength and stability.", SportId= sports[0].Id },
                // Index => 60
                new Workout { Id = 61, Name = "Kettlebell Windmill", Description ="Engages the obliques and improves shoulder mobility.", SportId= sports[0].Id },
                // Index => 61
                new Workout { Id = 62, Name = "Kettlebell Russian Twist", Description ="Targets the obliques while enhancing rotational strength.", SportId= sports[0].Id },


                // Full Body Exercises
                // Index => 62
                new Workout { Id = 63, Name = "Kettlebell Clean and Press", Description ="A compound movement that works multiple muscle groups.", SportId= sports[0].Id },
                // Index => 63                
                new Workout { Id = 64, Name = "Kettlebell Thruster (Squat and Press)", Description ="Combines a squat with an overhead press for a high-intensity workout", SportId= sports[0].Id },
                // Index => 64
                new Workout { Id = 65, Name = "Kettlebell Farmer's Walk", Description ="Improves grip strength while engaging the entire body.", SportId= sports[0].Id },

                // Dynamic Movements
                // Index => 65
                new Workout { Id = 66, Name = "Kettlebell Swing (Single-Handed)", Description ="Adds instability to the traditional swing, enhancing grip and core engagement.", SportId= sports[0].Id },
                // Index => 66
                new Workout { Id = 67, Name = "Kettlebell Gorilla Row", Description ="A unique row variation that targets the back while maintaining a strong core position.", SportId= sports[0].Id },
                
                // Specialty Movements
                // Index => 67
                new Workout { Id = 68, Name = "Kettlebell Halo", Description ="Improves shoulder mobility while engaging the core.", SportId= sports[0].Id },
                // Index => 68
                new Workout { Id = 69, Name = "Kettlebell Bottoms Up Press", Description ="Challenges stability and grip strength by holding the kettlebell upside down.", SportId= sports[0].Id },
                #endregion

                #region Smith Machine
                // Chest
                // Index => 69
                new Workout { Id = 70, Name = "Smith Machine Bench Press", Description ="Targets the chest, triceps, and shoulders.", SportId= sports[0].Id },
                // Index => 70
                new Workout { Id = 71, Name = "Smith Machine Incline Bench Press", Description ="Focuses on the upper chest and shoulders.", SportId= sports[0].Id },
                // Index => 71
                new Workout { Id = 72, Name = "Smith Machine Decline Bench Press", Description ="Emphasizes the lower chest.", SportId= sports[0].Id },
                // Index => 72
                new Workout { Id = 73, Name = "Smith Machine Close-Grip Bench Press", Description ="Targets the triceps while engaging the", SportId= sports[0].Id },

                // Back
                // Index => 73
                new Workout { Id = 74, Name = "Smith Machine Bent Over Row", Description ="Works the upper back and lats.", SportId= sports[0].Id },
                // Index => 74
                new Workout { Id = 75, Name = "Smith Machine Inverted Row", Description ="Engages the back and biceps with a bodyweight variation.", SportId= sports[0].Id },
                // Index => 75
                new Workout { Id = 76, Name = "Smith Machine Reverse Grip Bent Over Row", Description ="Targets the upper back with a different grip for varied muscle activation.", SportId= sports[0].Id },

                // Shoulders
                // Index => 76
                new Workout { Id = 77, Name = "Smith Machine Seated Shoulder Press", Description ="Isolates the shoulders and triceps.", SportId= sports[0].Id },
                // Index => 77                
                new Workout { Id = 78, Name = "Smith Machine Upright Row", Description ="Engages the shoulders and traps.", SportId= sports[0].Id },
                // Index => 78                
                new Workout { Id = 79, Name = "Smith Machine Behind-the-Neck Press", Description ="Targets the shoulders but should be done with caution.", SportId= sports[0].Id },

                // Legs
                // Index => 79
                new Workout { Id = 80, Name = "Smith Machine Back Squat", Description ="A classic exercise for overall leg development.", SportId= sports[0].Id },
                // Index => 80
                new Workout { Id = 81, Name = "Smith Machine Front Squat", Description ="Emphasizes the quads and core stability.", SportId= sports[0].Id },
                // Index => 81
                new Workout { Id = 82, Name = "Smith Machine Romanian Deadlift", Description ="Targets the hamstrings and glutes.", SportId= sports[0].Id },
                // Index => 82
                new Workout { Id = 83, Name = "Smith Machine Split Squat", Description ="Focuses on one leg at a time for balance and strength.", SportId= sports[0].Id },
                // Index => 83
                new Workout { Id = 84, Name = "Smith Machine Reverse Lunge", Description ="Works the quads, hamstrings, and glutes.", SportId= sports[0].Id },
                // Index => 84
                new Workout { Id = 85, Name = "Smith Machine Hip Thrust", Description ="Builds strength in the glutes and hamstrings.", SportId= sports[0].Id },
                // Index => 85
                new Workout { Id = 86, Name = "Smith Machine Calf Raise", Description ="Isolates the calf muscles.", SportId= sports[0].Id },

                // Core
                // Index => 86
                new Workout { Id = 87, Name = "Smith Machine Hanging Leg Raise", Description ="Engages the abdominal muscles effectively.", SportId= sports[0].Id },
                // Index => 87
                new Workout { Id = 88, Name = "Smith Machine Plank (with feet on bar)", Description ="A variation that challenges core stability.", SportId= sports[0].Id },

                // Arms
                // Index => 88
                new Workout { Id = 89, Name = "Smith Machine Skull Crushers", Description ="Targets the triceps effectively.", SportId= sports[0].Id },
                // Index => 89
                new Workout { Id = 90, Name = "Smith Machine Bicep Curl", Description ="Isolates the biceps for focused development.", SportId= sports[0].Id },

                // Additional Exercises
                // Index => 90
                new Workout { Id = 91, Name = "Smith Machine Kaz Press", Description ="A unique press that targets both triceps and chest.", SportId= sports[0].Id },
                // Index => 91
                new Workout { Id = 92, Name = "Smith Machine Single-Leg Deadlift", Description ="Enhances balance while targeting hamstrings and glutes.", SportId= sports[0].Id },

                #endregion

                #region Leg Press Machine
                // Index => 92
                new Workout {Id = 93, Name = "Standard Leg Press", Description = "A foundational exercise that targets the quadriceps, hamstrings, and glutes.", SportId = sports[0].Id },
                // Index => 93
                new Workout {Id = 94, Name = "Wide Stance Leg Press", Description = "Emphasizes the inner thighs and glutes by placing feet wider than shoulder-width apart", SportId = sports[0].Id },
                // Index => 94
                new Workout {Id = 95, Name = "Narrow Stance Leg Press", Description = "Focuses on the outer quadriceps with feet placed closer together.", SportId = sports[0].Id },
                // Index => 95
                new Workout {Id = 96, Name = "High Foot Placement Leg Press", Description = "Targets the hamstrings and glutes by positioning feet higher on the platform.", SportId = sports[0].Id },                
                // Index => 96
                new Workout {Id = 97, Name = "Low Foot Placement Leg Press", Description = "Shifts emphasis to the quadriceps by placing feet lower on the platform.", SportId = sports[0].Id },                
                // Index => 97
                new Workout {Id = 98, Name = "Single Leg Press", Description = "Addresses strength imbalances by performing the leg press one leg at a time.", SportId = sports[0].Id },                
                // Index => 98
                new Workout {Id = 99, Name = "Calf Press on the Leg Press Machine", Description = "Targets the calf muscles by pressing with just the toes while keeping heels off the platform.", SportId = sports[0].Id },                
                // Index => 99
                new Workout {Id = 100, Name = "Single-Leg Calf Raise on Leg Press Machine", Description = "Similar to the calf press but performed one leg at a time for added focus.", SportId = sports[0].Id },                
                // Index => 100
                new Workout {Id = 101, Name = "Sumo Leg Press", Description = "A variation where feet are placed wider and turned outwards to target inner thighs more effectively.", SportId = sports[0].Id },                
                // Index => 101
                new Workout {Id = 102, Name = "Feet Elevated Leg Press", Description = " Elevating feet on a block or platform increases range of motion and targets glutes and hamstrings more intensely.", SportId = sports[0].Id },
                #endregion

                #region chest press machine                
                // Index => 102
                new Workout {Id = 103, Name = "Machine Chest Press", Description = "This is the standard exercise that targets the pectoral muscles, triceps, and shoulders. It's typically performed for moderate to high reps (8-12) to build muscle mass", SportId = sports[0].Id },
                // Index => 103
                new Workout {Id = 104, Name = "Incline Chest Press", Description = "Adjust the machine to an incline position to emphasize the upper chest. This variation helps in developing the upper pectoral muscles more effectively.", SportId = sports[0].Id },
                // Index => 104
                new Workout {Id = 105, Name = "Decline Chest Press", Description = "Set the machine to a decline position to target the lower part of the chest. This variation can help in achieving a more balanced chest development", SportId = sports[0].Id },
                // Index => 105
                new Workout {Id = 106, Name = "Leverage Chest Press", Description = "Similar to the machine chest press but uses a leverage system, allowing for a different angle and resistance curve, which can enhance muscle engagement", SportId = sports[0].Id },
                // Index => 106
                new Workout {Id = 107, Name = "Plate-Loaded Chest Press", Description = "Utilize a plate-loaded version of the chest press machine for increased weight versatility and a different feel during the lift", SportId = sports[0].Id },
                // Index => 107
                new Workout {Id = 108, Name = "Cable Chest Press", Description = "Perform seated, standing, or lying cable chest presses for varied resistance and muscle engagement, focusing on stability and control", SportId = sports[0].Id },
                // Index => 108
                new Workout {Id = 109, Name = "Drop Sets", Description = "After reaching muscle fatigue at your maximum weight, immediately reduce the weight and continue pressing until failure. This technique enhances muscle endurance and hypertrophy", SportId = sports[0].Id },
                // Index => 109
                new Workout {Id = 110, Name = "Partial Reps", Description = "Focus on the strongest part of your range of motion by performing partial reps at the peak contraction of the lift, which can help in building strength at specific points in your lift", SportId = sports[0].Id },
                // Index => 110
                new Workout {Id = 111, Name = "High-Rep Finishing Set", Description = "Use the machine for a burnout set at the end of your workout with high repetitions (15-20) to fully exhaust your muscles", SportId = sports[0].Id },

                #endregion

                #region Lat Pulldown Machine
                // Index => 111
                new Workout {Id = 112, Name = "Standard Lat Pulldown", Description = "The basic lat pulldown targets the latissimus dorsi, rhomboids, and biceps.", SportId = sports[0].Id },
                // Index => 112
                new Workout {Id = 113, Name = "Wide Grip Lat Pulldown", Description = "Emphasizes the outer lats for a broader back.", SportId = sports[0].Id },
                // Index => 113
                new Workout {Id = 114, Name = "Close Grip Lat Pulldown", Description = "Focuses more on the inner lats and biceps", SportId = sports[0].Id },
                // Index => 114
                new Workout {Id = 115, Name = "Reverse Grip Lat Pulldown", Description = "Targets the middle back and biceps effectively.", SportId = sports[0].Id },
                // Index => 115
                new Workout {Id = 116, Name = "Single Arm Lat Pulldown", Description = "Allows for unilateral training, helping to correct muscle imbalances.", SportId = sports[0].Id },
                // Index => 116
                new Workout {Id = 117, Name = "Behind-the-Neck Lat Pulldown", Description = "Targets the upper lats and deltoids but should be performed with caution to avoid shoulder strain.", SportId = sports[0].Id },
                // Index => 117
                new Workout {Id = 118, Name = "Straight Arm Lat Pulldown", Description = "Isolates the lats without involving the biceps significantly.", SportId = sports[0].Id },
                // Index => 118
                new Workout {Id = 119, Name = "Alternating Grip Lat Pulldown", Description = "Combines different grips in one set for varied muscle engagement.", SportId = sports[0].Id },
                #endregion

                #region Leg Curl Machine
                // Index => 119
                new Workout {Id = 120, Name = "Seated Leg Curl", Description = "This is the most common exercise performed on a leg curl machine. It effectively isolates the hamstrings while allowing for a comfortable seated position. Adjust the machine so that the pad rests just above your ankles, and curl your legs down towards your glutes", SportId = sports[0].Id },
                // Index => 120
                new Workout {Id = 121, Name = "Lying Leg Curl", Description = "This variation involves lying face down on the machine. The pad should be positioned just above your calves, and you curl your legs upward towards your glutes. This position emphasizes the hamstrings differently than the seated version", SportId = sports[0].Id },
                // Index => 121
                new Workout {Id = 122, Name = "Standing Leg Curl", Description = "Some machines allow for a standing position, where you curl one leg at a time while standing. This variation helps improve balance and engages the stabilizing muscles in addition to targeting the hamstrings", SportId = sports[0].Id },
                // Index => 122
                new Workout {Id = 123, Name = "Single-Leg Curl", Description = "Perform leg curls one leg at a time to focus on muscle imbalances and enhance isolation of each hamstring individually", SportId = sports[0].Id },
                // Index => 123
                new Workout {Id = 124, Name = "Foot Position Variations", Description = "Adjust your foot positioning (toes pointed in, out, or straight) during curls to target different parts of the hamstrings and engage other stabilizing muscles", SportId = sports[0].Id },
                // Index => 124
                new Workout {Id = 125, Name = "Eccentric Focus", Description = "Emphasize the eccentric (lowering) phase of the curl by lowering the weight slowly after reaching the peak contraction, which can help increase muscle hypertrophy.", SportId = sports[0].Id },
                // Index => 125
                new Workout {Id = 126, Name = "Leg Curl Drop Sets", Description = "After reaching failure at a heavier weight, immediately reduce the weight and continue performing curls until failure again to maximize muscle fatigue.", SportId = sports[0].Id },
                // Index => 126
                new Workout {Id = 127, Name = "Supersets with Other Exercises", Description = "Combine leg curls with other lower body exercises (like squats or deadlifts) for a comprehensive leg workout that targets multiple muscle groups.", SportId = sports[0].Id },
                #endregion

                #region Leg Extension Machine
                // Index => 127
                new Workout {Id = 128, Name = "Standard Leg Extension", Description = "Sit on the machine with your back against the pad. Adjust the pad so it rests on your lower legs, just above your ankles. Extend your legs until they are straight, then lower back down", SportId = sports[0].Id },
                // Index => 128
                new Workout {Id = 129, Name = "Single-Leg Extension", Description = "Use the same machine but perform the exercise one leg at a time. This helps address muscle imbalances and allows for greater focus on each quadricep.", SportId = sports[0].Id },
                // Index => 129
                new Workout {Id = 130, Name = "One-Legged Machine Extension", Description = "If available, use a unilateral leg extension machine that allows each leg to work independently, providing an additional challenge and variety.", SportId = sports[0].Id },
                // Index => 130
                new Workout {Id = 131, Name = "Foot Position Variations", Description = "Experiment with different foot positions (toes pointed in, out, or straight) during the extension to target various parts of the quadriceps.", SportId = sports[0].Id },
                // Index => 131
                new Workout {Id = 132, Name = "Eccentric Focus", Description = "Emphasize the eccentric phase by lowering the weight slowly after reaching full extension. This technique can enhance muscle hypertrophy.", SportId = sports[0].Id },
                // Index => 132
                new Workout {Id = 133, Name = "Drop Sets", Description = "Perform a set to failure at a heavier weight, then immediately reduce the weight and continue until failure again to maximize muscle fatigue.", SportId = sports[0].Id },
                // Index => 133
                new Workout {Id = 134, Name = "Supersets with Other Exercises", Description = "Combine leg extensions with other leg exercises (like squats or lunges) for a comprehensive workout that targets multiple muscle groups.", SportId = sports[0].Id },
                // Index => 134
                new Workout {Id = 135, Name = "Controlled Tempo", Description = "Focus on maintaining a slow and controlled tempo throughout both the lifting and lowering phases to maximize muscle engagement.", SportId = sports[0].Id },
                #endregion

                #region Cable Machine
                // Upper Body Workouts
                // Index => 135
                new Workout { Id = 136, Name = "Cable Lat Pulldown", Description = "Targets the lats and upper back.", SportId = sports[0].Id },
                // Index => 136
                new Workout { Id = 137, Name = "Seated Cable Row", Description = "Focuses on the middle back and biceps.", SportId = sports[0].Id },
                // Index => 137
                new Workout { Id = 138, Name = "Cable Chest Flye", Description = "Great for isolating the pectoral muscles.", SportId = sports[0].Id },
                // Index => 138
                new Workout { Id = 139, Name = "Cable Crossover", Description = "Engages the chest from different angles.", SportId = sports[0].Id },
                // Index => 139
                new Workout { Id = 140, Name = "Cable Bicep Curl", Description = "Isolates the biceps for muscle growth.", SportId = sports[0].Id },
                // Index => 140
                new Workout { Id = 141, Name = "Cable Tricep Pushdown", Description = "Targets the triceps effectively.", SportId = sports[0].Id },
                // Index => 141
                new Workout { Id = 142, Name = "Face Pull", Description = "Strengthens the rear deltoids and rotator cuff muscles.", SportId = sports[0].Id },
                // Index => 142
                new Workout { Id = 143, Name = "Cable Lateral Raise", Description = "Works the deltoids, particularly the side delts.", SportId = sports[0].Id },
                // Index => 143
                new Workout { Id = 144, Name = "Cable Upright Row", Description = "Targets the shoulders and traps.", SportId = sports[0].Id },
                // Index => 144
                new Workout { Id = 145, Name = "Straight Arm Pulldown", Description = "Focuses on the lats and core stability.", SportId = sports[0].Id },

                // Core Workouts
                // Index => 145
                new Workout { Id = 146, Name = "Cable Crunch", Description = "Engages the abdominal muscles with constant tension.", SportId = sports[0].Id },
                // Index => 146
                new Workout { Id = 147, Name = "Kneeling Cable Crunch", Description = "A variation that targets the core from a kneeling position.", SportId = sports[0].Id },
                // Index => 147
                new Workout { Id = 148, Name = "Cable Wood Chop", Description = "Strengthens the obliques and improves rotational power.", SportId = sports[0].Id },
                // Index => 148
                new Workout { Id = 149, Name = "Cable Pallof Press", Description = "Enhances core stability and anti-rotation strength.", SportId = sports[0].Id },
                // Index => 149
                new Workout { Id = 150, Name = "Single-Arm Cable Side Bend", Description = "Targets the obliques while improving lateral strength.", SportId = sports[0].Id },

                // Lower Body Workouts
                // Index => 150
                new Workout { Id = 151, Name = "Cable Kickback", Description = "Isolates the glutes effectively.", SportId = sports[0].Id },
                // Index => 151
                new Workout { Id = 152, Name = "Single-Leg Cable Hip Extension", Description = "Focuses on glute activation and stability.", SportId = sports[0].Id },
                // Index => 152
                new Workout { Id = 153, Name = "Cable Pull-Through", Description = "Engages the hamstrings and glutes with minimal spinal load.", SportId = sports[0].Id },
                // Index => 153
                new Workout { Id = 154, Name = "Cable Squats", Description = "Adds resistance to traditional squats for extra challenge.", SportId = sports[0].Id },
                // Index => 154
                new Workout { Id = 155, Name = "Low-Cable Cross-Over (for legs)", Description = "Targets inner thighs when performed correctly.", SportId = sports[0].Id },
                // Index => 155
                new Workout { Id = 156, Name = "Incline Cable Chest Fly", Description = "Targets the upper portion of the chest.", SportId = sports[0].Id },
                // Index => 156
                new Workout { Id = 157, Name = "Overhead Cable Tricep Extension", Description = "Focuses on tricep development from an overhead position.", SportId = sports[0].Id },
                // Index => 157
                new Workout { Id = 158, Name = "Reverse Grip Triceps Pushdown", Description = "A variation that emphasizes different parts of the triceps.", SportId = sports[0].Id },
                // Index => 158
                new Workout { Id = 159, Name = "Standing Cable Low-to-High Twist", Description = "Engages both core and shoulder muscles through rotation.", SportId = sports[0].Id },
                // Index => 159
                new Workout { Id = 160, Name = "Rope Hammer Curl", Description = "Works both biceps and forearms effectively.", SportId = sports[0].Id },
                
                #endregion

                #region Bench Press
                // Primary Bench Press Variations
                // Index => 160
                new Workout { Id = 161, Name = "Flat Barbell Bench Press", Description = "The classic exercise for building overall chest strength and mass.", SportId = sports[0].Id },
                // Index => 161
                new Workout { Id = 162, Name = "Incline Barbell Bench Press", Description = "Performed on an incline bench (typically set at 30-45 degrees), this variation emphasizes the upper chest and shoulders.", SportId = sports[0].Id },
                // Index => 162
                new Workout { Id = 163, Name = "Decline Barbell Bench Press", Description = "Involves a decline bench position, targeting the lower part of the pectorals.", SportId = sports[0].Id },
                // Index => 163
                new Workout { Id = 164, Name = "Dumbbell Bench Press", Description = "Can be performed flat, incline, or decline; allows for a greater range of motion and engages stabilizing muscles.", SportId = sports[0].Id },
                // Index => 164
                new Workout { Id = 165, Name = "Close-Grip Bench Press", Description = "A narrower grip that shifts focus to the triceps while still engaging the chest.", SportId = sports[0].Id },
                // Index => 165
                new Workout { Id = 166, Name = "Wide-Grip Bench Press", Description = "A wider grip that targets the outer pectoral muscles more intensely.", SportId = sports[0].Id },
                // Index => 166
                new Workout { Id = 167, Name = "Tempo Bench Press", Description = "Involves controlling the speed of the lift (e.g., slow lowering phase) to increase time under tension.", SportId = sports[0].Id },
                // Index => 167
                new Workout { Id = 168, Name = "Spoto Press", Description = "Pauses just above the chest to enhance control and stability before pressing back up.", SportId = sports[0].Id },
                // Index => 168
                new Workout { Id = 169, Name = "Floor Press", Description = "Performed lying on the floor, this variation limits the range of motion and emphasizes triceps strength.", SportId = sports[0].Id },
                // Index => 169
                new Workout { Id = 170, Name = "Swiss Bar Bench Press", Description = "Utilizes a Swiss bar for a neutral grip, reducing shoulder strain while still effectively targeting the chest and triceps.", SportId = sports[0].Id },

                // Primary Bench Press Variations
                // Index => 170
                new Workout { Id = 171, Name = "Pause Bench Press", Description = "A standard press with a pause at the bottom position, enhancing strength off the chest.", SportId = sports[0].Id },                
                // Index => 171
                new Workout { Id = 172, Name = "Pin Press", Description = "Performed by setting pins in a power rack at a specific height, focusing on pressing from a dead stop.", SportId = sports[0].Id },
                // Index => 172
                new Workout { Id = 173, Name = "Board Press", Description = "Involves pressing with a board placed on the chest to limit range of motion, emphasizing lockout strength.", SportId = sports[0].Id },
                // Index => 173
                new Workout { Id = 174, Name = "Reverse Grip Bench Press", Description = "A unique grip that shifts emphasis to the upper chest and triceps while providing shoulder stability.", SportId = sports[0].Id },
                // Index => 174
                new Workout { Id = 175, Name = "Single-Arm Dumbbell Bench Press", Description = "Engages core stability while isolating each side of the chest independently.", SportId = sports[0].Id },
                #endregion

                #region Floor Press
                // Primary Floor Press Variations
                // Index => 175
                new Workout { Id = 176, Name = "Barbell Floor Press", Description ="The standard version that targets the chest, shoulders, and triceps with minimal shoulder strain.", SportId= sports[0].Id },
                // Index => 176
                new Workout { Id = 177, Name = "Dumbbell Floor Press", Description ="Allows for a greater range of motion and engages stabilizing muscles. Can be performed with a neutral grip for shoulder comfort.", SportId= sports[0].Id },
                // Index => 177
                new Workout { Id = 178, Name = "Kettlebell Floor Press", Description ="Similar to the dumbbell variation but adds unique stabilization challenges due to the kettlebell's shape.", SportId= sports[0].Id },
                // Index => 178
                new Workout { Id = 179, Name = "Single-Arm Dumbbell Floor Press", Description ="Focuses on one side at a time, addressing muscle imbalances and enhancing core stability.", SportId= sports[0].Id },
                // Index => 179
                new Workout { Id = 180, Name = "Single-Arm Kettlebell Floor Press", Description ="Involves pressing a kettlebell with one arm while maintaining core stability, increasing the challenge.", SportId= sports[0].Id },
                // Index => 180
                new Workout { Id = 181, Name = "Swiss Bar Floor Press", Description ="Utilizes a Swiss bar for a neutral grip, which can reduce shoulder strain while still effectively targeting the upper body.", SportId= sports[0].Id },

                // Primary Floor Press Variations
                // Index => 181
                new Workout { Id = 182, Name = "Paused Floor Press", Description ="Involves pausing at the bottom of the movement before pressing up, which increases time under tension for hypertrophy.", SportId= sports[0].Id },
                // Index => 182
                new Workout { Id = 183, Name = "Resisted Floor Press", Description ="Incorporates bands or chains to increase resistance as you press, enhancing strength development throughout the movement.", SportId= sports[0].Id },
                // Index => 183
                new Workout { Id = 184, Name = "Close-Grip Floor Press", Description ="A variation that emphasizes triceps engagement while still targeting the chest.", SportId= sports[0].Id },
                // Index => 184
                new Workout { Id = 185, Name = "Floor Press with Chains or Bands", Description ="Adding chains or bands increases resistance as you press, challenging your muscles differently.", SportId= sports[0].Id },
                // Index => 185
                new Workout { Id = 186, Name = "Eccentric Floor Press", Description ="Focuses on slowly lowering the weight to build strength in the eccentric phase of the lift.", SportId= sports[0].Id },
                #endregion

                #region Treadmill
                // Index => 186
                new Workout { Id = 187, Name = "Steady-State Jogging", Description ="A basic workout where you jog at a consistent pace for a set duration (e.g., 20-30 minutes) to improve cardiovascular endurance.", SportId= sports[0].Id },
                // Index => 187
                new Workout { Id = 188, Name = "Sprint Intervals", Description ="Alternate between high-intensity sprints and rest periods.", SportId= sports[0].Id },
                // Index => 188
                new Workout { Id = 189, Name = "Incline Walking or Running", Description ="Set the treadmill to an incline (e.g., 5-15%) and walk or run to increase intensity and engage the legs more effectively.", SportId= sports[0].Id },
                // Index => 189
                new Workout { Id = 190, Name = "Fartlek Training", Description ="A mix of different speeds during your run.", SportId= sports[0].Id },
                // Index => 190
                new Workout { Id = 191, Name = "Hill Sprints", Description ="Set the incline to a steep level (e.g., 10-15%) and perform short sprints (10-30 seconds) followed by recovery periods (1-2 minutes).", SportId= sports[0].Id },
                // Index => 191
                new Workout { Id = 192, Name = "12-3-30 Workout", Description ="Set the treadmill to a 12% incline, a speed of 3 mph, and walk for 30 minutes. This low-impact workout is effective for building endurance.", SportId= sports[0].Id },
                // Index => 192
                new Workout { Id = 193, Name = "Bodyweight HIIT", Description ="Incorporate bodyweight exercises between running intervals.", SportId= sports[0].Id },
                // Index => 193
                new Workout { Id = 194, Name = "Treadmill Circuit Training", Description ="Combine treadmill running with strength exercises.", SportId= sports[0].Id },
                // Index => 194
                new Workout { Id = 195, Name = "Tempo Runs", Description ="Gradually increase your pace to a challenging but sustainable speed, maintaining it for a set duration before cooling down.", SportId= sports[0].Id },
                // Index => 195
                new Workout { Id = 196, Name = "Recovery Walks", Description ="After intense workouts, use the treadmill for light walking to aid recovery and keep your muscles active.", SportId= sports[0].Id },

                // Advanced Techniques
                // Index => 196
                new Workout { Id = 197, Name = "Pyramid Intervals", Description ="Gradually increase sprint durations (e.g., from 20 seconds up to 1 minute) followed by equal rest periods, then decrease back down.", SportId = sports[0].Id },
                // Index => 197
                new Workout { Id = 198, Name = "Progressive Runs", Description ="Start at a slow pace and gradually increase speed every few minutes until reaching your maximum effort.", SportId= sports[0].Id },
                // Index => 198
                new Workout { Id = 199, Name = "Mixed Speed Workouts", Description ="Alternate between different speeds every few minutes (e.g., fast run, moderate jog, brisk walk) to enhance endurance and speed.", SportId = sports[0].Id },
                #endregion

                #region Rowing Machine
                // Index => 199
                new Workout { Id= 200, Name = "Interval Training", Description= "High-intensity intervals to improve endurance and burn fat", SportId = sports[0].Id  },
                // Index => 200
                new Workout { Id= 201, Name = "Row and Core Workout", Description= "Combines rowing with core strengthening", SportId = sports[0].Id  },
                // Index => 201
                new Workout { Id= 202, Name = "Renegade & Row EMOM", Description= "Targets back and core while incorporating rowing for cardio", SportId = sports[0].Id  },
                // Index => 202
                new Workout { Id= 203, Name = "Pump and Row Pyramid", Description= "Full-body workout with emphasis on endurance and strength", SportId = sports[0].Id  },
                // Index => 203
                new Workout { Id= 204, Name = "Burpee Blast Challenge", Description= "Combines cardio with explosive strength movements", SportId = sports[0].Id  },
                // Index => 204
                new Workout { Id= 205, Name = "The Ultimate Rowing Workout", Description= "Builds lean muscle while enhancing cardiovascular fitness", SportId = sports[0].Id  },
                // Index => 205
                new Workout { Id= 206, Name = "Endurance Rows", Description= "Improves overall cardiovascular health while toning muscles", SportId = sports[0].Id  },
                #endregion


                #region stationary Bike
                // Index => 206
                new Workout { Id= 207, Name = "Steady-State Cycling", Description= "Maintain a consistent pace at a moderate resistance for 20-60 minutes to improve cardiovascular endurance.", SportId = sports[0].Id  },
                // Index => 207
                new Workout { Id= 208, Name = "High-Intensity Interval Training (HIIT)", Description= "Alternate between high-intensity sprints and recovery periods. For example:\r\n30 seconds of maximum effort followed by 30 seconds of easy pedaling, repeated for 15-20 minutes.", SportId = sports[0].Id  },
                // Index => 208
                new Workout { Id= 209, Name = "Tabata Training", Description= "Perform 20 seconds of all-out cycling followed by 10 seconds of rest, repeated for 4 minutes (8 rounds). This is an intense workout that boosts anaerobic capacity.", SportId = sports[0].Id  },
                // Index => 209
                new Workout { Id= 210, Name = "Pyramid Intervals", Description= "Gradually increase the duration of sprints (e.g., 20 seconds, 40 seconds, 60 seconds) followed by equal rest periods, then decrease back down.", SportId = sports[0].Id  },
                // Index => 210
                new Workout { Id= 211, Name = "Hill Climb Simulation", Description= "Increase the resistance to simulate hill climbing. Cycle at a challenging resistance for a set time (e.g., 3-5 minutes), followed by recovery periods.", SportId = sports[0].Id  },
                // Index => 211
                new Workout { Id= 212, Name = "Fartlek Training", Description= "Incorporate varying speeds throughout your ride. For example:\r\nJog for 5 minutes, sprint for 1 minute, then recover with light cycling for 2 minutes, repeating the cycle.", SportId = sports[0].Id  },
                // Index => 212
                new Workout { Id= 213, Name = "Sprinting Intervals", Description= "Sprint at high intensity for short bursts (e.g., 20-40 seconds) followed by longer recovery periods (e.g., 1-2 minutes). Repeat several times.", SportId = sports[0].Id  },                
                // Index => 213
                new Workout { Id = 214, Name = "Resistance Pyramid", Description = "Start with low resistance and gradually increase every few minutes until reaching maximum effort, then decrease back down.", SportId = sports[0].Id },
                // Index => 214
                new Workout { Id = 215, Name = "Mixed Cardio Circuit", Description = "Combine stationary bike workouts with bodyweight exercises (like push-ups or squats) in between cycling intervals to enhance muscle engagement.", SportId = sports[0].Id },
                // Index => 215
                new Workout { Id = 216, Name = "Recovery Ride", Description = "Use the bike for low-intensity cycling after heavy lifting sessions to promote recovery without putting too much strain on the muscles.", SportId = sports[0].Id },
                // Index => 216
                new Workout { Id = 217, Name = "Sprint-Focused Workout", Description = "Warm up for 5 minutes, then alternate between 30 seconds of sprinting and 1 minute of easy cycling for a total of about 15-20 minutes.", SportId = sports[0].Id },
                // Index => 217
                new Workout { Id = 218, Name = "Endurance Challenge", Description = "Aim for longer durations at a steady pace (45-60 minutes) to build aerobic capacity and endurance.Aim for longer durations at a steady pace (45-60 minutes) to build aerobic capacity and endurance.", SportId = sports[0].Id },
                // Index => 218
                new Workout { Id = 219, Name = "LISS (Low-Intensity Steady State) Cardio", Description = "Maintain a low intensity over a longer duration (e.g., 30-60 minutes) to promote fat burning while minimizing fatigue.", SportId = sports[0].Id },
                // Index => 219
                new Workout { Id = 220, Name = "Cooldown Sessions", Description = "After intense workouts, spend 5-10 minutes cycling at a very light pace to help with muscle recovery and prevent stiffness.", SportId = sports[0].Id },

                #endregion


                #region Stair Climber
                // Index => 220
                new Workout { Id = 221, Name = "Steady-State Climbing", Description = "Maintain a consistent pace for 20-30 minutes at a moderate intensity to improve cardiovascular endurance and burn calories.", SportId = sports[0].Id },
                // Index => 221
                new Workout { Id= 222, Name = "Interval Training", Description= "Alternate between high-intensity climbing and recovery periods. For example:\r\n1 minute of fast climbing followed by 1-2 minutes of slower climbing. Repeat for 20-30 minutes.", SportId = sports[0].Id  },
                // Index => 222
                new Workout { Id= 223, Name = "Hill Climb Simulation", Description= "Increase the resistance or speed to simulate climbing a steep hill for a set duration (e.g., 5 minutes), followed by a recovery period.", SportId = sports[0].Id  },
                // Index => 223
                new Workout { Id= 224, Name = "Pyramid Intervals", Description= "Gradually increase the intensity for a set number of minutes (e.g., 1 minute, 2 minutes, 3 minutes) and then decrease back down.", SportId = sports[0].Id },
                // Index => 224
                new Workout { Id= 225, Name = "Tabata Training", Description= "Perform 20 seconds of maximum effort followed by 10 seconds of rest, repeated for 4 minutes (8 rounds). This is an intense workout that boosts anaerobic capacity.", SportId = sports[0].Id  },
                // Index => 225
                new Workout { Id= 226, Name = "Fartlek Training", Description= "Incorporate varying speeds throughout your climb. For example:\r\nClimb at a moderate pace for 5 minutes, then sprint for 1 minute, followed by easy climbing for 2 minutes. Repeat.", SportId = sports[0].Id  },
                // Index => 226
                new Workout { Id= 227, Name = "25-7-2 Workout", Description= "Set the stair climber to an intensity level of 7 and climb for 25 minutes without holding onto the handrails to engage your core more effectively.", SportId = sports[0].Id  },
                // Index => 227
                new Workout { Id= 228, Name = "Circuit Training", Description= "Combine stair climbing with bodyweight exercises (like push-ups or squats) in between climbing intervals to enhance muscle engagement.", SportId = sports[0].Id  },
                // Index => 228
                new Workout { Id= 229, Name = "Endurance Challenge", Description= "Aim for longer durations at a steady pace (e.g., 30-60 minutes) to build aerobic capacity and endurance.", SportId = sports[0].Id  },
                // Index => 229
                new Workout { Id= 230, Name = "Cooldown Sessions", Description= "After intense workouts, spend 5-10 minutes on the stair climber at a very light pace to help with muscle recovery and prevent stiffness.", SportId = sports[0].Id  },
                // Index => 230
                new Workout { Id= 231, Name = "Resistance Training", Description= "Increase the resistance setting on the stair climber to challenge your muscles more and build strength in your legs and glutes.", SportId = sports[0].Id  },
                // Index => 231
                new Workout { Id= 232, Name = "Single-Leg Climbing", Description= "Alternate between using one leg at a time to target each leg individually, which can help improve balance and address muscle imbalances.", SportId = sports[0].Id  },
                // Index => 232
                new Workout { Id= 233, Name = "Backward Climbing", Description= "If your machine allows it, try climbing backward for short intervals to engage different muscle groups and improve coordination.", SportId = sports[0].Id  },
                // Index => 233
                new Workout { Id= 234, Name = "Sprints on the Stair Climber", Description= "Perform short bursts of maximum effort climbing (e.g., 20-30 seconds) followed by longer recovery periods (e.g., 1-2 minutes).", SportId = sports[0].Id  },
                #endregion

                #region Power Rack
                // Index => 234
                new Workout { Id = 235, Name="Barbell Squat", Description="A foundational exercise for building leg strength and mass. Can be performed as back squats or front squats.", SportId = sports[0].Id },
                // Index => 235
                new Workout { Id = 236, Name="Rack Pulls", Description="A partial deadlift that starts with the barbell positioned at knee height, focusing on the upper portion of the deadlift movement.", SportId = sports[0].Id },
                // Index => 236
                new Workout { Id = 237, Name="Barbell Bench Press", Description="Performed inside the rack for safety, this exercise targets the chest, shoulders, and triceps.", SportId = sports[0].Id },
                // Index => 237
                new Workout { Id = 238, Name="Overhead Press", Description="Standing or seated, this movement targets the shoulders and triceps while engaging the core for stability.", SportId = sports[0].Id },
                // Index => 238
                new Workout { Id = 239, Name="Deadlifts", Description="Can be performed with the barbell set at different heights to focus on various parts of the lift (e.g., conventional deadlifts or sumo deadlifts).", SportId = sports[0].Id },                
                // Index => 239
                new Workout { Id = 240, Name="Pull-Ups/Chin-Ups", Description="Utilize the pull-up bar attached to the power rack for bodyweight exercises targeting the back and biceps.", SportId = sports[0].Id },
                // Index => 240
                new Workout { Id = 241, Name="Barbell Lunges", Description="Perform lunges with the barbell resting on your back to enhance leg strength and stability.", SportId = sports[0].Id },
                // Index => 241
                new Workout { Id = 242, Name="Incline Bench Press", Description="Adjust a bench inside the rack to perform incline presses, targeting the upper chest.", SportId = sports[0].Id },

                // Isolation Exercises
                // Index => 242
                new Workout { Id = 243, Name="Barbell Curl", Description="Use the power rack to perform curls with a barbell for focused bicep training.", SportId = sports[0].Id },
                // Index => 243
                new Workout { Id = 244, Name="Tricep Dips", Description="If your rack has dip bars, perform dips to target the triceps and chest.", SportId = sports[0].Id },
                // Index => 244
                new Workout { Id = 245, Name="Leg Extensions (using attachments)", Description="If your power rack has attachments, you can perform leg extensions for isolated quadricep work.", SportId = sports[0].Id },
                // Index => 245
                new Workout { Id = 246, Name="Leg Curls (using attachments)", Description="Similar to leg extensions, if equipped, this can target the hamstrings effectively.", SportId = sports[0].Id },

                // Advanced Techniques
                // Index => 246
                new Workout { Id = 247, Name="Paused Squats", Description="Pause at the bottom of your squat for a few seconds before pressing up to increase time under tension.", SportId = sports[0].Id },
                // Index => 247
                new Workout { Id = 248, Name="Tempo Training", Description="Control the speed of each lift (e.g., slow descent) to enhance muscle engagement and growth.\r\n", SportId = sports[0].Id },
                // Index => 248
                new Workout { Id = 249, Name="Drop Sets", Description="After reaching failure with a heavier weight, immediately reduce weight and continue until failure again.", SportId = sports[0].Id },
                // Index => 249
                new Workout { Id = 250, Name="Supersets", Description="Combine two exercises (e.g., squat followed by overhead press) with minimal rest in between for increased intensity.", SportId = sports[0].Id },
                // Index => 250
                new Workout { Id = 251, Name="Dynamic Effort Training", Description="Use lighter weights at higher speeds to develop explosive strength in compound lifts.", SportId = sports[0].Id },
                
                // Full-Body Workouts
                // Index => 251
                new Workout { Id = 252, Name="Full-Body Circuit", Description="Create a circuit using multiple exercises (squats, bench press, rows, etc.) within the power rack for comprehensive training.", SportId = sports[0].Id },
                // Index => 252
                new Workout { Id = 253, Name="Progressive Overload Routine", Description="Focus on gradually increasing weights across various lifts performed in the power rack over time to build strength and muscle mass.", SportId = sports[0].Id },
                #endregion

                
                #region Battle Ropes

                //
                // Index  => 253
                new Workout { Id = 254, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 255, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 256, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 257, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 258, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 259, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 260, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 261, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 262, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 263, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 264, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 265, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 266, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 267, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 268, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 269, Name="", Description="", SportId = sports[0].Id },
                new Workout { Id = 270, Name="", Description="", SportId = sports[0].Id },

                #endregion

            };
            await context.Workouts.AddRangeAsync(workouts);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutEquipment.Any())
        {
            var workoutEquipments = new List<WorkoutEquipment>
            {
                #region Dumbells
                // Chest // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = workouts[11].Id },
                new WorkoutEquipment { WorkoutId = workouts[1].Id, EquipmentId = workouts[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[2].Id, EquipmentId = workouts[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[2].Id, EquipmentId = workouts[12].Id },

                // Back // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[3].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[4].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[5].Id, EquipmentId = equipments[1].Id },

                // Shoulders // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[6].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[7].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[8].Id, EquipmentId = equipments[1].Id },

                // Arms // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[9].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[10].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[11].Id, EquipmentId = equipments[1].Id },

                // Lower Body // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[12].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[13].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[14].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[15].Id, EquipmentId = equipments[1].Id },

                // Core Workouts // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[16].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[17].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[18].Id, EquipmentId = equipments[1].Id },
                
                // Full Body Workouts // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[19].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[20].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[21].Id, EquipmentId = equipments[1].Id },
                #endregion

                #region Barbells
                // Chest // Barbells
                new WorkoutEquipment { WorkoutId = workouts[22].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[22].Id, EquipmentId = equipments[11].Id },

                new WorkoutEquipment { WorkoutId = workouts[23].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[23].Id, EquipmentId = equipments[11].Id },

                new WorkoutEquipment { WorkoutId = workouts[24].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[24].Id, EquipmentId = equipments[11].Id },

                new WorkoutEquipment { WorkoutId = workouts[25].Id, EquipmentId = equipments[2].Id },

                // Back // Barbells
                new WorkoutEquipment { WorkoutId = workouts[26].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[27].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[28].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[29].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[30].Id, EquipmentId = equipments[2].Id },

                // Shoulders // Barbells
                new WorkoutEquipment { WorkoutId = workouts[31].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[32].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[33].Id, EquipmentId = equipments[2].Id },

                // Arms // Barbells
                new WorkoutEquipment { WorkoutId = workouts[34].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[35].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[36].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[37].Id, EquipmentId = equipments[2].Id },

                // Core Workouts // Barbells
                new WorkoutEquipment { WorkoutId = workouts[38].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[39].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[40].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[41].Id, EquipmentId = equipments[2].Id },

                // Lower Body // Barbells
                new WorkoutEquipment { WorkoutId = workouts[42].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[43].Id, EquipmentId = equipments[2].Id },

                // Full Body Workouts // Barbells
                new WorkoutEquipment { WorkoutId = workouts[44].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[45].Id, EquipmentId = equipments[2].Id },

                #endregion

                #region KettleBells
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },

                #endregion

                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[2].Id },

            };
            await context.WorkoutEquipment.AddRangeAsync(workoutEquipments);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutInstructions.Any())
        {
            var instructions = new List<WorkoutInstruction>
            {
                new WorkoutInstruction { WorkoutId = workouts[0].Id, Description = "", ImgUrl = "", VideoUrl = ""},
                new WorkoutInstruction { WorkoutId = workouts[0].Id, Description = "", ImgUrl = "", VideoUrl = ""}
            };
            await context.WorkoutInstructions.AddRangeAsync(instructions);
            await context.SaveChangesAsync();
        }

        if (!context.BodyWorkouts.Any())
        {
            var bodyWorkouts = new List<BodyWorkout>
            {
                new BodyWorkout { WorkoutId = workouts[0].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[0].Id, BodyId = bodies[0].Id }
            };
            await context.BodyWorkouts.AddRangeAsync(bodyWorkouts);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutAgeRanges.Any())
        {
            var workoutAgeRanges = new List<WorkoutAgeRange>
            {
                new WorkoutAgeRange {WorkoutId = workouts[0].Id, Age = Age.Eighteen_To_TwentyNine },
                new WorkoutAgeRange {WorkoutId = workouts[0].Id, Age = Age.Thirty_To_Thirty_Nine },
            };
            await context.WorkoutAgeRanges.AddRangeAsync(workoutAgeRanges);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutLevels.Any())
        {
            var workoutLevels = new List<WorkoutLevel>
            {
                new WorkoutLevel { WorkoutId = 1, Level = Domain.Enums.Level.Beginner, Description="" },
            };
            await context.WorkoutLevels.AddRangeAsync(workoutLevels);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutSex.Any())
        {
            var genders = new List<WorkoutSex>
            {
                new WorkoutSex { WorkoutId = workouts[0].Id, Sex = Sex.Man},
                new WorkoutSex { WorkoutId = workouts[0].Id, Sex = Sex.Man}
            };
            await context.WorkoutSex.AddRangeAsync(genders);
            await context.SaveChangesAsync();
        }

        
        // Done Workout Models

        if (!context.UserRoles.Any())
        {
            var roles = new List<IdentityRole<Guid>>
            {
                new IdentityRole<Guid> { Name = "Admin" },
                new IdentityRole<Guid> { Name = "Support" },
                new IdentityRole<Guid> { Name = "Athlete" },
                new IdentityRole<Guid> { Name = "Coach" }
            };
            await context.Roles.AddRangeAsync(roles);
            await context.SaveChangesAsync();
        }
    }
}
