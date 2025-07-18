﻿namespace Presentation.Seed;

public static class WorkoutDatasets
{
    //private readonly FitnessContext context;
    //public WorkoutDatasets(FitnessContext _context)
    //{
    //    context = _context;
    //}

    public static async Task<List<Workout>> WorkoutSeedAsync()
    {
        var optionsBuilder = new DbContextOptionsBuilder<FitnessContext>();
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=FitnessPlan;User Id=sa;Password=1234512345;MultipleActiveResultSets=true;TrustServerCertificate=True");

        using var context = new FitnessContext(optionsBuilder.Options);
        var workouts = new List<Workout>();
        var bodyBuildingId = await context.Sports.AsNoTracking().Where(z => z.Name == "Body Building").Select(z => z.Id).FirstOrDefaultAsync();

        // Workouts according to Eqiupments ...
        workouts = new List<Workout>
        {
            #region Dumbells
            // Chest
            //Index => 0
            new Workout { Id = 1, Name = "Dumbbell Bench Press", Description = "Targets the chest; can be done flat, incline, or decline.", SportId = bodyBuildingId },
            //Index => 1
            new Workout { Id = 2, Name = "Dumbbell Fly", Description = "Focuses on the upper and lateral pec muscles", SportId = bodyBuildingId },
            //Index => 2
            new Workout { Id = 3, Name = "Dumbbell Floor Press", Description ="Similar to bench press but performed on the floor.", SportId= bodyBuildingId },


            // Back
            //Index 3
            new Workout { Id = 4, Name = "Dumbbell Bent-Over Rows", Description ="Engages the entire back.", SportId= bodyBuildingId },
            //Index 4
            new Workout { Id = 5, Name = "Dumbbell Pullover", Description ="Works the lats and upper chest.", SportId= bodyBuildingId },
            //Index 5
            new Workout { Id = 6, Name = "Renegade Row", Description ="Combines a plank with a row for core and back strength.", SportId= bodyBuildingId },

            // Shoulders
            //Index 6
            new Workout { Id = 7, Name = "Standing Dumbbell Press", Description ="Builds shoulder strength while engaging the core.", SportId= bodyBuildingId },
            //Index 7
            new Workout { Id = 8, Name = "Dumbbell Lateral Raise", Description ="Isolates the lateral deltoids.", SportId= bodyBuildingId },
            //Index 8
            new Workout { Id = 9, Name = "Dumbbell Arnold Press", Description ="Targets multiple shoulder muscles through rotation.", SportId= bodyBuildingId },

            // Arms
            //Index 9
            new Workout { Id = 10, Name = "Dumbbell Bicep Curls", Description ="Essential for bicep development.", SportId= bodyBuildingId },
            //Index 10
            new Workout { Id = 11, Name = "Hammer Curls", Description ="Targets the brachialis and brachioradialis.", SportId= bodyBuildingId },
            //Index 11
            new Workout { Id = 12, Name = "Dumbbell Tricep Kickbacks", Description ="Isolates the triceps effectively.", SportId= bodyBuildingId },

            // Lower Body
            //Index 12
            new Workout { Id = 13, Name = "Dumbbell Squats (Goblet Squats)", Description ="Fundamental for leg strength.", SportId= bodyBuildingId },
            //Index 13
            new Workout { Id = 14, Name = "Dumbbell Lunges (Walking Lunges)", Description ="Focuses on single-leg strength and stability.", SportId= bodyBuildingId },
            //Index 14
            new Workout { Id = 15, Name = "Dumbbell Deadlifts (Stiff-Legged Deadlifts)", Description ="Engages the posterior chain, especially hamstrings and glutes.", SportId= bodyBuildingId },
            //Index 15
            new Workout { Id = 16, Name = "Dumbbell Step-Ups", Description ="Improves leg strength and balance.", SportId= bodyBuildingId },

            // Core Workouts
            //Index 16
            new Workout { Id = 17, Name = "Weighted Crunches", Description ="Targets the rectus abdominis.", SportId= bodyBuildingId },
            //Index 17
            new Workout { Id = 18, Name = "Russian Twists", Description ="Engages obliques for rotational strength.", SportId= bodyBuildingId },
            //Index 18
            new Workout { Id = 19, Name = "Plank with Dumbbells", Description ="Enhances core stability while incorporating shoulder work.", SportId= bodyBuildingId },

            // Full Body Workouts
            //Index 19
            new Workout { Id = 20, Name = "Devil's Press", Description ="Combines a burpee with dumbbells for a full-body workout.", SportId= bodyBuildingId },
            //Index 20
            new Workout { Id = 21, Name = "Farmer’s Carry", Description ="Enhances grip strength and overall conditioning while working multiple muscle groups.", SportId= bodyBuildingId },
            //Index 21
            new Workout { Id = 22, Name = "Dumbbell High Pulls", Description ="Targets shoulders, traps, and upper back.", SportId= bodyBuildingId },
            #endregion

            #region Barbells
            // Chest
            //Index => 22
            new Workout { Id = 23, Name = "Barbell Bench Press", Description ="A fundamental exercise for overall chest development.", SportId= bodyBuildingId },
            //Index => 23
            new Workout { Id = 24, Name = "Incline Barbell Press", Description ="Targets the upper chest, performed on an inclined bench.", SportId= bodyBuildingId },
            //Index => 24
            new Workout { Id = 25, Name = "Decline Barbell Press", Description ="Focuses on the lower chest, done on a declined bench.", SportId= bodyBuildingId },
            //Index => 25
            new Workout { Id = 26, Name = "Barbell Pullover", Description ="Engages the chest and lats, performed lying on a bench.", SportId= bodyBuildingId },


            // Back
            //Index => 26
            new Workout { Id = 27, Name = "Barbell Bent-Over Row", Description ="A classic exercise for building thickness in the back.", SportId= bodyBuildingId },
            //Index => 27
            new Workout { Id = 28, Name = "Pendlay Row", Description ="An explosive variation of the bent-over row focusing on strength.", SportId= bodyBuildingId },
            //Index => 28
            new Workout { Id = 29, Name = "T-Bar Row", Description ="Targets the middle back and lats; requires a T-bar setup.", SportId= bodyBuildingId },
            //Index => 29
            new Workout { Id = 30, Name = "Barbell Deadlift", Description ="A compound movement that works the entire posterior chain.", SportId= bodyBuildingId },
            //Index => 30
            new Workout { Id = 31, Name = "Barbell Shrug", Description ="Isolates the upper trapezius muscles.", SportId= bodyBuildingId },

            // Shoulders
            //Index => 31
            new Workout { Id = 32, Name = "Barbell Overhead Press", Description ="A primary shoulder exercise that also engages the core.", SportId= bodyBuildingId },
            //Index => 32
            new Workout { Id = 33, Name = "Barbell Upright Row", Description ="Targets the shoulders and traps by lifting the bar to chin height.", SportId= bodyBuildingId },
            //Index => 33
            new Workout { Id = 34, Name = "Barbell Front Raise", Description ="Isolates the front deltoids by lifting the bar in front of you.", SportId= bodyBuildingId },

            // Arms
            //Index => 34
            new Workout { Id = 35, Name = "Barbell Bicep Curl", Description ="A staple for building bicep mass.", SportId= bodyBuildingId },
            //Index => 35
            new Workout { Id = 36, Name = "Close-Grip Barbell Bench Press", Description ="Primarily targets the triceps while also engaging the chest.", SportId= bodyBuildingId },
            //Index => 36
            new Workout { Id = 37, Name = "Skull Crushers", Description ="Focuses on triceps development using a barbell.", SportId= bodyBuildingId },
                
            // Core Workouts
            //Index => 37
            new Workout { Id = 38, Name = "Barbell Squat", Description ="A fundamental exercise for overall leg development.", SportId= bodyBuildingId },
                

            //Index => 39
            new Workout { Id = 40, Name = "Barbell Lunges", Description ="Targets quads and glutes; can be performed forward or backward.", SportId= bodyBuildingId },
            //Index => 40
            new Workout { Id = 41, Name = "Barbell Romanian Deadlift", Description ="Focuses on hamstrings and glutes with a hip hinge movement.", SportId= bodyBuildingId },

            // Lower Body Workouts
            //Index => 41
            new Workout { Id = 42, Name = "Barbell Rollout", Description ="Engages core muscles through an extended rollout motion.", SportId= bodyBuildingId },
            //Index => 42
            new Workout { Id = 43, Name = "Landmine Anti-Rotation Press", Description ="Strengthens core stability while pressing a barbell anchored at one end.", SportId= bodyBuildingId },


            // Full Body Workouts
            //Index => 43
            new Workout { Id = 44, Name = "Barbell Clean and Press", Description ="A dynamic movement that works multiple muscle groups including legs, back, shoulders, and arms.", SportId= bodyBuildingId },
            //Index => 44
            new Workout { Id = 45, Name = "Barbell Thruster", Description =" Thruster: Combines a front squat with an overhead press for a full-body workout.", SportId= bodyBuildingId },

            #endregion

            #region KettleBells
            // Lower Body Exercises
            //Index => 45
            new Workout { Id = 46, Name = "Kettlebell Goblet Squat", Description ="A fundamental squat variation that enhances leg strength and mobility", SportId= bodyBuildingId },
            //Index => 46
            new Workout { Id = 47, Name = "Kettlebell Swing", Description ="A ballistic movement targeting the glutes and hamstrings", SportId= bodyBuildingId },
            //Index => 47
            new Workout { Id = 48, Name = "Kettlebell Deadlift", Description ="Effective for developing posterior chain strength", SportId= bodyBuildingId },
            //Index => 48
            new Workout { Id = 49, Name = "Kettlebell Single-Leg Deadlift", Description ="Improves balance and engages the core", SportId= bodyBuildingId },
            //Index => 49
            new Workout { Id = 50, Name = "Kettlebell Racked Lunge", Description ="", SportId= bodyBuildingId },
            //Index => 50
            new Workout { Id = 51, Name = "Kettlebell Reverse Lunge", Description ="", SportId= bodyBuildingId },
            //Index => 51
            new Workout { Id = 52, Name = "Kettlebell Side Lunge", Description ="", SportId= bodyBuildingId },
            //Index => 52
            new Workout { Id = 53, Name = "Kettlebell Walking Lunge", Description ="", SportId= bodyBuildingId },
            //Index => 53
            new Workout { Id = 54, Name = "Kettlebell Overhead Squat", Description ="Enhances shoulder stability and lower body strength.", SportId= bodyBuildingId },

            // Upper Body Exercises
            // Index => 54
            new Workout { Id = 55, Name = "Kettlebell Overhead Press", Description ="Builds shoulder strength and stability.", SportId= bodyBuildingId },
            // Index => 55
            new Workout { Id = 56, Name = "Kettlebell Snatch", Description ="A full-body power exercise that requires technique and explosiveness.", SportId= bodyBuildingId },
            // Index => 56
            new Workout { Id = 57, Name = "Kettlebell Renegade Row", Description ="Engages the core while working the back and arms.", SportId= bodyBuildingId },
            // Index => 57
            new Workout { Id = 58, Name = "Kettlebell Push Press", Description ="Combines a squat with an overhead press for total-body engagement.", SportId= bodyBuildingId },
            // Index => 58
            new Workout { Id = 59, Name = "Kettlebell High Pulls", Description ="Focuses on the upper back and shoulders.", SportId= bodyBuildingId },
                
            // Core Exercises
            // Index => 59
            new Workout { Id = 60, Name = "Turkish Get-Up", Description ="A complex movement that builds core strength and stability.", SportId= bodyBuildingId },
            // Index => 60
            new Workout { Id = 61, Name = "Kettlebell Windmill", Description ="Engages the obliques and improves shoulder mobility.", SportId= bodyBuildingId },
            // Index => 61
            new Workout { Id = 62, Name = "Kettlebell Russian Twist", Description ="Targets the obliques while enhancing rotational strength.", SportId= bodyBuildingId },


            // Full Body Exercises
            // Index => 62
            new Workout { Id = 63, Name = "Kettlebell Clean and Press", Description ="A compound movement that works multiple muscle groups.", SportId= bodyBuildingId },
            // Index => 63                
            new Workout { Id = 64, Name = "Kettlebell Thruster (Squat and Press)", Description ="Combines a squat with an overhead press for a high-intensity workout", SportId= bodyBuildingId },
            // Index => 64
            new Workout { Id = 65, Name = "Kettlebell Farmer's Walk", Description ="Improves grip strength while engaging the entire body.", SportId= bodyBuildingId },

            // Dynamic Movements
            // Index => 65
            new Workout { Id = 66, Name = "Kettlebell Swing (Single-Handed)", Description ="Adds instability to the traditional swing, enhancing grip and core engagement.", SportId= bodyBuildingId },
            // Index => 66
            new Workout { Id = 67, Name = "Kettlebell Gorilla Row", Description ="A unique row variation that targets the back while maintaining a strong core position.", SportId= bodyBuildingId },
                
            // Specialty Movements
            // Index => 67
            new Workout { Id = 68, Name = "Kettlebell Halo", Description ="Improves shoulder mobility while engaging the core.", SportId= bodyBuildingId },
            // Index => 68
            new Workout { Id = 69, Name = "Kettlebell Bottoms Up Press", Description ="Challenges stability and grip strength by holding the kettlebell upside down.", SportId= bodyBuildingId },
            #endregion

            #region Smith Machine
            // Chest
            // Index => 69
            new Workout { Id = 70, Name = "Smith Machine Bench Press", Description ="Targets the chest, triceps, and shoulders.", SportId= bodyBuildingId },
            // Index => 70
            new Workout { Id = 71, Name = "Smith Machine Incline Bench Press", Description ="Focuses on the upper chest and shoulders.", SportId= bodyBuildingId },
            // Index => 71
            new Workout { Id = 72, Name = "Smith Machine Decline Bench Press", Description ="Emphasizes the lower chest.", SportId= bodyBuildingId },
            // Index => 72
            new Workout { Id = 73, Name = "Smith Machine Close-Grip Bench Press", Description ="Targets the triceps while engaging the", SportId= bodyBuildingId },

            // Back
            // Index => 73
            new Workout { Id = 74, Name = "Smith Machine Bent Over Row", Description ="Works the upper back and lats.", SportId= bodyBuildingId },
            // Index => 74
            new Workout { Id = 75, Name = "Smith Machine Inverted Row", Description ="Engages the back and biceps with a bodyweight variation.", SportId= bodyBuildingId },
            // Index => 75
            new Workout { Id = 76, Name = "Smith Machine Reverse Grip Bent Over Row", Description ="Targets the upper back with a different grip for varied muscle activation.", SportId= bodyBuildingId },

            // Shoulders
            // Index => 76
            new Workout { Id = 77, Name = "Smith Machine Seated Shoulder Press", Description ="Isolates the shoulders and triceps.", SportId= bodyBuildingId },
            // Index => 77                
            new Workout { Id = 78, Name = "Smith Machine Upright Row", Description ="Engages the shoulders and traps.", SportId= bodyBuildingId },
            // Index => 78                
            new Workout { Id = 79, Name = "Smith Machine Behind-the-Neck Press", Description ="Targets the shoulders but should be done with caution.", SportId= bodyBuildingId },

            // Legs
            // Index => 79
            new Workout { Id = 80, Name = "Smith Machine Back Squat", Description ="A classic exercise for overall leg development.", SportId= bodyBuildingId },
            // Index => 80
            new Workout { Id = 81, Name = "Smith Machine Front Squat", Description ="Emphasizes the quads and core stability.", SportId= bodyBuildingId },
            // Index => 81
            new Workout { Id = 82, Name = "Smith Machine Romanian Deadlift", Description ="Targets the hamstrings and glutes.", SportId= bodyBuildingId },
            // Index => 82
            new Workout { Id = 83, Name = "Smith Machine Split Squat", Description ="Focuses on one leg at a time for balance and strength.", SportId= bodyBuildingId },
            // Index => 83
            new Workout { Id = 84, Name = "Smith Machine Reverse Lunge", Description ="Works the quads, hamstrings, and glutes.", SportId= bodyBuildingId },
            // Index => 84
            new Workout { Id = 85, Name = "Smith Machine Hip Thrust", Description ="Builds strength in the glutes and hamstrings.", SportId= bodyBuildingId },
            // Index => 85
            new Workout { Id = 86, Name = "Smith Machine Calf Raise", Description ="Isolates the calf muscles.", SportId= bodyBuildingId },

            // Core
            // Index => 86
            new Workout { Id = 87, Name = "Smith Machine Hanging Leg Raise", Description ="Engages the abdominal muscles effectively.", SportId= bodyBuildingId },
            // Index => 87
            new Workout { Id = 88, Name = "Smith Machine Plank (with feet on bar)", Description ="A variation that challenges core stability.", SportId= bodyBuildingId },

            // Arms
            // Index => 88
            new Workout { Id = 89, Name = "Smith Machine Skull Crushers", Description ="Targets the triceps effectively.", SportId= bodyBuildingId },
            // Index => 89
            new Workout { Id = 90, Name = "Smith Machine Bicep Curl", Description ="Isolates the biceps for focused development.", SportId= bodyBuildingId },

            // Additional Exercises
            // Index => 90
            new Workout { Id = 91, Name = "Smith Machine Kaz Press", Description ="A unique press that targets both triceps and chest.", SportId= bodyBuildingId },
            // Index => 91
            new Workout { Id = 92, Name = "Smith Machine Single-Leg Deadlift", Description ="Enhances balance while targeting hamstrings and glutes.", SportId= bodyBuildingId },

            #endregion

            #region Leg Press Machine
            // Index => 92
            new Workout {Id = 93, Name = "Standard Leg Press", Description = "A foundational exercise that targets the quadriceps, hamstrings, and glutes. / Execution: Sit on a leg press machine, place feet on the platform, and push the weight away by extending your legs.", SportId = bodyBuildingId },
            // Index => 93
            new Workout {Id = 94, Name = "Wide Stance Leg Press", Description = "Emphasizes the inner thighs and glutes by placing feet wider than shoulder-width apart", SportId = bodyBuildingId },
            // Index => 94
            new Workout {Id = 95, Name = "Narrow Stance Leg Press", Description = "Focuses on the outer quadriceps with feet placed closer together.", SportId = bodyBuildingId },
            // Index => 95
            new Workout {Id = 96, Name = "High Foot Placement Leg Press", Description = "Targets the hamstrings and glutes by positioning feet higher on the platform.", SportId = bodyBuildingId },                
            // Index => 96
            new Workout {Id = 97, Name = "Low Foot Placement Leg Press", Description = "Shifts emphasis to the quadriceps by placing feet lower on the platform.", SportId = bodyBuildingId },                
            // Index => 97
            new Workout {Id = 98, Name = "Single Leg Press", Description = "Addresses strength imbalances by performing the leg press one leg at a time.", SportId = bodyBuildingId },                
            // Index => 98
            new Workout {Id = 99, Name = "Calf Press on the Leg Press Machine", Description = "Targets the calf muscles by pressing with just the toes while keeping heels off the platform.", SportId = bodyBuildingId },                
            // Index => 99
            new Workout {Id = 100, Name = "Single-Leg Calf Raise on Leg Press Machine", Description = "Similar to the calf press but performed one leg at a time for added focus.", SportId = bodyBuildingId },                
            // Index => 100
            new Workout {Id = 101, Name = "Sumo Leg Press", Description = "A variation where feet are placed wider and turned outwards to target inner thighs more effectively.", SportId = bodyBuildingId },                
            // Index => 101
            new Workout {Id = 102, Name = "Feet Elevated Leg Press", Description = " Elevating feet on a block or platform increases range of motion and targets glutes and hamstrings more intensely.", SportId = bodyBuildingId },
            #endregion

            #region chest press machine
            // Index => 102
            new Workout {Id = 103, Name = "Machine Chest Press", Description = "This is the standard exercise that targets the pectoral muscles, triceps, and shoulders. It's typically performed for moderate to high reps (8-12) to build muscle mass", SportId = bodyBuildingId },
            // Index => 103
            new Workout {Id = 104, Name = "Incline Chest Press", Description = "Adjust the machine to an incline position to emphasize the upper chest. This variation helps in developing the upper pectoral muscles more effectively.", SportId = bodyBuildingId },
            // Index => 104
            new Workout {Id = 105, Name = "Decline Chest Press", Description = "Set the machine to a decline position to target the lower part of the chest. This variation can help in achieving a more balanced chest development", SportId = bodyBuildingId },
            // Index => 105
            new Workout {Id = 106, Name = "Leverage Chest Press", Description = "Similar to the machine chest press but uses a leverage system, allowing for a different angle and resistance curve, which can enhance muscle engagement", SportId = bodyBuildingId },
            // Index => 106
            new Workout {Id = 107, Name = "Plate-Loaded Chest Press", Description = "Utilize a plate-loaded version of the chest press machine for increased weight versatility and a different feel during the lift", SportId = bodyBuildingId },
            // Index => 107
            new Workout {Id = 108, Name = "Cable Chest Press", Description = "Perform seated, standing, or lying cable chest presses for varied resistance and muscle engagement, focusing on stability and control", SportId = bodyBuildingId },
            // Index => 108
            new Workout {Id = 109, Name = "Drop Sets", Description = "After reaching muscle fatigue at your maximum weight, immediately reduce the weight and continue pressing until failure. This technique enhances muscle endurance and hypertrophy", SportId = bodyBuildingId },
            // Index => 109
            new Workout {Id = 110, Name = "Partial Reps", Description = "Focus on the strongest part of your range of motion by performing partial reps at the peak contraction of the lift, which can help in building strength at specific points in your lift", SportId = bodyBuildingId },
            // Index => 110
            new Workout {Id = 111, Name = "High-Rep Finishing Set", Description = "Use the machine for a burnout set at the end of your workout with high repetitions (15-20) to fully exhaust your muscles", SportId = bodyBuildingId },

            #endregion

            #region Lat Pulldown Machine
            // Index => 111
            new Workout {Id = 112, Name = "Standard Lat Pulldown", Description = "The basic lat pulldown targets the latissimus dorsi, rhomboids, and biceps.", SportId = bodyBuildingId },
            // Index => 112
            new Workout {Id = 113, Name = "Wide Grip Lat Pulldown", Description = "Emphasizes the outer lats for a broader back.", SportId = bodyBuildingId },
            // Index => 113
            new Workout {Id = 114, Name = "Close Grip Lat Pulldown", Description = "Focuses more on the inner lats and biceps", SportId = bodyBuildingId },
            // Index => 114
            new Workout {Id = 115, Name = "Reverse Grip Lat Pulldown", Description = "Targets the middle back and biceps effectively.", SportId = bodyBuildingId },
            // Index => 115
            new Workout {Id = 116, Name = "Single Arm Lat Pulldown", Description = "Allows for unilateral training, helping to correct muscle imbalances.", SportId = bodyBuildingId },
            // Index => 116
            new Workout {Id = 117, Name = "Behind-the-Neck Lat Pulldown", Description = "Targets the upper lats and deltoids but should be performed with caution to avoid shoulder strain.", SportId = bodyBuildingId },
            // Index => 117
            new Workout {Id = 118, Name = "Straight Arm Lat Pulldown", Description = "Isolates the lats without involving the biceps significantly.", SportId = bodyBuildingId },
            // Index => 118
            new Workout {Id = 119, Name = "Alternating Grip Lat Pulldown", Description = "Combines different grips in one set for varied muscle engagement.", SportId = bodyBuildingId },
            #endregion

            #region Leg Curl Machine
            // Index => 119
            new Workout {Id = 120, Name = "Seated Leg Curl", Description = "This is the most common exercise performed on a leg curl machine. It effectively isolates the hamstrings while allowing for a comfortable seated position. Adjust the machine so that the pad rests just above your ankles, and curl your legs down towards your glutes", SportId = bodyBuildingId },
            // Index => 120
            new Workout {Id = 121, Name = "Lying Leg Curl", Description = "This variation involves lying face down on the machine. The pad should be positioned just above your calves, and you curl your legs upward towards your glutes. This position emphasizes the hamstrings differently than the seated version", SportId = bodyBuildingId },
            // Index => 121
            new Workout {Id = 122, Name = "Standing Leg Curl", Description = "Some machines allow for a standing position, where you curl one leg at a time while standing. This variation helps improve balance and engages the stabilizing muscles in addition to targeting the hamstrings", SportId = bodyBuildingId },
            // Index => 122
            new Workout {Id = 123, Name = "Single-Leg Curl", Description = "Perform leg curls one leg at a time to focus on muscle imbalances and enhance isolation of each hamstring individually", SportId = bodyBuildingId },
            // Index => 123
            new Workout {Id = 124, Name = "Foot Position Variations", Description = "Adjust your foot positioning (toes pointed in, out, or straight) during curls to target different parts of the hamstrings and engage other stabilizing muscles", SportId = bodyBuildingId },
            // Index => 124
            new Workout {Id = 125, Name = "Eccentric Focus", Description = "Emphasize the eccentric (lowering) phase of the curl by lowering the weight slowly after reaching the peak contraction, which can help increase muscle hypertrophy.", SportId = bodyBuildingId },
            // Index => 125
            new Workout {Id = 126, Name = "Leg Curl Drop Sets", Description = "After reaching failure at a heavier weight, immediately reduce the weight and continue performing curls until failure again to maximize muscle fatigue.", SportId = bodyBuildingId },
            // Index => 126
            new Workout {Id = 127, Name = "Supersets with Other Exercises", Description = "Combine leg curls with other lower body exercises (like squats or deadlifts) for a comprehensive leg workout that targets multiple muscle groups.", SportId = bodyBuildingId },
            #endregion

            #region Leg Extension Machine
            // Index => 127
            new Workout {Id = 128, Name = "Standard Leg Extension", Description = "Sit on the machine with your back against the pad. Adjust the pad so it rests on your lower legs, just above your ankles. Extend your legs until they are straight, then lower back down", SportId = bodyBuildingId },
            // Index => 128
            new Workout {Id = 129, Name = "Single-Leg Extension", Description = "Use the same machine but perform the exercise one leg at a time. This helps address muscle imbalances and allows for greater focus on each quadricep.", SportId = bodyBuildingId },
            // Index => 129
            new Workout {Id = 130, Name = "One-Legged Machine Extension", Description = "If available, use a unilateral leg extension machine that allows each leg to work independently, providing an additional challenge and variety.", SportId = bodyBuildingId },
                
                
            // Index => 134
            new Workout {Id = 135, Name = "Controlled Tempo", Description = "Focus on maintaining a slow and controlled tempo throughout both the lifting and lowering phases to maximize muscle engagement.", SportId = bodyBuildingId },
            #endregion

            #region Cable Machine
            // Upper Body Workouts
            // Index => 135
            new Workout { Id = 136, Name = "Cable Lat Pulldown", Description = "Targets the lats and upper back.", SportId = bodyBuildingId },
            // Index => 136
            new Workout { Id = 137, Name = "Seated Cable Row", Description = "Focuses on the middle back and biceps.", SportId = bodyBuildingId },
            // Index => 137
            new Workout { Id = 138, Name = "Cable Chest Flye", Description = "Great for isolating the pectoral muscles.", SportId = bodyBuildingId },
            // Index => 138
            new Workout { Id = 139, Name = "Cable Crossover", Description = "Engages the chest from different angles.", SportId = bodyBuildingId },
            // Index => 139
            new Workout { Id = 140, Name = "Cable Bicep Curl", Description = "Isolates the biceps for muscle growth.", SportId = bodyBuildingId },
            // Index => 140
            new Workout { Id = 141, Name = "Cable Tricep Pushdown", Description = "Targets the triceps effectively.", SportId = bodyBuildingId },
            // Index => 141
            new Workout { Id = 142, Name = "Face Pull", Description = "Strengthens the rear deltoids and rotator cuff muscles.", SportId = bodyBuildingId },
            // Index => 142
            new Workout { Id = 143, Name = "Cable Lateral Raise", Description = "Works the deltoids, particularly the side delts.", SportId = bodyBuildingId },
            // Index => 143
            new Workout { Id = 144, Name = "Cable Upright Row", Description = "Targets the shoulders and traps.", SportId = bodyBuildingId },
            // Index => 144
            new Workout { Id = 145, Name = "Straight Arm Pulldown", Description = "Focuses on the lats and core stability.", SportId = bodyBuildingId },

            // Core Workouts
            // Index => 145
            new Workout { Id = 146, Name = "Cable Crunch", Description = "Engages the abdominal muscles with constant tension.", SportId = bodyBuildingId },
            // Index => 146
            new Workout { Id = 147, Name = "Kneeling Cable Crunch", Description = "A variation that targets the core from a kneeling position.", SportId = bodyBuildingId },
            // Index => 147
            new Workout { Id = 148, Name = "Cable Wood Chop", Description = "Strengthens the obliques and improves rotational power.", SportId = bodyBuildingId },
            // Index => 148
            new Workout { Id = 149, Name = "Cable Pallof Press", Description = "Enhances core stability and anti-rotation strength.", SportId = bodyBuildingId },
            // Index => 149
            new Workout { Id = 150, Name = "Single-Arm Cable Side Bend", Description = "Targets the obliques while improving lateral strength.", SportId = bodyBuildingId },

            // Lower Body Workouts
            // Index => 150
            new Workout { Id = 151, Name = "Cable Kickback", Description = "Isolates the glutes effectively.", SportId = bodyBuildingId },
            // Index => 151
            new Workout { Id = 152, Name = "Single-Leg Cable Hip Extension", Description = "Focuses on glute activation and stability.", SportId = bodyBuildingId },
            // Index => 152
            new Workout { Id = 153, Name = "Cable Pull-Through", Description = "Engages the hamstrings and glutes with minimal spinal load.", SportId = bodyBuildingId },
            // Index => 153
            new Workout { Id = 154, Name = "Cable Squats", Description = "Adds resistance to traditional squats for extra challenge.", SportId = bodyBuildingId },
            // Index => 154
            new Workout { Id = 155, Name = "Low-Cable Cross-Over (for legs)", Description = "Targets inner thighs when performed correctly.", SportId = bodyBuildingId },
            // Index => 155
            new Workout { Id = 156, Name = "Incline Cable Chest Fly", Description = "Targets the upper portion of the chest.", SportId = bodyBuildingId },
            // Index => 156
            new Workout { Id = 157, Name = "Overhead Cable Tricep Extension", Description = "Focuses on tricep development from an overhead position.", SportId = bodyBuildingId },
            // Index => 157
            new Workout { Id = 158, Name = "Reverse Grip Triceps Pushdown", Description = "A variation that emphasizes different parts of the triceps.", SportId = bodyBuildingId },
            // Index => 158
            new Workout { Id = 159, Name = "Standing Cable Low-to-High Twist", Description = "Engages both core and shoulder muscles through rotation.", SportId = bodyBuildingId },
            // Index => 159
            new Workout { Id = 160, Name = "Rope Hammer Curl", Description = "Works both biceps and forearms effectively.", SportId = bodyBuildingId },
                
            #endregion

            #region Bench Press
            // Primary Bench Press Variations
            // Index => 160
            new Workout { Id = 161, Name = "Flat Barbell Bench Press", Description = "The classic exercise for building overall chest strength and mass.", SportId = bodyBuildingId },
            // Index => 161
            new Workout { Id = 162, Name = "Incline Barbell Bench Press", Description = "Performed on an incline bench (typically set at 30-45 degrees), this variation emphasizes the upper chest and shoulders.", SportId = bodyBuildingId },
            // Index => 162
            new Workout { Id = 163, Name = "Decline Barbell Bench Press", Description = "Involves a decline bench position, targeting the lower part of the pectorals.", SportId = bodyBuildingId },
            // Index => 164
            new Workout { Id = 165, Name = "Close-Grip Bench Press", Description = "A narrower grip that shifts focus to the triceps while still engaging the chest.", SportId = bodyBuildingId },
            // Index => 165
            new Workout { Id = 166, Name = "Wide-Grip Bench Press", Description = "A wider grip that targets the outer pectoral muscles more intensely.", SportId = bodyBuildingId },
            // Index => 166
            new Workout { Id = 167, Name = "Tempo Bench Press", Description = "Involves controlling the speed of the lift (e.g., slow lowering phase) to increase time under tension.", SportId = bodyBuildingId },
            // Index => 167
            new Workout { Id = 168, Name = "Spoto Press", Description = "Pauses just above the chest to enhance control and stability before pressing back up.", SportId = bodyBuildingId },
                
            // Index => 169
            new Workout { Id = 170, Name = "Swiss Bar Bench Press", Description = "Utilizes a Swiss bar for a neutral grip, reducing shoulder strain while still effectively targeting the chest and triceps.", SportId = bodyBuildingId },

            // Primary Bench Press Variations
            // Index => 170
            new Workout { Id = 171, Name = "Pause Bench Press", Description = "A standard press with a pause at the bottom position, enhancing strength off the chest.", SportId = bodyBuildingId },                
            // Index => 171
            new Workout { Id = 172, Name = "Pin Press", Description = "Performed by setting pins in a power rack at a specific height, focusing on pressing from a dead stop.", SportId = bodyBuildingId },
            // Index => 172
            new Workout { Id = 173, Name = "Board Press", Description = "Involves pressing with a board placed on the chest to limit range of motion, emphasizing lockout strength.", SportId = bodyBuildingId },
            // Index => 173
            new Workout { Id = 174, Name = "Reverse Grip Bench Press", Description = "A unique grip that shifts emphasis to the upper chest and triceps while providing shoulder stability.", SportId = bodyBuildingId },
            // Index => 174
            new Workout { Id = 175, Name = "Single-Arm Dumbbell Bench Press", Description = "Engages core stability while isolating each side of the chest independently.", SportId = bodyBuildingId },
            #endregion

            #region Floor Press
            // Primary Floor Press Variations
            // Index => 175
            new Workout { Id = 176, Name = "Barbell Floor Press", Description ="The standard version that targets the chest, shoulders, and triceps with minimal shoulder strain.", SportId= bodyBuildingId },
            // Index => 177
            new Workout { Id = 178, Name = "Kettlebell Floor Press", Description ="Similar to the dumbbell variation but adds unique stabilization challenges due to the kettlebell's shape.", SportId= bodyBuildingId },
            // Index => 178
            new Workout { Id = 179, Name = "Single-Arm Dumbbell Floor Press", Description ="Focuses on one side at a time, addressing muscle imbalances and enhancing core stability.", SportId= bodyBuildingId },
            // Index => 179
            new Workout { Id = 180, Name = "Single-Arm Kettlebell Floor Press", Description ="Involves pressing a kettlebell with one arm while maintaining core stability, increasing the challenge.", SportId= bodyBuildingId },
            // Index => 180
            new Workout { Id = 181, Name = "Swiss Bar Floor Press", Description ="Utilizes a Swiss bar for a neutral grip, which can reduce shoulder strain while still effectively targeting the upper body.", SportId= bodyBuildingId },

            // Primary Floor Press Variations
            // Index => 181
            new Workout { Id = 182, Name = "Paused Floor Press", Description ="Involves pausing at the bottom of the movement before pressing up, which increases time under tension for hypertrophy.", SportId= bodyBuildingId },
            // Index => 182
            new Workout { Id = 183, Name = "Resisted Floor Press", Description ="Incorporates bands or chains to increase resistance as you press, enhancing strength development throughout the movement.", SportId= bodyBuildingId },
            // Index => 183
            new Workout { Id = 184, Name = "Close-Grip Floor Press", Description ="A variation that emphasizes triceps engagement while still targeting the chest.", SportId= bodyBuildingId },
            // Index => 184
            new Workout { Id = 185, Name = "Floor Press with Chains or Bands", Description ="Adding chains or bands increases resistance as you press, challenging your muscles differently.", SportId= bodyBuildingId },
            // Index => 185
            new Workout { Id = 186, Name = "Eccentric Floor Press", Description ="Focuses on slowly lowering the weight to build strength in the eccentric phase of the lift.", SportId= bodyBuildingId },
            #endregion

            #region Treadmill
            // Index => 186
            new Workout { Id = 187, Name = "Steady-State Jogging", Description ="A basic workout where you jog at a consistent pace for a set duration (e.g., 20-30 minutes) to improve cardiovascular endurance.", SportId= bodyBuildingId },
            // Index => 187
            new Workout { Id = 188, Name = "Sprint Intervals", Description ="Alternate between high-intensity sprints and rest periods.", SportId= bodyBuildingId },
            // Index => 188
            new Workout { Id = 189, Name = "Incline Walking or Running", Description ="Set the treadmill to an incline (e.g., 5-15%) and walk or run to increase intensity and engage the legs more effectively.", SportId= bodyBuildingId },
            // Index => 189
            new Workout { Id = 190, Name = "Fartlek Training", Description ="A mix of different speeds during your run.", SportId= bodyBuildingId },
            // Index => 190
            new Workout { Id = 191, Name = "Hill Sprints", Description ="Set the incline to a steep level (e.g., 10-15%) and perform short sprints (10-30 seconds) followed by recovery periods (1-2 minutes).", SportId= bodyBuildingId },
            // Index => 191
            new Workout { Id = 192, Name = "12-3-30 Workout", Description ="Set the treadmill to a 12% incline, a speed of 3 mph, and walk for 30 minutes. This low-impact workout is effective for building endurance.", SportId= bodyBuildingId },
            // Index => 192
            new Workout { Id = 193, Name = "Bodyweight HIIT", Description ="Incorporate bodyweight exercises between running intervals.", SportId= bodyBuildingId },
            // Index => 193
            new Workout { Id = 194, Name = "Treadmill Circuit Training", Description ="Combine treadmill running with strength exercises.", SportId= bodyBuildingId },
            // Index => 194
            new Workout { Id = 195, Name = "Tempo Runs", Description ="Gradually increase your pace to a challenging but sustainable speed, maintaining it for a set duration before cooling down.", SportId= bodyBuildingId },
            // Index => 195
            new Workout { Id = 196, Name = "Recovery Walks", Description ="After intense workouts, use the treadmill for light walking to aid recovery and keep your muscles active.", SportId= bodyBuildingId },

            // Advanced Techniques
            // Index => 196
            new Workout { Id = 197, Name = "Pyramid Intervals", Description ="Gradually increase sprint durations (e.g., from 20 seconds up to 1 minute) followed by equal rest periods, then decrease back down.", SportId = bodyBuildingId },
            // Index => 197
            new Workout { Id = 198, Name = "Progressive Runs", Description ="Start at a slow pace and gradually increase speed every few minutes until reaching your maximum effort.", SportId= bodyBuildingId },
            // Index => 198
            new Workout { Id = 199, Name = "Mixed Speed Workouts", Description ="Alternate between different speeds every few minutes (e.g., fast run, moderate jog, brisk walk) to enhance endurance and speed.", SportId = bodyBuildingId },
            #endregion

            #region Rowing Machine
            // Index => 199
            new Workout { Id= 200, Name = "Interval Training", Description= "High-intensity intervals to improve endurance and burn fat", SportId = bodyBuildingId  },
            // Index => 200
            new Workout { Id= 201, Name = "Row and Core Workout", Description= "Combines rowing with core strengthening", SportId = bodyBuildingId  },
            // Index => 201
            new Workout { Id= 202, Name = "Renegade & Row EMOM", Description= "Targets back and core while incorporating rowing for cardio", SportId = bodyBuildingId  },
            // Index => 202
            new Workout { Id= 203, Name = "Pump and Row Pyramid", Description= "Full-body workout with emphasis on endurance and strength", SportId = bodyBuildingId  },
            // Index => 203
            new Workout { Id= 204, Name = "Burpee Blast Challenge", Description= "Combines cardio with explosive strength movements", SportId = bodyBuildingId  },
            // Index => 204
            new Workout { Id= 205, Name = "The Ultimate Rowing Workout", Description= "Builds lean muscle while enhancing cardiovascular fitness", SportId = bodyBuildingId  },
            // Index => 205
            new Workout { Id= 206, Name = "Endurance Rows", Description= "Improves overall cardiovascular health while toning muscles", SportId = bodyBuildingId  },
            #endregion

            #region stationary Bike
            // Index => 206
            new Workout { Id= 207, Name = "Steady-State Cycling", Description= "Maintain a consistent pace at a moderate resistance for 20-60 minutes to improve cardiovascular endurance.", SportId = bodyBuildingId  },
            // Index => 207
            new Workout { Id= 208, Name = "High-Intensity Interval Training (HIIT)", Description= "Alternate between high-intensity sprints and recovery periods. For example:\r\n30 seconds of maximum effort followed by 30 seconds of easy pedaling, repeated for 15-20 minutes.", SportId = bodyBuildingId  },
            // Index => 208
            new Workout { Id= 209, Name = "Tabata Training", Description= "Perform 20 seconds of all-out cycling followed by 10 seconds of rest, repeated for 4 minutes (8 rounds). This is an intense workout that boosts anaerobic capacity.", SportId = bodyBuildingId  },
                
            // Index => 210
            new Workout { Id= 211, Name = "Hill Climb Simulation", Description= "Increase the resistance to simulate hill climbing. Cycle at a challenging resistance for a set time (e.g., 3-5 minutes), followed by recovery periods.", SportId = bodyBuildingId  },
                
            // Index => 212
            new Workout { Id= 213, Name = "Sprinting Intervals", Description= "Sprint at high intensity for short bursts (e.g., 20-40 seconds) followed by longer recovery periods (e.g., 1-2 minutes). Repeat several times.", SportId = bodyBuildingId  },                
            // Index => 213
            new Workout { Id = 214, Name = "Resistance Pyramid", Description = "Start with low resistance and gradually increase every few minutes until reaching maximum effort, then decrease back down.", SportId = bodyBuildingId },
            // Index => 214
            new Workout { Id = 215, Name = "Mixed Cardio Circuit", Description = "Combine stationary bike workouts with bodyweight exercises (like push-ups or squats) in between cycling intervals to enhance muscle engagement.", SportId = bodyBuildingId },
            // Index => 215
            new Workout { Id = 216, Name = "Recovery Ride", Description = "Use the bike for low-intensity cycling after heavy lifting sessions to promote recovery without putting too much strain on the muscles.", SportId = bodyBuildingId },
            // Index => 216
            new Workout { Id = 217, Name = "Sprint-Focused Workout", Description = "Warm up for 5 minutes, then alternate between 30 seconds of sprinting and 1 minute of easy cycling for a total of about 15-20 minutes.", SportId = bodyBuildingId },
            // Index => 217
            new Workout { Id = 218, Name = "Endurance Challenge", Description = "Aim for longer durations at a steady pace (45-60 minutes) to build aerobic capacity and endurance.Aim for longer durations at a steady pace (45-60 minutes) to build aerobic capacity and endurance.", SportId = bodyBuildingId },
            // Index => 218
            new Workout { Id = 219, Name = "LISS (Low-Intensity Steady State) Cardio", Description = "Maintain a low intensity over a longer duration (e.g., 30-60 minutes) to promote fat burning while minimizing fatigue.", SportId = bodyBuildingId },
            // Index => 219
            new Workout { Id = 220, Name = "Cooldown Sessions", Description = "After intense workouts, spend 5-10 minutes cycling at a very light pace to help with muscle recovery and prevent stiffness.", SportId = bodyBuildingId },

            #endregion

            #region Stair Climber
            // Index => 220
            new Workout { Id = 221, Name = "Steady-State Climbing", Description = "Maintain a consistent pace for 20-30 minutes at a moderate intensity to improve cardiovascular endurance and burn calories.", SportId = bodyBuildingId },
                
                
            // Index => 226
            new Workout { Id= 227, Name = "25-7-2 Workout", Description= "Set the stair climber to an intensity level of 7 and climb for 25 minutes without holding onto the handrails to engage your core more effectively.", SportId = bodyBuildingId  },
            // Index => 227
            new Workout { Id= 228, Name = "Circuit Training", Description= "Combine stair climbing with bodyweight exercises (like push-ups or squats) in between climbing intervals to enhance muscle engagement.", SportId = bodyBuildingId  },
                
            // Index => 230
            new Workout { Id= 231, Name = "Resistance Training", Description= "Increase the resistance setting on the stair climber to challenge your muscles more and build strength in your legs and glutes.", SportId = bodyBuildingId  },
            // Index => 231
            new Workout { Id= 232, Name = "Single-Leg Climbing", Description= "Alternate between using one leg at a time to target each leg individually, which can help improve balance and address muscle imbalances.", SportId = bodyBuildingId  },
            // Index => 232
            new Workout { Id= 233, Name = "Backward Climbing", Description= "If your machine allows it, try climbing backward for short intervals to engage different muscle groups and improve coordination.", SportId = bodyBuildingId  },
            // Index => 233
            new Workout { Id= 234, Name = "Sprints on the Stair Climber", Description= "Perform short bursts of maximum effort climbing (e.g., 20-30 seconds) followed by longer recovery periods (e.g., 1-2 minutes).", SportId = bodyBuildingId  },
            #endregion

            #region Power Rack
                
            // Index => 235
            new Workout { Id = 236, Name="Rack Pulls", Description="A partial deadlift that starts with the barbell positioned at knee height, focusing on the upper portion of the deadlift movement.", SportId = bodyBuildingId },

            // Index => 237
            new Workout { Id = 238, Name="Overhead Press", Description="Standing or seated, this movement targets the shoulders and triceps while engaging the core for stability.", SportId = bodyBuildingId },
            // Index => 238
            new Workout { Id = 239, Name="Deadlifts", Description="Can be performed with the barbell set at different heights to focus on various parts of the lift (e.g., conventional deadlifts or sumo deadlifts).", SportId = bodyBuildingId },                
            // Index => 239
            new Workout { Id = 240, Name="Pull-Ups/Chin-Ups", Description="Utilize the pull-up bar attached to the power rack for bodyweight exercises targeting the back and biceps.", SportId = bodyBuildingId },
                
            // Index => 241
            new Workout { Id = 242, Name="Incline Bench Press", Description="Adjust a bench inside the rack to perform incline presses, targeting the upper chest.", SportId = bodyBuildingId },

            // Isolation Exercises
            // Index => 242
            new Workout { Id = 243, Name="Barbell Curl", Description="Use the power rack to perform curls with a barbell for focused bicep training.", SportId = bodyBuildingId },
            // Index => 243
            new Workout { Id = 244, Name="Tricep Dips", Description="If your rack has dip bars, perform dips to target the triceps and chest.", SportId = bodyBuildingId },
            // Index => 244
            new Workout { Id = 245, Name="Leg Extensions (using attachments)", Description="If your power rack has attachments, you can perform leg extensions for isolated quadricep work.", SportId = bodyBuildingId },
            // Index => 245
            new Workout { Id = 246, Name="Leg Curls (using attachments)", Description="Similar to leg extensions, if equipped, this can target the hamstrings effectively.", SportId = bodyBuildingId },

            // Advanced Techniques
            // Index => 246
            new Workout { Id = 247, Name="Paused Squats", Description="Pause at the bottom of your squat for a few seconds before pressing up to increase time under tension.", SportId = bodyBuildingId },
            // Index => 247
            new Workout { Id = 248, Name="Tempo Training", Description="Control the speed of each lift (e.g., slow descent) to enhance muscle engagement and growth.\r\n", SportId = bodyBuildingId },
                
            // Index => 249
            new Workout { Id = 250, Name="Supersets", Description="Combine two exercises (e.g., squat followed by overhead press) with minimal rest in between for increased intensity.", SportId = bodyBuildingId },
            // Index => 250
            new Workout { Id = 251, Name="Dynamic Effort Training", Description="Use lighter weights at higher speeds to develop explosive strength in compound lifts.", SportId = bodyBuildingId },
                
            // Full-Body Workouts
            // Index => 251
            new Workout { Id = 252, Name="Full-Body Circuit", Description="Create a circuit using multiple exercises (squats, bench press, rows, etc.) within the power rack for comprehensive training.", SportId = bodyBuildingId },
            // Index => 252
            new Workout { Id = 253, Name="Progressive Overload Routine", Description="Focus on gradually increasing weights across various lifts performed in the power rack over time to build strength and muscle mass.", SportId = bodyBuildingId },
            #endregion

            #region Battle Ropes
            // Index  => 253
            new Workout { Id = 254, Name="Alternating Waves", Description="Raise one arm and then the other to create waves down the rope, focusing on speed and power.", SportId = bodyBuildingId },
            // Index  => 254
            new Workout { Id = 255, Name="Two-Handed Waves", Description="Raise both ends of the rope simultaneously and slam them down, engaging the core and upper body.", SportId = bodyBuildingId },
            // Index  => 255
            new Workout { Id = 256, Name="In and Out Waves", Description="Bring both arms in simultaneously to cross over, then back out, targeting the chest and shoulders.", SportId = bodyBuildingId },
            // Index  => 256
            new Workout { Id = 257, Name="Rope Slams", Description="Lift both ends overhead and slam them down as hard as possible to engage the entire body.", SportId = bodyBuildingId },
            // Index  => 257
            new Workout { Id = 258, Name="Sidewinders", Description="Move the arms side to side while creating waves, engaging the obliques and core.", SportId = bodyBuildingId },
            // Index  => 258
            new Workout { Id = 259, Name="Snakes", Description="Create small waves by moving your arms up and down quickly, focusing on shoulder stability.", SportId = bodyBuildingId },
            // Index  => 259
            new Workout { Id = 260, Name="Rainbows", Description="Swing the ropes in an arc from one side of your body to the other, engaging the core throughout.", SportId = bodyBuildingId },
            // Index  => 260
            new Workout { Id = 261, Name="Plank Alternating Slams", Description="In a plank position, alternate slamming each end of the rope while maintaining core stability.", SportId = bodyBuildingId },
            // Index  => 261
            new Workout { Id = 262, Name="Battle Rope Russian Twists", Description="In a seated position with feet elevated, twist your torso while pulling the ropes side to side.", SportId = bodyBuildingId },
            // Index  => 262
            new Workout { Id = 263, Name="Jumping Jack Waves", Description="Perform jumping jacks while simultaneously raising and lowering the ropes, combining cardio with upper body work.", SportId = bodyBuildingId },
            // Index  => 263
            new Workout { Id = 264, Name="Alternating Lunge Wave", Description="Step back into a lunge while creating waves with the ropes, targeting legs and core.", SportId = bodyBuildingId },
            // Index  => 264
            new Workout { Id = 265, Name="Half-Kneeling Waves", Description="Perform waves from a half-kneeling position to engage the core and improve balance.", SportId = bodyBuildingId },
            // Index  => 265
            new Workout { Id = 266, Name="Tsunami Waves", Description="Create large waves by moving both arms in unison, focusing on explosive power.", SportId = bodyBuildingId },
            // Index  => 266
            new Workout { Id = 267, Name="Fireman’s Carry", Description="Sling the rope across your shoulder and perform sprints or lateral movements for added resistance.", SportId = bodyBuildingId },
            // Index  => 267
            new Workout { Id = 268, Name="Squat Waves", Description="Perform squats while creating waves with the ropes for a full-body workout.", SportId = bodyBuildingId },
                
            // Index  => 269
            new Workout { Id = 270, Name="Tabata Workout", Description="Perform 20 seconds of work followed by 10 seconds of rest for 8 rounds on various exercises (e.g., alternating waves, slams).", SportId = bodyBuildingId },
                
            // Index  => 272
            new Workout { Id = 273, Name ="Unilateral Workouts", Description = "Focus on one side at a time (e.g., unilateral waves) to improve muscle imbalances and core stability.", SportId = bodyBuildingId},
            // Index  => 273
            new Workout { Id = 274, Name ="Full-Body Conditioning Circuit", Description = "Incorporate battle ropes with bodyweight exercises (e.g., push-ups or burpees) for comprehensive conditioning.", SportId = bodyBuildingId},
            #endregion

            #region Bands
            // Upper Body Workouts
            // Index  => 274
            new Workout { Id = 275, Name ="Banded Push-Ups", Description = "Place the band around your upper back and hold the ends under your hands to increase resistance during push-ups.", SportId = bodyBuildingId},
                
            // Index => 275
            new Workout { Id = 276, Name ="Banded Chest Press", Description = "Anchor the band behind you and press forward, mimicking a bench press motion to target the chest.", SportId = bodyBuildingId},                
            // Index => 276
            new Workout { Id = 277, Name ="Banded Tricep Extensions", Description = "Anchor the band above you and extend your arms downward to target the triceps.", SportId = bodyBuildingId},
            // Index => 277
            new Workout { Id = 278, Name ="Single-Arm Lat Pulldown", Description = "Anchor the band above you and pull down with one arm to target the lats.", SportId = bodyBuildingId},                
            // Index => 278
            new Workout { Id = 279, Name ="Reverse Fly", Description = "Stand on a band, bend forward slightly, and raise your arms to the side, targeting the rear delts.", SportId = bodyBuildingId},


            // Index  => 279
            new Workout { Id = 280, Name ="Banded Shoulder Press", Description = "Stand on the band and press overhead, engaging the shoulders and triceps.", SportId = bodyBuildingId},
            // Index  => 280
            new Workout { Id = 281, Name ="Banded Bent-Over Row", Description = "Stand on the band, bend forward, and pull the handles towards your ribcage to target the back muscles.", SportId = bodyBuildingId},
            // Index  => 281
            new Workout { Id = 282, Name ="Banded Bicep Curl", Description = "Stand on the band and curl the handles towards your shoulders, focusing on the biceps.", SportId = bodyBuildingId},
            // Index  => 282
            new Workout { Id = 283, Name ="Banded Tricep Kickback", Description = "Anchor the band and extend your arms backward to work the triceps.", SportId = bodyBuildingId},
            // Index  => 283
            new Workout { Id = 284, Name ="Banded Lateral Raise", Description = "Stand on the band and raise your arms to the side to target the deltoids.", SportId = bodyBuildingId},
            // Index  => 284
            new Workout { Id = 285, Name ="Banded Chest Fly", Description = "Anchor the band behind you and perform a fly motion to engage the chest muscles.", SportId = bodyBuildingId},
            // Index  => 285
            new Workout { Id = 286, Name ="Banded Face Pull", Description = "Anchor the band at head height and pull towards your face to strengthen rear delts and upper back.", SportId = bodyBuildingId},

            // Core Workouts
            // Index  => 286
            new Workout { Id = 287, Name ="Band Pallof Press", Description = "Stand sideways to an anchored band and press it away from your chest, engaging your core for stability.", SportId = bodyBuildingId},
            // Index  => 287
            new Workout { Id = 288, Name ="Band Russian Twists", Description = "Sit with your feet elevated, holding a band anchored behind you, and twist side to side.", SportId = bodyBuildingId},
            // Index  => 288
            new Workout { Id = 289, Name ="Band Assisted Dragon Flags", Description = "Use a band for support while performing dragon flags to enhance core strength.", SportId = bodyBuildingId},
            // Index  => 289
            new Workout { Id = 290, Name ="Band Crunches", Description = "Lie on your back with the band anchored above you, pulling down as you crunch up.", SportId = bodyBuildingId},
            // Index  => 290
            new Workout { Id = 291, Name ="Band Alternate Heel Touches", Description = "Lie on your back with knees bent, holding a band, and alternate tapping each heel while engaging your core.", SportId = bodyBuildingId},

            // Index  => 291
            new Workout { Id = 292, Name ="Banded Plank Rows", Description = "In a plank position, row each arm while maintaining core stability.", SportId = bodyBuildingId},
            // Index  => 292
            new Workout { Id = 293, Name ="Banded Woodchoppers", Description = "Anchor the band low and pull diagonally across your body to engage obliques.", SportId = bodyBuildingId},
                
                
            // Lower Body Workouts
            // Index  => 293
            new Workout { Id = 294, Name ="Banded Squats", Description = "Stand on the band with feet shoulder-width apart and perform squats, adding resistance.", SportId = bodyBuildingId},
            // Index  => 294
            new Workout { Id = 295, Name ="Banded Bulgarian Split Squats", Description = "Place one foot behind you on a bench while standing on a band with the other foot to perform split squats.", SportId = bodyBuildingId},
            // Index  => 295
            new Workout { Id = 296, Name ="Banded Deadlifts", Description = "Stand on the band and perform deadlifts by hinging at the hips while keeping tension in the band.", SportId = bodyBuildingId},
            // Index  => 296
            new Workout { Id = 297, Name ="Banded Lying Hamstring Curl", Description = "Lie on your stomach with a band secured around your ankles; curl your legs towards your glutes.", SportId = bodyBuildingId},
            // Index  => 297
            new Workout { Id = 298, Name ="Banded Glute Bridges", Description = "Place a band around your thighs and perform glute bridges to activate glutes effectively.", SportId = bodyBuildingId},
            // Index  => 298
            new Workout { Id = 299, Name ="Banded Calf Raises", Description = "Stand on the band with feet shoulder-width apart and raise up onto your toes for calf engagement.", SportId = bodyBuildingId},
                
            // Index  => 299
            new Workout { Id = 300, Name ="Banded Lunges", Description = "Step back into lunges while holding onto bands for added resistance.", SportId = bodyBuildingId},
            // Index  => 300
            new Workout { Id = 301, Name ="Banded Hamstring Curls", Description = "Anchor one end of the band at ankle height; curl your leg towards your glutes while standing or lying down.", SportId = bodyBuildingId},
            // Index  => 301
            new Workout { Id = 302, Name ="Banded Side Steps (Abductions)", Description = "Place a band around your legs just above your knees; step side-to-side to target hip abductors.", SportId = bodyBuildingId},
            #endregion

            #region Stability Ball
            // Core Workouts
            // Index => 302
            new Workout { Id = 303, Name ="Stability Ball Crunch", Description = "Lie faceup on the ball with your low back supported, feet flat on the floor, and perform a crunch by raising your shoulders off the ball.", SportId = bodyBuildingId},
            // Index => 303
            new Workout { Id = 304, Name ="Stability Ball Oblique Crunch", Description = "Similar to the crunch, but rotate your upper body to one side to engage the obliques.", SportId = bodyBuildingId},
            // Index => 304
            new Workout { Id = 305, Name ="Stability Ball Knee Raise", Description = "Balance on the ball and lift one knee towards your chest, alternating sides.", SportId = bodyBuildingId},
            // Index => 305
            new Workout { Id = 306, Name ="Stability Ball Bicycle Crunch", Description = "Perform a bicycle crunch while lying on the ball, bringing opposite elbow to knee.", SportId = bodyBuildingId},
            // Index => 306
            new Workout { Id = 307, Name ="Stability Ball Tuck", Description = "Start in a plank position with feet on the ball and pull your knees towards your chest.", SportId = bodyBuildingId},
            // Index => 307
            new Workout { Id = 308, Name ="Stability Ball Pike", Description = "From a plank position, pull your feet towards your hands while keeping your legs straight to raise your hips.", SportId = bodyBuildingId},
            // Index => 308
            new Workout { Id = 309, Name ="Stability Ball Hands-to-Feet Pass", Description = "Lie on your back holding the ball between your hands and feet. Lift both to pass the ball from hands to feet and back.", SportId = bodyBuildingId},
            // Index => 309
            new Workout { Id = 310, Name ="Stability Ball Dead Bug", Description = "Lie on your back with legs up and arms extended, squeezing the ball between your hands and knees while alternating arm and leg movements.", SportId = bodyBuildingId},                
            // Index => 310
            new Workout { Id = 311, Name ="Stability Ball Stir the Pot", Description = "In a plank position with forearms on the ball, move your arms in circular motions while keeping your body stable.", SportId = bodyBuildingId},
            // Index => 311
            new Workout { Id = 312, Name ="Stability Ball Rollout", Description = "Kneel with the ball in front of you and roll it forward while keeping your core engaged.", SportId = bodyBuildingId},

            // Lower Body Workouts
            // Index => 312
            new Workout { Id = 313, Name ="Stability Ball Hip Thrust", Description = "Lie on your back with shoulders on the ball and feet flat on the ground; lift hips to engage glutes.", SportId = bodyBuildingId},
            // Index => 313
            new Workout { Id = 314, Name ="Stability Ball Hamstring Curl", Description = "Lie on your back with heels resting on the ball; lift hips and curl the ball towards you by bending your knees.", SportId = bodyBuildingId},
            // Index => 314
            new Workout { Id = 315, Name ="Stability Ball Squat", Description = "Stand with your back against a wall and place a stability ball between you and the wall; perform squats while pressing against the ball.", SportId = bodyBuildingId},
            // Index => 315
            new Workout { Id = 316, Name ="Stability Ball Lunge", Description = "Place one foot on the ball behind you and perform lunges with the other leg.", SportId = bodyBuildingId},
            // Index => 316
            new Workout { Id = 317, Name ="Stability Ball Glute Bridge", Description = "With feet on the ball, lift hips off the ground to engage glutes and hamstrings.", SportId = bodyBuildingId},
            // Index => 317
            new Workout { Id = 318, Name ="Stability Ball Single-Leg Hamstring Curl", Description = "Perform hamstring curls with one leg while keeping the other extended.", SportId = bodyBuildingId},
            // Index => 318
            new Workout { Id = 319, Name ="Stability Ball Rearfoot Elevated Split Squat", Description = "Place one foot on the ball behind you; squat down with the front leg.", SportId = bodyBuildingId},
            // Index => 319
            new Workout { Id = 320, Name ="Stability Ball Calf Raises", Description = "Stand on a stability ball or use it for balance while performing calf raises.", SportId = bodyBuildingId},

            // Upper Body Workouts
            // Index => 320
            new Workout { Id = 321, Name ="Stability Ball Push-Ups", Description = "Place hands on the stability ball while performing push-ups to engage stabilizing muscles.", SportId = bodyBuildingId},
            // Index => 321
            new Workout { Id = 322, Name ="Stability Ball Tricep Dips", Description = "With hands on the ball behind you, lower and raise your body using triceps.", SportId = bodyBuildingId},
            // Index => 322
            new Workout { Id = 323, Name ="Kneeling Triceps Extension", Description = "Kneel with arms resting on the stability ball; extend arms to work triceps.", SportId = bodyBuildingId},
            // Index => 323
            new Workout { Id = 324, Name ="Chest Flys on Stability Ball", Description = "Lie back on a stability ball holding dumbbells; perform flys to target chest muscles.", SportId = bodyBuildingId},
            // Index => 324
            new Workout { Id = 325, Name ="Y's and T's", Description = "Lie face down on the stability ball and raise arms in a Y or T position to engage shoulders and upper back.", SportId = bodyBuildingId},
            // Index => 325
            new Workout { Id = 326, Name ="Stability Ball Plank Rows", Description = "In plank position with hands on the ball, row one arm at a time to engage back muscles.", SportId = bodyBuildingId},
            // Index => 326
            new Workout { Id = 327, Name ="Forearm Plank with Feet on Stability Ball", Description = "Hold a plank position with feet resting on the stability ball for core stability training.", SportId = bodyBuildingId},
            // Index => 327
            new Workout { Id = 328, Name ="Push-Up Variations (Feet or Hands Elevated)", Description = "Elevate either feet or hands on the stability ball for added difficulty during push-ups.", SportId = bodyBuildingId},

            #endregion

            #region Foam Roll
            // Lower Body
            // Index => 328
            new Workout { Id = 329, Name ="Quadriceps Roll", Description = "Position the foam roller under your quads and roll from the hip to just above the knee to release tension.", SportId = bodyBuildingId},
            // Index => 329
            new Workout { Id = 330, Name ="Hamstring Roll", Description = "Sit with your legs extended and place the roller under your hamstrings. Roll from just below the glutes to just above the knees.", SportId = bodyBuildingId},
            // Index => 330
            new Workout { Id = 331, Name ="IT Band Roll", Description = "Lie on your side with the roller positioned along the outside of your thigh. Roll from just below the hip to just above the knee.", SportId = bodyBuildingId},
            // Index => 331
            new Workout { Id = 332, Name ="Calf Roll", Description = "Sit with your legs extended and place the roller under your calves. Lift your body off the ground and roll from knee to ankle.", SportId = bodyBuildingId},
            // Index => 332
            new Workout { Id = 333, Name ="Glute Roll", Description = "Sit on the foam roller and cross one ankle over the opposite knee. Lean into the glute and roll back and forth.", SportId = bodyBuildingId},
            // Index => 333
            new Workout { Id = 334, Name ="Hip Flexor Roll", Description = "Lie face down with the roller under one hip flexor, rolling slowly to release tightness in that area.", SportId = bodyBuildingId},
                
            // Upper Body
            // Index => 334
            new Workout { Id = 335, Name ="Thoracic Spine Roll", Description = "Place the roller under your upper back and roll from the mid-back to the shoulder blades to improve spinal mobility.", SportId = bodyBuildingId},
            // Index => 335
            new Workout { Id = 336, Name ="Lats Roll", Description = "Lie on your side with the foam roller positioned under your lat (just below your armpit). Roll down towards your mid-back.", SportId = bodyBuildingId},
            // Index => 336
            new Workout { Id = 337, Name ="Shoulder Roll", Description = "Lie on your side with the roller under one shoulder and roll up and down to target shoulder tightness.", SportId = bodyBuildingId},
            // Index => 337
            new Workout { Id = 338, Name ="Pectoral Stretch", Description = "Position the foam roller vertically along your spine and relax into a stretch with arms outstretched in a \"Y\" position for chest opening.", SportId = bodyBuildingId},

            // Core
            // Index => 338
            new Workout { Id = 339, Name ="Lower Back Roll", Description = "Caution: Only perform if you have adequate core strength. Lie on your back with the roller positioned under your lower back, rolling gently from mid-back to low back.", SportId = bodyBuildingId},
            // Index => 339
            new Workout { Id = 340, Name ="Abdominal Foam Rolling", Description = "Lie face down with the foam roller positioned under your abdomen; gently roll side to side for core relaxation.", SportId = bodyBuildingId},
            #endregion

            #region Abdominal Bench
            // Index => 340
            new Workout { Id = 341, Name ="Bench Crunch", Description = "Lie on your back on the bench with feet on the bench or in the air. Lift your shoulders off the bench to engage your abs.", SportId = bodyBuildingId},
            // Index => 341
            new Workout { Id = 342, Name ="Reverse Crunch", Description = "Lie on your back, grab the bench behind your head, and lift your hips off the bench while bringing your knees towards your chest.", SportId = bodyBuildingId},
            // Index => 342
            new Workout { Id = 343, Name ="Jackknife", Description = "Lie on your back with legs in the air. Simultaneously lift your shoulders off the bench while lowering your legs towards the bench.", SportId = bodyBuildingId},
            // Index => 343
            new Workout { Id = 344, Name ="Leg Raises", Description = "Lie on your back, hold the bench at your sides, and lift your legs towards the ceiling, keeping them straight or slightly bent.", SportId = bodyBuildingId},
            // Index => 344
            new Workout { Id = 345, Name ="Flutter Kicks", Description = "Lie on your back, lift your shoulders off the bench, and alternate raising each leg in a fluttering motion.", SportId = bodyBuildingId},
            // Index => 345
            new Workout { Id = 346, Name ="Knee to Chest Crunches", Description = "Lie on your back, bend your knees, and simultaneously lift your shoulders off the bench while bringing your knees to your chest.", SportId = bodyBuildingId},
            // Index => 346
            new Workout { Id = 347, Name ="Decline Sit-Ups", Description = "Set the bench at a decline angle and perform full sit-ups.", SportId = bodyBuildingId},
                
            // Index => 348
            new Workout { Id = 349, Name ="Bicycle Crunches", Description = "Highly effective for engaging the rectus abdominis and obliques. / Execution: Lie on your back, bring your knees toward your chest, and lift your shoulder blades off the ground. Straighten one leg while twisting your torso to bring the opposite elbow towards the bent knee. Alternate sides.", SportId = bodyBuildingId},
            // Index => 349
            new Workout { Id = 350, Name ="Hip Lifts", Description = "Lie on your back, anchor your hands overhead, and lift your hips towards the ceiling.", SportId = bodyBuildingId},
            // Index => 350
            new Workout { Id = 351, Name ="Straight Leg Raises", Description = "Similar to leg raises, but keep your legs completely straight throughout the movement.", SportId = bodyBuildingId},
            // Index => 351
            new Workout { Id = 352, Name ="Decline Plank", Description = "Set up in a plank position with your feet elevated on the bench.", SportId = bodyBuildingId},
            #endregion

            #region Pull-Up Bar
            // Index => 352
            new Workout { Id = 353, Name ="Standard Pull-Ups", Description = "Grip the bar with palms facing away from you, pull your body up until your chin is above the bar.", SportId = bodyBuildingId},
            // Index => 353
            new Workout { Id = 354, Name ="Chin-Ups", Description = "Grip the bar with palms facing you. This variation emphasizes the biceps more than standard pull-ups.", SportId = bodyBuildingId},
            // Index => 354
            new Workout { Id = 355, Name ="Wide-Grip Pull-Ups", Description = "Use a wider grip to target the upper back and lats more intensely.", SportId = bodyBuildingId},

            // Index => 355
            new Workout { Id = 356, Name ="Close-Grip Pull-Ups", Description = "A narrower grip that focuses more on the biceps and inner back muscles.", SportId = bodyBuildingId},

            // Index => 356
            new Workout { Id = 357, Name ="Weighted Pull-Ups", Description = "Add weight using a dip belt or weighted vest to increase resistance during pull-ups.", SportId = bodyBuildingId},

            // Index => 357
            new Workout { Id = 358, Name ="Assisted Pull-Ups", Description = "Use a resistance band or an assisted pull-up machine to help lift your body weight.", SportId = bodyBuildingId},

            // Index => 358
            new Workout { Id = 359, Name ="Negative Pull-Ups", Description = "Jump or step up to the top position and slowly lower yourself down to build strength.", SportId = bodyBuildingId},

            // Index => 359
            new Workout { Id = 360, Name ="Scapular Pull-Ups", Description = "Hang from the bar and perform small movements by retracting and depressing your shoulder blades without bending your elbows.", SportId = bodyBuildingId},

            // Index => 360
            new Workout { Id = 361, Name ="L-Sit Pull-Ups", Description = "Perform pull-ups while holding your legs straight out in front of you, engaging your core throughout.", SportId = bodyBuildingId},

            // Index => 361
            new Workout { Id = 362, Name ="Muscle-Ups", Description = "A combination of a pull-up and a dip; pull up explosively and transition into a dip position above the bar.", SportId = bodyBuildingId},

            // Core Exercises
            // Index => 362
            new Workout { Id = 363, Name ="Hanging Knee Raises", Description = "Hang from the bar and lift your knees towards your chest, focusing on engaging your abs.", SportId = bodyBuildingId},

            // Index => 363
            new Workout { Id = 364, Name ="Hanging Leg Raises", Description = "Similar to knee raises but keep your legs straight as you lift them towards the bar.", SportId = bodyBuildingId},

            // Index => 364
            new Workout { Id = 365, Name ="Hanging Windshield Wipers", Description = "From a hanging position, move your legs side to side in a controlled manner to target obliques.", SportId = bodyBuildingId},

            // Index => 365
            new Workout { Id = 366, Name ="Hanging L-Sit", Description = "Hang from the bar with legs extended in front of you, holding this position to engage core muscles.\r\nHanging Straight Leg Raise", SportId = bodyBuildingId},
            // Dynamic Movements
            // Index => 366
            new Workout { Id = 367, Name ="Burpee Pull-Ups", Description = "Perform a burpee followed by a pull-up, combining cardio with strength training.", SportId = bodyBuildingId},

            // Index => 367
            new Workout { Id = 368, Name ="Kipping Pull-Ups", Description = "Use momentum from your hips to assist in pulling yourself up, often used in CrossFit workouts.", SportId = bodyBuildingId},

            // Index => 368
            new Workout { Id = 369, Name ="Towel Pull-Ups", Description = "Drape a towel over the bar and grip it for added difficulty and grip training.", SportId = bodyBuildingId},

            // Index => 369
            new Workout { Id = 370, Name ="One-Arm Pull-Up (Assisted)", Description = "Use one arm while holding onto the other arm for assistance; progress towards full one-arm pull-ups.", SportId = bodyBuildingId},

            // Index => 370
            new Workout { Id = 371, Name ="Front Lever Holds", Description = "Hang from the bar and lift your body into a horizontal position, engaging multiple muscle groups for strength.", SportId = bodyBuildingId},
            #endregion

            #region Cable
            // Upper Body Exercises:

            // Index => 374
            new Workout { Id = 375, Name ="Cable Fly", Description = "", SportId = bodyBuildingId},

            // Index => 375
            new Workout { Id = 376, Name ="Cable Press-Around", Description = "", SportId = bodyBuildingId},

            // Index => 376
            new Workout { Id = 377, Name ="Straight-Arm Pulldown", Description = "", SportId = bodyBuildingId},

            // Index => 378
            new Workout { Id = 379, Name ="Close-Grip Lat Pulldown", Description = "", SportId = bodyBuildingId},
                
            // Index => 379
            new Workout { Id = 380, Name ="Single-Arm Overhead Triceps Extension", Description = "", SportId = bodyBuildingId},

            // Index => 380
            new Workout { Id = 381, Name ="Cable Row", Description = "", SportId = bodyBuildingId},

            // Index => 382
            new Workout { Id = 383, Name ="Upright Cable Fly", Description = "", SportId = bodyBuildingId},

            // Index => 383
            new Workout { Id = 384, Name ="Low to High Cable Raise", Description = "", SportId = bodyBuildingId},

            // Index => 384
            new Workout { Id = 385, Name ="Front Raise (Hammer Grip, Single Arm, and with Bar)", Description = "", SportId = bodyBuildingId},

            // Index => 385
            new Workout { Id = 386, Name ="Side Hang Lateral Raise", Description = "", SportId = bodyBuildingId},

            // Index => 386
            new Workout { Id = 387, Name ="Bent Over Cable Crossover", Description = "", SportId = bodyBuildingId},

            // Index => 387
            new Workout { Id = 388, Name ="Bent Over Row with Bar", Description = "", SportId = bodyBuildingId},

            // Index => 388
            new Workout { Id = 389, Name ="Standing Row (Single Arm)", Description = "", SportId = bodyBuildingId},

            // Index => 389
            new Workout { Id = 390, Name="Kneeling Row (Single Arm)", Description="", SportId= bodyBuildingId},

            // Index => 390
            new Workout { Id = 391, Name="Cable Pushdown", Description="", SportId= bodyBuildingId},

            // Index => 391
            new Workout { Id = 392, Name="Rope Pushdown", Description="", SportId= bodyBuildingId},

            // Index => 392
            new Workout { Id = 393, Name="Single Arm Cable Extension", Description="", SportId= bodyBuildingId},

            // Index => 393
            new Workout { Id = 394, Name="Double Handle Cable Extension", Description="", SportId= bodyBuildingId},

            // Index => 394
            new Workout { Id = 395, Name="Overhead Extension", Description="", SportId= bodyBuildingId},


            //Lower Body Exercises:

            // Index => 397
            new Workout { Id = 398, Name="Cable Lunges", Description="", SportId= bodyBuildingId},

            // Index => 398
            new Workout { Id = 399, Name="Cable Leg Extensions", Description="", SportId= bodyBuildingId},

            // Index => 399
            new Workout { Id = 400, Name="Cable Hamstring Curls", Description="", SportId= bodyBuildingId},

            // Core Exercises
            // Index => 400
            new Workout { Id = 401, Name="Cable Crunches", Description="", SportId= bodyBuildingId},

            // Index => 403
            new Workout { Id = 404, Name="Cable Russian Twists", Description="", SportId= bodyBuildingId},
            #endregion

            #region Medicine Ball
            // Core Exercises
            // Index => 404
            new Workout { Id = 405, Name ="Russian Twist", Description = "Sit on the ground, lean back slightly, and twist your torso side to side while holding the medicine ball.", SportId = bodyBuildingId},
            // Index => 405
            new Workout { Id = 406, Name ="Medicine Ball V-Up", Description = "Lie on your back, hold the ball overhead, and lift your arms and legs simultaneously to form a V shape, passing the ball from hands to feet.", SportId = bodyBuildingId},
            // Index => 406
            new Workout { Id = 407, Name ="Medicine Ball Crunch", Description = "Lie on your back with legs elevated; hold the ball overhead and crunch up, bringing the ball towards your knees.", SportId = bodyBuildingId},
            // Index => 407
            new Workout { Id = 408, Name ="Medicine Ball Toe Touches", Description = "Lie on your back with legs straight up; lift your shoulders off the ground and reach for your toes with the medicine ball.", SportId = bodyBuildingId},
            // Index => 408
            new Workout { Id = 409, Name ="Medicine Ball Plank Pass", Description = "In a plank position, pass the medicine ball from one hand to the other while maintaining stability.", SportId = bodyBuildingId},

            // Index => 409
            new Workout { Id = 410, Name ="Medicine Ball Woodchoppers", Description = "Stand with feet shoulder-width apart; hold the ball overhead and bring it diagonally down across your body to engage your core.", SportId = bodyBuildingId},
            // Index => 410
            new Workout { Id = 411, Name ="Medicine Ball Side Plank Rotation", Description = "In a side plank position, hold the medicine ball and rotate your torso to bring it towards the ground, then back up.", SportId = bodyBuildingId},
                
                
            // Upper Body Exercises
            // Index => 411
            new Workout { Id = 412, Name ="Medicine Ball Push-Ups", Description = "Place one hand on the medicine ball while performing push-ups to engage stabilizing muscles.", SportId = bodyBuildingId},
            // Index => 412
            new Workout { Id = 413, Name ="Medicine Ball Overhead Press", Description = "Stand or sit with the ball at chest height; press it overhead and lower it back down.", SportId = bodyBuildingId},
            // Index => 413
            new Workout { Id = 414, Name ="Medicine Ball Slams", Description = "Lift the ball overhead and slam it down to the ground, engaging your entire body for power.", SportId = bodyBuildingId},

            // Index => 414
            new Workout { Id = 415, Name ="Rolling Push-Ups", Description = "Perform push-ups while rolling the medicine ball between hands after each rep.", SportId = bodyBuildingId},
            // Index => 415
            new Workout { Id = 416, Name ="Medicine Ball Chest Pass", Description = "Stand facing a wall; throw the ball against it explosively and catch it on the rebound.", SportId = bodyBuildingId},
            // Index => 416
            new Workout { Id = 417, Name ="Medicine Ball Tricep Extensions", Description = "Hold the ball overhead with both hands, lower it behind your head, then extend back up.", SportId = bodyBuildingId},


            // Index => 417
            new Workout { Id = 418, Name ="Bicep Curl with Medicine Ball", Description = "Stand with feet shoulder-width apart; hold the ball at chest level and curl it towards your chest.", SportId = bodyBuildingId},
                
            // Lower Body Exercises
            // Index => 418
            new Workout { Id = 419, Name ="Medicine Ball Squat", Description = "Hold the medicine ball at chest level while performing squats to add resistance.", SportId = bodyBuildingId},
            // Index => 419
            new Workout { Id = 420, Name ="Medicine Ball Lunge and Twist", Description = "Step forward into a lunge while twisting your torso towards the leg that is forward, holding the medicine ball.", SportId = bodyBuildingId},


            // Index => 420
            new Workout { Id = 421, Name ="Reaching Romanian Deadlift", Description = "Stand on one leg while holding a medicine ball; hinge at your hips to lower the ball toward the ground while extending the other leg behind you.", SportId = bodyBuildingId},
            // Index => 421
            new Workout { Id = 422, Name ="Medicine Ball Thruster", Description = "Perform a squat holding the ball at chest level, then explode upward while pressing the ball overhead.", SportId = bodyBuildingId},
            // Index => 422
            new Workout { Id = 423, Name ="Medicine Ball Side Lunges", Description = "Hold the medicine ball at chest level as you perform side lunges, keeping your core engaged.", SportId = bodyBuildingId},
            // Index => 423
            new Workout { Id = 424, Name ="Medicine Ball Step-Ups", Description = "Step onto a bench or platform while holding a medicine ball at chest height for added resistance.", SportId = bodyBuildingId},

            // Dynamic Movements
            // Index => 424
            new Workout { Id = 425, Name ="Overhead Medicine Ball Throw", Description = "Stand 8-10 feet from a wall; throw the medicine ball overhead against it and catch it on rebound.", SportId = bodyBuildingId},
            // Index => 425
            new Workout { Id = 426, Name ="Rotational Medicine Ball Throw", Description = "Stand sideways to a wall; rotate your torso and throw the ball against it explosively using hip rotation for power.", SportId = bodyBuildingId},
            // Index => 426
            new Workout { Id = 427, Name ="Medicine Ball Soccer Throw", Description = "Hold the medicine ball overhead and step forward as you throw it against a wall in a soccer-style motion.", SportId = bodyBuildingId},
            // Index => 427
            new Workout { Id = 428, Name ="Medicine Ball Figure 8s", Description = "Pass the medicine ball around your legs in a figure-eight pattern to engage core stability and coordination.", SportId = bodyBuildingId},
            // Index => 428
            new Workout { Id = 429, Name ="Medicine Ball Around-the-World", Description = "Hold the medicine ball above your head and make large circular movements with your arms in both directions.", SportId = bodyBuildingId},
            #endregion

            #region E-Z Curl Bar
            // Bicep Exercises
            // Index => 429
            new Workout { Id = 430, Name ="Standard Bicep Curl", Description = "Stand with the bar at shoulder height and curl it up towards your chest, focusing on squeezing your biceps at the top.", SportId = bodyBuildingId},
            // Index => 430
            new Workout { Id = 431, Name ="Close-Grip E-Z Bar Curl", Description = "Use a closer grip to target the long head of the biceps, enhancing peak development", SportId = bodyBuildingId},
            // Index => 431
            new Workout { Id = 432, Name ="Preacher Curl", Description = "Sit on a preacher bench and curl the bar towards your shoulders, isolating the biceps effectively", SportId = bodyBuildingId},
            // Index => 432
            new Workout { Id = 433, Name ="Reverse Curl", Description = "Hold the bar with an overhand grip and curl it upwards, targeting the forearms and biceps", SportId = bodyBuildingId},
            // Index => 433
            new Workout { Id = 434, Name ="21s", Description = "Perform seven curls in the lower half of the movement, seven in the upper half, and seven full curls for an intense bicep workout", SportId = bodyBuildingId},
                
            // Triceps Exercises
                
            // Index => 435
            new Workout { Id = 436, Name ="Overhead Triceps Extension", Description = "Hold the bar overhead with arms extended, then lower it behind your head before raising it back up", SportId = bodyBuildingId},
                
            // Shoulder Exercises
            // Index => 437
            new Workout { Id = 438, Name ="Shoulder Press", Description = "Press the bar overhead while standing or seated to engage shoulder muscles effectively", SportId = bodyBuildingId},
            // Index => 438
            new Workout { Id = 439, Name ="Upright Row", Description = "Hold the bar with an overhand grip and pull it vertically towards your chin, engaging both shoulders and traps", SportId = bodyBuildingId},
                
            // Back Exercises
            // Index => 439
            new Workout { Id = 440, Name ="Bent Over Row", Description = "Bend forward at the hips while holding the bar and pull it towards your waist to work on back strength", SportId = bodyBuildingId},

            #endregion

            #region Trap Bar (Hex Bar)
            // Lower Body Exercises
            // Index => 440
            new Workout { Id = 441, Name ="Trap Bar Deadlift", Description = "A fundamental exercise for building strength in the legs and back.", SportId = bodyBuildingId},
            // Index => 441
            new Workout { Id = 442, Name ="Romanian Deadlift", Description = "Focuses on the hamstrings and glutes while maintaining a slight bend in the knees.", SportId = bodyBuildingId},
            // Index => 442
            new Workout { Id = 443, Name ="Stiff-Legged Deadlift", Description = "Targets the hamstrings and lower back with minimal knee flexion.", SportId = bodyBuildingId},
            // Index => 443
            new Workout { Id = 444, Name ="Split Squat", Description = "A unilateral exercise that enhances balance and leg strength.", SportId = bodyBuildingId},
            // Index => 444
            new Workout { Id = 445, Name ="Lunges", Description = "Can be performed forward or backward to target the quads and glutes.", SportId = bodyBuildingId},
            // Index => 445
            new Workout { Id = 446, Name ="Hex Bar Squat", Description = "Allows for squatting with a more natural grip, reducing stress on the lower back.", SportId = bodyBuildingId},
            // Index => 446
            new Workout { Id = 447, Name ="Jump Squats", Description = "A plyometric variation that builds explosive power in the legs.", SportId = bodyBuildingId},
            // Index => 447
            new Workout { Id = 448, Name ="Farmer's Walk", Description = "Enhances grip strength and overall conditioning by carrying the bar over distance.", SportId = bodyBuildingId},
            // Upper Body Exercises
                
                
            // Index => 450
            new Workout { Id = 451, Name ="Push-Ups on Trap Bar", Description = "Elevates the push-up position for increased range of motion and comfort.", SportId = bodyBuildingId},
                
            // Index => 452
            new Workout { Id = 453, Name ="Shrugs", Description = "Targets the trapezius muscles, focusing on shoulder stability and strength.", SportId = bodyBuildingId},
            // Index => 453
            new Workout { Id = 454, Name ="Chest Supported Row", Description = "Provides support for the chest while targeting upper back muscles.", SportId = bodyBuildingId},
                

            // Core Exercises
            // Index => 455
            new Workout { Id = 456, Name ="Plank Holds", Description = "Engages core muscles effectively while stabilizing with the barbell.", SportId = bodyBuildingId},                
            // Index => 456
            new Workout { Id = 457, Name ="Burpee Jumps with Trap Bar", Description = "Combines cardio with strength training, enhancing explosiveness and endurance.", SportId = bodyBuildingId},
            // Index => 457
            new Workout { Id = 458, Name ="Suitcase Carry", Description = "Improves core stability and grip strength by carrying the bar on one side.", SportId = bodyBuildingId},
                
            // Advanced Variations
            // Index => 458
            new Workout { Id = 459, Name ="Elevated Split Squat", Description = "Involves placing one foot on an elevated surface to increase range of motion and difficulty.", SportId = bodyBuildingId},
            // Index => 459
            new Workout { Id = 460, Name ="Single Leg Deadlift", Description = "A balance-focused exercise that targets hamstrings and glutes unilaterally.", SportId = bodyBuildingId},
            // Index => 460
            new Workout { Id = 461, Name ="Trap Bar Push Press", Description = "Combines a leg drive with an overhead press for full-body engagement.", SportId = bodyBuildingId},
            #endregion

            #region Cambered Bar
            // Lower Body Exercises
            // Index => 461
            new Workout { Id = 462, Name ="Cambered Bar Squat", Description = "A variation of the squat that allows for a lower center of gravity, promoting better balance and engagement of the posterior chain.", SportId = bodyBuildingId},
                
            // Index => 463
            new Workout { Id = 464, Name ="Box Squats", Description = "Sit back onto a box or bench to improve squat depth and technique.", SportId = bodyBuildingId},
            // Index => 464
            new Workout { Id = 465, Name ="Front Squats", Description = "Use the cambered bar for front squats to challenge your core stability while maintaining an upright torso.", SportId = bodyBuildingId},
            // Index => 465
            new Workout { Id = 466, Name ="Good Mornings", Description = "Hinge at the hips with the bar on your back to target the hamstrings and lower back.", SportId = bodyBuildingId},
                
            // Index => 467
            new Workout { Id = 468, Name ="Romanian Deadlifts", Description = "Focus on hamstring development by lowering the bar while keeping your legs relatively straight.", SportId = bodyBuildingId},
                
            // Upper Body Exercises
            // Index => 468
            new Workout { Id = 469, Name ="Cambered Bar Overhead Press", Description = "Press the bar overhead while standing or seated, benefiting from a neutral grip that reduces shoulder strain.", SportId = bodyBuildingId},
            // Index => 469
            new Workout { Id = 470, Name ="Bent-Over Row", Description = "Hinge forward and row the cambered bar towards your torso to target the upper back and lats.", SportId = bodyBuildingId},

            // Index => 471
            new Workout { Id = 472, Name ="Push-Ups on Cambered Bar", Description = "Elevate your push-up position using the cambered bar for increased range of motion.", SportId = bodyBuildingId},
                
                
            // Core Exercises
            // Index => 473
            new Workout { Id = 474, Name ="Plank Holds with Cambered Bar", Description = "Place your hands on the bar while holding a plank position to engage your core muscles.", SportId = bodyBuildingId},
                
            // Index => 475
            new Workout { Id = 476, Name ="Farmers Walk", Description = "Carry the cambered bar over a distance to enhance grip strength and overall conditioning.", SportId = bodyBuildingId},                
            // Advanced Variations
            // Index => 476
            new Workout { Id = 477, Name ="Tempo Squats", Description = "Perform squats with controlled tempos (slow descent and explosive ascent) to increase time under tension.", SportId = bodyBuildingId},
            // Index => 477
            new Workout { Id = 478, Name ="Single-Leg Deadlifts", Description = "Use the cambered bar for unilateral training, focusing on balance and coordination while targeting each leg individually.", SportId = bodyBuildingId},
            // Index => 478
            new Workout { Id = 479, Name ="Split Squats", Description = "Perform split squats with one foot elevated behind you, using the cambered bar for added resistance.", SportId = bodyBuildingId},
            #endregion

            #region Safety Bar
            // Lower Body Exercises
            // Index => 479
            new Workout { Id = 480, Name ="Safety Bar Squat", Description = "The primary exercise that targets the quads, hamstrings, and glutes while allowing for a more upright torso position.", SportId = bodyBuildingId},
            // Index => 480
            new Workout { Id = 481, Name ="Hatfield Squat", Description = "A variation where you can hold onto supports for balance, making it easier to focus on depth and form.", SportId = bodyBuildingId},
            // Index => 481
            new Workout { Id = 482, Name ="Walking Lunges", Description = "Perform lunges while holding the Safety Bar to engage the legs and improve stability.", SportId = bodyBuildingId},
                
            // Index => 484
            new Workout { Id = 485, Name ="Upper Back Good Mornings", Description = "A variation focusing more on upper back engagement while performing the good morning movement.", SportId = bodyBuildingId},
            // Index => 485
            new Workout { Id = 486, Name ="Side Bends", Description = "Perform side bends with the Safety Bar to target the obliques and improve core strength.", SportId = bodyBuildingId},

            // Upper Body Exercises
            // Index => 487
            new Workout { Id = 488, Name ="Tricep Extensions", Description = "Use the Safety Bar for overhead tricep extensions, effectively targeting the triceps.", SportId = bodyBuildingId},
            // Index => 488
            new Workout { Id = 489, Name ="JM Press", Description = "A hybrid movement combining a close-grip bench press with a skull crusher for tricep development.", SportId = bodyBuildingId},
            // Index => 489
            new Workout { Id = 490, Name ="Safety Bar Floor Press", Description = "Lying on the floor, press the Safety Bar from a neutral position to target the chest and triceps without straining the shoulders.", SportId = bodyBuildingId},
                
                
            // Core Exercises
            // Index => 492
            new Workout { Id = 493, Name ="Loaded Carry", Description = "Carrying the Safety Bar over a distance helps improve grip strength and core stability.", SportId = bodyBuildingId},
            // Index => 493
            new Workout { Id = 494, Name ="Plank Holds with Safety Bar", Description = "Position yourself in a plank while holding onto the Safety Bar for added core engagement.", SportId = bodyBuildingId},
            #endregion

            #region Axle Bar
            // Lower Body Exercises
            // Index => 494
            new Workout { Id = 495, Name ="Axle Bar Deadlift", Description = "A fundamental exercise for building overall strength in the posterior chain, particularly the hamstrings, glutes, and lower back.", SportId = bodyBuildingId},
            // Index => 495
            new Workout { Id = 496, Name ="Axle Bar Squat", Description = "Perform squats with the Axle Bar to target the quads and glutes while benefiting from the thicker grip.", SportId = bodyBuildingId},
                
            // Upper Body Exercises
            // Index => 500
            new Workout { Id = 501, Name ="Axle Bar Overhead Press", Description = "Press the Axle Bar overhead to develop shoulder strength, utilizing a neutral grip that can reduce shoulder strain.", SportId = bodyBuildingId},
            // Index => 501
            new Workout { Id = 502, Name ="Axle Bar Bent-Over Rows", Description = "Works the lats, rhomboids, and biceps. The grip challenge enhances forearm and grip strength.", SportId = bodyBuildingId},
                
            // Index => 505
            new Workout { Id = 506, Name ="Axle Bar Bench Press", Description = "Perform bench presses with the Axle Bar to enhance chest development while challenging grip strength.", SportId = bodyBuildingId},
            // Core Exercises
            // Index => 506
            new Workout { Id = 507, Name ="Plank Holds with Axle Bar", Description = "Position yourself in a plank while holding onto the Axle Bar for increased core engagement.", SportId = bodyBuildingId},
                
            // Advanced Variations
            // Index => 509
            new Workout { Id = 510, Name ="Axle Bar Clean and Press", Description = "A compound movement that combines a clean with an overhead press, enhancing full-body coordination and strength.", SportId = bodyBuildingId},                
            // Index => 510
            new Workout { Id = 511, Name ="Axle Bar Thrusters", Description = "A dynamic movement combining a front squat with an overhead press, great for conditioning and leg development.", SportId = bodyBuildingId},
            // Index => 511
            new Workout { Id = 512, Name ="Jump Squats with Axle Bar", Description = "Incorporate jump squats for explosive power training while using the added resistance of the Axle Bar.", SportId = bodyBuildingId},
            #endregion

            #region Swiss Bar
            //
            // Index => 513
            new Workout { Id = 514, Name ="Swiss Bar Overhead Press", Description = "Targets the shoulders and triceps with a neutral grip to minimize discomfort.", SportId = bodyBuildingId},
            // Index => 514
            new Workout { Id = 515, Name ="Swiss Bar Bent-Over Row", Description = "Engages the back muscles effectively while allowing for a neutral grip to reduce elbow strain.", SportId = bodyBuildingId},
            // Index => 515
            new Workout { Id = 516, Name ="Swiss Bar Skull Crushers", Description = "Focuses on triceps development with less stress on the elbows compared to traditional methods.", SportId = bodyBuildingId},
            // Index => 516
            new Workout { Id = 517, Name ="Swiss Bar Hammer Curls", Description = "A bicep exercise that allows for heavier loads due to the bilateral grip.", SportId = bodyBuildingId},
            // Index => 517
            new Workout { Id = 518, Name ="Swiss Bar Pullovers", Description = "Works the lats and chest, providing a strong stretch and contraction.", SportId = bodyBuildingId},
            // Index => 518
            new Workout { Id = 519, Name ="Swiss Bar Push-Ups", Description = "Increases range of motion and allows for various grip positions to target different muscle areas.", SportId = bodyBuildingId},
            // Index => 519
            new Workout { Id = 520, Name ="Swiss Bar Seal Row", Description = "A variation of the row that eliminates momentum, focusing purely on back strength.", SportId = bodyBuildingId},
            // Index => 520
            new Workout { Id = 521, Name ="Swiss Bar Ab Rollout", Description = "Engages the core effectively while utilizing the Swiss bar for stability.", SportId = bodyBuildingId},
            // Index => 521
            new Workout { Id = 522, Name ="Swiss Bar Front Raise", Description = "Targets the front deltoids with a safer shoulder position.", SportId = bodyBuildingId},
            // Index => 522
            new Workout { Id = 523, Name ="Swiss Bar Single-Leg Romanian Deadlift", Description = "Enhances balance and unilateral strength in the hamstrings and glutes.", SportId = bodyBuildingId},
            // Index => 523
            new Workout { Id = 524, Name ="Swiss Bar Jammer Press", Description = "A dynamic pressing movement that can improve explosiveness and power.", SportId = bodyBuildingId},
            // Index => 524
            new Workout { Id = 525, Name ="Swiss Bar Supported Hip Thrust", Description = "Utilizes the Swiss bar to add weight to hip thrusts, targeting glute development.", SportId = bodyBuildingId},
            // Index => 525
            new Workout { Id = 526, Name ="Swiss Bar Elevated Rack Row", Description = "A variation of the row that focuses on upper back engagement from an elevated position.", SportId = bodyBuildingId},
            // Index => 526
            new Workout { Id = 527, Name ="Swiss Bar Suitcase Carry", Description = "Enhances grip strength and engages the core through unilateral loading.", SportId = bodyBuildingId},
            // Index => 527
            new Workout { Id = 528, Name ="Swiss Bar Zercher Squat", Description = "A squat variation that emphasizes core stability and leg strength while reducing forearm strain.", SportId = bodyBuildingId},
            // Index => 528
            new Workout { Id = 529, Name ="Swiss Bar Hamstring Curl", Description = "A lower-intensity exercise targeting hamstring strength, suitable for later in workouts.", SportId = bodyBuildingId},
            // Index => 529
            new Workout { Id = 530, Name ="Swiss Bar Weighted Push-Up", Description = "Adds resistance to traditional push-ups, increasing difficulty and muscle engagement.", SportId = bodyBuildingId},
            // Index => 530
            new Workout { Id = 531, Name ="Swiss Bar Elevated Push-Up", Description = "Similar to weighted push-ups but performed at an angle for increased challenge.", SportId = bodyBuildingId},
            // Index => 531
            new Workout { Id = 532, Name ="Swiss Bar Trap Raise", Description = "Focuses on developing upper traps with a neutral grip for comfort during lifting.", SportId = bodyBuildingId},
            #endregion

            #region Buffalo Bar
            // Index => 532
            new Workout { Id = 533, Name ="Buffalo Bar Back Squat", Description = "Utilizes the unique curve of the bar to allow for a more natural shoulder position, reducing discomfort while performing squats.", SportId = bodyBuildingId},
            // Index => 533
            new Workout { Id = 534, Name ="Buffalo Bar Front Squat", Description = "The design allows the bar to rest comfortably on the shoulders, making it easier to maintain an upright torso during the squat.", SportId = bodyBuildingId},
            // Index => 534
            new Workout { Id = 535, Name ="Buffalo Bar Bench Press", Description = "The bend in the bar enables a greater range of motion, allowing for deeper presses that can enhance muscle activation in the chest.", SportId = bodyBuildingId},
            // Index => 535
            new Workout { Id = 536, Name ="Buffalo Bar Overhead Press", Description = "This exercise benefits from the neutral grip position, which can reduce shoulder strain compared to traditional overhead pressing.", SportId = bodyBuildingId},
            // Index => 536
            new Workout { Id = 537, Name ="Buffalo Bar Lunges", Description = "The bar's design allows for comfortable lunging movements without straining the shoulders, making it ideal for leg workouts.", SportId = bodyBuildingId},
            // Index => 537
            new Workout { Id = 538, Name ="Buffalo Bar Good Mornings", Description = "This exercise targets the hamstrings and lower back while providing a stable grip and comfortable positioning on the shoulders.", SportId = bodyBuildingId},
            // Index => 538
            new Workout { Id = 539, Name ="Buffalo Bar Romanian Deadlift", Description = "Similar to traditional deadlifts but with improved comfort due to the bar's design, focusing on hamstring and glute engagement.", SportId = bodyBuildingId},
            // Index => 539
            new Workout { Id = 540, Name ="Buffalo Bar Skull Crushers", Description = "A triceps exercise that allows for a neutral grip, reducing elbow strain while effectively targeting the triceps.", SportId = bodyBuildingId},
            // Index => 540
            new Workout { Id = 541, Name ="Buffalo Bar Bent-Over Row", Description = "This variation allows for a neutral grip, reducing stress on the elbows and shoulders while effectively working the back muscles.", SportId = bodyBuildingId},
            // Index => 541
            new Workout { Id = 542, Name ="Buffalo Bar Ab Rollout", Description = "Engages the core effectively while providing stability through the unique grip and positioning of the bar.", SportId = bodyBuildingId},
            // Index => 542
            new Workout { Id = 543, Name ="Buffalo Bar Farmer's Walk", Description = "The neutral grip helps maintain shoulder stability while carrying heavy loads, enhancing grip strength and core stability.", SportId = bodyBuildingId},
            // Index => 543
            new Workout { Id = 544, Name ="Buffalo Bar Single-Leg Deadlift", Description = "Focuses on unilateral strength development in the hamstrings and glutes while maintaining balance and stability.", SportId = bodyBuildingId},
            #endregion
                
            #region Fixed Barbells
                
                
            // Index => 550
            new Workout { Id = 551, Name ="Barbell Skull Crushers", Description = "Isolates the triceps effectively while minimizing strain on the elbows.", SportId = bodyBuildingId},
            // Index => 551
            new Workout { Id = 552, Name ="Barbell Front Squat", Description = "Emphasizes the quadriceps and core stability, promoting an upright squat position.", SportId = bodyBuildingId},
                
            // Index => 553
            new Workout { Id = 554, Name ="Barbell Hip Thrust", Description = "Isolates the glutes for strength development and improved posture.", SportId = bodyBuildingId},
                
            // Index => 555
            new Workout { Id = 556, Name ="Barbell High Pull", Description = "A dynamic movement that targets the upper back and shoulders while improving explosiveness.", SportId = bodyBuildingId},
            // Index => 556
            new Workout { Id = 557, Name ="Barbell Landmine Press", Description = "Excellent for shoulder stability and strength; performed with one end of the bar secured.", SportId = bodyBuildingId},
            // Index => 557
            new Workout { Id = 558, Name ="Barbell Man Maker", Description = "A full-body exercise combining a burpee with a clean and press to elevate heart rate.", SportId = bodyBuildingId},
            // Index => 558
            new Workout { Id = 559, Name ="Barbell Reverse Bicep Curl", Description = "Works both the biceps and forearms through an overhand grip for increased grip strength.", SportId = bodyBuildingId},
            // Index => 559
            new Workout { Id = 560, Name ="Barbell Push Press", Description = "A powerful overhead movement that engages the legs for momentum in pressing.", SportId = bodyBuildingId},
            // Index => 560
            new Workout { Id = 561, Name ="Barbell Zercher Squat", Description = "Holds the bar in the crook of your arms, emphasizing core engagement and leg strength.", SportId = bodyBuildingId},
            // Index => 561
            new Workout { Id = 562, Name ="Barbell Farmer's Walk", Description = "Enhances grip strength and core stability while walking with a fixed barbell at your side.", SportId = bodyBuildingId},
            // Index => 562
            new Workout { Id = 563, Name ="Barbell Tyre Flip (alternative)", Description = "A functional exercise simulating tire flips using a barbell to engage multiple muscle groups.", SportId = bodyBuildingId},
            // Index => 563
            new Workout { Id = 564, Name ="Barbell Abs Rollout", Description = "Utilizes a fixed bar for rolling out to engage core muscles effectively.", SportId = bodyBuildingId},
            #endregion

            #region Abdominal
            // Index => 564 / Target => Upper Abs
            new Workout { Id = 565, Name ="Sit-Ups", Description = "Lie on your back with knees bent and feet secured. Raise your torso towards your knees.", SportId = bodyBuildingId},
            // Index => 565 / Target => Lower Abs
            new Workout { Id = 566, Name ="Leg Lifts", Description = "Lie flat and lift your legs until perpendicular to the floor, then lower them slowly.", SportId = bodyBuildingId},
            // Index => 566 / Target => Upper and Lower Abs
            new Workout { Id = 567, Name ="V-Ups", Description = "Simultaneously raise your legs and torso off the ground, reaching for your toes.", SportId = bodyBuildingId},
            // Index => 567 / Target => Lower Abs
            new Workout { Id = 568, Name ="Seated Knee Tucks", Description = "Sit with legs extended, pull your knees to your chest, then return to the starting position.", SportId = bodyBuildingId},
            // Index => 568 / Target => Upper and Lower Abs
            new Workout { Id = 569, Name ="Toe Touches", Description = "Lie flat, lift your legs and reach your hands towards your toes.", SportId = bodyBuildingId},
            // Index => 569 / Target => Upper Abs
            new Workout { Id = 570, Name ="Crunches", Description = "Curl your torso towards your knees while keeping your lower back on the floor.", SportId = bodyBuildingId},
            // Index => 570 / Target => Reverse Crunches
            new Workout { Id = 571, Name ="Upper and Lower Abs", Description = "Pull your knees towards your chest while curling your torso upwards.", SportId = bodyBuildingId},
                
            // Index => 573 / Target => Core Stability
            new Workout { Id = 574, Name ="Plank", Description = "Hold a push-up position with a straight body line, engaging the core.", SportId = bodyBuildingId},
            // Index => 574 / Target => Obliques
            new Workout { Id = 575, Name ="Woodchoppers", Description = "Use a cable or resistance band to simulate chopping wood across your body.", SportId = bodyBuildingId},
            // Index => 575 / Target => Core Stability
            new Workout { Id = 576, Name ="Ab Rollouts", Description = "Roll out on an ab wheel or barbell from a kneeling position, extending forward.", SportId = bodyBuildingId},
            // Index => 576 / Target => Core Stability and Mobility
            new Workout { Id = 577, Name ="Spider Crawls", Description = "Crawl forward on all fours while maintaining tight abs.", SportId = bodyBuildingId},
            // Index => 577 / Target => Full Core Engagement
            new Workout { Id = 578, Name ="Sledgehammer Swings", Description = "Swing a sledgehammer against a tire or similar object, engaging the core throughout.", SportId = bodyBuildingId},
            // Index => 578 / Target => Obliques and Upper Abs
            new Workout { Id = 579, Name ="Cross-Body Crunches (Bicycle crunches)", Description = "Perform crunches while bringing opposite elbow to knee in a twisting motion.", SportId = bodyBuildingId},
            // Index => 579 / Target => Lower Abs
            new Workout { Id = 580, Name ="Decline Reverse Crunches", Description = "Use a decline bench to perform reverse crunches for added difficulty.", SportId = bodyBuildingId},
            // Index => 580 / Target => Bottoms Up (Hip Raise)
            new Workout { Id = 581, Name ="Lower Abs and Glutes", Description = "Lying on your back, raise hips off the ground while keeping legs extended.", SportId = bodyBuildingId},
                
            // Index => 582 / Target => Full Core Engagement and Cardio
            new Workout { Id = 583, Name ="Mountain Climbers", Description = "In a plank position, alternate bringing knees toward the chest quickly.", SportId = bodyBuildingId},

            // Index => 584 / Target =>
            new Workout { Id = 585, Name ="Side plank", Description = "Strengthens the obliques while improving stability. / Execution: Lie on one side, prop yourself up on your forearm, and lift your hips off the ground to form a straight line from head to heels.", SportId = bodyBuildingId},
            // Index => 585 / Target =>
            new Workout { Id = 586, Name ="Scissor kicks", Description = "", SportId = bodyBuildingId},
            // Index => 586 / Target =>
            new Workout { Id = 587, Name ="Copenhagen plank", Description = "", SportId = bodyBuildingId},
            // Index => 587 / Target =>
            new Workout { Id = 588, Name ="Hollow hold", Description = "", SportId = bodyBuildingId},
            // Index => 588 / Target =>
            new Workout { Id = 589, Name ="Squat", Description = "", SportId = bodyBuildingId},
            // Index => 589 / Target =>
            new Workout { Id = 590, Name ="Barbell rollout", Description = "", SportId = bodyBuildingId},
            // Index => 590 / Target =>
            new Workout { Id = 591, Name ="Swiss ball crunch", Description = "", SportId = bodyBuildingId},
            // Index => 591 / Target =>
            new Workout { Id = 592, Name ="Deadbug", Description = "", SportId = bodyBuildingId},
            // Index => 592 / Target =>
            new Workout { Id = 593, Name ="Cable crunch", Description = "", SportId = bodyBuildingId},
            // Index => 593 / Target =>
            new Workout { Id = 594, Name ="Reverse crunch", Description = "", SportId = bodyBuildingId},
            // Index => 594 / Target =>
            new Workout { Id = 595, Name ="Bird dog exercise", Description = "Improves stability and engages both the core and erector spinae. / Execution: Start on hands and knees, extend one arm forward and the opposite leg back while keeping your core tight.", SportId = bodyBuildingId},
            // Index => 595 / Target =>
            new Workout { Id = 596, Name ="Flutter kick", Description = "", SportId = bodyBuildingId},
            // Index => 596 / Target =>
            new Workout { Id = 597, Name ="Toe touchers", Description = "", SportId = bodyBuildingId},
            // Index => 597 / Target =>
            new Workout { Id = 598, Name ="Dead bug", Description = "", SportId = bodyBuildingId},
            // Index => 598 / Target =>
            new Workout { Id = 599, Name ="Crunch", Description = "", SportId = bodyBuildingId},
            // Index => 599 / Target =>
            new Workout { Id = 600, Name ="Horizontal Cable Woodchop", Description = "", SportId = bodyBuildingId},
            #endregion


            // Workouts according to Body...
            #region Pectoralis Major
            // 
            // Index => 600
            new Workout { Id = 601, Name="Incline Dumbbell Bench Press", Description= "Focuses on the upper part of the pectoralis major. / Set an incline bench at 30-45 degrees, press dumbbells from shoulder height upwards.", SportId= bodyBuildingId },
            // Index => 601
            new Workout { Id = 602, Name="Decline Bench Press", Description= "Targets the lower portion of the pectoralis major. / Execution: Lie on a decline bench and press a barbell or dumbbells upward.", SportId= bodyBuildingId },
            // Index => 602
            new Workout { Id = 603, Name="Cable Crossovers", Description="Excellent for isolating the pecs with variations targeting different angles. / Execution: Stand between two cable machines and pull the cables together in front of you at various heights (low to high and high to low) to engage different parts of the muscle.", SportId= bodyBuildingId},
            // Index => 603
            new Workout { Id = 604, Name="Dumbbell Flyes", Description="Isolates the pectoralis major effectively. Execution: Lie on a flat or incline bench with dumbbells in hand, arms extended above, lower them out to the sides in a wide arc, then bring them back together.", SportId= bodyBuildingId},
            // Index => 604
            new Workout { Id = 605, Name="Push-Ups (Standard and Variations)", Description="Bodyweight exercise that engages the pecs significantly. / Variations include close-grip push-ups for inner pecs and elevated push-ups for added difficulty.", SportId= bodyBuildingId},
            // Index => 605
            new Workout { Id = 606, Name="Kettlebell Fly", Description="A variation that provides dynamic movement and stability work. /  Perform as you would with dumbbells but using kettlebells for added challenge.", SportId= bodyBuildingId},
            // Index => 606
            new Workout { Id = 607, Name="Guillotine Press", Description="A unique variation that targets the upper chest. / Execution: Lower a barbell towards your neck instead of your chest while lying on a flat bench.", SportId= bodyBuildingId},
            // Index => 607
            new Workout { Id = 608, Name="180-Degree Twisting Dumbbell Bench Press", Description="Engages both heads of the pectoralis major through rotation. / Lower dumbbells to your sides while twisting palms inward at the top of the movement.", SportId= bodyBuildingId},
            // Index => 608
            new Workout { Id = 609, Name="Standing Cable Chest Fly", Description="Provides constant tension throughout the movement. / Execution: Stand with cables at shoulder height and perform fly movements similar to dumbbell flyes.", SportId= bodyBuildingId},
            // Index => 609
            new Workout { Id = 610, Name="Resistance Band Push-Ups", Description="Adds resistance to traditional push-ups, enhancing pec activation. / Execution: Place bands across your back and hold them under your hands while performing push-ups.", SportId= bodyBuildingId},

            #endregion

            #region Pectoralis Minor
            // Index => 610
            new Workout { Id = 611, Name="Dips", Description="Dips are excellent for targeting both the pectoralis major and minor./ Use parallel bars, lean slightly forward, and lower your body by bending your elbows until you feel a stretch in your chest, then press back up.", SportId= bodyBuildingId},
            // Index => 611
            new Workout { Id = 612, Name="Cable Crossovers (Low to High)", Description="This exercise emphasizes the upper portion of the chest, engaging the pec minor. / Execution: Set the cables at the lowest position, grab the handles with palms facing up, and pull them upward in a scooping motion until they meet at eye level.", SportId= bodyBuildingId},
            // Index => 612
            new Workout { Id = 613, Name="Cable Crossovers (High to Low)", Description="Targets the lower part of the pectoralis major but also engages the pec minor./ Execution: Set cables at a high position and pull them down towards your core using a neutral grip.", SportId= bodyBuildingId},
            // Index => 613
            new Workout { Id = 614, Name="Incline Dumbbell Press", Description="Focuses on the upper chest while also engaging the pec minor. / Execution: Set an incline bench at 30-45 degrees, press dumbbells from shoulder height upwards.", SportId= bodyBuildingId},
            // Index => 614
            new Workout { Id = 615, Name="Push-Ups (with Forward Lean)", Description="A bodyweight exercise that can effectively engage the pec minor. / Execution: Perform standard push-ups but lean forward during the movement to increase involvement of the pecs.", SportId= bodyBuildingId},
            // Index => 615
            new Workout { Id = 616, Name="Serratus Punches", Description="While primarily targeting the serratus anterior, this exercise also activates the pec minor. / Execution: Stand or kneel with weights in hand and punch forward while keeping your elbow slightly bent.", SportId= bodyBuildingId},
            // Index => 616
            new Workout { Id = 617, Name="Modified Push-Up Plus", Description="Enhances activation of both pectoral muscles while focusing on scapular stability. / Execution: Perform a standard push-up but add an extra push at the top to protract your shoulder blades.", SportId= bodyBuildingId},
            // Index => 617
            new Workout { Id = 618, Name="Front Raises with Dumbbells", Description="Engages shoulder muscles while indirectly working on pec minor stabilization. / Execution: Hold dumbbells at your sides and raise them straight in front of you to shoulder height.", SportId= bodyBuildingId},
            #endregion

            #region Chest
            // Index => 618
            new Workout { Id = 619, Name="Cable Flyes (Low to High)", Description="Engages different angles of the chest. / Execution: Set cables at a low position, pull them upward in front of you", SportId= bodyBuildingId},
            // Index => 619
            new Workout { Id = 620, Name="Cable Flyes (High to Low)", Description="Targets lower pecs while also engaging the pectoralis minor. / Execution: Set cables at a high position and pull them down towards your core.", SportId= bodyBuildingId},
            // Index => 620
            new Workout { Id = 621, Name="Plyometric Push-Ups", Description="xplosive movement that targets fast-twitch muscle fibers in the chest. / Perform standard push-ups but push off explosively so your hands leave the ground.", SportId= bodyBuildingId},
            // Index => 621
            new Workout { Id = 622, Name="Half-Kneeling Cable Chest Press", Description="Engages core muscles while focusing on one side of the chest./ Kneel with one leg forward and press a cable out in front of you.", SportId= bodyBuildingId},
            #endregion

            #region Back
            // Index => 622
            new Workout { Id = 623, Name="Single-Arm Dumbbell Row", Description=" Unilateral exercise that focuses on independent contractions of each side of the back, allowing for deeper engagement of core musculature.", SportId= bodyBuildingId},
            // Index => 623
            new Workout { Id = 624, Name="Chest-Supported Dumbbell Row", Description="Places less strain on the lower back while maintaining significant engagement of upper back muscles", SportId= bodyBuildingId},
                
            // Index => 625
            new Workout { Id = 626, Name="Seated Row", Description="Often done with either a machine or dumbbells, this exercise targets the mid-to-lower back regions, including the latissimus dorsi and trapezius muscles", SportId= bodyBuildingId},
            // Index => 626
            new Workout { Id = 627, Name="Superman Exercise", Description="Engages mid-back muscles along with rotator cuff muscles without needing equipment.", SportId= bodyBuildingId},
            // Index => 627
            new Workout { Id = 628, Name="Med Ball Wood Chop", Description="Incorporates rotational forces to engage obliques and mid-back muscles simultaneously", SportId= bodyBuildingId},
            // Index => 628                
            new Workout { Id = 629, Name="Scapula Shrug", Description="Directly targets the trapezius muscles, contributing to overall back thickness and definition", SportId= bodyBuildingId},
            // Index => 629
            new Workout { Id = 630, Name="Band Pull-apart", Description="Helps maintain scapular stability and engages the broader back region, including the rhomboids and levators scapulae", SportId= bodyBuildingId},
            // Index => 630
            new Workout { Id = 631, Name="Good Morning Exercise", Description="Though traditionally considered a hip extension exercise, it does contribute to activating certain portions of the lumbar extensors which play a supportive role in back health and aesthetics", SportId= bodyBuildingId},
            #endregion

            #region Upper Back
            // Index => 631
            new Workout { Id = 632, Name="Face Pulls", Description="Excellent for targeting the rear deltoids and upper traps. / Execution: Use a cable machine set at face height, pull the rope towards your face while keeping elbows high.", SportId= bodyBuildingId},
            // Index => 632
            new Workout { Id = 633, Name="Dumbbell Flyes (Reverse)", Description="Targets the rear deltoids and upper back muscles. / Execution: Bend at the hips, hold dumbbells with palms facing each other, and lift them out to the sides.", SportId= bodyBuildingId},
            // Index => 633
            new Workout { Id = 634, Name="Inverted Rows", Description="Bodyweight exercise that targets the entire upper back. / Execution: Set a barbell in a squat rack at waist height; lie underneath it and pull your chest to the bar.", SportId= bodyBuildingId},
            // Index => 634
            new Workout { Id = 635, Name="Dumbbell Pullovers", Description="Although primarily targeting the chest, this exercise also engages the lats effectively. / Execution: Lie on a bench, hold a dumbbell above your chest, and lower it behind your head before bringing it back up.", SportId= bodyBuildingId},
            #endregion
                
            #region Middle Back
            // Index => 635
            new Workout { Id = 636, Name="Cable Face Pull", Description="Targets the upper traps and rear deltoids, contributing to overall upper back development. / Execution: Use a cable machine set at face height, pull the rope towards your face with elbows high.", SportId= bodyBuildingId},
            // Index => 636
            new Workout { Id = 637, Name="Seal Row", Description="A variation that minimizes lower back strain while targeting the mid-back. / Execution: Lie face down on a bench with arms hanging down, pull dumbbells towards your chest.", SportId= bodyBuildingId},
            // Index => 637
            new Workout { Id = 638, Name="Hammer Iso Row", Description="Ideal for isolating the middle back with controlled movements. / Execution: Sit on a machine with your chest against the pad, pull handles towards your body while keeping elbows close.", SportId= bodyBuildingId},
            // Index => 638
            new Workout { Id = 639, Name="Reverse Grip Barbell Row", Description="Changes grip to emphasize different parts of the mid-back. / Execution: Perform as you would with a standard bent-over row but with an underhand grip.", SportId= bodyBuildingId},
            // Index => 639
            new Workout { Id = 640, Name="Incline Dumbbell Row", Description="Chest-supported variation that allows for higher rep training. / Execution: Lie on an incline bench and row dumbbells towards your sides.", SportId= bodyBuildingId},
            // Index => 640
            new Workout { Id = 641, Name="Prone Cobra", Description="Strengthens mid-back muscles while improving posture. / Execution: Lie face down, lift your chest off the ground while pinching shoulder blades together, and hold for several seconds.", SportId= bodyBuildingId},
            // Index => 641
            new Workout { Id = 642, Name="Unilateral Band Row", Description="Enhances unilateral strength and stability in the middle back. / Execution: Attach a resistance band at waist height, stand facing away, and pull one arm back while keeping your core engaged.", SportId= bodyBuildingId},
            // Index => 642
            new Workout { Id = 643, Name="Meadow Landmine Row", Description="Targets the mid-back with an emphasis on range of motion. / Execution: Stand next to a landmine setup, grab the bar with one hand, and row it towards your hip.", SportId= bodyBuildingId},
            #endregion

            #region latissimus dorsi (lats),
            // Index => 644
            new Workout { Id = 645, Name="One-Arm Cable Pulldown", Description="Isolates each lat individually for better muscle engagement. / Execution: Use a cable machine with a single handle; pull down towards your hip while keeping your core engaged.", SportId= bodyBuildingId},                
            // Index => 645
            new Workout { Id = 646, Name="Plank Rows (Renegade Rows)", Description="Engages core stability while working on lat strength. / Execution: In a plank position with dumbbells, row one weight at a time towards your hip.", SportId= bodyBuildingId},
            // Index => 646
            new Workout { Id = 647, Name="Landmine Row", Description="Utilizes a landmine attachment for unique angles of resistance targeting the lats. / Execution: Stand over a landmine, grip it with both hands, and row towards your body.", SportId= bodyBuildingId},
            #endregion

            #region Trapezius (Traps)
            // Index => 648
            new Workout { Id = 649, Name="Barbell Shrugs", Description="A fundamental exercise for developing the upper traps. / Execution: Stand with a barbell at hip level, grip it with both hands, and shrug your shoulders up towards your ears.", SportId= bodyBuildingId},
            // Index => 649
            new Workout { Id = 650, Name="Dumbbell Shrugs", Description="Similar to barbell shrugs but allows for a greater range of motion. / Execution: Hold a dumbbell in each hand at your sides and shrug your shoulders upwards.", SportId= bodyBuildingId},
            // Index => 650
            new Workout { Id = 651, Name="Wide-Grip Barbell Shrugs", Description="Targets the upper traps more effectively by using a wider grip. / Execution: Perform shrugs with a wider grip on the barbell, starting from 30 degrees of shoulder abduction.", SportId= bodyBuildingId},                
            // Index => 651
            new Workout { Id = 652, Name="Single-Arm Angled Shrugs", Description="Focuses on one side of the traps at a time. / Execution: Use a cable machine or dumbbell to perform shrugs at an angle, allowing for isolated contraction.", SportId= bodyBuildingId},
            // Index => 652
            new Workout { Id = 653, Name="Upright Rows", Description="Engages both the traps and deltoids. / Execution: Use a barbell or dumbbells; pull the weights up towards your chin while keeping elbows above shoulder height.", SportId= bodyBuildingId},
            // Index => 653
            new Workout { Id = 654, Name="Farmer's Carry", Description="Engages multiple muscle groups, including the traps, for stability and strength. / Execution: Hold heavy dumbbells or kettlebells in each hand and walk for distance or time.", SportId= bodyBuildingId},
            // Index => 654
            new Workout { Id = 655, Name="Dumbbell Snatch", Description="A dynamic movement that activates the traps along with other muscle groups. / Execution: From a standing position, lift a dumbbell from the ground to overhead in one fluid motion.", SportId= bodyBuildingId},                
            // Index => 655
            new Workout { Id = 656, Name="Bent-Over Dumbbell Rows", Description="Targets both middle and lower traps along with rhomboids. / Execution: Bend over with dumbbells in hand and row them towards your hips while squeezing your shoulder blades together.", SportId= bodyBuildingId},
            // Index => 656
            new Workout { Id = 657, Name="Prone Dumbbell Flyes", Description="Engages rear deltoids and upper traps. / Execution: Lie face down on an incline bench with dumbbells; lift them out to the sides in a wide arc.", SportId= bodyBuildingId},                
            // Index => 657
            new Workout { Id = 658, Name="Cable Upright Rows", Description="Similar to traditional upright rows but allows for constant tension throughout the movement. / Execution: Use a cable machine with a straight bar attachment; pull towards your chin while maintaining proper form.", SportId= bodyBuildingId},
            #endregion

            #region Rhomboids
            // Index => 658
            new Workout { Id = 659, Name="Cable Reverse Fly", Description="Targets the rhomboids in a long lever position. / Stand between two cables set at shoulder height; pull the cables out to the sides while keeping arms slightly bent.", SportId= bodyBuildingId},
            // Index => 659
            new Workout { Id = 660, Name="Barbell Row", Description="A compound movement that works multiple back muscles, including the rhomboids. / Execution: Bend at the hips with a barbell, pull it towards your lower ribcage while retracting your shoulder blades.", SportId= bodyBuildingId},                
            // Index => 660
            new Workout { Id = 661, Name="Low-to-High Cable Row", Description="Engages the upper back and rhomboids effectively. / Execution: Set cables low; pull them upwards towards your face while keeping elbows high.", SportId= bodyBuildingId},                
            // Index => 661
            new Workout { Id = 662, Name="Kettlebell Gorilla Rows", Description="Engages multiple muscles in the upper back, including rhomboids. / Execution: Stand between two kettlebells; alternate rowing each kettlebell towards your hip.", SportId= bodyBuildingId},
            // Index => 662
            new Workout { Id = 663, Name="Chest-Supported Machine Row", Description="Provides stability and allows for heavy loading to target rhomboids effectively. / Execution: Sit on a chest-supported row machine; pull handles towards you while squeezing shoulder blades together.", SportId= bodyBuildingId},                
            // Index => 663
            new Workout { Id = 664, Name="Plank Rotations", Description="Engages core and upper back muscles, including rhomboids. / Execution: Start in a plank position; rotate into a side plank while reaching one arm toward the ceiling.", SportId= bodyBuildingId},
            #endregion

            #region Erector Spinae
            // Index => 664
            new Workout { Id = 665, Name="Hyperextensions (Back Extensions)", Description="Isolates the erector spinae and strengthens the lower back. / Execution: Use a hyperextension bench; hinge forward at the hips and then extend back up, squeezing your glutes at the top.", SportId= bodyBuildingId},                
            // Index => 665
            new Workout { Id = 666, Name="Seated Dumbbell Good Mornings", Description="A variation that allows for controlled movement to target the erector spinae. / Execution: Sit on a bench, hold dumbbells between your thighs, lean forward while maintaining a flat back, and return to starting position.", SportId= bodyBuildingId},
            // Index => 666
            new Workout { Id = 667, Name="Supermans", Description="Engages the entire back musculature, including the erector spinae. / Execution: Lie face down, lift your arms and legs off the ground simultaneously while engaging your lower back muscles.", SportId= bodyBuildingId},
            // Index => 667
            new Workout { Id = 668, Name="Kneeling Back Extensions", Description="Focuses on lower back strength in a controlled manner. / Execution: Kneel on a mat with hands behind your head; lean back to extend the spine before returning to upright.", SportId= bodyBuildingId},                
            // Index => 668
            new Workout { Id = 669, Name="Jefferson Curls", Description="A dynamic stretching exercise that targets spinal flexion and extension. / Execution: Stand on an elevated surface with a kettlebell; roll down vertebra by vertebra before returning to standing.", SportId= bodyBuildingId},
            // Index => 669
            new Workout { Id = 670, Name="Cable Deadlifts", Description="A variation of deadlifts using cable machines for constant tension. / Execution: Set up a cable machine at low height; perform deadlift motions while pulling from the cable.", SportId= bodyBuildingId},                
            // Index => 670
            new Workout { Id = 671, Name="Hip Bridges", Description="Engages glutes and lower back muscles, including erector spinae. / Execution: Lie on your back with knees bent; lift your hips towards the ceiling while squeezing glutes at the top.", SportId= bodyBuildingId},                
            // Index => 671
            new Workout { Id = 672, Name="Cat-Cow Stretch", Description="A dynamic movement that promotes flexibility in the spine while engaging erector spinae. / Execution: In a tabletop position, alternate between arching your back (cat) and lowering it (cow).", SportId= bodyBuildingId},                
            // Index => 672
            new Workout { Id = 673, Name="Bent-Over Rows", Description="Engages multiple muscles in the back, including erector spinae for stabilization. / Execution: Bend at hips with dumbbells or barbell; pull weights towards your abdomen while maintaining a flat back.", SportId= bodyBuildingId},                
            // Index => 673
            new Workout { Id = 674, Name="45-Degree Back Extensions", Description="A machine-based exercise focusing on lower back extension. / Execution: Position yourself on a 45-degree back extension machine; hinge forward and then extend back up against resistance.", SportId= bodyBuildingId},
            #endregion

            #region Shoulders
            // Index => 674
            new Workout { Id = 675, Name="Overhead Barbell Press (Military Press)", Description="A fundamental compound movement that targets all three heads of the deltoids. / Execution: Stand with feet shoulder-width apart, grip the barbell at shoulder height, and press it overhead until arms are fully extended.", SportId= bodyBuildingId},
            // Index => 675
            new Workout { Id = 676, Name="Dumbbell Shoulder Press", Description="Similar to the barbell press but allows for a greater range of motion / Execution: Sit or stand with a dumbbell in each hand at shoulder height, press them overhead while keeping your back straight.", SportId= bodyBuildingId},
            // Index => 676
            new Workout { Id = 677, Name="Push Press", Description="A dynamic movement that allows for heavier weights by involving leg drive. / Execution: Start with a barbell at shoulder height; use your legs to help push it overhead explosively.", SportId= bodyBuildingId},
            // Index => 677
            new Workout { Id = 678, Name="Seated Dumbbell Press", Description="A variation that provides support for better stability during pressing movements. / Execution: Sit on a bench with back support and press dumbbells overhead from shoulder height.", SportId= bodyBuildingId},
            // Index => 678
            new Workout { Id = 679, Name="Bent-Over Dumbbell Lateral Raise", Description="Targets rear delts while minimizing momentum. / Execution: Bend forward at the hips and raise dumbbells out to the sides, focusing on squeezing your shoulder blades together.", SportId= bodyBuildingId},
            #endregion

            #region Anterior Deltoids
            // Index => 679
            new Workout { Id = 680, Name="Incline Dumbbell Front Raise", Description="Targets the anterior deltoids from a different angle. / Execution: Lie back on an incline bench and raise dumbbells in front of you.", SportId= bodyBuildingId},
            // Index => 680
            new Workout { Id = 681, Name="Cable Front Raise", Description="Provides constant tension throughout the movement./ Execution: Attach a D-handle to a low pulley; pull it straight up in front of you.", SportId= bodyBuildingId},
            // Index => 681
            new Workout { Id = 682, Name="Dumbbell Thruster", Description="A compound movement that combines a squat and an overhead press, engaging the anterior delts./ Execution: Hold dumbbells at shoulder height, squat down, then press up as you stand.", SportId= bodyBuildingId},
            // Index => 682
            new Workout { Id = 683, Name="Plate Raise", Description="A unique variation that targets the front delts while also engaging the core. / Execution: Hold a weight plate with both hands and raise it in front of you until arms are parallel to the ground.", SportId= bodyBuildingId},
            // Index => 683
            new Workout { Id = 684, Name="Dumbbell Clean and Press", Description="A dynamic exercise that targets multiple muscle groups, including the anterior deltoids. / Execution: Start with dumbbells at your sides, clean them to shoulder height, then press overhead.", SportId= bodyBuildingId},
            // Index => 684
            new Workout { Id = 685, Name="Kettlebell Front Raise", Description="Similar to dumbbell front raises but adds instability for greater engagement. / Execution: Hold a kettlebell by the handle and raise it in front of you.", SportId= bodyBuildingId},
            // Index => 685
            new Workout { Id = 686, Name="Lying Front Raises on an Incline Bench", Description="Isolates the anterior deltoids effectively without using momentum. / Execution: Lie face down on an incline bench and raise dumbbells in front of you.", SportId= bodyBuildingId},
            // Index => 686
            new Workout { Id = 687, Name="Single-Arm Dumbbell Front Raise", Description="Focuses on one side at a time for better muscle engagement and balance. / Execution: Raise one dumbbell directly in front of you while keeping the other arm at your side.", SportId= bodyBuildingId},
            #endregion

            #region Lateral Deltoids
            // Index => 687
            new Workout { Id = 688, Name="Seated Dumbbell Shoulder Press", Description="A compound movement that targets the entire shoulder complex, including the lateral deltoids. /Execution: Sit on a bench with back support and press dumbbells overhead from shoulder height. ", SportId= bodyBuildingId},
            // Index => 688
            new Workout { Id = 689, Name="Pike Push-Ups", Description="A bodyweight exercise that emphasizes shoulder activation, particularly in the lateral deltoids. / Execution: Start in a downward dog position and lower your head towards the ground, then push back up.", SportId= bodyBuildingId},
            // Index => 689
            new Workout { Id = 690, Name="Incline W-Raise", Description="Targets lateral deltoids while lying on an incline bench. / Execution: Lie face down on an incline bench with dumbbells; lift them out to the sides to form a \"W\" shape.", SportId= bodyBuildingId},
            // Index => 690
            new Workout { Id = 691, Name="Standing Dumbbell Lateral Raise (Internally Rotated)", Description="A variation that emphasizes lateral deltoid activation while reducing strain on the shoulder joint. / Execution: Hold dumbbells at your sides, internally rotate your thumbs downwards, and raise them out to the sides.", SportId= bodyBuildingId},
            // Index => 691
            new Workout { Id = 692, Name="One-Arm Cable Raise", Description="Isolates one lateral deltoid at a time for focused training. / Execution: Stand next to a cable machine; pull the handle out to the side with one arm while keeping your body stable.", SportId= bodyBuildingId},
            // Index => 692
            new Workout { Id = 693, Name="Lateral Raise Machine", Description="Provides support and allows for focused isolation of the lateral deltoids. / Execution: Sit on a lateral raise machine and lift the handles outward against resistance.", SportId= bodyBuildingId},                
            // Index => 693
            new Workout { Id = 694, Name="Side Plank with Arm Raise", Description="Engages both core and lateral deltoids for stability and strength. / Execution: In a side plank position, lift your top arm straight up towards the ceiling.", SportId= bodyBuildingId},
            // Index => 694
            new Workout { Id = 695, Name="Reverse Pec Deck Machine", Description="Primarily targets rear deltoids but also engages lateral heads during certain variations. / Execution: Sit facing the pads and pull them back while maintaining proper form.", SportId= bodyBuildingId},
            // Index => 695
            new Workout { Id = 696, Name="Kettlebell Lateral Raise", Description="Similar to dumbbell raises but adds instability for greater engagement. / Execution: Hold a kettlebell by its handle and raise it out to the side.", SportId= bodyBuildingId},
            #endregion

            #region Hands
            // Index => 696
            new Workout { Id = 697, Name="Grip Hangs", Description="Hang from a pull-up bar to build grip strength. / Execution: Simply hang from the bar with both hands for as long as possible, gradually increasing the duration.", SportId= bodyBuildingId},
            // Index => 697
            new Workout { Id = 698, Name="Towel Grip Dumbbell Curls", Description="Enhances grip strength while working the biceps. / Execution: Wrap a towel around a dumbbell handle; perform curls while gripping the towel.", SportId= bodyBuildingId},
            // Index => 698
            new Workout { Id = 699, Name="Rubber Ball Squeeze", Description="Strengthens the forearm flexors and improves grip. / Execution: Squeeze a rubber or tennis ball for 30-90 seconds, performing three sets with each hand.", SportId= bodyBuildingId},                
            // Index => 699
            new Workout { Id = 700, Name="Fingertip Push-Ups", Description="Strengthens fingers and enhances overall grip. / Execution: Perform push-ups on your fingertips instead of your palms to increase finger strength.", SportId= bodyBuildingId},
            // Index => 700
            new Workout { Id = 701, Name="Plate Pinches", Description="Develops pinch grip strength. / Execution: Hold two weight plates together with your fingers and hold for as long as possible.", SportId= bodyBuildingId},
            // Index => 701
            new Workout { Id = 702, Name="Wrist Twists", Description="Improves wrist strength and mobility./ Execution: Hold a light dumbbell in one hand; rotate your wrist up and down for 12-15 repetitions.", SportId= bodyBuildingId},
            // Index => 702
            new Workout { Id = 703, Name="Rubber Band Abduction", Description="Strengthens the intrinsic muscles of the hand. / Execution: Place a rubber band around your fingers and spread them apart against the resistance.", SportId= bodyBuildingId},
            // Index => 703
            new Workout { Id = 704, Name="Static Barbell Holds", Description="Builds overall grip strength. / Execution: Hold a barbell at shoulder height for as long as you can, focusing on maintaining grip.", SportId= bodyBuildingId},
            // Index => 704
            new Workout { Id = 705, Name="Newspaper Ball Tearing", Description="Improves hand dexterity and grip strength. / Execution: Tear sheets of newspaper into small pieces using just your hands.", SportId= bodyBuildingId},
            // Index => 705
            new Workout { Id = 706, Name="Isometric Hooks (Claw)", Description="Engages finger muscles and improves grip stability. / Execution: Clasp your fingers together in a hook position and pull against each other without moving.", SportId= bodyBuildingId},
            // Index => 706
            new Workout { Id = 707, Name="Thumb Pinch Strengthening", Description="Focuses on thumb strength, which is crucial for grip. / Execution: Use putty or a soft ball; pinch it between your thumb and index finger repeatedly.", SportId= bodyBuildingId},
            // Index => 707
            new Workout { Id = 708, Name="Wrist Curls (Palms Up)", Description="Strengthens forearms, enhancing grip strength. / Execution: Sit on a bench, rest your forearms on your knees, and curl a barbell or dumbbell upwards with palms facing up.", SportId= bodyBuildingId},                
            // Index => 708
            new Workout { Id = 709, Name="Wrist Curls (Palms Down)", Description="Targets the extensor muscles of the forearms. / Execution: Similar to palms-up wrist curls, but with palms facing down to work the opposite muscle group.", SportId= bodyBuildingId},
            // Index => 709
            new Workout { Id = 710, Name="Dumbbell Farmer’s Walk", Description="Builds grip endurance while engaging core and lower body. / Execution: Carry heavy dumbbells in each hand and walk for distance or time.", SportId= bodyBuildingId},
            // Index => 710
            new Workout { Id = 711, Name="Hand/Finger Tendon Glide", Description="Improves flexibility and range of motion in the fingers. /Execution: Extend fingers straight, make a hook fist, then make a full fist; repeat several times.", SportId= bodyBuildingId},
            #endregion

            #region Arms / Biceps Exercises
            // Index => 711
            new Workout { Id = 712, Name="Dumbbell Curl", Description="Allows for greater range of motion compared to barbell curls. / Execution: Hold a dumbbell in each hand at your sides and curl them up towards your shoulders.", SportId= bodyBuildingId},
            // Index => 712
            new Workout { Id = 713, Name="Incline Dumbbell Curl", Description="Targets the long head of the biceps for better peak development. / Execution: Sit on an incline bench, hold dumbbells, and curl them towards your shoulders.", SportId= bodyBuildingId},
            // Index => 713
            new Workout { Id = 714, Name="Concentration Curl", Description="Isolates the biceps for maximum engagement. / Execution: Sit down, rest your elbow against your thigh, and curl the weight up.", SportId= bodyBuildingId},
            // Index => 714
            new Workout { Id = 715, Name="Zottman Curl", Description="Works both the biceps and forearms by combining a regular curl with a reverse curl. / Execution: Curl up with palms facing up, then rotate palms down and lower the weights slowly.", SportId= bodyBuildingId},
            // Index => 715
            new Workout { Id = 716, Name="Prone Dumbbell Spider Curl", Description="Emphasizes strict form to isolate the biceps. / Execution: Lie face down on an incline bench and curl dumbbells towards your shoulders.", SportId= bodyBuildingId},
            // Triceps Exercises
            // Index => 716
            new Workout { Id = 717, Name="Overhead Tricep Extension", Description="Focuses on the long head of the triceps. / Execution: Hold a dumbbell overhead with both hands, lower it behind your head, then extend back to starting position.", SportId= bodyBuildingId},
            #endregion
                
            #region Biceps Brachii
            // Index => 717
            new Workout { Id = 718, Name="EZ-Bar Curl", Description="A variation that reduces wrist strain while targeting the biceps. / Execution: Use an EZ-bar; grip it with an underhand grip and curl towards your shoulders.", SportId= bodyBuildingId},
            // Index => 718
            new Workout { Id = 719, Name="Cable Rope Hammer Curl", Description="Targets both heads of the biceps effectively.Targets both heads of the biceps effectively. / Execution: Attach a rope to a low pulley; perform hammer curls by pulling up with palms facing each other.", SportId= bodyBuildingId},
            // Index => 719
            new Workout { Id = 720, Name="Weighted Chin-Ups", Description="A compound movement that heavily engages the biceps along with back muscles. / Execution: Hang from a pull-up bar with palms facing you; pull yourself up until your chin is above the bar.", SportId= bodyBuildingId},
            // Index => 720
            new Workout { Id = 721, Name="Low Cable Double Hand Curl", Description="Targets the biceps while maintaining constant tension. / Execution: Stand with feet shoulder-width apart, hold cable handles at hip height, and curl towards your shoulders.", SportId= bodyBuildingId},
            // Index => 721
            new Workout { Id = 722, Name="Dumbbell Cross-Body Hammer Curl", Description="Focuses on the brachialis while also hitting the biceps. / Execution: Hold a dumbbell in one hand; curl it across your body towards the opposite shoulder.", SportId= bodyBuildingId},

            #endregion

            #region Triceps Brachii
            // Index => 722
            new Workout { Id = 723, Name="EZ-Bar Skull Crushers", Description="An isolation exercise that effectively targets the triceps. / Execution: Lie on a bench with an EZ-bar; lower the bar towards your forehead, then extend back to starting position while keeping elbows tucked.", SportId= bodyBuildingId},
            // Index => 723
            new Workout { Id = 724, Name="Tricep Pushdown", Description="A cable exercise that isolates the triceps. / Execution: Stand in front of a cable machine, grip the handle with both hands, and push down until your arms are fully extended, keeping elbows close to your body.", SportId= bodyBuildingId},
            // Index => 724
            new Workout { Id = 725, Name="Diamond Push-Ups", Description="A variation of push-ups that emphasizes tricep engagement. / Execution: Assume a push-up position with hands close together forming a diamond shape; lower your body and press back up.", SportId= bodyBuildingId},
            // Index => 725
            new Workout { Id = 726, Name="Single-Arm Cable Pushdown", Description="Targets each tricep individually for balanced development. / Execution: Stand next to a cable machine, pull down the handle with one arm while keeping your elbow stationary.", SportId= bodyBuildingId},
            // Index => 726
            new Workout { Id = 727, Name="Bench Dips", Description="A simpler version of dips that can be done with just a bench. / Execution: Sit on a bench, place your hands beside you, and lower your body by bending your elbows before pushing back up.", SportId= bodyBuildingId},
            // Index => 727
            new Workout { Id = 728, Name="Seated Dumbbell Overhead Extension", Description="Isolates the triceps while providing stability. / Execution: Sit on a bench, hold a dumbbell with both hands above your head, lower it behind your head, and extend back up.", SportId= bodyBuildingId},
            // Index => 728
            new Workout { Id = 729, Name="Cable Overhead Tricep Extension", Description="Provides constant tension throughout the movement./ Execution: Stand facing away from a cable machine, grip the handle overhead, and extend your arms forward.", SportId= bodyBuildingId},                
            // Index => 729
            new Workout { Id = 730, Name="Dumbbell Kickbacks", Description="Targets the triceps while also engaging stabilizing muscles in the shoulder. / Execution: Bend forward at the hips, hold a dumbbell in one hand, extend it back while keeping your elbow close to your body.", SportId= bodyBuildingId},
            // Index => 730
            new Workout { Id = 731, Name="Reverse Grip Tricep Pushdown", Description="Changes grip to emphasize different parts of the triceps. / Execution: Use an underhand grip on a cable machine and push down as you would in a standard pushdown.", SportId= bodyBuildingId},
            // Index => 731
            new Workout { Id = 732, Name="Tricep Rope Pushdown", Description="Allows for greater range of motion compared to straight bars. / Execution: Attach a rope to a cable machine; pull down while spreading the rope at the bottom for maximum contraction.", SportId= bodyBuildingId},
            // Index => 732
            new Workout { Id = 733, Name="Kettlebell Overhead Tricep Extension", Description="A dynamic exercise that engages core stability along with triceps. / Execution: Hold a kettlebell overhead with both hands, lower it behind your head, then extend back up.", SportId= bodyBuildingId},

            #endregion

            #region Brachialis (Lower Biceps)
            // Index => 731
            new Workout { Id = 732, Name="Reverse Curls", Description="Focuses on the brachialis and forearm muscles. / Execution: Stand with a barbell or dumbbells using an overhand grip. Curl the weights towards your shoulders while keeping your elbows stationary.", SportId= bodyBuildingId},
            // Index => 732
            new Workout { Id = 733, Name="Concentration Curls", Description="Isolates the biceps and brachialis for maximum contraction. / Execution: Sit on a bench, rest your elbow against your thigh, and curl a dumbbell towards your shoulder.", SportId= bodyBuildingId},
            // Index => 733
            new Workout { Id = 734, Name="Preacher Curls", Description="Targets the lower part of the biceps and brachialis while providing stability. / Execution: Use a preacher curl bench; grasp a barbell or dumbbells and curl towards your shoulders.", SportId= bodyBuildingId},
            // Index => 735
            new Workout { Id = 736, Name="One-Arm Dumbbell Spider Curl", Description="Isolates the arm while targeting the brachialis effectively. / Execution: Lie face down on an incline bench, let one arm hang straight down, and curl the dumbbell up without twisting your wrist.", SportId= bodyBuildingId},
            // Index => 736
            new Workout { Id = 737, Name="Cable Hammer Curl", Description="Provides constant tension on the brachialis throughout the movement. / Execution: Attach a rope to a low pulley; stand facing away from the machine and perform hammer curls.", SportId= bodyBuildingId},
            // Index => 737
            new Workout { Id = 738, Name="Dumbbell Reverse Grip Curl", Description="Similar to reverse curls but allows for greater range of motion. / Execution: Hold dumbbells with an overhand grip and curl them towards your shoulders.", SportId= bodyBuildingId},
            // Index => 738
            new Workout { Id = 739, Name="Kettlebell Hammer Curl", Description="Engages both biceps and forearms effectively. / Execution: Hold kettlebells in each hand with palms facing each other, curl them towards your shoulders.", SportId= bodyBuildingId},
            // Index => 739
            new Workout { Id = 740, Name="Seated Alternate Dumbbell Curls", Description="Allows for focused contraction of each arm individually. / Execution: Sit on a bench, alternate curling dumbbells towards your shoulders while keeping elbows stationary.", SportId= bodyBuildingId},
            #endregion

            #region Forearm
            // Index => 740
            new Workout { Id = 741, Name="Barbell Wrist Curl", Description="Targets the flexor muscles of the forearm. / Execution: Sit on a bench, rest your forearms on your thighs with palms up, and curl the barbell upwards using only your wrists.", SportId= bodyBuildingId},
            // Index => 741
            new Workout { Id = 742, Name="Barbell Reverse Wrist Curls", Description="Focuses on the extensor muscles of the forearm. / Execution: Sit with your forearms resting on your thighs, palms facing down, and curl the barbell upwards using only your wrists.", SportId= bodyBuildingId},
            // Index => 742
            new Workout { Id = 743, Name="Dumbbell Wrist Curls", Description="Allows for individual arm training to improve balance. / Execution: Straddle a bench, hold a dumbbell with an underhand grip, and curl it up while resting your forearm on the bench.", SportId= bodyBuildingId},
            // Index => 743
            new Workout { Id = 744, Name="Dumbbell Reverse Wrist Curls", Description="Similar to barbell reverse curls but allows for more range of motion. / Execution: Hold a dumbbell with an overhand grip and curl it upwards while keeping your forearm stationary.", SportId= bodyBuildingId},
            // Index => 744
            new Workout { Id = 745, Name="Reverse Barbell Curls", Description="Engages both the biceps and brachialis while targeting the forearms. / Execution: Stand with a barbell using an overhand grip; curl it towards your chest while keeping elbows tucked in.", SportId= bodyBuildingId},
            // Index => 745
            new Workout { Id = 746, Name="Wrist Roller", Description="A specialized tool that targets both flexors and extensors. / Execution: Use a wrist roller device; roll the weight up and down by rotating your wrists.", SportId= bodyBuildingId},
            // Index => 746
            new Workout { Id = 747, Name="Wrist Flexion with Dumbbells", Description=" Isolates wrist flexor muscles. / Execution: Sit on a bench, hold dumbbells with palms facing up, and flex your wrists to lift the weights.", SportId= bodyBuildingId},
            // Index => 747
            new Workout { Id = 748, Name="Wrist Extension with Dumbbells", Description="Targets wrist extensor muscles. / Execution: Sit on a bench, hold dumbbells with palms facing down, and extend your wrists to lift the weights.", SportId= bodyBuildingId},
            // Index => 748
            new Workout { Id = 749, Name="Dead Hangs", Description="Improves grip strength through bodyweight training. / Execution: Hang from a pull-up bar for as long as possible to build grip endurance.", SportId= bodyBuildingId},
            #endregion

            #region Wrists
            // Index => 749
            new Workout { Id = 750, Name="Reverse Barbell Wrist Curls", Description="Focuses on the wrist extensors. / Execution: Sit with your forearms resting on your thighs, palms facing down, and curl the barbell upwards using only your wrists.", SportId= bodyBuildingId},
            // Index => 750
            new Workout { Id = 751, Name="Hand Grippers", Description="Specifically designed tools for improving grip strength. / Execution: Use hand grippers to perform repetitions of squeezing to strengthen the fingers and wrists.", SportId= bodyBuildingId},
            #endregion

            #region Abdominals
            // Index => 751
            new Workout { Id = 752, Name="Captain’s Chair", Description="Targets the lower abs effectively. / Execution: Using a captain's chair, let your legs dangle straight down. Raise your knees towards your chest while engaging your core, then slowly lower them back down.", SportId=bodyBuildingId},
            // Index => 752
            new Workout { Id = 753, Name="Crunches on an Exercise Ball", Description="Provides a greater range of motion compared to traditional crunches. / Execution: Sit on a stability ball with feet flat on the floor. Lean back slightly, place hands behind your head, and perform crunches by lifting your torso towards your knees.", SportId= bodyBuildingId},
            // Index => 753
            new Workout { Id = 754, Name="Dragon Flag", Description="A challenging exercise that targets the entire core. / Execution: Lie on a bench with shoulders supported and hold onto the bench behind you. Lift your legs up towards the ceiling while keeping them straight, then lower them while maintaining control.", SportId= bodyBuildingId},
            // Index => 754
            new Workout { Id = 755, Name="Cocoon", Description="Engages both upper and lower abs effectively. / Execution: Lie flat on your back with arms extended behind you and feet slightly off the ground. Pull knees toward your chest while simultaneously lifting your upper body off the ground.", SportId= bodyBuildingId},
            #endregion

            #region Rectus Abdominis
            // Index => 755
            new Workout { Id = 756, Name="Toe Taps", Description="A Pilates-based move that engages the rectus abdominis. / Execution: Lie on your back with legs in a tabletop position. Lower one foot to tap the floor, then return to starting position and repeat with the other leg.", SportId= bodyBuildingId},
            // Index => 756
            new Workout { Id = 757, Name="Side Jackknife", Description="Focuses on obliques but also engages rectus abdominis. / Execution: Lie on one side, lift your upper body and legs simultaneously towards each other in a jackknife motion.", SportId= bodyBuildingId},
            #endregion

            #region Internal Obliques
            // Index => 757
            new Workout { Id = 758, Name="Side Crunch", Description="Isolates the internal obliques on each side. / Execution: Lie on your side with knees bent. Crunch up by bringing your elbow towards your hip while engaging your oblique muscles.", SportId= bodyBuildingId},
            // Index => 758
            new Workout { Id = 759, Name="Oblique Cable Crunch", Description="Adds resistance to target the internal obliques. / Execution: Kneel beside a cable machine with the handle at shoulder height. Pull the handle down towards your opposite knee while crunching sideways.", SportId= bodyBuildingId},
            // Index => 759
            new Workout { Id = 760, Name="Plank with Hip Dips", Description="Engages the entire core, including internal obliques. / Execution: Start in a plank position and lower your hips towards the ground on one side, then return to center and repeat on the other side.", SportId= bodyBuildingId},
            // Index => 760
            new Workout { Id = 761, Name="Side Plank with Rotation", Description="Adds a rotational element to engage the internal obliques more intensely. / Execution: In a side plank position, reach your top arm under your body and rotate your torso before returning to the starting position.", SportId= bodyBuildingId},
            // Index => 761
            new Workout { Id = 762, Name="Heel Taps", Description="Targets the obliques while lying on your back. / Execution: Lie flat on your back with knees bent. Lift your head and shoulders off the ground and reach down to tap your heels alternately.", SportId= bodyBuildingId},
            // Index => 762
            new Workout { Id = 763, Name="Spiderman Exercise", Description="Engages core muscles dynamically while incorporating movement. / Execution: Start in a push-up position; as you lower yourself, bring one knee towards the elbow of the same side, alternating sides with each rep.", SportId= bodyBuildingId},
            // Index => 763
            new Workout { Id = 764, Name="Medicine Ball Rotational Toss", Description="A dynamic exercise that targets the internal obliques through rotation. / Execution: Stand with feet shoulder-width apart, hold a medicine ball at chest level, rotate your torso to one side and toss it against a wall or to a partner.", SportId= bodyBuildingId},
            // Index => 764
            new Workout { Id = 765, Name="Windshield Wipers", Description="Engages both internal and external obliques through rotation. / Execution: Lie on your back with legs lifted straight up. Lower both legs to one side while keeping shoulders on the ground, then return to center and repeat on the other side.", SportId= bodyBuildingId},
            // Index => 765
            new Workout { Id = 766, Name="Oblique Bench Crunch", Description="Targets internal obliques effectively from an inclined position. / Execution: Lie on an incline bench with knees bent; perform crunches by reaching toward one knee at a time.", SportId= bodyBuildingId},
            // Index => 766
            new Workout { Id = 767, Name="T-Rotation", Description="Engages core stability while targeting internal obliques. / Execution: Start in a push-up position; rotate one arm upwards towards the ceiling while lifting that side's hip off the ground, then return to start and repeat on the other side.", SportId= bodyBuildingId},
            #endregion

            #region External Obliques
            // Index => 767
            new Workout { Id = 768, Name="Oblique Crunches", Description="Strengthens the external obliques while improving stability. / Execution: Lie on one side, prop yourself up on your forearm, and lift your hips off the ground to form a straight line from head to heels.", SportId= bodyBuildingId},
            // Index => 768
            new Workout { Id = 769, Name="Side Plank with Hip Dips", Description="Adds dynamic movement to the side plank, engaging the external obliques more intensely. / Execution: In a side plank position, lower your hips towards the ground and then lift them back up.", SportId= bodyBuildingId},
            // Index => 769
            new Workout { Id = 770, Name="Cable Woodchoppers", Description="A rotational exercise that targets the external obliques. / Execution: Stand beside a cable machine with the pulley set high. Pull the handle down and across your body in a chopping motion.", SportId= bodyBuildingId},
            // Index => 770
            new Workout { Id = 771, Name="Lying Windshield Wipers", Description="Targets both internal and external obliques through rotation. / Execution: Lie on your back with legs lifted straight up. Lower both legs to one side while keeping shoulders planted, then return to center and repeat on the other side.", SportId= bodyBuildingId},
            // Index => 771
            new Workout { Id = 772, Name="High to Low Wood Chop", Description="Mimics a chopping motion that engages the external obliques. / Execution: Stand with feet shoulder-width apart, hold a weight overhead, and chop diagonally down across your body.", SportId= bodyBuildingId},
            // Index => 772
            new Workout { Id = 773, Name="Hanging Leg Raises with Twist", Description="Engages both lower abs and obliques through rotation. / Execution: Hang from a pull-up bar and raise your legs; twist at the hips to bring your legs towards one side before lowering them.", SportId= bodyBuildingId},
            // Index => 773
            new Workout { Id = 774, Name="Oblique Sit-Ups", Description="A variation of sit-ups that emphasizes oblique engagement. / Execution: Lie on your back with knees bent and resting to one side; perform sit-ups by reaching toward your knee with your elbow on that same side.", SportId= bodyBuildingId},
            #endregion

            #region legs
            // Index => 774
            new Workout { Id = 775, Name="Barbell Back Squat", Description="A fundamental compound movement that targets the entire lower body. / Execution: Stand with feet shoulder-width apart, position the barbell on your upper back, and squat down until your thighs are parallel to the ground.", SportId= bodyBuildingId},
            // Index => 775
            new Workout { Id = 776, Name="Bulgarian Split Squat", Description="A single-leg exercise that targets quads and glutes. / Execution: Place one foot on a bench behind you and squat down with the front leg until the thigh is parallel to the ground.", SportId= bodyBuildingId},
            // Index => 776
            new Workout { Id = 777, Name="Calf Raises", Description="Targets the calf muscles for improved lower leg strength. / Execution: Stand on a calf raise machine or step with heels hanging off an edge; raise and lower your heels.", SportId= bodyBuildingId},                
            // Index => 777
            new Workout { Id = 778, Name="Hack Squat", Description="Focuses on quads while providing back support. / Execution: Use a hack squat machine; place shoulders under pads and squat down while pushing through your heels.", SportId= bodyBuildingId},
            // Index => 778
            new Workout { Id = 779, Name="Step-Ups", Description="Engages quads, hamstrings, and glutes. / Execution: Step onto a bench or platform with one foot, then bring the other foot up before stepping back down.", SportId= bodyBuildingId},
            // Index => 779
            new Workout { Id = 780, Name="Sled Push/Pull", Description="A functional exercise that builds strength in legs and core. / Execution: Push or pull a weighted sled across a flat surface for distance or time.", SportId= bodyBuildingId},
            #endregion
                
            #region Quadriceps
            // Index => 780
            new Workout { Id = 781, Name="Sissy Squats", Description="Isolates the quadriceps effectively. / Execution: Stand with feet shoulder-width apart, lean back while bending your knees and lowering your body without letting your heels lift off the ground.", SportId= bodyBuildingId},
            // Index => 781
            new Workout { Id = 782, Name="Narrow-Stance Squats", Description="Focuses more on the vastus lateralis of the quads. / Execution: Perform squats with feet close together to emphasize inner quad activation.", SportId= bodyBuildingId},
            // Index => 782
            new Workout { Id = 783, Name="Pistol Squats", Description="A challenging single-leg squat that targets quads. / Execution: Stand on one leg while extending the other leg forward; lower yourself into a squat on the standing leg.", SportId= bodyBuildingId},
            // Index => 783
            new Workout { Id = 784, Name="Kettlebell Front Squat", Description="Similar to barbell front squats but allows for better mobility. / Execution: Hold kettlebells at shoulder height and perform squats while keeping an upright posture.", SportId= bodyBuildingId},
            #endregion

            #region Hamstrings
            // Index => 784
            new Workout { Id = 785, Name="Conventional Deadlifts", Description="A compound movement that engages the entire posterior chain, including the hamstrings. / Execution: Stand with feet hip-width apart, grip the barbell on the floor, and lift it by extending your hips and knees until standing tall.", SportId= bodyBuildingId},
            // Index => 785
            new Workout { Id = 786, Name="Nordic Hamstring Curls", Description="An advanced exercise that isolates the hamstrings. / Execution: Kneel on the ground with feet anchored. Slowly lower your body forward while keeping your hips extended, then pull yourself back up.", SportId= bodyBuildingId},
            // Index => 786
            new Workout { Id = 787, Name="Single-Leg Romanian Deadlifts", Description="Engages each leg individually for balance and stability. / Execution: Stand on one leg while holding a dumbbell or kettlebell in the opposite hand; hinge at the hips to lower the weight towards the ground.", SportId= bodyBuildingId},
            // Index => 787
            new Workout { Id = 788, Name="Glute-Ham Raises", Description="An excellent exercise for targeting both glutes and hamstrings. / Execution: Use a glute-ham developer machine; secure your feet and lower your body forward before pulling back up using your hamstrings.", SportId= bodyBuildingId},
            // Index => 788
            new Workout { Id = 789, Name="Stiff-Leg Deadlifts", Description="Similar to Romanian deadlifts but with less knee bend to emphasize hamstring stretch. / Execution: Stand with feet shoulder-width apart, hold a barbell or dumbbells, and hinge at the hips to lower weights while keeping legs straight (with a slight bend).", SportId= bodyBuildingId},
            // Index => 789
            new Workout { Id = 790, Name="Floor Glute-Ham Raises", Description="A challenging exercise that targets hamstrings directly from a floor position. / Execution: Lie face down on the ground with feet anchored; flex at the knees to lift your body up using only your hamstrings.", SportId= bodyBuildingId},
	        #endregion
                
            #region Gluteus Maximus
            // Index => 790
            new Workout { Id = 791, Name="Dumbbell Squat", Description="A fundamental compound movement that targets the glutes and quads. / Execution: Stand with feet shoulder-width apart, holding dumbbells at arm’s length by your sides. Push your hips back and lower your body until your thighs are parallel to the floor, then return to standing.", SportId= bodyBuildingId},
            // Index => 791
            new Workout { Id = 792, Name="Glute Bridge", Description="Targets the glutes effectively while also engaging the core. / Execution: Lie on your back with knees bent and feet flat on the floor. Lift your hips towards the ceiling by squeezing your glutes at the top, then lower back down.", SportId= bodyBuildingId},
            // Index => 792
            new Workout { Id = 793, Name="Donkey Kicks", Description="Targets the glutes through hip extension. / Execution: Start on all fours with hands under shoulders and knees under hips. Keeping your knee bent, lift one leg towards the ceiling while squeezing your glute at the top.", SportId= bodyBuildingId},
            // Index => 793
            new Workout { Id = 794, Name="Sumo Deadlift", Description="A variation that targets glutes more due to wider stance. / Execution: Stand with feet wider than shoulder-width apart and toes pointed out. Grip the barbell between your legs and lift it by extending hips and knees.", SportId= bodyBuildingId},
            // Index => 794
            new Workout { Id = 795, Name="Curtsy Lunge", Description="Engages glutes through lateral movement. / Execution: Stand with feet hip-width apart, step one leg behind you and to the side (like a curtsy), lowering into a lunge position before returning to standing.", SportId= bodyBuildingId},
            // Index => 795
            new Workout { Id = 796, Name="Hip Abductor Machine", Description="Isolates and strengthens the outer glutes. / Execution: Sit on an abductor machine with legs inside pads; push outward against resistance to engage the gluteus medius and maximus.", SportId= bodyBuildingId},
            #endregion

            #region Gluteus Medius
            // Index => 796
            new Workout { Id = 797, Name="Lateral Banded Walks", Description="Engages the gluteus medius through lateral movement. / Engages the gluteus medius through lateral movement.", SportId= bodyBuildingId},
            // Index => 797
            new Workout { Id = 798, Name="Side-Lying Leg Lifts", Description="Isolates the gluteus medius effectively. / Execution: Lie on your side with legs stacked. Keeping your top leg straight, lift it towards the ceiling, then lower back down.", SportId= bodyBuildingId},
            // Index => 798
            new Workout { Id = 799, Name="Clamshells", Description="Targets both the gluteus medius and minimus. / Execution: Lie on your side with knees bent at 45 degrees. Keeping your heels together, lift your top knee as high as you can without moving your pelvis.", SportId= bodyBuildingId},
            // Index => 799
            new Workout { Id = 800, Name="Fire Hydrants", Description="Engages the gluteus medius while stabilizing the core. / Execution: Start on all fours, keeping your knee bent at 90 degrees, lift one leg out to the side until parallel to your hip, then lower back down.", SportId= bodyBuildingId},
            // Index => 800
            new Workout { Id = 801, Name="Standing Hip Abduction", Description="Focuses on hip abduction to strengthen the gluteus medius. / Execution: Stand with feet together, shift weight onto one leg, and lift the other leg out to the side, keeping it straight. Return to starting position without letting it touch the ground.", SportId= bodyBuildingId},
            // Index => 801
            new Workout { Id = 802, Name="Single-Leg Glute Bridge", Description="Activates the gluteus medius while also working the gluteus maximus. / Execution: Lie on your back with one foot planted and the other leg extended towards the ceiling. Lift your hips off the ground by pressing through your planted foot.", SportId= bodyBuildingId},
            // Index => 802
            new Workout { Id = 803, Name="Side Plank with Leg Lift", Description="Strengthens both core and gluteus medius. / Execution: In a side plank position, lift your top leg straight up while maintaining stability in your hips.", SportId= bodyBuildingId},
            // Index => 803
            new Workout { Id = 804, Name="Lateral Lunges", Description="Engages glutes and inner thighs while promoting stability. / Execution: Step out to one side into a lunge position, keeping the opposite leg straight. Push through the bent leg to return to standing.", SportId= bodyBuildingId},
            // Index => 804
            new Workout { Id = 805, Name="Cable Hip Abduction", Description="Provides resistance for targeted glute activation. / Execution: Attach an ankle strap to a low pulley; stand facing away from the machine and lift your leg out to the side against resistance.", SportId= bodyBuildingId},
            // Index => 805
            new Workout { Id = 806, Name="Squats with Resistance Band", Description="Enhances engagement of the gluteus medius during squats. / Execution: Place a resistance band just above your knees; perform squats while pushing against the band to activate your outer hips.", SportId= bodyBuildingId},
            // Index => 806
            new Workout { Id = 807, Name="Reverse Lunge with Lateral Raise", Description="Combines lower body movement with upper body activation for balance. / Execution: Step back into a lunge while simultaneously lifting weights or arms laterally to engage core and glutes.", SportId= bodyBuildingId},
            // Index => 807
            new Workout { Id = 808, Name="Hip Thrusts with Abduction", Description="Targets both gluteus maximus and medius. / Execution: Perform a standard hip thrust but add a resistance band around your knees; push against the band as you lift your hips.", SportId= bodyBuildingId},
            // Index => 808
            new Workout { Id = 809, Name="Side Step-Ups", Description="Engages glutes through lateral movement. / Execution: Stand beside a bench or platform; step sideways onto it with one foot, pressing through that foot to stand up before stepping back down.", SportId= bodyBuildingId},
            // Index => 809
            new Workout { Id = 810, Name="Single-Leg Balance", Description="Helps improve stability and strengthen gluteus medius. / Execution: Stand on one leg with a slight bend in your knee; hold this position for 30-60 seconds, challenging balance by closing your eyes or moving arms.", SportId= bodyBuildingId},
            #endregion

            #region Gluteus Medius
            // Index => 810
            new Workout { Id = 811, Name="Single-Leg Dumbbell Hip Thrust", Description="Targets the glutes while challenging stability. / Execution: Sit on the ground with your upper back against a bench, extend one leg towards the ceiling, and thrust your hips upward using the planted foot.", SportId= bodyBuildingId},
            // Index => 811
            new Workout { Id = 812, Name="Curtsy Lunges", Description="Activates the gluteus minimus more than traditional lunges. / Execution: Step one leg behind and to the side of the other leg into a lunge position, keeping your back straight and core engaged.", SportId= bodyBuildingId},
            #endregion

            #region Gluteus Minimus
            // Index => 812
            new Workout { Id = 813, Name="Standing Calf Raises", Description="A classic exercise that targets the gastrocnemius muscle. / Execution: Stand on a raised platform or step with your heels hanging off. Push through the balls of your feet to raise your body upward, then lower your heels below the platform for a full stretch.", SportId= bodyBuildingId},
            // Index => 813
            new Workout { Id = 814, Name="Seated Calf Raises", Description="Focuses on the soleus muscle and is performed with knees bent. / Execution: Sit on a calf raise machine or bench with feet flat on the floor. Press down into the balls of your feet to raise your heels as high as possible, then lower back down.", SportId= bodyBuildingId},
            // Index => 814
            new Workout { Id = 815, Name="Single-Leg Calf Raises", Description="Increases intensity by isolating each calf. / Stand on one leg on a raised surface. Lower your heel towards the ground, then push through the ball of your foot to raise your heel as high as possible.", SportId= bodyBuildingId},
            // Index => 815
            new Workout { Id = 816, Name="Eccentric Calf Raises", Description="Focuses on the eccentric phase to improve muscle elasticity. / Execution: Stand on a step with heels hanging off. Raise both heels, then slowly lower one heel at a time, emphasizing control during the descent.", SportId= bodyBuildingId},
            // Index => 816
            new Workout { Id = 817, Name="Donkey Calf Raises", Description="Allows for greater range of motion and heavier loading. / Execution: Bend forward at the hips while using a donkey calf raise machine or positioning yourself to allow for a full stretch and contraction of the calves.", SportId= bodyBuildingId},
            // Index => 817
            new Workout { Id = 818, Name="Tiptoe Farmers Carry", Description="Engages calves dynamically while improving grip strength. / Execution: Hold heavy dumbbells or kettlebells in each hand and walk on your tiptoes for distance or time.", SportId= bodyBuildingId},
            // Index => 818
            new Workout { Id = 819, Name="Jump Rope", Description="A great cardio exercise that also targets calves. / Execution: Jump continuously while landing softly on the balls of your feet to engage calf muscles throughout the movement.", SportId= bodyBuildingId},
            // Index => 819
            new Workout { Id = 820, Name="Squats Into Calf Raises", Description="Combines squats with calf raises for functional strength. / Execution: Perform a squat, and as you rise, transition into a calf raise at the top of the movement.", SportId= bodyBuildingId},
            // Index => 820
            new Workout { Id = 821, Name="Sled Drag (on Toes)", Description="Engages calves through resistance training. / Execution: Attach a sled to your waist and walk forward on your toes, dragging the sled behind you.", SportId= bodyBuildingId},
            // Index => 821
            new Workout { Id = 822, Name="Jumping Calf Raises", Description="A plyometric exercise that builds explosive strength in calves. / Execution: Jump using only your calves to propel you upward, landing softly and absorbing impact.", SportId= bodyBuildingId},
            // Index => 822
            new Workout { Id = 823, Name="Stadium Stairs", Description=" Running stairs effectively targets calves. / Execution: Run up and down stadium stairs, ensuring each step is taken with the balls of your feet.", SportId= bodyBuildingId},
                
            // Index => 824
            new Workout { Id = 825, Name="Captain Morgan Calf Raise", Description="A unique variation that engages balance and stability. / Execution: Stand on one leg with the other leg bent at 90 degrees; perform calf raises while maintaining balance.", SportId= bodyBuildingId},
            // Index => 825
            new Workout { Id = 826, Name="Lateral Lunge to Calf Raise", Description="Combines lateral movement with calf engagement. / Execution: Step out into a lateral lunge, then push off that leg into a calf raise as you return to standing.", SportId= bodyBuildingId},
            // Index => 826
            new Workout { Id = 827, Name="Calf Raise Machine Variations", Description="Utilize various calf raise machines available at gyms for targeted training. / Execution: Follow standard procedures for seated or standing calf raises using machines designed specifically for this purpose.", SportId= bodyBuildingId},
            #endregion

            #region Gastrocnemius Calves
            // Index => 827
            new Workout { Id = 828, Name="Weighted Calf Raises", Description="Increases resistance to enhance muscle growth. / Execution: Hold dumbbells at your sides or use a barbell across your back while performing standing calf raises.", SportId= bodyBuildingId},
            // Index => 828
            new Workout { Id = 829, Name="Calf Raise on Leg Press Machine", Description="Targets gastrocnemius while allowing for heavy loading. / Execution: Sit on a leg press machine with feet positioned on the platform; perform calf raises by pushing through the balls of your feet.", SportId= bodyBuildingId},
            // Index => 829
            new Workout { Id = 830, Name="Plyometric Box Jumps", Description="Builds explosive power in calves. / Execution: Jump onto a sturdy box or platform from a standing position, focusing on pushing off with your calves.", SportId= bodyBuildingId},
            // Index => 830
            new Workout { Id = 831, Name="Calf Raises with Resistance Bands", Description="Provides variable resistance for targeted training. / Execution: Stand on a resistance band with both feet and perform calf raises, holding onto something for balance if necessary.", SportId= bodyBuildingId},
            // Index => 831
            new Workout { Id = 832, Name="Static Neutral Hold", Description="An isometric exercise that tests calf strength and endurance. / Execution: Stand with the balls of your feet elevated on a block; hold this position for 30-60 seconds while maintaining tension in your calves.", SportId= bodyBuildingId},
            // Index => 832
            new Workout { Id = 833, Name="Sprints", Description="Engages calves through rapid explosive movements. / Execution: Perform short-distance sprints (50-100 yards) focusing on maximizing push-off from the calves.", SportId= bodyBuildingId},
            // Index => 833
            new Workout { Id = 834, Name="Calf Raises on Smith Machine", Description="Allows for controlled movement and added weight. / Execution: Position yourself under a Smith machine barbell, set at shoulder height; perform standing calf raises with added resistance.", SportId= bodyBuildingId},
            // Index => 834
            new Workout { Id = 835, Name="Explosive Calf Step-Ups", Description="Combines plyometric movement with calf engagement. / Execution: Set up with one foot on a box or bench; explosively drive off that foot, jumping upwards off the bench and switching feet in mid-air.", SportId= bodyBuildingId},
            #endregion

            #region Gastrocnemius Calves
            // Index => 835
            new Workout { Id = 836, Name="Bent-Knee Calf Raises", Description="Similar to seated calf raises but can be performed standing. / Execution: Stand with knees slightly bent and perform calf raises, ensuring that you maintain the knee bend throughout the movement.", SportId= bodyBuildingId},
            // Index => 836
            new Workout { Id = 837, Name="Single-Leg Seated Calf Raises", Description="Focuses on one calf at a time for balanced development. / Execution: Sit on a bench with one foot on the ground and the other foot resting on your knee. Perform calf raises with the working leg while keeping the knee bent.", SportId= bodyBuildingId},
            // Index => 837
            new Workout { Id = 838, Name="Standing Soleus Calf Raise", Description="Targets the soleus while standing. / Execution: Stand with feet shoulder-width apart and knees slightly bent. Raise your heels off the ground, focusing on squeezing your calves at the top before lowering back down.", SportId= bodyBuildingId},
            // Index => 838
            new Workout { Id = 839, Name="Soleus Wall Sit", Description="Engages the soleus in an isometric hold. / Execution: Lean against a wall in a squat position with knees bent at 90 degrees. Raise your heels off the ground and hold this position for 30-60 seconds.", SportId= bodyBuildingId},
            // Index => 839
            new Workout { Id = 840, Name="Tip-Toe Walking", Description="Strengthens calves through functional movement. / Execution: Walk on your tiptoes for a set distance or time, focusing on maintaining balance and engaging your calves throughout.", SportId= bodyBuildingId},
            // Index => 840
            new Workout { Id = 841, Name="Calf Raises on Leg Press Machine (Bent Knee)", Description="Allows for greater loading while isolating the soleus. / Execution: Sit on a leg press machine with your feet positioned high; perform calf raises while keeping your knees bent.", SportId= bodyBuildingId},
            // Index => 842
            new Workout { Id = 843, Name="Sled Drag with Bent Knee", Description="Engages soleus through functional movement. / Execution: Attach a sled to your waist and walk forward while keeping your knees slightly bent, focusing on using your calves to push off.", SportId= bodyBuildingId},
            // Index => 843
            new Workout { Id = 844, Name="Calf Raise Finisher", Description="A combination of various calf raise techniques to fully fatigue the muscle. / Execution: Perform three sets of seated calf raises followed by standing calf raises, emphasizing slow controlled movements and holding at both the top and bottom of each rep.", SportId= bodyBuildingId},
            // Index => 844
            new Workout { Id = 845, Name="Wall Calf Stretch with Bent Knee", Description="Stretches and strengthens the soleus through controlled movement. / Execution: Place one foot behind you against a wall while keeping it bent; lean into the wall to stretch while performing small calf raises.", SportId= bodyBuildingId},
            // Index => 845
            new Workout { Id = 846, Name="Calf Raises on Smith Machine (Bent Knee)", Description="Provides controlled movement for focused training. / Execution: Position yourself under a Smith machine barbell set at shoulder height; perform standing calf raises while maintaining slight knee flexion.", SportId= bodyBuildingId},
            #endregion
        };

        //await context.Workouts.AddRangeAsync(workouts);
        //await context.SaveChangesAsync();

        //var instructions = new List<WorkoutInstruction>
        //{
        //    new WorkoutInstruction { WorkoutId = workouts[0].Id, Step= 1, Instruction = "Lie flat on a bench, holding a dumbbell in each hand at chest level, palms facing forward." },
        //    new WorkoutInstruction { WorkoutId = workouts[0].Id, Step= 2, Instruction = "Plant your feet firmly on the ground and engage your core." },
        //    new WorkoutInstruction { WorkoutId = workouts[0].Id, Step= 3, Instruction = "Press the dumbbells upward until your arms are fully extended, keeping them slightly bent at the top." },
        //    new WorkoutInstruction { WorkoutId = workouts[0].Id, Step= 4, Instruction = "Slowly lower the dumbbells back to chest level, maintaining control." },
        //    new WorkoutInstruction { WorkoutId = workouts[0].Id, Step= 5, Instruction = "Repeat for desired reps, keeping movements smooth and controlled." },

        //    new WorkoutInstruction { WorkoutId = workouts[1].Id, Step= 1, Instruction = "Setup: Lie on a flat bench, holding a dumbbell in each hand. Extend arms above your chest, palms facing each other, elbows slightly bent." },
        //    new WorkoutInstruction { WorkoutId = workouts[1].Id, Step= 2, Instruction = "Lowering Phase: Slowly lower the dumbbells in a wide arc to your sides, keeping elbows slightly bent, until you feel a stretch in your chest." },
        //    new WorkoutInstruction { WorkoutId = workouts[1].Id, Step= 3, Instruction = "Lifting Phase: Contract your chest muscles to bring the dumbbells back up in the same arc to the starting position, keeping arms extended." },
        //    new WorkoutInstruction { WorkoutId = workouts[1].Id, Step= 4, Instruction = "Repeat: Perform the movement for the desired reps, maintaining control and a slight bend in the elbows throughout." },

        //    new WorkoutInstruction { WorkoutId = workouts[2].Id, Step= 1, Instruction = "Setup: Lie on your back on the floor, knees bent and feet flat. Hold a dumbbell in each hand, positioned above your chest with palms facing forward." },
        //    new WorkoutInstruction { WorkoutId = workouts[2].Id, Step= 2, Instruction = "Lowering Phase: Slowly lower the dumbbells by bending your elbows, bringing your upper arms toward the floor until they lightly touch or hover just above." },
        //    new WorkoutInstruction { WorkoutId = workouts[2].Id, Step= 3, Instruction = "Pressing Phase: Push the dumbbells back up to the starting position by extending your elbows, contracting your chest and triceps." },
        //    new WorkoutInstruction { WorkoutId = workouts[2].Id, Step= 4, Instruction = "Repeat: Perform the movement for the desired reps, keeping your movements controlled and maintaining a neutral wrist position." },

        //    new WorkoutInstruction { WorkoutId = workouts[3].Id, Step= 1, Instruction = "Setup: Stand with feet shoulder-width apart, holding a dumbbell in each hand. Bend at the hips, keeping your back straight, until your torso is nearly parallel to the floor." },
        //    new WorkoutInstruction { WorkoutId = workouts[3].Id, Step= 2, Instruction = "Starting Position: Let the dumbbells hang at arm’s length, palms facing each other, with shoulders relaxed." },
        //    new WorkoutInstruction { WorkoutId = workouts[3].Id, Step= 3, Instruction = "Pulling Phase: Pull the dumbbells toward your hips, bending your elbows and squeezing your shoulder blades together, keeping your arms close to your body." },
        //    new WorkoutInstruction { WorkoutId = workouts[3].Id, Step= 4, Instruction = "Lowering Phase: Slowly lower the dumbbells back to the starting position, maintaining control and keeping your back straight throughout." },

        //    new WorkoutInstruction { WorkoutId = workouts[4].Id, Step= 1, Instruction = "Setup: Lie on a flat bench with your upper back and shoulders supported, feet flat on the floor. Hold one dumbbell with both hands, cupping the top end, and extend your arms above your chest." },
        //    new WorkoutInstruction { WorkoutId = workouts[4].Id, Step= 2, Instruction = "Lowering Phase: Slowly lower the dumbbell in an arc over your head toward the floor, keeping a slight bend in your elbows and feeling a stretch in your chest and lats." },
        //    new WorkoutInstruction { WorkoutId = workouts[4].Id, Step= 3, Instruction = "Pulling Phase: Engage your lats and chest to pull the dumbbell back to the starting position above your chest, following the same arc." },
        //    new WorkoutInstruction { WorkoutId = workouts[4].Id, Step= 4, Instruction = "Repeat: Perform the movement for the desired reps, maintaining control and a slight elbow bend throughout." },

        //    new WorkoutInstruction { WorkoutId = workouts[5].Id, Step= 1, Instruction = "Setup: Lie on a flat bench with your upper back and shoulders supported, feet flat on the floor. Hold one dumbbell with both hands, cupping the top end, and extend your arms above your chest." },
        //    new WorkoutInstruction { WorkoutId = workouts[5].Id, Step= 2, Instruction = "Lowering Phase: Slowly lower the dumbbell in an arc over your head toward the floor, keeping a slight bend in your elbows and feeling a stretch in your chest and lats." },
        //    new WorkoutInstruction { WorkoutId = workouts[5].Id, Step= 3, Instruction = "Pulling Phase: Engage your lats and chest to pull the dumbbell back to the starting position above your chest, following the same arc." },
        //    new WorkoutInstruction { WorkoutId = workouts[5].Id, Step= 4, Instruction = "Repeat: Perform the movement for the desired reps, maintaining control and a slight elbow bend throughout." },

        //    new WorkoutInstruction { WorkoutId = workouts[6].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[7].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[8].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[9].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[10].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[11].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[12].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[13].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[14].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[15].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[16].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[17].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[18].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[19].Id, Step= 1, Instruction = "" },

        //    new WorkoutInstruction { WorkoutId = workouts[20].Id, Step= 1, Instruction = "" },
        //};
        //await context.WorkoutInstructions.AddRangeAsync(instructions);
        //await context.SaveChangesAsync();

        ////**************************
        //var workoutEquipment = new List<WorkoutEquipment>();
        //workoutEquipment = new List<WorkoutEquipment>
        //{

        //};
        //await context.WorkoutEquipment.AddRangeAsync(workoutEquipment);
        //await context.SaveChangesAsync();
        ////**************************
        //var workoutLevel = new List<WorkoutLevel>();
        //workoutLevel = new List<WorkoutLevel>
        //{
        //    new WorkoutLevel{ WorkoutId = workouts[4].Id , Level = Difficulty.Intermediate },
        //    new WorkoutLevel{ WorkoutId = workouts[5].Id , Level = Difficulty.Intermediate },
        //};
        //await context.WorkoutLevels.AddRangeAsync(workoutLevel);
        //await context.SaveChangesAsync();

        //// ***************************************************************** //
        //var bodyWorkouts = new List<BodyWorkout>();
        //var bicepId = await context.Bodies.Where(z => z.Name == "Biceps").Select(z => z.Id).FirstOrDefaultAsync();
        //var longHeadBicepId = await context.Bodies.Where(z => z.Name == "Long Head Bicep").Select(z => z.Id).FirstOrDefaultAsync();
        //var shortHeadBicepId = await context.Bodies.Where(z => z.Name == "Short Head Bicep").Select(z => z.Id).FirstOrDefaultAsync();

        //bodyWorkouts = new List<BodyWorkout>
        //{

        //};
        //await context.BodyWorkouts.AddRangeAsync(bodyWorkouts);
        //await context.SaveChangesAsync();

        return workouts;
    }


    public static async Task duplicateWorkouts()
    {
        var workouts = await WorkoutSeedAsync();
        var duplicateWorkouts = workouts.GroupBy(z => z.Name)
            .Where(g => g.Count() > 1)
            .SelectMany(z => z.Skip(1))
            .ToList(); // ==> 

        var dupName = duplicateWorkouts.Select(z => z.Name).ToList(); // ==> 

        var json = JsonSerializer.Serialize(dupName, new JsonSerializerOptions { WriteIndented = true });
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "listItems.json");
        File.WriteAllText(filePath, json);


        Console.Clear();
        foreach (var item in dupName)
        {
            Console.WriteLine($"duplicate Name {item}");
        }

        var uniqueSeedWorkouts = workouts
            .GroupBy(x => x.Name)
            .Select(g => g.First())
            .ToList(); // ==> 

        var optionsBuilder = new DbContextOptionsBuilder<FitnessContext>();
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=FitnessPlan;User Id=sa;Password=1234512345;MultipleActiveResultSets=true;TrustServerCertificate=True");

        using var context = new FitnessContext(optionsBuilder.Options);
        //var backWorkouts = BackWorkoutDbInitializer.BackWorkoutSeedAsync(context);
        List<Workout> backWorkouts = await BackWorkoutDbInitializer.BackWorkoutSeedAsync(context);

        var backs = backWorkouts.Select(z => z.Name).ToList();
        var workoutNames = workouts.Select(z => z.Name).ToList();
        var comapreWorkoutToBacks = workoutNames.Intersect(backs).ToList();
        
        var compareSecond = workoutNames.Where(item => backs.Contains(item, StringComparer.OrdinalIgnoreCase)).Distinct().ToList();
        
        var set2 = new HashSet<string>(backs, StringComparer.OrdinalIgnoreCase);
        var duplicateNames = backs
            .GroupBy(s => s, StringComparer.OrdinalIgnoreCase)
            .Where(g => g.Count() > 1)
            .SelectMany(g => g.Skip(1)) // Skip first occurrence in each group
            .ToList();

        var duplicateJson = JsonSerializer.Serialize(duplicateNames, new JsonSerializerOptions { WriteIndented = true });
        var duplicatefilepath = Path.Combine(Directory.GetCurrentDirectory(), "duplicateitems.json");
        File.WriteAllText(duplicatefilepath, duplicateJson);

        var duplicates = workoutNames.Where(set2.Contains).Distinct().ToList();

        var dbjson = JsonSerializer.Serialize(comapreWorkoutToBacks, new JsonSerializerOptions { WriteIndented = true });
        var dbfilepath = Path.Combine(Directory.GetCurrentDirectory(), "dbitems.json");
        File.WriteAllText(dbfilepath, dbjson);


        // // ==> Get data from database then compare,
        //var workoutNames = uniqueSeedWorkouts.Select(x => x.Name).ToList();
        //var existingWorkouts = await context.Workouts
        //    .Where(w => workoutNames.Contains(w.Name))
        //    .ToListAsync();
        //var exisname = existingWorkouts.Select(z => z.Name).ToList();

        //var dbJson = JsonSerializer.Serialize(exisname, new JsonSerializerOptions { WriteIndented = true });
        //var dbfilePath = Path.Combine(Directory.GetCurrentDirectory(), "dbItems.json");
        //File.WriteAllText(dbfilePath, dbJson);
        //foreach (var item in exisname)
        //{
        //    Console.WriteLine($"existing Workouts => {item}");
        //}


    }

}