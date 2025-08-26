namespace Presentation.Seed;

public class HamstringWorkoutDbInitializer
{
    public static async Task WorkoutSeedAsync(FitnessContext context)
    {
        var Workouts = new List<Workout>();

        var bodybuildingId = await context.Sports.Where(s => s.Name == "Body Building").Select(z => z.Id).FirstOrDefaultAsync();
        var cardioSportId = await context.Sports.Where(s => s.Name == "Cardio").Select(z => z.Id).FirstOrDefaultAsync();
        var crossfitId = await context.Sports.Where(s => s.Name == "Cross Fit").Select(z => z.Id).FirstOrDefaultAsync();
        var yogaSportId = await context.Sports.Where(s => s.Name == "Yoga").Select(z => z.Id).FirstOrDefaultAsync();

        Workouts = new List<Workout>
        {
            // Barbell,
            new Workout{ Name = "Barbell Stiff Leg Deadlifts", SportId = bodybuildingId, Description = "" },                        // index => 0,
            new Workout{ Name = "Barbell High Bar Good Morning", SportId = bodybuildingId, Description = "" },                      // index => 1,
            new Workout{ Name = "Barbell Low Bar Good Morning", SportId = bodybuildingId, Description = "" },                       // index => 2,
            new Workout{ Name = "Barbell Romanian Deadlift", SportId = bodybuildingId, Description = "" },                          // index => 3,
            new Workout{ Name = "Barbell Snatch Grip Deadlift", SportId = bodybuildingId, Description = "" },                       // index => 4,
            new Workout{ Name = "Barbell Snatch Grip Romanian Deadlift", SportId = bodybuildingId, Description = "" },              // index => 5,
            new Workout{ Name = "Barbell Zercher Good Morning", SportId = bodybuildingId, Description = "" },                       // index => 6,
            new Workout{ Name = "Barbell Suitcase Deadlift", SportId = bodybuildingId, Description = "" },                          // index => 7,
            new Workout{ Name = "Landmine Romanian Deadlift", SportId = bodybuildingId, Description = "" },                         // index => 8,
            new Workout{ Name = "Landmine Single Leg Romanian Deadlift", SportId = bodybuildingId, Description = "" },              // index => 9,
            new Workout{ Name = "Landmine Staggered Romanian Deadlift", SportId = bodybuildingId, Description = "" },               // index => 10,
            new Workout{ Name = "Barbell Suitcase Carry", SportId = bodybuildingId, Description = "" },                             // index => 11,
            
            // Machine,
            new Workout{ Name = "Machine Hamstring Curl", SportId = bodybuildingId, Description = "" },                             // index => 12,
            new Workout{ Name = "Glute Ham Raise", SportId = bodybuildingId, Description = "" },                                    // index => 13,
            new Workout{ Name = "Seated Leg Curl", SportId = bodybuildingId, Description = "" },                                    // index => 14,
            new Workout{ Name = "Machine Seated Leg Curl", SportId = bodybuildingId, Description = "" },                            // index => 15,
            new Workout{ Name = "Machine Plate Loaded Kneeling Hamstring Curl", SportId = bodybuildingId, Description = "" },       // index => 16,
            new Workout{ Name = "Machine Reverse Hyperextension", SportId = bodybuildingId, Description = "" },                     // index => 17,
            new Workout{ Name = "Machine Standing Hamstring Curl", SportId = bodybuildingId, Description = "" },                    // index => 18,
            new Workout{ Name = "Machine Seated Hamstring Curl", SportId = bodybuildingId, Description = "" },                      // index => 19,
            
            // Stretches,
            new Workout{ Name = "Hamstrings Stretch Variation Four", SportId = cardioSportId, Description = "" },                   // index => 20,
            new Workout{ Name = "Hamstrings Stretch Variation Three", SportId = cardioSportId, Description = "" },                  // index => 21,
            new Workout{ Name = "Hamstrings Stretch Variation Two", SportId = cardioSportId, Description = "" },                    // index => 22,
            new Workout{ Name = "Hamstrings Stretch Variation One", SportId = cardioSportId, Description = "" },                    // index => 23,
            
            // Plate,
            new Workout{ Name = "Plate Single Leg Pinch Grip Deadlift", SportId = bodybuildingId, Description = "" },               // index => 24,
            new Workout{ Name = "Plate Single Leg Deadlift", SportId = bodybuildingId, Description = "" },                          // index => 25,
            new Workout{ Name = "Plate Staggered Deadlift", SportId = bodybuildingId, Description = "" },                           // index => 26,
            new Workout{ Name = "Plate Staggered Pinch Grip Deadlift", SportId = bodybuildingId, Description = "" },                // index => 27,
            new Workout{ Name = "Plate Good Morning", SportId = bodybuildingId, Description = "" },                                 // index => 28,
            new Workout{ Name = "Plate Good Morning Anterior", SportId = bodybuildingId, Description = "" },                        // index => 29,
            new Workout{ Name = "Plate Deadlift", SportId = bodybuildingId, Description = "" },                                     // index => 30,
            new Workout{ Name = "Plate Staggered Waiters Bow", SportId = bodybuildingId, Description = "" },                        // index => 31,
            new Workout{ Name = "Plate Waiters Bow", SportId = bodybuildingId, Description = "" },                                  // index => 32,
            
            // Smith-Machine,
            new Workout{ Name = "Smith Machine Staggered Deadlift", SportId = bodybuildingId, Description = "" },                   // index => 33,
            new Workout{ Name = "Smith Machine Romanian Deadlift", SportId = bodybuildingId, Description = "" },                    // index => 34,
            new Workout{ Name = "Smith Machine Sumo Romanian Deadlift", SportId = bodybuildingId, Description = "" },               // index => 35,
            
            // Dumbbells,
            new Workout{ Name = "Dumbbell Goblet Good Morning", SportId = bodybuildingId, Description = "" },                       // index => 36,
            new Workout{ Name = "Dumbbell Romanian Deadlift", SportId = bodybuildingId, Description = "" },                         // index => 37,
            new Workout{ Name = "Dumbbell Leg Curl", SportId = bodybuildingId, Description = "" },                                  // index => 38,
            new Workout{ Name = "Dumbbell Single Leg Single Arm Deadlift", SportId = bodybuildingId, Description = "" },            // index => 39,
            new Workout{ Name = "Dumbbell Single Leg Stiff Leg Deadlift", SportId = bodybuildingId, Description = "" },             // index => 40,
            new Workout{ Name = "Dumbbell Staggered Deadlift", SportId = bodybuildingId, Description = "" },                        // index => 41,
            new Workout{ Name = "Dumbbell Swing", SportId = bodybuildingId, Description = "" },                                     // index => 42,
            new Workout{ Name = "Dumbbell Glute Bridge", SportId = bodybuildingId, Description = "" },                              // index => 43,
            new Workout{ Name = "Dumbbell Cross Body Romanian Deadlift", SportId = bodybuildingId, Description = "" },              // index => 44,
            new Workout{ Name = "Dumbbell Staggered Waiters Bow", SportId = bodybuildingId, Description = "" },                     // index => 45,
            new Workout{ Name = "Dumbbell Waiters Bow", SportId = bodybuildingId, Description = "" },                               // index => 46,
            new Workout{ Name = "Dumbbell Half Kneeling Goblet Romanian Deadlift", SportId = bodybuildingId, Description = "" },    // index => 47,
            new Workout{ Name = "Dumbbell Half Kneeling Romanian Deadlift", SportId = bodybuildingId, Description = "" },           // index => 48,
            
            // Medicine-Ball,
            new Workout{ Name = "Medicine Ball Single Leg Deadlift", SportId = bodybuildingId, Description = "" },                  // index => 49,
            
            // Cables,
            new Workout{ Name = "Cable Bar Romanian Deadlift", SportId = bodybuildingId, Description = "" },                        // index => 50,
            new Workout{ Name = "Cable Single Leg Deadlift", SportId = bodybuildingId, Description = "" },                          // index => 51,
            new Workout{ Name = "Cable Pull Through", SportId = bodybuildingId, Description = "" },                                 // index => 52,
            new Workout{ Name = "Cable Hamstring Curl", SportId = bodybuildingId, Description = "" },                               // index => 53,
            new Workout{ Name = "Cable Bar Staggered Romanian Deadlift", SportId = bodybuildingId, Description = "" },              // index => 54,
            new Workout{ Name = "Cable Elevated Deadlift", SportId = bodybuildingId, Description = "" },                            // index => 55,
            new Workout{ Name = "Cable Seated Leg Curl", SportId = bodybuildingId, Description = "" },                              // index => 56,
            new Workout{ Name = "Cable Single Leg Laying Leg Curl", SportId = bodybuildingId, Description = "" },                   // index => 57,
            new Workout{ Name = "Cable Zercher Good Morning", SportId = bodybuildingId, Description = "" },                         // index => 58,
            
            // TRX,
            new Workout{ Name = "TRX Hamstring Curl", SportId = crossfitId, Description = "" },                                     // index => 59, 
            
            // Vitruvian,
            new Workout{ Name = "Vitruvian Romanian Deadlift", SportId = bodybuildingId, Description = "" },                        // index => 60,
            new Workout{ Name = "Vitruvian Single Leg Deadlift", SportId = bodybuildingId, Description = "" },                      // index => 61,
            new Workout{ Name = "Vitruvian Staggered Deadlift", SportId = bodybuildingId, Description = "" },                       // index => 62,
            
            // Recovery,
            new Workout{ Name = "Deadlift Bounces Stretch", SportId = cardioSportId, Description = "" },                            // index => 63,
            new Workout{ Name = "Hamstring Mobilisation Seated Lacrosse Ball", SportId = cardioSportId, Description = "" },         // index => 64,
            new Workout{ Name = "Hamstring Stretch Dynamic Standing Bilateral", SportId = cardioSportId, Description = "" },        // index => 65,
            new Workout{ Name = "Hamstring Stretch Dynamic Supine Alternating", SportId = cardioSportId, Description = "" },        // index => 66,
            new Workout{ Name = "Hamstring Stretch Seated Single Leg", SportId = cardioSportId, Description = "" },                 // index => 67,
            new Workout{ Name = "Hamstring Stretch Seated Single Leg Isometric", SportId = cardioSportId, Description = "" },       // index => 68,
            new Workout{ Name = "Hamstring Stretch Static Standing Single Leg", SportId = cardioSportId, Description = "" },        // index => 69,
            new Workout{ Name = "Hamstring Stretch Supine Dynamic Band", SportId = cardioSportId, Description = "" },               // index => 70,
            new Workout{ Name = "Hamstring Stretch Supine Glide", SportId = cardioSportId, Description = "" },                      // index => 71,
            new Workout{ Name = "Hamstring Stretch Supine Static", SportId = cardioSportId, Description = "" },                     // index => 72,
            new Workout{ Name = "Box Supported Single Leg Deadlift", SportId = cardioSportId, Description = "" },                   // index => 73,
            new Workout{ Name = "Inchworm", SportId = cardioSportId, Description = "" },                                            // index => 74,
            
            // Bodyweight,
            new Workout{ Name = "Good Mornings", SportId = crossfitId, Description = "" },                                          // index => 75,
            new Workout{ Name = "Single Legged Romanian Deadlifts", SportId = crossfitId, Description = "" },                       // index => 76,
            new Workout{ Name = "Nordic Hamstring Curl", SportId = crossfitId, Description = "" },                                  // index => 77,
            new Workout{ Name = "Bodyweight Reverse Lunge", SportId = crossfitId, Description = "" },                               // index => 78,
            new Workout{ Name = "Hamstring Bridge Isometric Open Angle", SportId = crossfitId, Description = "" },                  // index => 79,
            new Workout{ Name = "Hamstring Bridge With Elevated Legs Box Bilateral", SportId = crossfitId, Description = "" },      // index => 80,
            new Workout{ Name = "Hamstring Bridge With Elevated Legs Box Unilateral", SportId = crossfitId, Description = "" },     // index => 81,
            new Workout{ Name = "Slider Hamstring Curl Single Leg", SportId = crossfitId, Description = "" },                       // index => 82,
            new Workout{ Name = "Single Leg Slider Hamstring Curl 2", SportId = crossfitId, Description = "" },                     // index => 83,
            new Workout{ Name = "Slider Hamstring Curl Eccentric", SportId = crossfitId, Description = "" },                        // index => 84,
            new Workout{ Name = "Bodyweight Standing Hamstring Curl", SportId = crossfitId, Description = "" },                     // index => 85,
            new Workout{ Name = "Bodyweight Standing Hamstring Curl Isometric", SportId = crossfitId, Description = "" },           // index => 86,
            new Workout{ Name = "Slider Hamstring Curl", SportId = crossfitId, Description = "" },                                  // index => 87,
            new Workout{ Name = "Bodyweight Single Leg Balance Stable", SportId = crossfitId, Description = "" },                   // index => 88,
            new Workout{ Name = "Bodyweight Staggered Waiters Bow", SportId = crossfitId, Description = "" },                       // index => 89,
            new Workout{ Name = "Bodyweight Waiters Bow", SportId = crossfitId, Description = "" },                                 // index => 90,
            new Workout{ Name = "Bodyweight Stability Ball Hyperextension", SportId = crossfitId, Description = "" },               // index => 91,
            new Workout{ Name = "Stability Ball Hamstring Curl", SportId = crossfitId, Description = "" },                          // index => 92,
            new Workout{ Name = "Stability Ball Reverse Hyperextension", SportId = crossfitId, Description = "" },                  // index => 93,
            new Workout{ Name = "Half Kneeling Hip Hinge", SportId = crossfitId, Description = "" },                                // index => 94,
            
            // Kettlebells,
            new Workout{ Name = "Kettlebell Deadlift (Single)", SportId = bodybuildingId, Description = "" },                       // index => 95,
            new Workout{ Name = "Kettlebell Swing", SportId = bodybuildingId, Description = "" },                                   // index => 96,
            new Workout{ Name = "Kettlebell Single Leg Deadlift", SportId = bodybuildingId, Description = "" },                     // index => 97,
            new Workout{ Name = "Kettlebell Staggered Deadlift (Single)", SportId = bodybuildingId, Description = "" },             // index => 98,
            new Workout{ Name = "Kettlebell Goblet Good Morning", SportId = bodybuildingId, Description = "" },                     // index => 99,
            new Workout{ Name = "Kettlebell Alternating Swing", SportId = bodybuildingId, Description = "" },                       // index => 100,
            new Workout{ Name = "Kettlebell Conventional Deadlift (Double)", SportId = bodybuildingId, Description = "" },          // index => 101,
            new Workout{ Name = "Kettlebell Swing (Double)", SportId = bodybuildingId, Description = "" },                          // index => 102,
            new Workout{ Name = "Kettlebell Full Swing", SportId = bodybuildingId, Description = "" },                              // index => 103,
            new Workout{ Name = "Kettlebell Romanian Deadlift", SportId = bodybuildingId, Description = "" },                       // index => 104,
            new Workout{ Name = "Kettlebell Single Arm Swing", SportId = bodybuildingId, Description = "" },                        // index => 105,
            new Workout{ Name = "Kettlebell Staggered Deadlift", SportId = bodybuildingId, Description = "" },                      // index => 106,
            new Workout{ Name = "Kettlebell Staggered Swing", SportId = bodybuildingId, Description = "" },                         // index => 107,
            new Workout{ Name = "Swing To Upright Row", SportId = bodybuildingId, Description = "" },                               // index => 108,
            new Workout{ Name = "Kettlebell Suitcase Deadlift", SportId = bodybuildingId, Description = "" },                       // index => 109,
            new Workout{ Name = "Kettlebell Staggered Waiters Bow", SportId = bodybuildingId, Description = "" },                   // index => 110,
            new Workout{ Name = "Kettlebell Waiters Bow", SportId = bodybuildingId, Description = "" },                             // index => 111,
            new Workout{ Name = "Kettlebell Half Kneeling Goblet Romanian Deadlift", SportId = bodybuildingId, Description = "" },  // index => 112,
            new Workout{ Name = "Kettlebell Half Kneeling Romanian Deadlift", SportId = bodybuildingId, Description = "" },         // index => 113,
            
            // Band,
            new Workout{ Name = "Band Good Morning", SportId = cardioSportId, Description = "" },                                   // index => 114,
            new Workout{ Name = "Band Pullthrough", SportId = cardioSportId, Description = "" },                                    // index => 115,
            new Workout{ Name = "Band Romanian Deadlift", SportId = cardioSportId, Description = "" },                              // index => 116,
            new Workout{ Name = "Band Leg Curl", SportId = cardioSportId, Description = "" },                                       // index => 117,
            
            // Yoga,
            new Workout{ Name = "Half Monkey Pose", SportId = yogaSportId, Description = "" },                                      // index => 118,
            new Workout{ Name = "Seated Forward Bend", SportId = yogaSportId, Description = "" },                                   // index => 119,
            new Workout{ Name = "Pyramid Pose", SportId = yogaSportId, Description = "" },                                          // index => 120,
            new Workout{ Name = "Pyramid Pose Blocks", SportId = yogaSportId, Description = "" },                                   // index => 121,
            new Workout{ Name = "Standing Forward Bend", SportId = yogaSportId, Description = "" },                                 // index => 122,
            new Workout{ Name = "Standing Forward Bend Blocks", SportId = yogaSportId, Description = "" },                          // index => 123,
            new Workout{ Name = "Warrior Three", SportId = yogaSportId, Description = "" },                                         // index => 124,
            new Workout{ Name = "Wide Legged Standing Forward Bend Holding Heels", SportId = yogaSportId, Description = "" },       // index => 125,
            
            // Cardio,
            new Workout{ Name = "Treadmill Jog", SportId = cardioSportId, Description = "" },                                       // index => 126,
            new Workout{ Name = "Treadmill Sprint", SportId = cardioSportId, Description = "" },                                    // index => 127,
            new Workout{ Name = "Treadmill Walk", SportId = cardioSportId, Description = "" },                                      // index => 128,
            new Workout{ Name = "Cardio Figure Eight Sprint", SportId = cardioSportId, Description = "" },                          // index => 129,
            new Workout{ Name = "Cardio Three Step Heismans", SportId = cardioSportId, Description = "" },                          // index => 130,
            new Workout{ Name = "Cardio Knee Taps", SportId = cardioSportId, Description = "" },                                    // index => 131,
            new Workout{ Name = "Butt Kick", SportId = cardioSportId, Description = "" },                                           // index => 132
        };


        await context.Workouts.AddRangeAsync(Workouts);
        await context.SaveChangesAsync();

        // ***************************************************************** //
        var workoutInstruction = new List<WorkoutInstruction>();
        workoutInstruction = new List<WorkoutInstruction>
        {
            #region Barbell,
            new WorkoutInstruction{ WorkoutId = Workouts[0].Id , Step = 1 , Instruction = " Stand with a barbell at your shins with your feet shoulder width apart." },
            new WorkoutInstruction{ WorkoutId = Workouts[0].Id , Step = 2 , Instruction = " Bend forward at your hips and keep your knees as fully extended as possible." },
            new WorkoutInstruction{ WorkoutId = Workouts[0].Id , Step = 3 , Instruction = " Grab the barbell and then extend your hips while maintaining a straight back." },
            new WorkoutInstruction{ WorkoutId = Workouts[0].Id , Step = 4 , Instruction = " From the standing position, lower the weight in a controlled manner." },
            new WorkoutInstruction{ WorkoutId = Workouts[0].Id , Step = 5 , Instruction = " You can either lower the weight to the floor or before you touch the floor, depending on your mobility." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[1].Id , Step = 1 , Instruction = " Place the bar on your traps. You may need a pad so the bar doesn't dig into your cervical spine." },
            new WorkoutInstruction{ WorkoutId = Workouts[1].Id , Step = 2 , Instruction = " Push your hips straight back. Your knees should stay MOSTLY extended (think soft knees). Also make sure to" },
            new WorkoutInstruction{ WorkoutId = Workouts[1].Id , Step = 3 , Instruction = " Look for what feels like a stretch in your hamstrings. The stretch feeling means you're likely nearing the end of your Range of Motion without rounding your spine." },
            new WorkoutInstruction{ WorkoutId = Workouts[1].Id , Step = 4 , Instruction = " When you feel the stretch push your hips forward until you're in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[2].Id , Step = 1 , Instruction = " Place the bar between your traps and rear delts. Pull your shoulder blades back to give the bar a shelf to sit on." },
            new WorkoutInstruction{ WorkoutId = Workouts[2].Id , Step = 2 , Instruction = " Push your hips back until you feel a stretch in your hamstrings. This means you're nearing the end of your Range of Motion with out rounding your spine." },
            new WorkoutInstruction{ WorkoutId = Workouts[2].Id , Step = 3 , Instruction = " When you feel the stretch push your hips forward until you'e in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[3].Id , Step = 1 , Instruction = " Take a shoulder width, double overhand or mixed grip." },
            new WorkoutInstruction{ WorkoutId = Workouts[3].Id , Step = 2 , Instruction = " Push your hips back while leaving your knees mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[3].Id , Step = 3 , Instruction = " When you feel the stretch, push your hips forward until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[4].Id , Step = 1 , Instruction = " Start by standing with your feet about hip-width apart, with your toes pointed slightly outward." },            
            new WorkoutInstruction{ WorkoutId = Workouts[4].Id , Step = 2 , Instruction = " Place a barbell on the floor in front of you, with the weight plates on either side. Make sure that the bar is directly in line with your feet." },
            new WorkoutInstruction{ WorkoutId = Workouts[4].Id , Step = 3 , Instruction = " Bend down and grab the barbell with an overhand grip, your hands much wider than shoulder-width apart. Keep your back straight and your shoulders down as you grip the bar." },
            new WorkoutInstruction{ WorkoutId = Workouts[4].Id , Step = 4 , Instruction = " Stand up straight, lifting the barbell off the ground and pulling it toward your hips. Keep your elbows close to your body and your shoulders down as you do this." },
            new WorkoutInstruction{ WorkoutId = Workouts[4].Id , Step = 5 , Instruction = " Slowly lower the barbell back to the ground, making sure to keep your back straight and your shoulders down throughout the movement." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[5].Id , Step = 1 , Instruction = " Start by standing with your feet about hip-width apart. The bar should be in a rack or box so it's lifted off the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[5].Id , Step = 2 , Instruction = " Grab the barbell with an overhand grip, your hands should be much wider than shoulder-width apart." },
            new WorkoutInstruction{ WorkoutId = Workouts[5].Id , Step = 3 , Instruction = " Hing forward at the hips keeping your knees mostly extended. Hinge until you feel a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[5].Id , Step = 4 , Instruction = " When you feel the stretch, push your hips forward until you are back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[6].Id , Step = 1 , Instruction = " Begin by standing with your feet about hip-width apart and holding a barbell in the crook of your elbows, with your palms facing towards your body." },
            new WorkoutInstruction{ WorkoutId = Workouts[6].Id , Step = 2 , Instruction = " Keeping your core engaged and your back straight, bend at the hips and lower your torso forward until it is nearly parallel to the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[6].Id , Step = 3 , Instruction = " Push through your heels to extend your hips and raise your body back to the starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[7].Id , Step = 1 , Instruction = " Begin by standing with your feet hip-width apart and holding a barbell at one side of your body, with your palms facing your thighs." },
            new WorkoutInstruction{ WorkoutId = Workouts[7].Id , Step = 2 , Instruction = " Keeping your core engaged and your back straight, bend at the hips and knees to lower the barbell down towards the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[7].Id , Step = 3 , Instruction = " As the barbell reaches the ground, use your legs and glutes to push through your heels and extend your hips and knees to raise your body back to the starting position." },
            new WorkoutInstruction{ WorkoutId = Workouts[7].Id , Step = 4 , Instruction = " Repeat the movement for the desired number of reps, then switch sides and repeat the exercise with the barbell on the opposite side of your body." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[8].Id , Step = 1 , Instruction = " Stand in front of the landmine with your feet hip-width apart and your knees slightly bent. Grasp the landmine barbell with both hands, palms facing each other, and hold it in front of your thighs." },
            new WorkoutInstruction{ WorkoutId = Workouts[8].Id , Step = 2 , Instruction = " Keeping your back straight and your core engaged, hinge at the hips and push your hips back, allowing the landmine to travel down your thighs. Lower the landmine by bending forward at the hips while keeping your back flat, allowing the barbell to move closer to the floor. Continue the movement until you feel a stretch in your hamstrings, keeping your legs relatively straight but with a slight bend in the knees." },
            new WorkoutInstruction{ WorkoutId = Workouts[8].Id , Step = 3 , Instruction = " Reverse the movement by pushing your hips forward and driving through your heels while keeping your back straight." },
            new WorkoutInstruction{ WorkoutId = Workouts[8].Id , Step = 4 , Instruction = " Repeat for the desired number of reps." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[9].Id , Step = 1 , Instruction = " Grab the end of the landmine and stand perpendicular to the bar." },
            new WorkoutInstruction{ WorkoutId = Workouts[9].Id , Step = 2 , Instruction = " Lift your inside leg and keep your outside leg planted." },
            new WorkoutInstruction{ WorkoutId = Workouts[9].Id , Step = 3 , Instruction = " Push your hips back keeping your knees mostly extended. When you feel the stretch in your hams, push your hips forward until you are standing upright." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[10].Id , Step = 1 , Instruction = " Stand in a staggered position. With the back leg bent and the front mostly extended." },
            new WorkoutInstruction{ WorkoutId = Workouts[10].Id , Step = 2 , Instruction = " Push your hips back until you feel a stretch through your front hamstring." },
            new WorkoutInstruction{ WorkoutId = Workouts[10].Id , Step = 3 , Instruction = " Push your hips back forward until you are standing." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[11].Id , Step = 1 , Instruction = " Begin by standing with your feet hip-width apart with the bar on the ground at your side." },
            new WorkoutInstruction{ WorkoutId = Workouts[11].Id , Step = 2 , Instruction = " Lift the bar to your side and walk for the allotted amount of time or distance." },
            new WorkoutInstruction{ WorkoutId = Workouts[11].Id , Step = 3 , Instruction = " Set the bar down and switch sides." },
            #endregion,
            
            #region Machine,
            new WorkoutInstruction{ WorkoutId = Workouts[12].Id , Step = 1 , Instruction = " Lay down on the machine, placing your legs beneath the padded lever. Position your legs so that the padded lever is below your calve muscles." },
            new WorkoutInstruction{ WorkoutId = Workouts[12].Id , Step = 2 , Instruction = " Support yourself by grabbing the side handles of the machine, and slowly raise the weight with your legs, toes pointed straight." },
            new WorkoutInstruction{ WorkoutId = Workouts[12].Id , Step = 3 , Instruction = " Pause at the apex of the motion, then slowly return to starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[13].Id , Step = 1 , Instruction = " Position yourself on a glute ham raise machine or find a suitable substitute like a stability ball or bench." },
            new WorkoutInstruction{ WorkoutId = Workouts[13].Id , Step = 2 , Instruction = " Adjust the equipment to fit your body by setting the footplate at an appropriate height and making sure your feet are securely anchored." },
            new WorkoutInstruction{ WorkoutId = Workouts[13].Id , Step = 3 , Instruction = " Begin the movement by slowly lowering your upper body towards the ground while keeping your torso and legs aligned." },
            new WorkoutInstruction{ WorkoutId = Workouts[13].Id , Step = 4 , Instruction = " Once you reach the lowest point where your body is parallel to the ground or as far as you can comfortably go, pause briefly." },
            new WorkoutInstruction{ WorkoutId = Workouts[13].Id , Step = 5 , Instruction = " Engage your glutes and hamstrings again as you push yourself back up to the starting position, using the strength of your posterior chain muscles." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[14].Id , Step = 1 , Instruction = " Sit on the machine. Adjust the back pad to where the leg pad is just above your knees." },
            new WorkoutInstruction{ WorkoutId = Workouts[14].Id , Step = 2 , Instruction = " Adjust the leg pad that goes on your lower leg until it's on your achilles." },
            new WorkoutInstruction{ WorkoutId = Workouts[14].Id , Step = 3 , Instruction = " Use the two handles to push your self back in the chair. Curl your legs as far as possible, and then extend your knees. (Do not hyperextend)" },
            
            new WorkoutInstruction{ WorkoutId = Workouts[15].Id , Step = 1 , Instruction = " Sit back in the seat. Use the two handles to push yourself back into the chair." },
            new WorkoutInstruction{ WorkoutId = Workouts[15].Id , Step = 2 , Instruction = " Flex your ankles and point your toes upward." },
            new WorkoutInstruction{ WorkoutId = Workouts[15].Id , Step = 3 , Instruction = " Flex your knee bringing the pad backward, extend your knee without allowing the weight to touch back down." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[16].Id , Step = 1 , Instruction = " Lay down on the machine, placing your working leg beneath the padded lever. Position your leg so that the padded lever is below your calve muscle." },
            new WorkoutInstruction{ WorkoutId = Workouts[16].Id , Step = 2 , Instruction = " Support yourself by grabbing the side handles of the machine, and slowly raise the weight with your legs." },
            new WorkoutInstruction{ WorkoutId = Workouts[16].Id , Step = 3 , Instruction = " Pause at the apex of the motion, then slowly return to starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[17].Id , Step = 1 , Instruction = " Lay on the pad and grab the handles." },
            new WorkoutInstruction{ WorkoutId = Workouts[17].Id , Step = 2 , Instruction = " Slip your legs into the belt loop." },
            new WorkoutInstruction{ WorkoutId = Workouts[17].Id , Step = 3 , Instruction = " Push your legs back until they are horizontal with the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[17].Id , Step = 4 , Instruction = " Lower back to the starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[18].Id , Step = 1 , Instruction = " Press yourself into the pads and put your calves against the lower pads." },
            new WorkoutInstruction{ WorkoutId = Workouts[18].Id , Step = 2 , Instruction = " Flex your knee until you feel a contraction in your hamstring, then lower back to the start." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[19].Id , Step = 1 , Instruction = " Adjust the back pad and ankle pad to suit your height." },
            new WorkoutInstruction{ WorkoutId = Workouts[19].Id , Step = 2 , Instruction = " Disengage the knee pad and lower it as far as you can." },
            new WorkoutInstruction{ WorkoutId = Workouts[19].Id , Step = 3 , Instruction = " Flex your knees against resistance, then extend until you feel a stretch in your hamstrings." },
            #endregion,
            
            #region Stretches,
            new WorkoutInstruction{ WorkoutId = Workouts[20].Id , Step = 1 , Instruction = " Sit on the floor with your legs out in front of you." },
            new WorkoutInstruction{ WorkoutId = Workouts[20].Id , Step = 2 , Instruction = " Reach forward to try and touch your toes. Reach as far forward as you can go." },
            new WorkoutInstruction{ WorkoutId = Workouts[20].Id , Step = 3 , Instruction = " Hold the stretch for a few seconds then return to starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[21].Id , Step = 1 , Instruction = " Sit on the floor with one leg outstretched and the other bent at the knee, foot resting on the opposite inner thigh." },
            new WorkoutInstruction{ WorkoutId = Workouts[21].Id , Step = 2 , Instruction = " Reach forward to touch the toes of the outstretched leg." },
            new WorkoutInstruction{ WorkoutId = Workouts[21].Id , Step = 3 , Instruction = " Hold the stretch for a few seconds then return to starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[22].Id , Step = 1 , Instruction = " Stand with one foot in front of the other." },
            new WorkoutInstruction{ WorkoutId = Workouts[22].Id , Step = 2 , Instruction = " Bend your rear leg as much as you can, keeping the front leg straight." },
            new WorkoutInstruction{ WorkoutId = Workouts[22].Id , Step = 3 , Instruction = " Hold the stretch for a few seconds then return to starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[23].Id , Step = 1 , Instruction = " Lie down with your legs reaching up the wall. your bum should be slightly off the floor." },
            new WorkoutInstruction{ WorkoutId = Workouts[23].Id , Step = 2 , Instruction = " Bend one leg and leave the other outstretched." },
            new WorkoutInstruction{ WorkoutId = Workouts[23].Id , Step = 3 , Instruction = " Push your thigh towards the wall." },
            new WorkoutInstruction{ WorkoutId = Workouts[23].Id , Step = 4 , Instruction = " Hold the stretch for a few seconds then return to starting position." },
            #endregion,
            
            #region Plate,
            new WorkoutInstruction{ WorkoutId = Workouts[24].Id , Step = 1 , Instruction = " Stand with your feet shoulder-width apart and facing forwards. Grip the sides of a weight plate with your palms facing down." },
            new WorkoutInstruction{ WorkoutId = Workouts[24].Id , Step = 2 , Instruction = " Balance on one foot, as you raise the weight keep your arms and back straight, while you bring your  other foot back towards the ground" },
            new WorkoutInstruction{ WorkoutId = Workouts[24].Id , Step = 3 , Instruction = " Keep four raised leg straight and in alignment with your back as you lower the plate back down to the starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[25].Id , Step = 1 , Instruction = " Engage your core and straighten your legs to lift the plate off the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[25].Id , Step = 2 , Instruction = " Stand on one leg, keeping the other leg off the ground, while holding the plate in front of your body." },
            new WorkoutInstruction{ WorkoutId = Workouts[25].Id , Step = 3 , Instruction = " Keep your back straight and maintain a neutral head position while looking straight ahead." },
            new WorkoutInstruction{ WorkoutId = Workouts[25].Id , Step = 4 , Instruction = " Lower the plate back down to the ground while keeping your balance on one leg." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[26].Id , Step = 1 , Instruction = " Start by standing with your feet shoulder-width apart and holding a weight plate." },
            new WorkoutInstruction{ WorkoutId = Workouts[26].Id , Step = 2 , Instruction = " Place one foot slightly behind the other, with the heel of your back foot elevated." },
            new WorkoutInstruction{ WorkoutId = Workouts[26].Id , Step = 3 , Instruction = " From this starting position, bend at the hips and knees to lower the plate towards the ground, keeping your back straight and your core engaged." },
            new WorkoutInstruction{ WorkoutId = Workouts[26].Id , Step = 4 , Instruction = " Once the plate is below your knees, drive through your heels to stand back up to the starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[27].Id , Step = 1 , Instruction = " Start by standing with your feet shoulder-width apart and holding two plates with a pinch grip." },
            new WorkoutInstruction{ WorkoutId = Workouts[27].Id , Step = 2 , Instruction = " Place one foot slightly behind the other, with the heel of your back foot elevated." },
            new WorkoutInstruction{ WorkoutId = Workouts[27].Id , Step = 3 , Instruction = " From this starting position, bend at the hips and knees to lower the plates towards the ground, keeping your back straight and your core engaged." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[28].Id , Step = 1 , Instruction = " Stand with feet hip-width apart, the plate held behind the neck and the knees slightly bent." },
            new WorkoutInstruction{ WorkoutId = Workouts[28].Id , Step = 2 , Instruction = " Bend forward at the hips, keeping the back straight, until the torso is parallel to the floor." },
            new WorkoutInstruction{ WorkoutId = Workouts[28].Id , Step = 3 , Instruction = " Push through the hips to return to the starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[29].Id , Step = 1 , Instruction = " Stand with feet hip-width apart, the plate held in front of you, and the knees slightly bent." },
            new WorkoutInstruction{ WorkoutId = Workouts[29].Id , Step = 2 , Instruction = " Bend forward at the hips, keeping the back straight, until the torso is parallel to the floor." },
            new WorkoutInstruction{ WorkoutId = Workouts[29].Id , Step = 3 , Instruction = " Push through the hips to return to the starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[30].Id , Step = 1 , Instruction = " Stand with feet hip-width apart, the plate in front of the feet, and the knees slightly bent." },
            new WorkoutInstruction{ WorkoutId = Workouts[30].Id , Step = 2 , Instruction = " Bend the hips and knees to grip the plate with palms facing the body." },
            new WorkoutInstruction{ WorkoutId = Workouts[30].Id , Step = 3 , Instruction = " Keeping the back straight, stand up while lifting the plate off the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[30].Id , Step = 4 , Instruction = " Return the plate back to the starting position by bending the hips and knees, keeping control of the plate." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[31].Id , Step = 1 , Instruction = " Set up a bar at mid way up your quad. Place the working leg against the bar." },
            new WorkoutInstruction{ WorkoutId = Workouts[31].Id , Step = 2 , Instruction = " Place one foot behind. You should only be on your toes on that back foot. Your front foot should be planted flat the entire time." },
            new WorkoutInstruction{ WorkoutId = Workouts[31].Id , Step = 3 , Instruction = " Bend your back knee and push your hips back. Look for a stretch in your front hamstring." },
            new WorkoutInstruction{ WorkoutId = Workouts[31].Id , Step = 4 , Instruction = " When you feel the stretch, push your hips forward again until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[32].Id , Step = 1 , Instruction = " Place a barbell at about midway up your thigh. Press your quads into the barbell. Hold a plate up to your chest." },
            new WorkoutInstruction{ WorkoutId = Workouts[32].Id , Step = 2 , Instruction = " Push your hips back while leaving your knees mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[32].Id , Step = 3 , Instruction = " When you feel the stretch, push your hips forward until you're back in a standing position." },
            #endregion,
            
            #region Smith-Machine,
            new WorkoutInstruction{ WorkoutId = Workouts[33].Id , Step = 1 , Instruction = " Place one foot behind. You should only be on your toes on that back foot. Your front foot should be planted flat the entire time." },
            new WorkoutInstruction{ WorkoutId = Workouts[33].Id , Step = 2 , Instruction = " Bend your back knee and push your hips back. Look for a stretch in your front hamstring." },
            new WorkoutInstruction{ WorkoutId = Workouts[33].Id , Step = 3 , Instruction = " When you feel the stretch, push your hips forward again until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[34].Id , Step = 1 , Instruction = " Take a shoulder width, double overhand or mixed grip." },
            new WorkoutInstruction{ WorkoutId = Workouts[34].Id , Step = 2 , Instruction = " Push your hips back while leaving your knees mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[34].Id , Step = 3 , Instruction = " When you feel the stretch, push your hips forward until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[35].Id , Step = 1 , Instruction = " Stance width can vary with a sumo DL. Some prefer toes near the plates. Others prefer a more narrow stance to get more drive off the floor." },
            new WorkoutInstruction{ WorkoutId = Workouts[35].Id , Step = 2 , Instruction = " Make sure your arms are inside your legs. The bar should be just over your mid-foot. Flatten your back and unrack the bar" },
            new WorkoutInstruction{ WorkoutId = Workouts[35].Id , Step = 3 , Instruction = " Leave your knees mostly extended and flex and extend your hips." },
            #endregion,
            
            #region Dumbbells,
            new WorkoutInstruction{ WorkoutId = Workouts[36].Id , Step = 1 , Instruction = " Hold the dumbbell in a goblet position. With your elbows directly under your fists." },
            new WorkoutInstruction{ WorkoutId = Workouts[36].Id , Step = 2 , Instruction = " Push your hips back while leaving your knees MOSTLY extended. You should feel a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[36].Id , Step = 3 , Instruction = " When you feel the stretch push your hips forward until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[37].Id , Step = 1 , Instruction = " Stand with a shoulder width stance. Push your butt back while leaving your knees MOSTLY extended." },
            new WorkoutInstruction{ WorkoutId = Workouts[37].Id , Step = 2 , Instruction = " You should feel a stretch in your hamstrings. When you feel the stretch, push your hips forward to complete the rep." },
            new WorkoutInstruction{ WorkoutId = Workouts[37].Id , Step = 3 , Instruction = " Do not push your hips all the way forward. This will hyperextend your spine. Just go to a normal standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[38].Id , Step = 1 , Instruction = " Lay flat on a bench with a dumbbell between your feet." },
            new WorkoutInstruction{ WorkoutId = Workouts[38].Id , Step = 2 , Instruction = " Flex your knees and raise the dumbbell until the soles of your shoes are pointed at the ceiling." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[39].Id , Step = 1 , Instruction = " Start by standing on one leg with a dumbbell in one hand." },
            new WorkoutInstruction{ WorkoutId = Workouts[39].Id , Step = 2 , Instruction = " Slowly bend at the hips and lower the dumbbell towards the ground while extending your free leg behind you." },
            new WorkoutInstruction{ WorkoutId = Workouts[39].Id , Step = 3 , Instruction = " Keep your core engaged and your back straight as you lower the weight." },
            new WorkoutInstruction{ WorkoutId = Workouts[39].Id , Step = 4 , Instruction = " Once the dumbbell is close to the ground, push through your heel to return to the starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[40].Id , Step = 1 , Instruction = " Start by standing on one leg with your feet shoulder-width apart and holding two dumbbells." },
            new WorkoutInstruction{ WorkoutId = Workouts[40].Id , Step = 2 , Instruction = " From this starting position, hinge at the hips to lower the dumbbell towards the ground, keeping your back straight and your core engaged." },
            new WorkoutInstruction{ WorkoutId = Workouts[40].Id , Step = 3 , Instruction = " Once you feel a stretch in your hamstring, slowly return to the starting position." },
            new WorkoutInstruction{ WorkoutId = Workouts[40].Id , Step = 4 , Instruction = " Make sure to keep your standing leg slightly bent and avoid rounding your back as you lower the dumbbell." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[41].Id , Step = 1 , Instruction = " Start by standing with your feet shoulder-width apart and holding a dumbbell in each hand." },
            new WorkoutInstruction{ WorkoutId = Workouts[41].Id , Step = 2 , Instruction = " Place one foot slightly behind the other, with the heel of your back foot elevated on a step or weight plate." },
            new WorkoutInstruction{ WorkoutId = Workouts[41].Id , Step = 3 , Instruction = " From this starting position, bend at the hips and knees to lower the dumbbells towards the ground, keeping your back straight and your core engaged." },
            new WorkoutInstruction{ WorkoutId = Workouts[41].Id , Step = 4 , Instruction = " Once the dumbbells are below your knees, drive through your heels to stand back up to the starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[42].Id , Step = 1 , Instruction = " Start by standing with your feet shoulder-width apart and holding a dumbbell in both hands." },
            new WorkoutInstruction{ WorkoutId = Workouts[42].Id , Step = 2 , Instruction = " Bend your knees slightly and hinge at the hips to swing the dumbbell between your legs." },
            new WorkoutInstruction{ WorkoutId = Workouts[42].Id , Step = 3 , Instruction = " From this starting position, explosively extend your hips and swing the dumbbell up to chest height." },
            new WorkoutInstruction{ WorkoutId = Workouts[42].Id , Step = 4 , Instruction = " Allow the momentum of the swing to carry the dumbbell back down between your legs, and then repeat the movement for the desired number of repetitions." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[43].Id , Step = 1 , Instruction = " Lay flat on the ground with both feet planted. Make sure you keep your heels glued to the floor." },
            new WorkoutInstruction{ WorkoutId = Workouts[43].Id , Step = 2 , Instruction = " Place the dumbbell on your hips. Push your hips toward the ceiling until you feel your glutes contract." },
            new WorkoutInstruction{ WorkoutId = Workouts[43].Id , Step = 3 , Instruction = " Then return to the floor." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[44].Id , Step = 1 , Instruction = " Stand with a shoulder width stance holding one dumbbell. Push your butt back while leaving your knees MOSTLY extended." },
            new WorkoutInstruction{ WorkoutId = Workouts[44].Id , Step = 2 , Instruction = " Reach toward the opposing leg. You should feel a stretch in your hamstrings. When you feel the stretch, push your hips forward to complete the rep." },
            new WorkoutInstruction{ WorkoutId = Workouts[44].Id , Step = 3 , Instruction = " Do not push your hips all the way forward. This will hyperextend your spine. Just go to a normal standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[45].Id , Step = 1 , Instruction = " Set up a bar at mid way up your quad. Place the working leg against the bar." },
            new WorkoutInstruction{ WorkoutId = Workouts[45].Id , Step = 2 , Instruction = " Place one foot behind. You should only be on your toes on that back foot. Your front foot should be planted flat the entire time." },
            new WorkoutInstruction{ WorkoutId = Workouts[45].Id , Step = 3 , Instruction = " Bend your back knee and push your hips back. Look for a stretch in your front hamstring." },
            new WorkoutInstruction{ WorkoutId = Workouts[45].Id , Step = 4 , Instruction = " When you feel the stretch, push your hips forward again until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[46].Id , Step = 1 , Instruction = " Place a barbell at about midway up your thigh. Press your quads into the barbell." },
            new WorkoutInstruction{ WorkoutId = Workouts[46].Id , Step = 2 , Instruction = " Push your hips back while leaving your knees mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[46].Id , Step = 3 , Instruction = " When you feel the stretch, push your hips forward until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[47].Id , Step = 1 , Instruction = " Place one knee on a bench and hold a dumbbell in a goblet position." },
            new WorkoutInstruction{ WorkoutId = Workouts[47].Id , Step = 2 , Instruction = " Push your hips back while leaving your knee mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[47].Id , Step = 3 , Instruction = " When you feel the stretch, push your hips forward until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[48].Id , Step = 1 , Instruction = " Place one knee on a bench and hold a dumbbell." },
            new WorkoutInstruction{ WorkoutId = Workouts[48].Id , Step = 2 , Instruction = " Push your hips back while leaving your knee mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[48].Id , Step = 3 , Instruction = " When you feel the stretch, push your hips forward until you're back in a standing position." },
            #endregion,
            
            #region Medicine-Ball,
            new WorkoutInstruction{ WorkoutId = Workouts[49].Id , Step = 1 , Instruction = " Hold medicine ball while standing on one leg." },
            new WorkoutInstruction{ WorkoutId = Workouts[49].Id , Step = 2 , Instruction = " Hinge forward on one leg, extending other leg behind." },
            new WorkoutInstruction{ WorkoutId = Workouts[49].Id , Step = 3 , Instruction = " Return to starting position. Repeat on other leg." },
            #endregion,
            
            #region Cables,
            new WorkoutInstruction{ WorkoutId = Workouts[50].Id , Step = 1 , Instruction = " Start with a straight bar or ez bar attachment set to the bottom of the machine. Squat the weight up into a standing position and walk a few steps back" },
            new WorkoutInstruction{ WorkoutId = Workouts[50].Id , Step = 2 , Instruction = " Push your butt back to initiate the movement and then push your butt forward until you're back in a standing position." },
            new WorkoutInstruction{ WorkoutId = Workouts[50].Id , Step = 3 , Instruction = " To protect yourself from injury, always maintain a flat back on any exercise." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[51].Id , Step = 1 , Instruction = " Start with a straight bar or easy bar attachment. Squat the weight up into a standing position and walk a few steps back." },
            new WorkoutInstruction{ WorkoutId = Workouts[51].Id , Step = 2 , Instruction = " Push your butt back to initiate the movement while lifting one of your legs. Then push your butt forward until you're back in a standing position." },
            new WorkoutInstruction{ WorkoutId = Workouts[51].Id , Step = 3 , Instruction = " Compete your given amount of reps, then switch to opposite leg." },
            new WorkoutInstruction{ WorkoutId = Workouts[51].Id , Step = 4 , Instruction = " To protect yourself from injury, always maintain a flat back." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[52].Id , Step = 1 , Instruction = " This exercise works best with a rope attachment but can be done with anything. The attachment should be set to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = Workouts[52].Id , Step = 2 , Instruction = " Face away from the cable machine, straddle the cable itself, and grab the attachment. Walk a few steps away." },
            new WorkoutInstruction{ WorkoutId = Workouts[52].Id , Step = 3 , Instruction = " Break at the hips while maintaining a flat back and mostly extended knees." },
            new WorkoutInstruction{ WorkoutId = Workouts[52].Id , Step = 4 , Instruction = " Push hips forward until you are back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[53].Id , Step = 1 , Instruction = " Use an ankle attachment with the cable set all the way to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = Workouts[53].Id , Step = 2 , Instruction = " Stand upright or try bending slightly forward." },
            new WorkoutInstruction{ WorkoutId = Workouts[53].Id , Step = 3 , Instruction = " Flex at the knee and pull your ankle straight back." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[54].Id , Step = 1 , Instruction = " Start with a straight bar attachment set to the bottom of the machine. Squat the weight up into a standing position and walk a few steps back." },
            new WorkoutInstruction{ WorkoutId = Workouts[54].Id , Step = 2 , Instruction = " Stand with a staggered stance. Push your butt back to initiate the movement and then push your butt forward until you're back in a standing position." },
            new WorkoutInstruction{ WorkoutId = Workouts[54].Id , Step = 3 , Instruction = " To protect yourself from injury, always maintain a flat back on any exercise." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[55].Id , Step = 1 , Instruction = " Start with handles set to the bottom of the machine. Grab a box, stand on top of the box, squat the weight up into a standing position." },
            new WorkoutInstruction{ WorkoutId = Workouts[55].Id , Step = 2 , Instruction = " Push your butt back to initiate the movement and then push your butt forward until you're back in a standing position." },
            new WorkoutInstruction{ WorkoutId = Workouts[55].Id , Step = 3 , Instruction = " To protect yourself from injury, always maintain a flat back on any exercise." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[56].Id , Step = 1 , Instruction = " Bring a bench over to the cable stack, put the cable at head height (when seated). Use an ankle attachment." },
            new WorkoutInstruction{ WorkoutId = Workouts[56].Id , Step = 2 , Instruction = " Sit on the bench." },
            new WorkoutInstruction{ WorkoutId = Workouts[56].Id , Step = 3 , Instruction = " Flex at the knee and pull your ankle straight back." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[57].Id , Step = 1 , Instruction = " Bring a bench over to the cable stack, put the cable all the way at the bottom. Use an ankle attachment." },
            new WorkoutInstruction{ WorkoutId = Workouts[57].Id , Step = 2 , Instruction = " Lay on the bench." },
            new WorkoutInstruction{ WorkoutId = Workouts[57].Id , Step = 3 , Instruction = " Flex at the knee and pull your ankle straight back." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[58].Id , Step = 1 , Instruction = " Begin by standing with your feet about hip-width apart and holding the bar in the crook of your elbows, with your palms facing towards your body." },
            new WorkoutInstruction{ WorkoutId = Workouts[58].Id , Step = 2 , Instruction = " Keeping your core engaged and your back straight, bend at the hips and lower your torso forward until it is nearly parallel to the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[58].Id , Step = 3 , Instruction = " Push through your heels to extend your hips and raise your body back to the starting position." },
            #endregion,
            
            #region TRX,
            new WorkoutInstruction{ WorkoutId = Workouts[59].Id , Step = 1 , Instruction = " Start by facing the TRX straps and positioning yourself in a push-up position with your hands on the ground and your feet in the TRX foot cradles." },
            new WorkoutInstruction{ WorkoutId = Workouts[59].Id , Step = 2 , Instruction = " Keeping your core engaged and body in a straight line, bend your knees and bring your heels towards your glutes." },
            new WorkoutInstruction{ WorkoutId = Workouts[59].Id , Step = 3 , Instruction = " Pause for a moment at the top of the movement, then slowly lower your legs back to the starting position." },
            #endregion,
            
            #region Vitruvian,
            new WorkoutInstruction{ WorkoutId = Workouts[60].Id , Step = 1 , Instruction = " Take an overhand grip." },
            new WorkoutInstruction{ WorkoutId = Workouts[60].Id , Step = 2 , Instruction = " Keep your knees mostly extended and hinge forward at the hips." },
            new WorkoutInstruction{ WorkoutId = Workouts[60].Id , Step = 3 , Instruction = " Keep a flat back." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[61].Id , Step = 1 , Instruction = " Hold medicine ball while standing on one leg." },
            new WorkoutInstruction{ WorkoutId = Workouts[61].Id , Step = 2 , Instruction = " Hinge forward on one leg, extending other leg behind." },
            new WorkoutInstruction{ WorkoutId = Workouts[61].Id , Step = 3 , Instruction = " Return to starting position. Repeat on other leg." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[62].Id , Step = 1 , Instruction = " Place one foot firmly on the ground and one foot behind the other. Bend the knee on your back leg." },
            new WorkoutInstruction{ WorkoutId = Workouts[62].Id , Step = 2 , Instruction = " Hinge forward until you feel a stretch in your front leg." },
            #endregion,
            
            #region Recovery,
            new WorkoutInstruction{ WorkoutId = Workouts[63].Id , Step = 1 , Instruction = " Stand up straight with a good form." },
            new WorkoutInstruction{ WorkoutId = Workouts[63].Id , Step = 2 , Instruction = " Send your hips back and start tilting the upper body." },
            new WorkoutInstruction{ WorkoutId = Workouts[63].Id , Step = 3 , Instruction = " Maintain a straight back as you aim for your toes." },
            new WorkoutInstruction{ WorkoutId = Workouts[63].Id , Step = 4 , Instruction = " Your range depends on your hamstring flexibility." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[64].Id , Step = 1 , Instruction = " Place a massage ball on a bench." },
            new WorkoutInstruction{ WorkoutId = Workouts[64].Id , Step = 2 , Instruction = " Sit on the ball with your hamstring." },
            new WorkoutInstruction{ WorkoutId = Workouts[64].Id , Step = 3 , Instruction = " Move around till you find a tight/sore spot." },
            new WorkoutInstruction{ WorkoutId = Workouts[64].Id , Step = 4 , Instruction = " Extend and bend your knee to mobilise the hamstring." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[65].Id , Step = 1 , Instruction = " Standing, split stance." },
            new WorkoutInstruction{ WorkoutId = Workouts[65].Id , Step = 2 , Instruction = " Dynamically kick your back leg forward and up." },
            new WorkoutInstruction{ WorkoutId = Workouts[65].Id , Step = 3 , Instruction = " Return to starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[66].Id , Step = 1 , Instruction = " Lie on your back with straight legs." },
            new WorkoutInstruction{ WorkoutId = Workouts[66].Id , Step = 2 , Instruction = " Perform a posterior pelvic tilt and maintain the position." },
            new WorkoutInstruction{ WorkoutId = Workouts[66].Id , Step = 3 , Instruction = " Kick one leg up to feel a stretch in the hamstring." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[68].Id , Step = 1 , Instruction = " Sit against a wall." },
            new WorkoutInstruction{ WorkoutId = Workouts[68].Id , Step = 2 , Instruction = " Bend one leg and tuck the foot by the straight leg's knee." },
            new WorkoutInstruction{ WorkoutId = Workouts[68].Id , Step = 3 , Instruction = " Dynamically reach forward towards your toes and return to starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[69].Id , Step = 1 , Instruction = " From the standing position, bring one leg slightly forward." },
            new WorkoutInstruction{ WorkoutId = Workouts[69].Id , Step = 2 , Instruction = " Raise your toes and lean over towards them." },
            new WorkoutInstruction{ WorkoutId = Workouts[69].Id , Step = 3 , Instruction = " Maintain the position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[70].Id , Step = 1 , Instruction = " Place a theraband or stretch strap around your foot." },
            new WorkoutInstruction{ WorkoutId = Workouts[70].Id , Step = 2 , Instruction = " Lie back onto the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[70].Id , Step = 3 , Instruction = " Raise your leg to stretching point with the aid of the band (strap)." },
            new WorkoutInstruction{ WorkoutId = Workouts[70].Id , Step = 4 , Instruction = " Tug onto the strap on the end of range to dynamically stretch the hamstring." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[71].Id , Step = 1 , Instruction = " Place a theraband around your foot." },
            new WorkoutInstruction{ WorkoutId = Workouts[71].Id , Step = 2 , Instruction = " Lie back onto the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[71].Id , Step = 3 , Instruction = " Raise your leg to stretching point with the aid of the band, keeping a slightly bent knee." },
            new WorkoutInstruction{ WorkoutId = Workouts[71].Id , Step = 4 , Instruction = " Extend and bend your knee to actively stretch your hamstring." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[72].Id , Step = 1 , Instruction = " Place a theraband or stretch strap around your foot." },
            new WorkoutInstruction{ WorkoutId = Workouts[72].Id , Step = 2 , Instruction = " Lie back onto the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[72].Id , Step = 3 , Instruction = " Raise your leg to stretching point with the aid of the band (strap)." },
            new WorkoutInstruction{ WorkoutId = Workouts[72].Id , Step = 4 , Instruction = " Tug onto the strap on the end of range to dynamically stretch the hamstring." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[73].Id , Step = 1 , Instruction = " Place a box behind you and one foot on it. Keep your chest up and the back straight" },
            new WorkoutInstruction{ WorkoutId = Workouts[73].Id , Step = 2 , Instruction = " Tilt at the hips to perform a deadlift. Use the box for balance and support" },
            new WorkoutInstruction{ WorkoutId = Workouts[73].Id , Step = 3 , Instruction = " Make sure you straighten your back leg when performing the deadlift." },
            new WorkoutInstruction{ WorkoutId = Workouts[73].Id , Step = 4 , Instruction = " As you get comfortable with the movement, try to lift the leg off the box when you reach the end range of the deadlift." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[74].Id , Step = 1 , Instruction = " Stand tall, hinge at hips, and reach hands to the floor." },
            new WorkoutInstruction{ WorkoutId = Workouts[74].Id , Step = 2 , Instruction = " Walk hands forward into a plank position." },
            new WorkoutInstruction{ WorkoutId = Workouts[74].Id , Step = 3 , Instruction = " Walk feet towards hands and repeat the motion." },
            #endregion,
            
            #region Bodyweight,
            new WorkoutInstruction{ WorkoutId = Workouts[75].Id , Step = 1 , Instruction = " Stand with your feet a little past shoulder width apart with a slight bend at your knee. Place your hands behind the back of your head." },
            new WorkoutInstruction{ WorkoutId = Workouts[75].Id , Step = 2 , Instruction = " Keeping your back straight, rotate your hips to bring your shoulders down towards the floor. Stop when your chest is parallel with the floor." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[76].Id , Step = 1 , Instruction = " Stand with your feet shoulder-width apart and knees slightly bent and raise one leg." },
            new WorkoutInstruction{ WorkoutId = Workouts[76].Id , Step = 2 , Instruction = " Without changing the bend in your knee, bend at your hips, and lower your torso until it's almost parallel to the floor." },
            new WorkoutInstruction{ WorkoutId = Workouts[76].Id , Step = 3 , Instruction = " Tense your glutes and then bring yourself back to the starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[77].Id , Step = 1 , Instruction = " Go to your knees and ask someone to hold your ankles." },
            new WorkoutInstruction{ WorkoutId = Workouts[77].Id , Step = 2 , Instruction = " Put your hands in front of you" },
            new WorkoutInstruction{ WorkoutId = Workouts[77].Id , Step = 3 , Instruction = " With a slight bend in your knees slowly bring your body to the ground (slower is better)" },
            new WorkoutInstruction{ WorkoutId = Workouts[77].Id , Step = 4 , Instruction = " Push up and reset to the starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[78].Id , Step = 1 , Instruction = " Take a big step backwards with your left leg, lowering your body until your left thigh is parallel to the ground and your right knee is bent at a 90-degree angle." },
            new WorkoutInstruction{ WorkoutId = Workouts[78].Id , Step = 2 , Instruction = " Push through your right heel to return to standing, bringing your left leg back to starting position." },
            new WorkoutInstruction{ WorkoutId = Workouts[78].Id , Step = 3 , Instruction = " Repeat the movement on the other side, stepping backwards with your right leg and lowering your body until your right thigh is parallel to the ground and your left knee is bent at a 90-degree angle." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[79].Id , Step = 1 , Instruction = " Lie on your back with knees slightly bent and heels dug in." },
            new WorkoutInstruction{ WorkoutId = Workouts[79].Id , Step = 2 , Instruction = " Perform a posterior pelvic tilt (flatten your lower back on the ground)." },
            new WorkoutInstruction{ WorkoutId = Workouts[79].Id , Step = 3 , Instruction = " Press the heels into the ground to raise your hips off it." },
            new WorkoutInstruction{ WorkoutId = Workouts[79].Id , Step = 4 , Instruction = " Hold the position for the specified duration." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[80].Id , Step = 1 , Instruction = " Lie on your back. Place your heels on a box or bench, having a 90° angle at hips and knees." },
            new WorkoutInstruction{ WorkoutId = Workouts[80].Id , Step = 2 , Instruction = " Perform a posterior pelvic tilt (flatten your lower back against the ground)." },
            new WorkoutInstruction{ WorkoutId = Workouts[80].Id , Step = 3 , Instruction = " Push through your heels into the box, lifting your hips up to the point where there is a straight line from your chest to your knees." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[81].Id , Step = 1 , Instruction = " Lie on your back. Place one heel on a box or bench, having a 90° angle at hip and knee." },
            new WorkoutInstruction{ WorkoutId = Workouts[81].Id , Step = 2 , Instruction = " Perform a posterior pelvic tilt (flatten your lower back against the ground)." },
            new WorkoutInstruction{ WorkoutId = Workouts[81].Id , Step = 3 , Instruction = " Push through your heel into the box, lifting your hips up to the point where there is a straight line from your chest to your knees." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[82].Id , Step = 1 , Instruction = " Lie on your back keeping both knees bent." },
            new WorkoutInstruction{ WorkoutId = Workouts[82].Id , Step = 2 , Instruction = " Have a slider under the heel of the working leg." },
            new WorkoutInstruction{ WorkoutId = Workouts[82].Id , Step = 3 , Instruction = " Extend and bend the working lag applying gentle downwards pressure." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[83].Id , Step = 1 , Instruction = " Lie on your back with bent knees and heels on a slider." },
            new WorkoutInstruction{ WorkoutId = Workouts[83].Id , Step = 2 , Instruction = " Perform a posterior pelvic tilt (flatten your lower back on the ground)." },
            new WorkoutInstruction{ WorkoutId = Workouts[83].Id , Step = 3 , Instruction = " Press the heels into the ground to raise your hips off it." },
            new WorkoutInstruction{ WorkoutId = Workouts[83].Id , Step = 4 , Instruction = " Extend and bend the working leg." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[84].Id , Step = 1 , Instruction = " Bend your knees so your feet are flat on the floor with heels under knees and toes raised." },
            new WorkoutInstruction{ WorkoutId = Workouts[84].Id , Step = 2 , Instruction = " Place sliders under your heels. Perform a posterior pelvic tilt (flatten your lower back against the ground)." },
            new WorkoutInstruction{ WorkoutId = Workouts[84].Id , Step = 3 , Instruction = " Push through your heels into the ground, lifting your hips up to the point where there is a straight line from your chest to your knees." },
            new WorkoutInstruction{ WorkoutId = Workouts[84].Id , Step = 4 , Instruction = " Extend your legs in a slow, controlled manner, to lower your bum to the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[84].Id , Step = 5 , Instruction = " Casually bend knees before repeating." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[85].Id , Step = 1 , Instruction = " Stand up straight using a balancing aid." },
            new WorkoutInstruction{ WorkoutId = Workouts[85].Id , Step = 2 , Instruction = " Shift your weight on one leg." },
            new WorkoutInstruction{ WorkoutId = Workouts[85].Id , Step = 3 , Instruction = " Bend and extend the non-weight bearing leg." },
            new WorkoutInstruction{ WorkoutId = Workouts[85].Id , Step = 4 , Instruction = " Knees should remain aligned." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[86].Id , Step = 1 , Instruction = " Stand up straight using a balancing aid." },
            new WorkoutInstruction{ WorkoutId = Workouts[86].Id , Step = 2 , Instruction = " Shift your weight on one leg." },
            new WorkoutInstruction{ WorkoutId = Workouts[86].Id , Step = 3 , Instruction = " Bend the non-weight bearing leg and hold." },
            new WorkoutInstruction{ WorkoutId = Workouts[86].Id , Step = 4 , Instruction = " Knees should remain aligned." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[87].Id , Step = 1 , Instruction = " Lie on your back with slightly bent knees and heels on sliders." },
            new WorkoutInstruction{ WorkoutId = Workouts[87].Id , Step = 2 , Instruction = " Pull your heels towards your glutes to lift your hips off the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[87].Id , Step = 3 , Instruction = " Extend knees to starting position, but do not rest hips on ground." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[88].Id , Step = 1 , Instruction = " Hold on to something stable and pull the leg on the opposing side straight up. Hold this position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[89].Id , Step = 1 , Instruction = " Set up a bar at mid way up your quad. Place the working leg against the bar." },
            new WorkoutInstruction{ WorkoutId = Workouts[89].Id , Step = 2 , Instruction = " Place one foot behind. You should only be on your toes on that back foot. Your front foot should be planted flat the entire time." },
            new WorkoutInstruction{ WorkoutId = Workouts[89].Id , Step = 3 , Instruction = " Bend your back knee and push your hips back. Look for a stretch in your front hamstring." },
            new WorkoutInstruction{ WorkoutId = Workouts[89].Id , Step = 4 , Instruction = " When you feel the stretch, push your hips forward again until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[90].Id , Step = 1 , Instruction = " Place a barbell at about midway up your thigh. Press your quads into the barbell." },
            new WorkoutInstruction{ WorkoutId = Workouts[90].Id , Step = 2 , Instruction = " Push your hips back while leaving your knees mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[90].Id , Step = 3 , Instruction = " When you feel the stretch, push your hips forward until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[91].Id , Step = 1 , Instruction = " Lie face-down on a stability ball, hips centered, feet anchored, hands behind your head." },
            new WorkoutInstruction{ WorkoutId = Workouts[91].Id , Step = 2 , Instruction = " Engage your core, lift your upper body until aligned with legs, keeping your neck neutral." },
            new WorkoutInstruction{ WorkoutId = Workouts[91].Id , Step = 3 , Instruction = " Lower your torso slowly back to the starting position, maintaining control and steady breathing." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[92].Id , Step = 1 , Instruction = " Lie on your back, heels on a stability ball, arms flat, and core engaged." },
            new WorkoutInstruction{ WorkoutId = Workouts[92].Id , Step = 2 , Instruction = " Lift hips, curl the ball toward you using your hamstrings, keeping control and balance." },
            new WorkoutInstruction{ WorkoutId = Workouts[92].Id , Step = 3 , Instruction = " Extend legs back to start while keeping hips lifted, then repeat for desired reps." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[93].Id , Step = 1 , Instruction = " Lie face down on a stability ball, hands on the floor, legs extended straight." },
            new WorkoutInstruction{ WorkoutId = Workouts[93].Id , Step = 2 , Instruction = " Engage glutes and lower back, raising legs until aligned with your torso." },
            new WorkoutInstruction{ WorkoutId = Workouts[93].Id , Step = 3 , Instruction = " Slowly lower legs back down without touching the ground, maintaining core engagement. Repeat." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[94].Id , Step = 1 , Instruction = " Place one knee on a bench." },
            new WorkoutInstruction{ WorkoutId = Workouts[94].Id , Step = 2 , Instruction = " Push your hips back while leaving your knee mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[94].Id , Step = 3 , Instruction = " When you feel the stretch, push your hips forward until you're back in a standing position." },
            #endregion,
            
            #region Kettlebells,
            new WorkoutInstruction{ WorkoutId = Workouts[95].Id , Step = 1 , Instruction = " Stand with your feet shoulder width apart holding the kettlebell with both hands in front of your thighs." },
            new WorkoutInstruction{ WorkoutId = Workouts[95].Id , Step = 2 , Instruction = " Bend forward at the hips bringing the kettlebell to the floor while you slightly bend your knees, keeping your back straight." },
            new WorkoutInstruction{ WorkoutId = Workouts[95].Id , Step = 3 , Instruction = " Return to standing position and repeat." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[96].Id , Step = 1 , Instruction = " Stand with your feet slightly wider than shoulder width apart holding the kettlebell between your legs, with your knees slightly bent." },
            new WorkoutInstruction{ WorkoutId = Workouts[96].Id , Step = 2 , Instruction = " Keeping your back straight, swing the kettlebell upwards until the kettlebell is level with your chest and carefully lower." },
            new WorkoutInstruction{ WorkoutId = Workouts[96].Id , Step = 3 , Instruction = " Repeat" },
            
            new WorkoutInstruction{ WorkoutId = Workouts[97].Id , Step = 1 , Instruction = " Stand with your feet shoulder width apart, lifting one foot off the floor behind you. Hold the kettlebell in the same arm as the lifted leg." },
            new WorkoutInstruction{ WorkoutId = Workouts[97].Id , Step = 2 , Instruction = " Bend forward at the hips bringing the kettlebell to the floor while you extend your lifted leg behind you, keeping your back straight - holding out your arm to the side for balance." },
            new WorkoutInstruction{ WorkoutId = Workouts[97].Id , Step = 3 , Instruction = " Return to the upright position and repeat." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[98].Id , Step = 1 , Instruction = " Stand with your feet shoulder width apart, shifting one foot behind you. Hold the kettlebell in both hands in front of your thighs." },
            new WorkoutInstruction{ WorkoutId = Workouts[98].Id , Step = 2 , Instruction = " Bend forward at the hips bringing the kettlebell to the floor while you slightly bend your knees and keep your back straight." },
            new WorkoutInstruction{ WorkoutId = Workouts[98].Id , Step = 3 , Instruction = " Return to the upright position and repeat." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[99].Id , Step = 1 , Instruction = " Stand with your feet shoulder width apart holding the kettlebell with both hands in front of your chest." },
            new WorkoutInstruction{ WorkoutId = Workouts[99].Id , Step = 2 , Instruction = " Bend forward at the hips keeping your back and knees straight and the kettlebell close to your chest." },
            new WorkoutInstruction{ WorkoutId = Workouts[99].Id , Step = 3 , Instruction = " Return to standing position and thrust your pelvis forward." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[100].Id , Step = 1 , Instruction = " Stand with feet shoulder-width apart, kettlebell between legs." },
            new WorkoutInstruction{ WorkoutId = Workouts[100].Id , Step = 2 , Instruction = " Hinge at hips, swing kettlebell between legs." },
            new WorkoutInstruction{ WorkoutId = Workouts[100].Id , Step = 3 , Instruction = " Swing kettlebell up, switch hands at the top, and repeat in a fluid motion." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[101].Id , Step = 1 , Instruction = " Stand with feet hip-width apart." },
            new WorkoutInstruction{ WorkoutId = Workouts[101].Id , Step = 2 , Instruction = " Bend at hips and knees to lift kettlebells." },
            new WorkoutInstruction{ WorkoutId = Workouts[101].Id , Step = 3 , Instruction = " Stand tall, then lower." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[102].Id , Step = 1 , Instruction = " Stand with feet shoulder-width apart, kettlebells outside legs" },
            new WorkoutInstruction{ WorkoutId = Workouts[102].Id , Step = 2 , Instruction = " Hinge at hips, swing kettlebells forward, then back." },
            new WorkoutInstruction{ WorkoutId = Workouts[102].Id , Step = 3 , Instruction = " Thrust hips to swing kettlebells upward, keeping arms straight." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[103].Id , Step = 1 , Instruction = " Stand with feet shoulder-width apart, kettlebell between legs." },
            new WorkoutInstruction{ WorkoutId = Workouts[103].Id , Step = 2 , Instruction = " Hinge at hips, grip kettlebell, and swing it overhead." },
            new WorkoutInstruction{ WorkoutId = Workouts[103].Id , Step = 3 , Instruction = " Extend hips and knees, lock out arms at the top." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[104].Id , Step = 1 , Instruction = " Stand with feet hip-width apart, holding kettlebells in front." },
            new WorkoutInstruction{ WorkoutId = Workouts[104].Id , Step = 2 , Instruction = " Hinge at hips, keeping back straight, and lower kettlebells towards ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[104].Id , Step = 3 , Instruction = " Return to start position, squeezing glutes at the top." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[105].Id , Step = 1 , Instruction = " Stand with feet shoulder-width apart, kettlebell between legs, grip with one hand, hinge at hips." },
            new WorkoutInstruction{ WorkoutId = Workouts[105].Id , Step = 2 , Instruction = " Swing kettlebell forcefully forward, using hip thrust, arm straight." },
            new WorkoutInstruction{ WorkoutId = Workouts[105].Id , Step = 3 , Instruction = " Swing kettlebell back between legs, repeat for desired reps." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[106].Id , Step = 1 , Instruction = " Begin with feet hip-width apart, one foot forward, kettlebell between feet." },
            new WorkoutInstruction{ WorkoutId = Workouts[106].Id , Step = 2 , Instruction = " Hinge at hips, grip kettlebell, and stand tall." },
            new WorkoutInstruction{ WorkoutId = Workouts[106].Id , Step = 3 , Instruction = " Lower kettlebell with control, then repeat." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[107].Id , Step = 1 , Instruction = " Lower kettlebell with control, then repeat." },
            new WorkoutInstruction{ WorkoutId = Workouts[107].Id , Step = 2 , Instruction = " Explosively thrust hips forward, swing kettlebell to chest height." },
            new WorkoutInstruction{ WorkoutId = Workouts[107].Id , Step = 3 , Instruction = " Repeat for desired reps, keeping core engaged and maintaining a staggered stance for balance." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[108].Id , Step = 1 , Instruction = " Start with a kettlebell between your legs, hinge at hips, swing it upward." },
            new WorkoutInstruction{ WorkoutId = Workouts[108].Id , Step = 2 , Instruction = " Lift kettlebell to chest level, elbows high, engaging shoulders." },
            new WorkoutInstruction{ WorkoutId = Workouts[108].Id , Step = 3 , Instruction = " Lower kettlebell back down, maintaining control. Repeat for desired reps." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[109].Id , Step = 1 , Instruction = " Begin by standing with your feet hip-width apart and holding a kettlebell at one side of your body, with your palms facing your thighs." },
            new WorkoutInstruction{ WorkoutId = Workouts[109].Id , Step = 2 , Instruction = " Keeping your core engaged and your back straight, bend at the hips and knees to lower the kettlebell down towards the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[109].Id , Step = 3 , Instruction = " As the kettlebell reaches the ground, use your legs and glutes to push through your heels and extend your hips and knees to raise your body back to the starting position." },
            new WorkoutInstruction{ WorkoutId = Workouts[109].Id , Step = 4 , Instruction = " Repeat the movement for the desired number of reps, then switch sides and repeat the exercise with the kettlebell on the opposite side of your body." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[110].Id , Step = 1 , Instruction = " Set up a bar at mid way up your quad. Place the working leg against the bar." },
            new WorkoutInstruction{ WorkoutId = Workouts[110].Id , Step = 2 , Instruction = " Place one foot behind. You should only be on your toes on that back foot. Your front foot should be planted flat the entire time." },
            new WorkoutInstruction{ WorkoutId = Workouts[110].Id , Step = 3 , Instruction = " Bend your back knee and push your hips back. Look for a stretch in your front hamstring." },
            new WorkoutInstruction{ WorkoutId = Workouts[110].Id , Step = 4 , Instruction = " When you feel the stretch, push your hips forward again until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[111].Id , Step = 1 , Instruction = " Place a barbell at about midway up your thigh. Press your quads into the barbell." },
            new WorkoutInstruction{ WorkoutId = Workouts[111].Id , Step = 2 , Instruction = " Push your hips back while leaving your knees mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[111].Id , Step = 3 , Instruction = " When you feel the stretch, push your hips forward until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[112].Id , Step = 1 , Instruction = " Place one knee on a bench and hold a kettlebell in a goblet position." },
            new WorkoutInstruction{ WorkoutId = Workouts[112].Id , Step = 2 , Instruction = " Push your hips back while leaving your knee mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[112].Id , Step = 3 , Instruction = " When you feel the stretch, push your hips forward until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[113].Id , Step = 1 , Instruction = " Place one knee on a bench and hold a kettlebell." },
            new WorkoutInstruction{ WorkoutId = Workouts[113].Id , Step = 2 , Instruction = " Push your hips back while leaving your knee mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[113].Id , Step = 3 , Instruction = " When you feel the stretch, push your hips forward until you're back in a standing position." },
            #endregion,
            
            #region Band,
            new WorkoutInstruction{ WorkoutId = Workouts[114].Id , Step = 1 , Instruction = " Anchor the band at hip level. Take a few steps away until the band is taut." },
            new WorkoutInstruction{ WorkoutId = Workouts[114].Id , Step = 2 , Instruction = " Push your hips back while keeping your back flat until you feel a stretch in your hamstrings." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[115].Id , Step = 1 , Instruction = " Anchor the band to the lowest point possible. Straddle the band and then grab with both hands." },
            new WorkoutInstruction{ WorkoutId = Workouts[115].Id , Step = 2 , Instruction = " Take a few steps away until the band is taut." },
            new WorkoutInstruction{ WorkoutId = Workouts[115].Id , Step = 3 , Instruction = " Push your butt back until you feel a stretch in your hamstrings. Then extend the hips back into the starting position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[116].Id , Step = 1 , Instruction = " Stand on your band with both feet." },
            new WorkoutInstruction{ WorkoutId = Workouts[116].Id , Step = 2 , Instruction = " Hinge forward at the hips while keeping a flat back." },
            new WorkoutInstruction{ WorkoutId = Workouts[116].Id , Step = 3 , Instruction = " Hinge until you feel a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = Workouts[116].Id , Step = 4 , Instruction = " Push your hips back forward until you are in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[117].Id , Step = 1 , Instruction = " Loop the band around a sturdy anchor point such as a weightlifting rack or a door handle." },
            new WorkoutInstruction{ WorkoutId = Workouts[117].Id , Step = 2 , Instruction = " Lie on your back with your heels placed inside the band. Make sure the band is centered under your heels and your feet are hip-width apart." },
            new WorkoutInstruction{ WorkoutId = Workouts[117].Id , Step = 3 , Instruction = " Using your hamstrings, curl your heels towards your glutes while keeping your hips on the ground." },
            #endregion,
            
            #region Yoga,
            new WorkoutInstruction{ WorkoutId = Workouts[118].Id , Step = 1 , Instruction = " Start in a tabletop position with your hands and knees on the floor." },
            new WorkoutInstruction{ WorkoutId = Workouts[118].Id , Step = 2 , Instruction = " Step your right foot forward, placing it between your hands." },
            new WorkoutInstruction{ WorkoutId = Workouts[118].Id , Step = 3 , Instruction = " Straighten your right leg and flex your toes towards your face, keeping your hands on the floor for support." },
            new WorkoutInstruction{ WorkoutId = Workouts[118].Id , Step = 4 , Instruction = " Hold for several breaths, then switch sides and repeat." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[119].Id , Step = 1 , Instruction = " Sit on the floor with your legs extended in front of you." },
            new WorkoutInstruction{ WorkoutId = Workouts[119].Id , Step = 2 , Instruction = " Inhale and lengthen your spine, then exhale and fold forward from your hips, keeping your spine long." },
            new WorkoutInstruction{ WorkoutId = Workouts[119].Id , Step = 3 , Instruction = " Reach for your feet or ankles, keeping your elbows straight." },
            new WorkoutInstruction{ WorkoutId = Workouts[119].Id , Step = 4 , Instruction = " Hold for several breaths, then release." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[120].Id , Step = 1 , Instruction = " Begin in Tadasana (Mountain Pose)." },
            new WorkoutInstruction{ WorkoutId = Workouts[120].Id , Step = 2 , Instruction = " Step your left foot back about 3-4 feet and place your heel down, keeping your toes pointing forward." },
            new WorkoutInstruction{ WorkoutId = Workouts[120].Id , Step = 3 , Instruction = " Inhale and lengthen your spine, then exhale and fold forward from your hips, bringing your hands to the floor on either side of your right foot." },
            new WorkoutInstruction{ WorkoutId = Workouts[120].Id , Step = 4 , Instruction = " Hold for several breaths, then switch sides and repeat." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[121].Id , Step = 1 , Instruction = " Begin in Tadasana (Mountain Pose) with two blocks at the top of your mat." },
            new WorkoutInstruction{ WorkoutId = Workouts[121].Id , Step = 2 , Instruction = " Step your left foot back about 3-4 feet and place your heel down, keeping your toes pointing forward." },
            new WorkoutInstruction{ WorkoutId = Workouts[121].Id , Step = 3 , Instruction = " Place the blocks on either side of your right foot at a height that allows you to comfortably place your hands on them." },
            new WorkoutInstruction{ WorkoutId = Workouts[121].Id , Step = 4 , Instruction = " Inhale and lengthen your spine, then exhale and fold forward from your hips, bringing your hands to the blocks. Hold for several breaths, then switch sides and repeat." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[122].Id , Step = 1 , Instruction = " Stand with your feet hip-width apart." },
            new WorkoutInstruction{ WorkoutId = Workouts[122].Id , Step = 2 , Instruction = " Hinge forward at your hips, reaching your hands towards the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[122].Id , Step = 3 , Instruction = " Allow your head to hang heavy and feel a stretch in the back of your legs." },
            new WorkoutInstruction{ WorkoutId = Workouts[122].Id , Step = 4 , Instruction = " Hold for a few breaths and then slowly roll up to a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[123].Id , Step = 1 , Instruction = " Stand with your feet hip-width apart and place a block on the ground in front of you." },
            new WorkoutInstruction{ WorkoutId = Workouts[123].Id , Step = 2 , Instruction = " Hinge forward at your hips and place your hands on the block." },
            new WorkoutInstruction{ WorkoutId = Workouts[123].Id , Step = 3 , Instruction = " Allow your head to hang heavy and feel a stretch in the back of your legs." },
            new WorkoutInstruction{ WorkoutId = Workouts[123].Id , Step = 4 , Instruction = " Hold for a few breaths and then slowly roll up to a standing position." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[124].Id , Step = 1 , Instruction = " Start in mountain pose, standing with your feet hip-width apart and arms at your sides." },
            new WorkoutInstruction{ WorkoutId = Workouts[124].Id , Step = 2 , Instruction = " Step your left foot back about 3-4 feet and raise it off the ground, while keeping your right foot facing forward." },
            new WorkoutInstruction{ WorkoutId = Workouts[124].Id , Step = 3 , Instruction = " Inhale and reach your arms forward, parallel to the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[124].Id , Step = 4 , Instruction = " Exhale and hinge forward at your hips, bringing your torso parallel to the ground and extending your left leg straight back. Keep your arms and right leg straight and hold the pose for a few breaths" },
            new WorkoutInstruction{ WorkoutId = Workouts[124].Id , Step = 5 , Instruction = " inhale and return to mountain pose. Repeat on the other side." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[125].Id , Step = 1 , Instruction = " Start standing at the top of your mat with your feet wide apart." },
            new WorkoutInstruction{ WorkoutId = Workouts[125].Id , Step = 2 , Instruction = " Start standing at the top of your mat with your feet wide apart." },
            new WorkoutInstruction{ WorkoutId = Workouts[125].Id , Step = 3 , Instruction = " Exhale and fold forward from your hips, bringing your hands up and over your head towards the ground." },
            new WorkoutInstruction{ WorkoutId = Workouts[125].Id , Step = 4 , Instruction = " Hold for a few breaths and then release the hands and come back up to standing." },
            #endregion,
            
            #region Cardio,
            new WorkoutInstruction{ WorkoutId = Workouts[126].Id , Step = 1 , Instruction = " Get the treadmill up to a comfortable speed where you are doing a light jog." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[127].Id , Step = 1 , Instruction = " Get the treadmill up to a speed where you are doing a sprint." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[128].Id , Step = 1 , Instruction = " Get the treadmill up to a comfortable speed where you are doing a walk." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[129].Id , Step = 1 , Instruction = " Perform s sprint in a figure eight pattern." },
            new WorkoutInstruction{ WorkoutId = Workouts[129].Id , Step = 2 , Instruction = " Make sure to stay low." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[130].Id , Step = 1 , Instruction = " Start with a shoulder width stance." },
            new WorkoutInstruction{ WorkoutId = Workouts[130].Id , Step = 2 , Instruction = " Stay on your toes, step right, tap your left toe to the ground, plant your right foot and raise your left leg." },
            new WorkoutInstruction{ WorkoutId = Workouts[130].Id , Step = 3 , Instruction = " Then repeat in the opposite direction." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[131].Id , Step = 1 , Instruction = " Stand straight, feet hip-width apart, engage core." },
            new WorkoutInstruction{ WorkoutId = Workouts[131].Id , Step = 2 , Instruction = " Lift knees alternately, tap with same side hand." },
            new WorkoutInstruction{ WorkoutId = Workouts[131].Id , Step = 3 , Instruction = " Continue rhythmically, maintain posture, increase speed as able." },
            
            new WorkoutInstruction{ WorkoutId = Workouts[132].Id , Step = 1 , Instruction = " Stand tall, jog in place, bringing heels toward your glutes." },
            new WorkoutInstruction{ WorkoutId = Workouts[132].Id , Step = 2 , Instruction = " Keep your core tight and swing arms naturally." },
            new WorkoutInstruction{ WorkoutId = Workouts[132].Id , Step = 3 , Instruction = " Alternate legs quickly, maintaining a steady rhythm." },
            #endregion
        };


        await context.WorkoutInstructions.AddRangeAsync(backWorkoutInstruction);
        await context.SaveChangesAsync();


        // ***************************************************************** //
        var workoutEquipment = new List<WorkoutEquipment>();

        var barbellId = context.Equipments.Where(x => x.Name == "Barbell").Select(x => x.Id).FirstOrDefault();
        var ezbarId = context.Equipments.Where(x => x.Name == "E-Z Curl Bar").Select(x => x.Id).FirstOrDefault();
        var cableMachineId = context.Equipments.Where(x => x.Name == "Cable Machine").Select(x => x.Id).FirstOrDefault();
        var pullUpMachineId = context.Equipments.Where(x => x.Name == "Pull Up Machine").Select(x => x.Id).FirstOrDefault();
        var machineId = context.Equipments.Where(x => x.Name == "Machine").Select(x => x.Id).FirstOrDefault();
        var stretchesId = context.Equipments.Where(x => x.Name == "stretches").Select(x => x.Id).FirstOrDefault();
        var plateId = context.Equipments.Where(x => x.Name == "Plate").Select(x => x.Id).FirstOrDefault();
        var bosuballId = context.Equipments.Where(x => x.Name == "Bosu-Ball").Select(x => x.Id).FirstOrDefault();
        var smithMachineId = context.Equipments.Where(x => x.Name == "Smith Machine").Select(x => x.Id).FirstOrDefault();
        var dumbellId = context.Equipments.Where(x => x.Name == "Dumbells").Select(x => x.Id).FirstOrDefault();
        var cableId = context.Equipments.Where(x => x.Name == "Cable").Select(x => x.Id).FirstOrDefault();
        var trxId = context.Equipments.Where(x => x.Name == "TRX").Select(x => x.Id).FirstOrDefault();
        var vitruvianId = context.Equipments.Where(x => x.Name == "Vitruvian").Select(x => x.Id).FirstOrDefault();
        var cardioId = context.Equipments.Where(x => x.Name == "Cardio").Select(x => x.Id).FirstOrDefault();
        var bodyweightId = context.Equipments.Where(x => x.Name == "Bodyweight").Select(x => x.Id).FirstOrDefault();
        var kettlebellId = context.Equipments.Where(x => x.Name == "KettleBells").Select(x => x.Id).FirstOrDefault();
        var BandsId = context.Equipments.Where(x => x.Name == "Bands").Select(x => x.Id).FirstOrDefault();
        var yogaId = context.Equipments.Where(x => x.Name == "Yoga").Select(x => x.Id).FirstOrDefault();

        workoutEquipment = new List<WorkoutEquipment>
        {
            #region Barbell,
            new WorkoutEquipment{ WorkoutId = Workouts[0].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[1].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[2].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[3].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[4].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[5].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[6].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[7].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[8].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[9].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[10].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[11].Id, EquipmentId = barbellId },
            #endregion,
            
            #region Machine,
            new WorkoutEquipment{ WorkoutId = Workouts[12].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[13].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[14].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[15].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[16].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[17].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[18].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[19].Id, EquipmentId = machineId },
            #endregion,
            
            #region Stretches,
            new WorkoutEquipment{ WorkoutId = Workouts[20].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = Workouts[21].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = Workouts[22].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = Workouts[23].Id, EquipmentId = stretchesId },
            #endregion,
            
            #region Plate,
            new WorkoutEquipment{ WorkoutId = Workouts[24].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[25].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[26].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[27].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[28].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[29].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[30].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[31].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[32].Id, EquipmentId = plateId },
            #endregion,
            
            #region Smith-Machine,
            new WorkoutEquipment{ WorkoutId = Workouts[33].Id, EquipmentId = smithMachineId },
            new WorkoutEquipment{ WorkoutId = Workouts[34].Id, EquipmentId = smithMachineId },
            new WorkoutEquipment{ WorkoutId = Workouts[35].Id, EquipmentId = smithMachineId },
            #endregion,
            
            #region Dumbbells,
            new WorkoutEquipment{ WorkoutId = Workouts[36].Id, EquipmentId = dumbbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[37].Id, EquipmentId = dumbbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[38].Id, EquipmentId = dumbbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[39].Id, EquipmentId = dumbbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[40].Id, EquipmentId = dumbbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[41].Id, EquipmentId = dumbbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[42].Id, EquipmentId = dumbbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[43].Id, EquipmentId = dumbbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[44].Id, EquipmentId = dumbbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[45].Id, EquipmentId = dumbbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[46].Id, EquipmentId = dumbbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[47].Id, EquipmentId = dumbbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[48].Id, EquipmentId = dumbbellId },
            #endregion,
            
            #region Medicine-Ball,
            new WorkoutEquipment{ WorkoutId = Workouts[49].Id, EquipmentId = medicineBallId },
            #endregion,
            
            #region Cables,
            new WorkoutEquipment{ WorkoutId = Workouts[50].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = Workouts[51].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = Workouts[52].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = Workouts[53].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = Workouts[54].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = Workouts[55].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = Workouts[56].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = Workouts[57].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = Workouts[58].Id, EquipmentId = cableId },
            #endregion,
            
            #region TRX,
            new WorkoutEquipment{ WorkoutId = Workouts[59].Id, EquipmentId = trxId },
            #endregion,
            
            #region Vitruvian,
            new WorkoutEquipment{ WorkoutId = Workouts[60].Id, EquipmentId = vitruvianId },
            new WorkoutEquipment{ WorkoutId = Workouts[61].Id, EquipmentId = vitruvianId },
            new WorkoutEquipment{ WorkoutId = Workouts[62].Id, EquipmentId = vitruvianId },
            #endregion,
            
            #region Recovery,
            new WorkoutEquipment{ WorkoutId = Workouts[63].Id, EquipmentId = recoveryId },
            new WorkoutEquipment{ WorkoutId = Workouts[64].Id, EquipmentId = recoveryId },
            new WorkoutEquipment{ WorkoutId = Workouts[65].Id, EquipmentId = recoveryId },
            new WorkoutEquipment{ WorkoutId = Workouts[66].Id, EquipmentId = recoveryId },
            new WorkoutEquipment{ WorkoutId = Workouts[67].Id, EquipmentId = recoveryId },
            new WorkoutEquipment{ WorkoutId = Workouts[68].Id, EquipmentId = recoveryId },
            new WorkoutEquipment{ WorkoutId = Workouts[69].Id, EquipmentId = recoveryId },
            new WorkoutEquipment{ WorkoutId = Workouts[70].Id, EquipmentId = recoveryId },
            new WorkoutEquipment{ WorkoutId = Workouts[71].Id, EquipmentId = recoveryId },
            new WorkoutEquipment{ WorkoutId = Workouts[72].Id, EquipmentId = recoveryId },
            new WorkoutEquipment{ WorkoutId = Workouts[73].Id, EquipmentId = recoveryId },
            new WorkoutEquipment{ WorkoutId = Workouts[74].Id, EquipmentId = recoveryId },
            #endregion,
            
            #region Bodyweight,
            new WorkoutEquipment{ WorkoutId = Workouts[75].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[76].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[77].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[78].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[79].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[80].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[81].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[82].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[83].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[84].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[85].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[86].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[87].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[88].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[89].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[90].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[91].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[92].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[93].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[94].Id, EquipmentId = bodyweightId },
            #endregion,
            
            #region Kettlebells,
            new WorkoutEquipment{ WorkoutId = Workouts[95].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[96].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[97].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[98].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[99].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[100].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[101].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[102].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[103].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[104].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[105].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[106].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[107].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[108].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[109].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[110].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[111].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[112].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[113].Id, EquipmentId = kettlebellId },
            #endregion,
            
            #region Band,
            new WorkoutEquipment{ WorkoutId = Workouts[114].Id, EquipmentId = BandId },
            new WorkoutEquipment{ WorkoutId = Workouts[115].Id, EquipmentId = BandId },
            new WorkoutEquipment{ WorkoutId = Workouts[116].Id, EquipmentId = BandId },
            new WorkoutEquipment{ WorkoutId = Workouts[117].Id, EquipmentId = BandId },
            #endregion,
            
            #region Yoga,
            new WorkoutEquipment{ WorkoutId = Workouts[118].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = Workouts[119].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = Workouts[120].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = Workouts[121].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = Workouts[122].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = Workouts[123].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = Workouts[124].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = Workouts[125].Id, EquipmentId = yogaId },
            #endregion,
            
            #region Cardio,
            new WorkoutEquipment{ WorkoutId = Workouts[126].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[127].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[128].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[129].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[130].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[131].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[132].Id, EquipmentId = cardioId },
            #endregion
        };

        await context.WorkoutEquipment.AddRangeAsync(workoutEquipment);
        await context.SaveChangesAsync();
        // ***************************************************************** //
        var workoutLevel = new List<WorkoutLevel>();
        workoutLevel = new List<WorkoutLevel>
        {
            #region Barbell,
            new WorkoutLevel{ WorkoutId = Workouts[0].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[1].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[2].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[3].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[4].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[5].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[6].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[7].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[8].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[9].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[10].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[11].Id, Level = Difficulty.Advanced },
            #endregion,
            
            #region Machine,
            new WorkoutLevel{ WorkoutId = Workouts[12].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[13].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[14].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[15].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[16].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[17].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[18].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[19].Id, Level = Difficulty.Novice },
            #endregion,
            
            #region Stretches,
            new WorkoutLevel{ WorkoutId = Workouts[20].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[21].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[22].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[23].Id, Level = Difficulty.Beginner },
            #endregion,
            
            #region Plate,
            new WorkoutLevel{ WorkoutId = Workouts[24].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[25].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[26].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[27].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[28].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[29].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[30].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[31].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[32].Id, Level = Difficulty.Intermediate },
            #endregion,
            
            #region Smith-Machine,
            new WorkoutLevel{ WorkoutId = Workouts[33].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[34].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[35].Id, Level = Difficulty.Intermediate },
            #endregion,
            
            #region Dumbbells,
            new WorkoutLevel{ WorkoutId = Workouts[36].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[37].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[38].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[39].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[40].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[41].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[42].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[43].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[44].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[45].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[46].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[47].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[48].Id, Level = Difficulty.Intermediate },
            #endregion,
            
            #region Medicine-Ball,
            new WorkoutLevel{ WorkoutId = Workouts[49].Id, Level = Difficulty.Intermediate },
            #endregion,
            
            #region Cables,
            new WorkoutLevel{ WorkoutId = Workouts[50].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[51].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[52].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[53].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[54].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[55].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[56].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[57].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[58].Id, Level = Difficulty.Advanced },
            #endregion,
            
            #region TRX,
            new WorkoutLevel{ WorkoutId = Workouts[59].Id, Level = Difficulty.Beginner },
            #endregion,
            
            #region Vitruvian,
            new WorkoutLevel{ WorkoutId = Workouts[60].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[61].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[62].Id, Level = Difficulty.Intermediate },
            #endregion,
            
            #region Recovery,
            new WorkoutLevel{ WorkoutId = Workouts[63].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[64].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[65].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[66].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[67].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[68].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[69].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[70].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[71].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[72].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[73].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[74].Id, Level = Difficulty.Beginner },
            #endregion,
            
            #region Bodyweight,
            new WorkoutLevel{ WorkoutId = Workouts[75].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[76].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[77].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[78].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[79].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[80].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[81].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[82].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[83].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[84].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[85].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[86].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[87].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[88].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[89].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[90].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[91].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[92].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[93].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[94].Id, Level = Difficulty.Intermediate },
            #endregion,
            
            #region Kettlebells,
            new WorkoutLevel{ WorkoutId = Workouts[95].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[96].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[97].Id, Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[98].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[99].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[100].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[101].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[102].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[103].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[104].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[105].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[106].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[107].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[108].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[109].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[110].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[111].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[112].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[113].Id, Level = Difficulty.Intermediate },
            #endregion,
            
            #region Band,
            new WorkoutLevel{ WorkoutId = Workouts[114].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[115].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[116].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[117].Id, Level = Difficulty.Beginner },
            #endregion,
            
            #region Yoga,
            new WorkoutLevel{ WorkoutId = Workouts[118].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[119].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[120].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[121].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[122].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[123].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[124].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[125].Id, Level = Difficulty.Beginner },
            #endregion,
            
            #region Cardio,
            new WorkoutLevel{ WorkoutId = Workouts[126].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[127].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[128].Id, Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[129].Id, Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[130].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[131].Id, Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[132].Id, Level = Difficulty.Novice },
            #endregion
        };


        await context.WorkoutLevels.AddRangeAsync(workoutLevel);
        await context.SaveChangesAsync();

        // ***************************************************************** //

        var bodyWorkouts = new List<BodyWorkout>();
        var bicepId = await context.Bodies.Where(z => z.Name == "Biceps").Select(z => z.Id).FirstOrDefaultAsync();

        bodyWorkouts = new List<BodyWorkout>
        {
            #region Barbell,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[0].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[0].Id, Target = PriorityTarget.Level 4 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[1].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[1].Id, Target = PriorityTarget.Level 4 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[2].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[2].Id, Target = PriorityTarget.Level 4 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[3].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[3].Id, Target = PriorityTarget.Level 4 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[4].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[5].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[5].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[6].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[6].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[7].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[8].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[8].Id, Target = PriorityTarget.Level 5
            },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[9].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[9].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[10].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[10].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[11].Id, Target = PriorityTarget.Tertiary },
            #endregion,

            #region Machine,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[12].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = medHamstringId , WorkoutId = Workouts[12].Id, Target = PriorityTarget.Secondary },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[13].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = medHamstringId , WorkoutId = Workouts[13].Id, Target = PriorityTarget.Secondary },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[14].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = medHamstringId , WorkoutId = Workouts[14].Id, Target = PriorityTarget.Secondary },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[15].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = medHamstringId , WorkoutId = Workouts[15].Id, Target = PriorityTarget.Secondary },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[16].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = medHamstringId , WorkoutId = Workouts[16].Id, Target = PriorityTarget.Secondary },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[17].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[17].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[18].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = medHamstringId , WorkoutId = Workouts[18].Id, Target = PriorityTarget.Secondary },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[19].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = medHamstringId , WorkoutId = Workouts[19].Id, Target = PriorityTarget.Secondary },
            #endregion,

            #region Stretches,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[20].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[21].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[22].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[23].Id, Target = PriorityTarget.Primary },
            #endregion,
            
            #region Plate,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[24].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[25].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[26].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[27].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[28].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[29].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[30].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[31].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[32].Id, Target = PriorityTarget.Tertiary },
            #endregion,
            
            #region Smith-Machine,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[33].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[34].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[35].Id, Target = PriorityTarget.Tertiary },
            #endregion,
            
            #region Dumbbells,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[36].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[36].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[37].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[37].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[38].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = medHamstringId , WorkoutId = Workouts[38].Id, Target = PriorityTarget.Secondary },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[39].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[39].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[40].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[40].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[41].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[41].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[42].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[43].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[44].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[44].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[45].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[45].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[46].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[46].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[47].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[47].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[48].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[48].Id, Target = PriorityTarget.Level 5 },
            #endregion,

            #region Medicine-Ball,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[49].Id, Target = PriorityTarget.Tertiary },
            #endregion,
            
            #region Cables,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[50].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[50].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[51].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[51].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[52].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[52].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[53].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = medHamstringId , WorkoutId = Workouts[53].Id, Target = PriorityTarget.Secondary },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[54].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[54].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[55].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[55].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[56].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = medHamstringId , WorkoutId = Workouts[56].Id, Target = PriorityTarget.Secondary },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[57].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = medHamstringId , WorkoutId = Workouts[57].Id, Target = PriorityTarget.Secondary },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[58].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[58].Id, Target = PriorityTarget.Level 5 },
            #endregion,
            
            #region TRX,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[59].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = medHamstringId , WorkoutId = Workouts[59].Id, Target = PriorityTarget.Secondary },
            #endregion,
            
            #region Vitruvian,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[60].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[61].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[62].Id, Target = PriorityTarget.Tertiary },
            #endregion,
            
            #region Recovery,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[63].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[64].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[65].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[66].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[67].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[68].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[69].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[70].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[71].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[72].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[73].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[74].Id, Target = PriorityTarget.Tertiary },
            #endregion,
            
            #region Bodyweight,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[75].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[75].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[76].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[76].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[77].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = medHamstringId , WorkoutId = Workouts[77].Id, Target = PriorityTarget.Secondary },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[78].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[79].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[80].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[81].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[82].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[83].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[84].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[85].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[86].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[87].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[88].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[89].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[89].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[90].Id, Target = PriorityTarget.Level 4 },
            new BodyWorkout{ BodyId = latHamstringId , WorkoutId = Workouts[90].Id, Target = PriorityTarget.Level 5 },

            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[91].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[92].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[93].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[94].Id, Target = PriorityTarget.Tertiary },
            #endregion,
            
            #region Kettlebells,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[95].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[96].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[97].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[98].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[99].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[100].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[101].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[102].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[103].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[104].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[105].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[106].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[107].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[108].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[109].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[110].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[111].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[112].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[113].Id, Target = PriorityTarget.Tertiary },
            #endregion,
            
            #region Band,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[114].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[115].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[116].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[117].Id, Target = PriorityTarget.Primary },
            #endregion,
            
            #region Yoga,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[118].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[119].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[120].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[121].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[122].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[123].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[124].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[125].Id, Target = PriorityTarget.Primary },
            #endregion,
            
            #region Cardio,
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[126].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[127].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[128].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[129].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[130].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[131].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = hamstringId , WorkoutId = Workouts[132].Id, Target = PriorityTarget.Primary },
            #endregion
        };
        await context.BodyWorkouts.AddRangeAsync(bodyWorkouts);
        await context.SaveChangesAsync();
        // ***************************************************************** //
        var workoutSex = new List<WorkoutSex>();
        workoutSex = new List<WorkoutSex>
        {
            #region Traps & Barbell
            new WorkoutSex{ WorkoutId = Workouts[0].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[0].Id, Sex = Sex.Female},


            #endregion

        };
        await context.WorkoutSex.AddRangeAsync(workoutSex);
        await context.SaveChangesAsync();
    }
}