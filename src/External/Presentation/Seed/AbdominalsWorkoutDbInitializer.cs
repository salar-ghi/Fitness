namespace Presentation.Seed;

public class AbdominalsWorkoutDbInitializer
{
    //private readonly FitnessContext _context;

    //public AbdominalsWorkoutDbInitializer(FitnessContext context)
    //{
    //    _context = context;
    //}

    public static async Task WorkoutSeedAsync(FitnessContext context)
    {
        var Workouts = new List<Workout>();

        var bodybuildingId = await context.Sports.Where(s => s.Name == "Body Building").Select(z => z.Id).FirstOrDefaultAsync();
        var cardioSportId = await context.Sports.Where(s => s.Name == "Cardio").Select(z => z.Id).FirstOrDefaultAsync();
        var crossfitId = await context.Sports.Where(s => s.Name == "Cross Fit").Select(z => z.Id).FirstOrDefaultAsync();
        var yogaSportId = await context.Sports.Where(s => s.Name == "Yoga").Select(z => z.Id).FirstOrDefaultAsync();

        Workouts = new List<Workout>
        {
            // Abdominals // Barbell
            new Workout{ Name = "Barbell Roll Outs", SportId = bodybuildingId, Description = "" },                                      // index => 0
            new Workout{ Name = "Barbell Situp", SportId = bodybuildingId, Description = "" },                                          // index => 1
            new Workout{ Name = "Barbell Larsen Bench Press", SportId = bodybuildingId, Description = "" },                             // index => 2
            new Workout{ Name = "Landmine Hollow Hold", SportId = bodybuildingId, Description = "" },                                   // index => 3
            new Workout{ Name = "Landmine Sit Up", SportId = bodybuildingId, Description = "" },                                        // index => 4
            new Workout{ Name = "Barbell Front Squat Olympic", SportId = bodybuildingId, Description = "" },                            // index => 5
            new Workout{ Name = "Barbell Hooklying Bench Press", SportId = bodybuildingId, Description = "" },                          // index => 6

            // Abdominals // Machine
            new Workout{ Name = "Machine Roll Outs", SportId = bodybuildingId, Description = "" },                                      // index => 7
            new Workout{ Name = "Rower Knee Tuck", SportId = bodybuildingId, Description = "" },                                        // index => 8
            new Workout{ Name = "Rower Pike", SportId = bodybuildingId, Description = "" },                                             // index => 9
            new Workout{ Name = "Machine Plate Loaded Crunch", SportId = bodybuildingId, Description = "" },                            // index => 10
            new Workout{ Name = "Machine Crunch", SportId = bodybuildingId, Description = "" },                                         // index => 11

            // Abdominals // Stretches
            new Workout{ Name = "Abdominals Stretch Variation Four", SportId = bodybuildingId, Description = "" },                      // index => 12
            new Workout{ Name = "Abdominals Stretch Variation Three", SportId = bodybuildingId, Description = "" },                     // index => 13
            new Workout{ Name = "Abdominals Stretch Variation Two", SportId = bodybuildingId, Description = "" },                       // index => 14
            new Workout{ Name = "Abdominals Stretch Variation One", SportId = bodybuildingId, Description = "" },                       // index => 15

            // Abdominals // Plate
            new Workout{ Name = "Plate Overhead Carry", SportId = bodybuildingId, Description = "" },                                   // index => 16
            new Workout{ Name = "Plate Russian Twist", SportId = bodybuildingId, Description = "" },                                    // index => 17
            new Workout{ Name = "Plate Situp", SportId = bodybuildingId, Description = "" },                                            // index => 18
            new Workout{ Name = "Weighted Forearm Plank", SportId = bodybuildingId, Description = "" },                                 // index => 19
            new Workout{ Name = "Weighted Hand Plank", SportId = bodybuildingId, Description = "" },                                    // index => 20
            new Workout{ Name = "Plate Hollow Hold", SportId = bodybuildingId, Description = "" },                                      // index => 21
            new Workout{ Name = "Weighted Plank Up Down", SportId = bodybuildingId, Description = "" },                                 // index => 22

            // Abdominals // Bosu-Ball
            new Workout{ Name = "Bosu Ball Forearm Plank", SportId = bodybuildingId, Description = "" },                                // index => 23
            new Workout{ Name = "Bosu Ball Hand Plank", SportId = bodybuildingId, Description = "" },                                   // index => 24
            new Workout{ Name = "Bosu Ball Plank Glute Kickback", SportId = bodybuildingId, Description = "" },                         // index => 25
            new Workout{ Name = "Bosu Ball Situp", SportId = bodybuildingId, Description = "" },                                        // index => 26
            new Workout{ Name = "Bosu Ball Toe Tap", SportId = bodybuildingId, Description = "" },                                      // index => 27
            new Workout{ Name = "Bosu Ball Up And Over", SportId = bodybuildingId, Description = "" },                                  // index => 28
            new Workout{ Name = "Bosu Ball Walkover Pushup", SportId = bodybuildingId, Description = "" },                              // index => 29

            // Abdominals // Smith-Machine
            new Workout{ Name = "Smith Machine Hanging Knee Tuck", SportId = bodybuildingId, Description = "" },                        // index => 30
            new Workout{ Name = "Smith Machine Reverse Crunch Hip Raise", SportId = bodybuildingId, Description = "" },                 // index => 31
            new Workout{ Name = "Smith Machine Situp", SportId = bodybuildingId, Description = "" },                                    // index => 32

            // Abdominals // Dumbbells
            new Workout{ Name = "Dumbbell Situp", SportId = bodybuildingId, Description = "" },                                         // index => 33
            new Workout{ Name = "Dumbbell Plank Pullthrough", SportId = bodybuildingId, Description = "" },                             // index => 34
            new Workout{ Name = "Dumbbell Hollow Hold", SportId = bodybuildingId, Description = "" },                                   // index => 35
            new Workout{ Name = "Dumbbell Crunch", SportId = bodybuildingId, Description = "" },                                        // index => 36
            new Workout{ Name = "Plank IYTW", SportId = bodybuildingId, Description = "" },                                             // index => 37
            new Workout{ Name = "Dumbbell Suitcase Crunch", SportId = bodybuildingId, Description = "" },                               // index => 38
            new Workout{ Name = "Dumbbell Russian Twist", SportId = bodybuildingId, Description = "" },                                 // index => 39
            new Workout{ Name = "Dumbbell Half Kneeling Wood Chopper", SportId = bodybuildingId, Description = "" },                    // index => 40
            new Workout{ Name = "Dumbbell Renegade Row", SportId = bodybuildingId, Description = "" },                                  // index => 41
            new Workout{ Name = "Pushup to Renegade Row", SportId = bodybuildingId, Description = "" },                                 // index => 42

            // Abdominals // Medicine-Ball
            new Workout{ Name = "Medicine Ball Halo", SportId = bodybuildingId, Description = "" },                                     // index => 43
            new Workout{ Name = "Medicine Ball Partner Situp Toss", SportId = bodybuildingId, Description = "" },                       // index => 44
            new Workout{ Name = "Medicine Ball Plank", SportId = bodybuildingId, Description = "" },                                    // index => 45
            new Workout{ Name = "Medicine Ball Slam", SportId = bodybuildingId, Description = "" },                                     // index => 46
            new Workout{ Name = "Medicine Ball Hollow Hold", SportId = bodybuildingId, Description = "" },                              // index => 47
            new Workout{ Name = "Medicine Ball Dead Bug", SportId = bodybuildingId, Description = "" },                                 // index => 48

            // Abdominals // Cables
            new Workout{ Name = "Cable Standing Crunch", SportId = bodybuildingId, Description = "" },                                  // index => 49
            new Workout{ Name = "Cable Row Bar Kneeling Crunch", SportId = bodybuildingId, Description = "" },                          // index => 50
            new Workout{ Name = "Cable Rope Kneeling Crunch", SportId = bodybuildingId, Description = "" },                             // index => 51
            new Workout{ Name = "Cable Rope Kneeling Oblique Crunch", SportId = bodybuildingId, Description = "" },                     // index => 52

            // Abdominals // TRX
            new Workout{ Name = "TRX Ab Rollout", SportId = bodybuildingId, Description = "" },                                         // index => 53
            new Workout{ Name = "TRX Forearm Plank", SportId = bodybuildingId, Description = "" },                                      // index => 54
            new Workout{ Name = "TRX Hand Plank", SportId = bodybuildingId, Description = "" },                                         // index => 55
            new Workout{ Name = "TRX Kneeling Ab Rollout", SportId = bodybuildingId, Description = "" },                                // index => 56
            new Workout{ Name = "TRX Knee Tuck", SportId = bodybuildingId, Description = "" },                                          // index => 57
            new Workout{ Name = "TRX Mountain Climber", SportId = bodybuildingId, Description = "" },                                   // index => 58
            new Workout{ Name = "TRX Pike", SportId = bodybuildingId, Description = "" },                                               // index => 59

            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 60
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 61
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 62
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 63
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 64
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 65
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 66
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 67
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 68
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 69
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 70
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 71
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 72
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 73
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 74
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 75
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 76
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 77
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 78
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 79
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 80
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 81
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 82
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 83
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 84
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 85
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 86
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 87
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 88
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 89
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 90
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 91
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 92
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 93
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 94
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 95
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 96
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 97
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 98
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 99
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 100
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 101
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                    // index => 102
        };
        await context.Workouts.AddRangeAsync(Workouts);
        await context.SaveChangesAsync();

        // ***************************************************************** //
        var backWorkoutInstruction = new List<WorkoutInstruction>();
        backWorkoutInstruction = new List<WorkoutInstruction>
        {
            #region Abdominals & Barbell
            new WorkoutInstruction{ WorkoutId = Workouts[0].Id , Step = 1 , Instruction = "Hold the Barbell with both hands and kneel on the floor with your feet up"},
            new WorkoutInstruction{ WorkoutId = Workouts[0].Id , Step = 2 , Instruction = "Slowly roll the Barbell straight forward, stretching your body into a straight position."},
            new WorkoutInstruction{ WorkoutId = Workouts[0].Id , Step = 3 , Instruction = "After a pause at the stretched position, start pulling yourself back to the starting position. This should be a slow and controlled movement."},

            new WorkoutInstruction{ WorkoutId = Workouts[1].Id , Step = 1 , Instruction = "Hold the bar with a slightly wider than shoulder width grip. Push the bar up toward the ceiling and maintain that elbow extension."},
            new WorkoutInstruction{ WorkoutId = Workouts[1].Id , Step = 2 , Instruction = "Flex your abs and sit-up. Aim to get your torso vertical while maintaining the barbell overhead."},

            new WorkoutInstruction{ WorkoutId = Workouts[2].Id , Step = 1 , Instruction = "Start in a bench press position with your legs elevated. Try to keep your knees with a slight bend in them."},
            new WorkoutInstruction{ WorkoutId = Workouts[2].Id , Step = 2 , Instruction = "Unrack the bar then initiate the rep."},
            new WorkoutInstruction{ WorkoutId = Workouts[2].Id , Step = 3 , Instruction = "Bring the bar to your torso and tap your ribcage before pressing back to the ceiling."},

            new WorkoutInstruction{ WorkoutId = Workouts[3].Id , Step = 1 , Instruction = "Start by lying flat on your back with your legs extended towards the landmine attachment and your arms overhead, holding the landmine barbell with both hands while engaging your core muscles by pressing your lower back into the ground and drawing your belly button in towards your spine."},
            new WorkoutInstruction{ WorkoutId = Workouts[3].Id , Step = 2 , Instruction = "Lift your legs off the ground, keeping them together and straight, and simultaneously raise your upper body off the ground, reaching the landmine barbell away from your face."},
            new WorkoutInstruction{ WorkoutId = Workouts[3].Id , Step = 3 , Instruction = "Hold this position for the desired duration, then carefully lower the barbell to the ground."},

            new WorkoutInstruction{ WorkoutId = Workouts[4].Id , Step = 1 , Instruction = "Lay flat on the ground and hold the end of the bar with your arms extended."},
            new WorkoutInstruction{ WorkoutId = Workouts[4].Id , Step = 2 , Instruction = "Raise your back off the ground until you are sitting at a 90 degree angle."},
            new WorkoutInstruction{ WorkoutId = Workouts[4].Id , Step = 3 , Instruction = "Then lower slowly back to the floor."},

            new WorkoutInstruction{ WorkoutId = Workouts[5].Id , Step = 1 , Instruction = "Measure your hands by the markings on the bar to make sure you're even. Then throw your elbows underneath the bar."},
            new WorkoutInstruction{ WorkoutId = Workouts[5].Id , Step = 2 , Instruction = "The bar should be set so high on your shoulders it digs into your neck a bit. Make sure to push your elbows up to the ceiling for the entire rep. To make sure you don't get too pitched forward."},
            new WorkoutInstruction{ WorkoutId = Workouts[5].Id , Step = 3 , Instruction = "Use the squat stance you would use for a back or goblet squat. Push your hips back to initiate the squat. Break at the knees until you hit parallel depth."},
            new WorkoutInstruction{ WorkoutId = Workouts[5].Id , Step = 4 , Instruction = "Squat back up to a standing position."},

            new WorkoutInstruction{ WorkoutId = Workouts[6].Id , Step = 1 , Instruction = "Start in a bench press position with your feet planted on the bench and knees bent."},
            new WorkoutInstruction{ WorkoutId = Workouts[6].Id , Step = 2 , Instruction = "Grasp the barbell with an overhand grip, positioning your hands slightly wider than shoulder-width apart."},
            new WorkoutInstruction{ WorkoutId = Workouts[6].Id , Step = 3 , Instruction = "Lift the barbell off the rack and lower it to your chest, keeping your elbows close to your sides."},
            new WorkoutInstruction{ WorkoutId = Workouts[6].Id , Step = 4 , Instruction = "Push the barbell back up to the starting position, fully extending your arms."},
            #endregion

            #region Abdominals && Machine
            new WorkoutInstruction{ WorkoutId = Workouts[7].Id , Step = 1 , Instruction = "Hold the Ab Roller with both hands and kneel on the floor with your feet up and crossed."},
            new WorkoutInstruction{ WorkoutId = Workouts[7].Id , Step = 2 , Instruction = "Slowly roll the ab roller straight forward, stretching your body into a straight position."},
            new WorkoutInstruction{ WorkoutId = Workouts[7].Id , Step = 3 , Instruction = "After a pause at the stretched position, start pulling yourself back to the starting position. This should be a slow and controlled movement."},

            new WorkoutInstruction{ WorkoutId = Workouts[8].Id , Step = 1 , Instruction = "Place your feet on the rower seat and get in to a hand plank position."},
            new WorkoutInstruction{ WorkoutId = Workouts[8].Id , Step = 2 , Instruction = "Pull your knees to your chest and flex your abs."},

            new WorkoutInstruction{ WorkoutId = Workouts[9].Id , Step = 1 , Instruction = "Place your feet on the rower seat and get in to a plank position."},
            new WorkoutInstruction{ WorkoutId = Workouts[9].Id , Step = 2 , Instruction = "Pull your hips straight up toward the ceiling."},
            new WorkoutInstruction{ WorkoutId = Workouts[9].Id , Step = 3 , Instruction = "Lower your hips until you're back in a plank position."},

            new WorkoutInstruction{ WorkoutId = Workouts[10].Id , Step = 1 , Instruction = "Place your feet under the foot pads and grab the handles with your hands."},
            new WorkoutInstruction{ WorkoutId = Workouts[10].Id , Step = 2 , Instruction = "Flex your spine and bring your upper and lower body together."},

            new WorkoutInstruction{ WorkoutId = Workouts[11].Id , Step = 1 , Instruction = "Place your feet under the foot pads and grab the handles with your hands."},
            new WorkoutInstruction{ WorkoutId = Workouts[11].Id , Step = 2 , Instruction = "Flex your spine and bring your upper and lower body together."},
            #endregion

            #region Abdominals && Stretches
            new WorkoutInstruction{ WorkoutId = Workouts[12].Id , Step = 1 , Instruction = "Lay on a ball or a Bosu ball with your feet firmly planted on the floor."},
            new WorkoutInstruction{ WorkoutId = Workouts[12].Id , Step = 2 , Instruction = "Lean all the way back until you feel a stretch in your abdomen."},
            new WorkoutInstruction{ WorkoutId = Workouts[12].Id , Step = 3 , Instruction = "Crunch upwards and hold for a 1-2 count."},
            new WorkoutInstruction{ WorkoutId = Workouts[12].Id , Step = 4 , Instruction = "Slowly return to the starting position and repeat."},

            new WorkoutInstruction{ WorkoutId = Workouts[13].Id , Step = 1 , Instruction = "Stand upright."},
            new WorkoutInstruction{ WorkoutId = Workouts[13].Id , Step = 2 , Instruction = "After completing the desired amount of reps with the left arm, switch to the right arm and lean to the left."},
            new WorkoutInstruction{ WorkoutId = Workouts[13].Id , Step = 3 , Instruction = "Reach up with your left arm and then lean slowly to the right. Lean until a stretch is felt in the obliques."},

            new WorkoutInstruction{ WorkoutId = Workouts[14].Id , Step = 1 , Instruction = "Stand upright."},
            new WorkoutInstruction{ WorkoutId = Workouts[14].Id , Step = 2 , Instruction = "Reach with both hands upwards until you can interlock your fingers."},
            new WorkoutInstruction{ WorkoutId = Workouts[14].Id , Step = 3 , Instruction = "With your hands above your head, lean back until a stretch is felt in the abdominals."},

            new WorkoutInstruction{ WorkoutId = Workouts[15].Id , Step = 1 , Instruction = "Lay on your stomach on the floor with your forearms flat on the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[15].Id , Step = 2 , Instruction = "Extend your elbows and push your upper body upwards."},
            new WorkoutInstruction{ WorkoutId = Workouts[15].Id , Step = 3 , Instruction = "Push your upper body upwards until you feel a stretch in your abs, then return to the starting position and repeat."},
            #endregion

            #region Abdominals && Plate
            new WorkoutInstruction{ WorkoutId = Workouts[16].Id , Step = 1 , Instruction = "Start by standing upright with your feet shoulder-width apart. Hold a single weight plate overhead with both hands, keeping your arms extended straight above your head."},
            new WorkoutInstruction{ WorkoutId = Workouts[16].Id , Step = 2 , Instruction = "Begin walking forward, taking slow and steady steps while maintaining a straight line. Your focus should be on maintaining balance and control of the weight plate overhead."},
            new WorkoutInstruction{ WorkoutId = Workouts[16].Id , Step = 3 , Instruction = "As you walk, continue to keep your arms extended and the weight plate overhead. Try to maintain good posture and avoid leaning forward or backward, as this could result in losing control of the weight plate."},
            new WorkoutInstruction{ WorkoutId = Workouts[16].Id , Step = 4 , Instruction = "Continue walking for a set distance or for a certain amount of time, keeping your focus on proper form and technique. When finished, return to the starting position and repeat as desired."},

            new WorkoutInstruction{ WorkoutId = Workouts[17].Id , Step = 1 , Instruction = "Start by sitting on the floor with your knees bent and feet flat on the ground"},
            new WorkoutInstruction{ WorkoutId = Workouts[17].Id , Step = 2 , Instruction = "Engage your core muscles by pulling your belly button toward your spine."},
            new WorkoutInstruction{ WorkoutId = Workouts[17].Id , Step = 3 , Instruction = "Slowly twist your upper body to the right, keeping your feet flat on the ground and your back straight."},
            new WorkoutInstruction{ WorkoutId = Workouts[17].Id , Step = 4 , Instruction = "Hold for a second and then twist to the left, holding for another second."},

            new WorkoutInstruction{ WorkoutId = Workouts[18].Id , Step = 1 , Instruction = "Start by lying on your back on a mat with your legs bent and feet flat on the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[18].Id , Step = 2 , Instruction = "Hold a weight plate over your head with both hands, making sure to keep your arms straight."},
            new WorkoutInstruction{ WorkoutId = Workouts[18].Id , Step = 3 , Instruction = "Engage your core and use your abdominal muscles to sit up, keeping the weight plate towards the ceiling."},

            new WorkoutInstruction{ WorkoutId = Workouts[19].Id , Step = 1 , Instruction = "Get into a kneeling position with both forearms pressed into the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[19].Id , Step = 2 , Instruction = "Place a weight plate on your back (or have a partner do it for you)."},
            new WorkoutInstruction{ WorkoutId = Workouts[19].Id , Step = 3 , Instruction = "Hold the plank for the allotted amount of time."},

            new WorkoutInstruction{ WorkoutId = Workouts[20].Id , Step = 1 , Instruction = "Start in a kneeling position with your hands planted on the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[20].Id , Step = 2 , Instruction = "Place a weight plate on your back or have a friend do it for you."},
            new WorkoutInstruction{ WorkoutId = Workouts[20].Id , Step = 3 , Instruction = "Pick your knees up off the ground. Hold in this position with a flat back."},

            new WorkoutInstruction{ WorkoutId = Workouts[21].Id , Step = 1 , Instruction = "Lay flat on the ground with your arms extended over head holding a weight plate."},
            new WorkoutInstruction{ WorkoutId = Workouts[21].Id , Step = 2 , Instruction = "Pick your upper back and your legs off the ground. Your body should be in a banana shape."},

            new WorkoutInstruction{ WorkoutId = Workouts[22].Id , Step = 1 , Instruction = "Start from a plank position. Place a plate on your back."},
            new WorkoutInstruction{ WorkoutId = Workouts[22].Id , Step = 2 , Instruction = "Go to one elbow then the other. Try to avoid rocking back and forth."},
            #endregion

            #region Abdominals && Bosu-Ball
            new WorkoutInstruction{ WorkoutId = Workouts[23].Id , Step = 1 , Instruction = "Place forearms on Bosu, elbows under shoulders."},
            new WorkoutInstruction{ WorkoutId = Workouts[23].Id , Step = 2 , Instruction = "Extend legs, keeping body straight."},
            new WorkoutInstruction{ WorkoutId = Workouts[23].Id , Step = 3 , Instruction = "Hold the plank position, engaging core."},

            new WorkoutInstruction{ WorkoutId = Workouts[24].Id , Step = 1 , Instruction = "Place hands on Bosu, shoulder-width apart."},
            new WorkoutInstruction{ WorkoutId = Workouts[24].Id , Step = 2 , Instruction = "Extend legs, keeping body straight."},
            new WorkoutInstruction{ WorkoutId = Workouts[24].Id , Step = 3 , Instruction = "Hold the plank position, engaging core."},

            new WorkoutInstruction{ WorkoutId = Workouts[25].Id , Step = 1 , Instruction = "Start in a plank position with Bosu under feet."},
            new WorkoutInstruction{ WorkoutId = Workouts[25].Id , Step = 2 , Instruction = "Lift one leg back, squeezing glutes."},
            new WorkoutInstruction{ WorkoutId = Workouts[25].Id , Step = 3 , Instruction = "Lower the leg back down and switch sides."},

            new WorkoutInstruction{ WorkoutId = Workouts[26].Id , Step = 1 , Instruction = "Lie on back, bosu elevated toward the ceiling."},
            new WorkoutInstruction{ WorkoutId = Workouts[26].Id , Step = 2 , Instruction = "Sit up, engaging core muscles."},
            new WorkoutInstruction{ WorkoutId = Workouts[26].Id , Step = 3 , Instruction = "Lower back down to complete one situp."},

            new WorkoutInstruction{ WorkoutId = Workouts[27].Id , Step = 1 , Instruction = "Stand in front of a low box."},
            new WorkoutInstruction{ WorkoutId = Workouts[27].Id , Step = 2 , Instruction = "Bring one foot to the edge of the box and alternate as quickly as possible."},
            new WorkoutInstruction{ WorkoutId = Workouts[27].Id , Step = 3 , Instruction = "Only lightly tap your feet to the box."},

            new WorkoutInstruction{ WorkoutId = Workouts[28].Id , Step = 1 , Instruction = "Stand next to Bosu, step up and over it."},
            new WorkoutInstruction{ WorkoutId = Workouts[28].Id , Step = 2 , Instruction = "Repeat, moving laterally side to side."},
            new WorkoutInstruction{ WorkoutId = Workouts[28].Id , Step = 3 , Instruction = "Keep a steady pace, engaging core muscles."},

            new WorkoutInstruction{ WorkoutId = Workouts[29].Id , Step = 1 , Instruction = "Place both hands on Bosu, wider than shoulder-width."},
            new WorkoutInstruction{ WorkoutId = Workouts[29].Id , Step = 2 , Instruction = "Perform a pushup, then walk hands to the other side."},
            new WorkoutInstruction{ WorkoutId = Workouts[29].Id , Step = 3 , Instruction = "Perform another pushup, repeat back and forth."},
            #endregion

            #region Abdominals && Smith-Machine
            new WorkoutInstruction{ WorkoutId = Workouts[30].Id , Step = 1 , Instruction = "Put a hip thrust pad on the smith machine bar at neck height. Put both arms over the bar and pull your feet off the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[30].Id , Step = 2 , Instruction = "Pull your knees to your chest and flex your abs."},
            
            new WorkoutInstruction{ WorkoutId = Workouts[31].Id , Step = 1 , Instruction = "Lay flat on the ground. With your feet on the bar."},
            new WorkoutInstruction{ WorkoutId = Workouts[31].Id , Step = 2 , Instruction = "Lift your hips off the ground."},

            new WorkoutInstruction{ WorkoutId = Workouts[32].Id , Step = 1 , Instruction = "Set up the Smith machine bar at an appropriate height."},
            new WorkoutInstruction{ WorkoutId = Workouts[32].Id , Step = 2 , Instruction = "Lie on your back beneath the bar, gripping it with your hands."},
            new WorkoutInstruction{ WorkoutId = Workouts[32].Id , Step = 3 , Instruction = "Engage your core, lift your upper body toward the bar, and exhale."},
            new WorkoutInstruction{ WorkoutId = Workouts[32].Id , Step = 4 , Instruction = "Lower your upper body back down in a controlled manner, inhaling."},

            #endregion

            #region Abdominals && Dumbbells
            new WorkoutInstruction{ WorkoutId = Workouts[33].Id , Step = 1 , Instruction = "Lay flat on the ground with your spine neutral. Extend you arms so your fists are pointed at the ceiling."},
            new WorkoutInstruction{ WorkoutId = Workouts[33].Id , Step = 2 , Instruction = "Sit-up by flexing your abs. Continue to reach for the ceiling for the entire rep."},

            new WorkoutInstruction{ WorkoutId = Workouts[34].Id , Step = 1 , Instruction = "Get into a plank position. Either from your knees or toes."},
            new WorkoutInstruction{ WorkoutId = Workouts[34].Id , Step = 2 , Instruction = "Start with the DB by your right hand. Reach with your left and pull the dumbbell to your left arm. Then repeat with the right."},

            new WorkoutInstruction{ WorkoutId = Workouts[35].Id , Step = 1 , Instruction = "Lay flat on the ground with a dumbbell overhead."},
            new WorkoutInstruction{ WorkoutId = Workouts[35].Id , Step = 2 , Instruction = "Pull your upper back and legs off the ground. Make a banana shape with your body."},
            new WorkoutInstruction{ WorkoutId = Workouts[35].Id , Step = 3 , Instruction = "The dumbbell should be held in your hands and your ears should be between your biceps."},

            new WorkoutInstruction{ WorkoutId = Workouts[36].Id , Step = 1 , Instruction = "Start by lying flat on your back with your feet flat on the floor and your knees bent."},
            new WorkoutInstruction{ WorkoutId = Workouts[36].Id , Step = 2 , Instruction = "Hold a dumbbell over your clavicle."},
            new WorkoutInstruction{ WorkoutId = Workouts[36].Id , Step = 3 , Instruction = "Engage your core muscles and lift your torso off the floor until your shoulders are a few inches off the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[36].Id , Step = 4 , Instruction = "Lower yourself back down to the starting position, but avoid resting completely on the floor between reps."},

            new WorkoutInstruction{ WorkoutId = Workouts[37].Id , Step = 1 , Instruction = "Start in a plank position. Hold one dumbbell."},
            new WorkoutInstruction{ WorkoutId = Workouts[37].Id , Step = 2 , Instruction = "Raise the dumbbell straight out in front of you (I), at a 45 degree angle (Y), out to the side (T), and then bend at the elbow while raising (W)."},
            new WorkoutInstruction{ WorkoutId = Workouts[37].Id , Step = 3 , Instruction = "Going through IYTW counts as one rep."},
            new WorkoutInstruction{ WorkoutId = Workouts[37].Id , Step = 4 , Instruction = "Make sure to keep your hips stable. If you're unable to, try performing this exercise from the knees."},

            new WorkoutInstruction{ WorkoutId = Workouts[38].Id , Step = 1 , Instruction = "Lay flat on the ground with a dumbbell. Point the soles of your shoes at the ceiling as well as the dumbbell."},
            new WorkoutInstruction{ WorkoutId = Workouts[38].Id , Step = 2 , Instruction = "Reach for your feet with the dumbbell before bringing your spine back to the floor."},

            new WorkoutInstruction{ WorkoutId = Workouts[39].Id , Step = 1 , Instruction = "Sit on the floor and flex your knees and hips to a 90 degree angle."},
            new WorkoutInstruction{ WorkoutId = Workouts[39].Id , Step = 2 , Instruction = "Your feet should be hovering off the ground. (If that's too hard start with heels on the floor)"},
            new WorkoutInstruction{ WorkoutId = Workouts[39].Id , Step = 3 , Instruction = "Rotate your upper spine to engage your obliques."},

            new WorkoutInstruction{ WorkoutId = Workouts[40].Id , Step = 1 , Instruction = "Take a half kneeling position. Start with the dumbbell by your knee on the side of the kneeling leg."},
            new WorkoutInstruction{ WorkoutId = Workouts[40].Id , Step = 2 , Instruction = "Rotate at the upper spine, holding the dumbbell away from your body with nearly extended elbows."},

            new WorkoutInstruction{ WorkoutId = Workouts[41].Id , Step = 1 , Instruction = "Start by getting into a plank position with a dumbbell in each hand. Your feet should be shoulder-width apart and your hands should be placed on the dumbbells, with your palms facing each other."},
            new WorkoutInstruction{ WorkoutId = Workouts[41].Id , Step = 2 , Instruction = "From this starting position, row one dumbbell up towards your chest, keeping your elbow close to your body and your core engaged."},
            new WorkoutInstruction{ WorkoutId = Workouts[41].Id , Step = 3 , Instruction = "Slowly lower the dumbbell back down to the starting position, and repeat on the other side."},
            new WorkoutInstruction{ WorkoutId = Workouts[41].Id , Step = 4 , Instruction = "Make sure to keep your body straight and your hips level throughout the movement."},

            new WorkoutInstruction{ WorkoutId = Workouts[42].Id , Step = 1 , Instruction = "Start in a high plank position with a pair of dumbbells positioned under your shoulders. Your hands should grip the dumbbells, palms facing each other."},
            new WorkoutInstruction{ WorkoutId = Workouts[42].Id , Step = 2 , Instruction = "Keep your core engaged and your back straight as you row one dumbbell up towards your hip, keeping your elbow close to your body."},
            new WorkoutInstruction{ WorkoutId = Workouts[42].Id , Step = 3 , Instruction = "Lower the dumbbell back down to the starting position and repeat on the other side."},
            #endregion

            #region Abdominals && Medicine-Ball
            new WorkoutInstruction{ WorkoutId = Workouts[43].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart, hold a medicine ball."},
            new WorkoutInstruction{ WorkoutId = Workouts[43].Id , Step = 2 , Instruction = "Circle the ball around your head, maintaining control."},
            new WorkoutInstruction{ WorkoutId = Workouts[43].Id , Step = 3 , Instruction = "Complete the desired number of repetitions in both directions."},
            
            new WorkoutInstruction{ WorkoutId = Workouts[44].Id , Step = 1 , Instruction = "Lie facing partner, knees bent."},
            new WorkoutInstruction{ WorkoutId = Workouts[44].Id , Step = 2 , Instruction = "Sit up, toss medicine ball to partner."},
            new WorkoutInstruction{ WorkoutId = Workouts[44].Id , Step = 3 , Instruction = "Catch and lower down. Repeat for desired reps."},

            new WorkoutInstruction{ WorkoutId = Workouts[45].Id , Step = 1 , Instruction = "Place forearms on medicine ball, extend legs."},
            new WorkoutInstruction{ WorkoutId = Workouts[45].Id , Step = 2 , Instruction = "Maintain straight body position for desired time."},

            new WorkoutInstruction{ WorkoutId = Workouts[46].Id , Step = 1 , Instruction = "Lift medicine ball overhead."},
            new WorkoutInstruction{ WorkoutId = Workouts[46].Id , Step = 2 , Instruction = "Slam ball down to ground with force."},

            new WorkoutInstruction{ WorkoutId = Workouts[47].Id , Step = 1 , Instruction = "Lie on your back, holding a medicine ball overhead."},
            new WorkoutInstruction{ WorkoutId = Workouts[47].Id , Step = 2 , Instruction = "Lift your shoulders and legs off the ground, engaging core."},
            new WorkoutInstruction{ WorkoutId = Workouts[47].Id , Step = 3 , Instruction = "Hold the position while maintaining stability."},

            new WorkoutInstruction{ WorkoutId = Workouts[48].Id , Step = 1 , Instruction = "Lie on your back, place a medicine ball between your extended arms and bent knees."},
            new WorkoutInstruction{ WorkoutId = Workouts[48].Id , Step = 2 , Instruction = "Lower opposite arm and leg to floor, keeping back pressed against ground and medicine ball in place."},
            new WorkoutInstruction{ WorkoutId = Workouts[48].Id , Step = 3 , Instruction = "Alternate sides, maintain core engagement, and repeat for desired reps or time."},
            #endregion

            #region Abdominals && Cables
            new WorkoutInstruction{ WorkoutId = Workouts[49].Id , Step = 1 , Instruction = "Use a double handle attachment and set the cable all the way to the top"},
            new WorkoutInstruction{ WorkoutId = Workouts[49].Id , Step = 2 , Instruction = "Face away from the cable tower and walk a few steps forward."},
            new WorkoutInstruction{ WorkoutId = Workouts[49].Id , Step = 3 , Instruction = "Push your hips back, and flex your abs."},
            new WorkoutInstruction{ WorkoutId = Workouts[49].Id , Step = 4 , Instruction = "Return to the starting standing position and repeat."},

            new WorkoutInstruction{ WorkoutId = Workouts[50].Id , Step = 1 , Instruction = "Use a double handle attachment and set the cable all the way to the top."},
            new WorkoutInstruction{ WorkoutId = Workouts[50].Id , Step = 2 , Instruction = "Walk a few steps forward then fall into a kneeling position."},
            new WorkoutInstruction{ WorkoutId = Workouts[50].Id , Step = 3 , Instruction = "Push your hips back and flex your abs, then push hips forward until in the starting position."},

            new WorkoutInstruction{ WorkoutId = Workouts[51].Id , Step = 1 , Instruction = "Use a rope attachment and set the cable all the way to the top."},
            new WorkoutInstruction{ WorkoutId = Workouts[51].Id , Step = 2 , Instruction = "Walk a few steps forward then fall into a kneeling position."},
            new WorkoutInstruction{ WorkoutId = Workouts[51].Id , Step = 3 , Instruction = "Push your hips back and flex your abs, then push hips forward until in the starting position."},

            new WorkoutInstruction{ WorkoutId = Workouts[52].Id , Step = 1 , Instruction = "Use a rope attachment and set the cable all the way to the top."},
            new WorkoutInstruction{ WorkoutId = Workouts[52].Id , Step = 2 , Instruction = "Walk a few steps forward then fall into a kneeling position."},
            new WorkoutInstruction{ WorkoutId = Workouts[52].Id , Step = 3 , Instruction = "Push your hips back and flex your abs, then push hips forward until in the starting position."},
            #endregion

            #region Abdominals && TRX
            new WorkoutInstruction{ WorkoutId = Workouts[53].Id , Step = 1 , Instruction = ""},

            new WorkoutInstruction{ WorkoutId = Workouts[54].Id , Step = 1 , Instruction = "Lie face down on the ground and place your forearms on the ground directly under your shoulders."},
            new WorkoutInstruction{ WorkoutId = Workouts[54].Id , Step = 2 , Instruction = "With your feet in the stirrups, kick both feet into the TRX straps and hold the handles above your head."},
            new WorkoutInstruction{ WorkoutId = Workouts[54].Id , Step = 3 , Instruction = "Tighten your abs, glutes, and legs to form a straight line from your head to your feet."},

            new WorkoutInstruction{ WorkoutId = Workouts[55].Id , Step = 1 , Instruction = "Start by facing away from the TRX straps and placing your feet in the TRX handles with your palms on the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[55].Id , Step = 2 , Instruction = "Lift your knees off the ground to begin the set."},
            new WorkoutInstruction{ WorkoutId = Workouts[55].Id , Step = 3 , Instruction = "Engage your core and maintain this position for the desired amount of time, holding a steady plank."},

            new WorkoutInstruction{ WorkoutId = Workouts[56].Id , Step = 1 , Instruction = "Begin in a kneeling position with the TRX straps adjusted to mid-calf length."},
            new WorkoutInstruction{ WorkoutId = Workouts[56].Id , Step = 2 , Instruction = "Grasp the TRX handles with both hands, keeping your arms extended and your shoulders away from your ears."},
            new WorkoutInstruction{ WorkoutId = Workouts[56].Id , Step = 3 , Instruction = "Keep your abs engaged, roll forward onto your toes, and extend your arms in front of you."},
            new WorkoutInstruction{ WorkoutId = Workouts[56].Id , Step = 4 , Instruction = "Slowly lower your body down to the ground, keeping your arms straight and your abs engaged."},

            new WorkoutInstruction{ WorkoutId = Workouts[57].Id , Step = 1 , Instruction = "Place your feet in the TRX stirrups and get in to a hand plank position."},
            new WorkoutInstruction{ WorkoutId = Workouts[57].Id , Step = 2 , Instruction = "Pull your knees to your chest and flex your abs."},

            new WorkoutInstruction{ WorkoutId = Workouts[58].Id , Step = 1 , Instruction = "Start in a plank position with the TRX straps adjusted to mid-calf length. Place your feet in the TRX stirrups."},
            new WorkoutInstruction{ WorkoutId = Workouts[58].Id , Step = 2 , Instruction = "Keep your abs engaged, and bring one knee towards your chest while keeping the other leg extended behind you."},
            new WorkoutInstruction{ WorkoutId = Workouts[58].Id , Step = 3 , Instruction = "Switch legs, bringing the opposite knee towards your chest while keeping your abs engaged and your back straight."},

            new WorkoutInstruction{ WorkoutId = Workouts[59].Id , Step = 1 , Instruction = "Place your feet in the stirrups and get in to a plank position."},
            new WorkoutInstruction{ WorkoutId = Workouts[59].Id , Step = 2 , Instruction = "Pull your hips straight up toward the ceiling."},
            new WorkoutInstruction{ WorkoutId = Workouts[59].Id , Step = 3 , Instruction = "Lower your hips until you're back in a plank position."},
            #endregion
            
            #region Abdominals && 
            new WorkoutInstruction{ WorkoutId = Workouts[60].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[61].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[62].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[63].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[64].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[65].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[66].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[67].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[68].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[69].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[70].Id , Step = 1 , Instruction = ""},

            new WorkoutInstruction{ WorkoutId = Workouts[71].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[72].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[73].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[74].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[75].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[76].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[77].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[78].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[79].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[80].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[81].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[82].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[83].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[84].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[85].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[86].Id , Step = 1 , Instruction = ""},
            
            new WorkoutInstruction{ WorkoutId = Workouts[87].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[88].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[89].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[90].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[91].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[92].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[93].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[94].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[95].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[96].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[97].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[98].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[99].Id , Step = 1 , Instruction = ""},
            new WorkoutInstruction{ WorkoutId = Workouts[100].Id , Step = 1 , Instruction = ""},

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
        var medicineId = context.Equipments.Where(x => x.Name == "Medicine Ball").Select(x => x.Id).FirstOrDefault();
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
            #region Abdominals & Barbell
            new WorkoutEquipment{ WorkoutId = Workouts[0].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[1].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[2].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[3].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[4].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[5].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[6].Id, EquipmentId = barbellId },
            #endregion

            #region Abdominals && Machine
            new WorkoutEquipment{ WorkoutId = Workouts[7].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[8].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[9].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[10].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[11].Id, EquipmentId = machineId },
            #endregion

            #region Abdominals && Stretches
            new WorkoutEquipment{ WorkoutId = Workouts[12].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = Workouts[13].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = Workouts[14].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = Workouts[15].Id, EquipmentId = stretchesId },
            #endregion

            #region Abdominals && Plate
            new WorkoutEquipment{ WorkoutId = Workouts[16].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[17].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[18].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[19].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[20].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[21].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[22].Id, EquipmentId = plateId },
            #endregion

            #region Abdominals && Bosu-Ball
            new WorkoutEquipment{ WorkoutId = Workouts[23].Id, EquipmentId = bosuballId },
            new WorkoutEquipment{ WorkoutId = Workouts[24].Id, EquipmentId = bosuballId },
            new WorkoutEquipment{ WorkoutId = Workouts[25].Id, EquipmentId = bosuballId },
            new WorkoutEquipment{ WorkoutId = Workouts[26].Id, EquipmentId = bosuballId },
            new WorkoutEquipment{ WorkoutId = Workouts[27].Id, EquipmentId = bosuballId },
            new WorkoutEquipment{ WorkoutId = Workouts[28].Id, EquipmentId = bosuballId },
            new WorkoutEquipment{ WorkoutId = Workouts[29].Id, EquipmentId = bosuballId },
            #endregion

            #region Abdominals && Smith-Machine
            new WorkoutEquipment{ WorkoutId = Workouts[30].Id, EquipmentId = smithMachineId },
            new WorkoutEquipment{ WorkoutId = Workouts[31].Id, EquipmentId = smithMachineId },
            new WorkoutEquipment{ WorkoutId = Workouts[32].Id, EquipmentId = smithMachineId },
            #endregion

            #region Abdominals && Dumbbells
            new WorkoutEquipment{ WorkoutId = Workouts[33].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[34].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[35].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[36].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[37].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[38].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[39].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[40].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[41].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[42].Id, EquipmentId = dumbellId },
            #endregion

            #region Abdominals && Medicine-Ball
            new WorkoutEquipment{ WorkoutId = Workouts[43].Id, EquipmentId = medicineId },
            new WorkoutEquipment{ WorkoutId = Workouts[44].Id, EquipmentId = medicineId },
            new WorkoutEquipment{ WorkoutId = Workouts[45].Id, EquipmentId = medicineId },
            new WorkoutEquipment{ WorkoutId = Workouts[46].Id, EquipmentId = medicineId },
            new WorkoutEquipment{ WorkoutId = Workouts[47].Id, EquipmentId = medicineId },
            new WorkoutEquipment{ WorkoutId = Workouts[48].Id, EquipmentId = medicineId },
            #endregion

            #region Abdominals && Cables
            new WorkoutEquipment{ WorkoutId = Workouts[49].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = Workouts[50].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = Workouts[51].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = Workouts[52].Id, EquipmentId = cableId },
            #endregion

            #region Abdominals && TRX
            new WorkoutEquipment{ WorkoutId = Workouts[53].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = Workouts[54].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = Workouts[55].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = Workouts[56].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = Workouts[57].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = Workouts[58].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = Workouts[59].Id, EquipmentId = trxId },

            #endregion

        };
        await context.WorkoutEquipment.AddRangeAsync(workoutEquipment);
        await context.SaveChangesAsync();
        // ***************************************************************** //
        var workoutLevel = new List<WorkoutLevel>();
        workoutLevel = new List<WorkoutLevel>
        {
            #region Abdominals & Barbell
            new WorkoutLevel{ WorkoutId = Workouts[0].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = Workouts[1].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[2].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = Workouts[3].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = Workouts[4].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[5].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = Workouts[6].Id , Level = Difficulty.Advanced},
            #endregion

            #region Abdominals && Machine
            new WorkoutLevel{ WorkoutId = Workouts[7].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[8].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[9].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[10].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = Workouts[11].Id , Level = Difficulty.Novice},
            #endregion

            #region Abdominals && Stretches
            new WorkoutLevel{ WorkoutId = Workouts[12].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[13].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = Workouts[14].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = Workouts[15].Id , Level = Difficulty.Novice},
            #endregion
            
            #region Abdominals && Plate
            new WorkoutLevel{ WorkoutId = Workouts[16].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[17].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[18].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[19].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[20].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[21].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = Workouts[22].Id , Level = Difficulty.Beginner},
            #endregion

            #region Abdominals && Bosu-Ball
            new WorkoutLevel{ WorkoutId = Workouts[23].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[24].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[25].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[26].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[27].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[28].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[29].Id , Level = Difficulty.Intermediate},
            #endregion

            #region Abdominals && Smith-Machine
            new WorkoutLevel{ WorkoutId = Workouts[30].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[31].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[32].Id , Level = Difficulty.Beginner},
            #endregion
            
            #region Abdominals && Dumbbells
            #endregion

            #region Abdominals && Dumbbells
            new WorkoutLevel{ WorkoutId = Workouts[33].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[34].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[35].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = Workouts[36].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[37].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[38].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = Workouts[39].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[40].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[41].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[42].Id , Level = Difficulty.Intermediate},
            #endregion

            #region Abdominals && Medicine-Ball
            new WorkoutLevel{ WorkoutId = Workouts[43].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[44].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[45].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[46].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[47].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[48].Id , Level = Difficulty.Intermediate},
            #endregion

            #region Abdominals && Cables
            new WorkoutLevel{ WorkoutId = Workouts[49].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[50].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[51].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[52].Id , Level = Difficulty.Beginner },
            #endregion

            #region Abdominals && TRX
            new WorkoutLevel{ WorkoutId = Workouts[53].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[54].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[55].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[56].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[57].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[58].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[59].Id , Level = Difficulty.Intermediate },

            #endregion





        };
        await context.WorkoutLevels.AddRangeAsync(workoutLevel);
        await context.SaveChangesAsync();

        // ***************************************************************** //

        var bodyWorkouts = new List<BodyWorkout>();
        var AbdoId = await context.Bodies.Where(z => z.Name == "Abdominals").Select(z => z.Id).FirstOrDefaultAsync();

        bodyWorkouts = new List<BodyWorkout>
        {
            #region Abdominals & Barbell
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[0].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[1].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[2].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[3].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[4].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[5].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[6].Id, Target = PriorityTarget.Tertiary },
            #endregion

            #region Abdominals && Machine
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[7].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[8].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[9].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[10].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[11].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Stretches
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[12].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[13].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[14].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[15].Id, Target = PriorityTarget.Primary },
            #endregion
            
            #region Abdominals && Plate
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[16].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[17].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[18].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[19].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[20].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[21].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[22].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Bosu-Ball
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[23].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[24].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[25].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[26].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[27].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[28].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[29].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Smith-Machine
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[30].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[31].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[32].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Dumbbells
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[33].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[34].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[35].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[36].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[37].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[38].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[39].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[40].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[41].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[42].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Medicine-Ball
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[43].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[44].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[45].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[46].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[47].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[48].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Cables
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[49].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[50].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[51].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[52].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && TRX
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[53].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[54].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[55].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[56].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[57].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[58].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[59].Id, Target = PriorityTarget.Primary },
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
