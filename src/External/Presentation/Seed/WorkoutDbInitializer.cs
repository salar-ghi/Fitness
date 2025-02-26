namespace Presentation.Seed;

public static class WorkoutDbInitializer
{
    public static async Task WorkoutSeedAsync(FitnessContext context)
    {
        using var transactions = await context.Database.BeginTransactionAsync();

        var workouts = new List<Workout>();
        if (!await context.Workouts.AnyAsync())
        {
            var bodybuildingId = await context.Sports.Where(s => s.Name == "Body Building").Select(z => z.Id).FirstOrDefaultAsync();
            var cardioId = await context.Sports.Where(s => s.Name == "Cardio").Select(z => z.Id).FirstOrDefaultAsync();
            var crossfitId = await context.Sports.Where(s => s.Name == "Cross Fit").Select(z => z.Id).FirstOrDefaultAsync();
            workouts = new List<Workout>
            {
                // biceps // Barbell
                new Workout{ Name = "Barbell Curl", SportId = bodybuildingId, Description = "" },                                   // index => 0
                new Workout{ Name = "Barbell Reverse Curl", SportId = bodybuildingId, Description = "" },                           // index => 1
                new Workout{ Name = "Barbell Landmine Row", SportId = bodybuildingId, Description = "" },                           // index => 2
                new Workout{ Name = "Barbell Long Landmine Row", SportId = bodybuildingId, Description = "" },                      // index => 3
                new Workout{ Name = "Barbell Meadows Row", SportId = bodybuildingId, Description = "" },                            // index => 4
                new Workout{ Name = "Barbell Pronated Pendlay Row", SportId = bodybuildingId, Description = "" },                   // index => 5
                new Workout{ Name = "Barbell Pronated Row", SportId = bodybuildingId, Description = "" },                           // index => 6
                new Workout{ Name = "Barbell Supinated Pendlay Row", SportId = bodybuildingId, Description = "" },                  // index => 7
                new Workout{ Name = "Barbell Supinated Row", SportId = bodybuildingId, Description = "" },                          // index => 8
                new Workout{ Name = "Landmine Bicep Curl", SportId = bodybuildingId, Description = "" },                            // index => 9
                new Workout{ Name = "Landmine Concentration Curl", SportId = bodybuildingId, Description = "" },                    // index => 10
                new Workout{ Name = "Barbell Drag Curl", SportId = bodybuildingId, Description = "" },                              // index => 11
                new Workout{ Name = "Landmine T Bar Rows", SportId = bodybuildingId, Description = "" },                            // index => 12
                new Workout{ Name = "Barbell Bent Over Row", SportId = bodybuildingId, Description = "" },                          // index => 13
                new Workout{ Name = "EZ Bar Preacher Curl", SportId = bodybuildingId, Description = "" },                           // index => 14
                new Workout{ Name = "EZ Bar Reverse Preacher Curl", SportId = bodybuildingId, Description = "" },                   // index => 15

                // biceps // Machine
                new Workout{ Name = "Machine Seated Cable Row", SportId = bodybuildingId, Description = "" },                       // index => 16
                new Workout{ Name = "Narrow Pulldown", SportId = bodybuildingId, Description = "" },                                // index => 17
                new Workout{ Name = "Neutral Pulldown", SportId = bodybuildingId, Description = "" },                               // index => 18
                new Workout{ Name = "Underhand Pulldown", SportId = bodybuildingId, Description = "" },                             // index => 19
                new Workout{ Name = "Machine Assisted Pull Up", SportId = bodybuildingId, Description = "" },                       // index => 20
                new Workout{ Name = "Machine Assisted Narrow Pull Up", SportId = bodybuildingId, Description = "" },                // index => 21
                new Workout{ Name = "Machine Assisted Neutral Chin Up", SportId = bodybuildingId, Description = "" },               // index => 22
                new Workout{ Name = "Machine Assisted Chin Up", SportId = bodybuildingId, Description = "" },                       // index => 23
                new Workout{ Name = "Machine Underhand Row", SportId = bodybuildingId, Description = "" },                          // index => 24
                new Workout{ Name = "Machine Plate Loaded Pulldown", SportId = bodybuildingId, Description = "" },                  // index => 25
                new Workout{ Name = "Machine Standing Plate Loaded Preacher Curl", SportId = bodybuildingId, Description = "" },    // index => 26
                new Workout{ Name = "Machine Seated Plate Loaded Preacher Curl", SportId = bodybuildingId, Description = "" },      // index => 27
                new Workout{ Name = "Machine Bicep Curl", SportId = bodybuildingId, Description = "" },                             // index => 28

                // biceps // stretches
                new Workout{ Name = "Biceps Stretch Variation Five", SportId = cardioId, Description = "" },                        // index => 29
                new Workout{ Name = "Biceps Stretch Variation Four", SportId = cardioId, Description = "" },                        // index => 30
                new Workout{ Name = "Biceps Stretch Variation Three", SportId = cardioId, Description = "" },                       // index => 31
                new Workout{ Name = "Biceps Stretch Variation Two", SportId = cardioId, Description = "" },                         // index => 32
                new Workout{ Name = "Biceps Stretch Variation One", SportId = cardioId, Description = "" },                         // index => 33

                // biceps // plate
                new Workout{ Name = "Plate Bicep Curl", SportId = bodybuildingId, Description = "" },                                   // index => 34
                new Workout{ Name = "Plate Curl To Overhead Press", SportId = bodybuildingId, Description = "" },                       // index => 35
                new Workout{ Name = "Plate Curl To Overhead Press To Tricep Extension", SportId = bodybuildingId, Description = "" },   // index => 36
                new Workout{ Name = "Plate Squat Hold Curl", SportId = bodybuildingId, Description = "" },                              // index => 37
                new Workout{ Name = "Plate Pinch Grip Row", SportId = bodybuildingId, Description = "" },                               // index => 38
                new Workout{ Name = "Weighted Chin Ups", SportId = bodybuildingId, Description = "" },                                  // index => 39

                // biceps // bosu-ball
                new Workout{ Name = "Bosu Ball Curl", SportId = cardioId, Description = "" },                                           // index => 40
                new Workout{ Name = "Bosu Ball Row", SportId = cardioId, Description = "" },                                            // index => 41

                // biceps // smith machine
                new Workout{ Name = "Smith Machine Drag Curl", SportId = bodybuildingId, Description = "" },                            // index => 42
                new Workout{ Name = "Smith Machine Underhand Row", SportId = bodybuildingId, Description = "" },                        // index => 43
                new Workout{ Name = "Smith Machine Overhand Row", SportId = bodybuildingId, Description = "" },                         // index => 44

                // biceps // dumbell
                new Workout{ Name = "Dumbbell Curl", SportId = bodybuildingId, Description = "" },                                                   // index => 45
                new Workout{ Name = "Dumbbell Hammer Curl", SportId = bodybuildingId, Description = "" },                                            // index => 46
                new Workout{ Name = "Dumbbell Reverse Curl", SportId = bodybuildingId, Description = "" },                                           // index => 47
                new Workout{ Name = "Dumbbell Incline Hammer Curl", SportId = bodybuildingId, Description = "" },                                    // index => 48
                new Workout{ Name = "Dumbbell Incline Reverse Curl", SportId = bodybuildingId, Description = "" },                                   // index => 49
                new Workout{ Name = "Dumbbell Incline Zottman Curl", SportId = bodybuildingId, Description = "" },                                   // index => 50
                new Workout{ Name = "Dumbbell Single Arm Preacher Curl", SportId = bodybuildingId, Description = "" },                               // index => 51
                new Workout{ Name = "Dumbbell Single Arm Spider Curl", SportId = bodybuildingId, Description = "" },                                 // index => 52
                new Workout{ Name = "Dumbbell Spider Curl", SportId = bodybuildingId, Description = "" },                                            // index => 53
                new Workout{ Name = "Dumbbell Twisting Curl", SportId = bodybuildingId, Description = "" },                                          // index => 54
                new Workout{ Name = "Dumbbell Concentration Curl", SportId = bodybuildingId, Description = "" },                                     // index => 55
                new Workout{ Name = "Dumbbell Alternating Pendlay Row", SportId = bodybuildingId, Description = "" },                                // index => 56
                new Workout{ Name = "Dumbbell Kneeling Single Arm Row", SportId = bodybuildingId, Description = "" },                                // index => 57
                new Workout{ Name = "Dumbbell Laying Incline Row", SportId = bodybuildingId, Description = "" },                                     // index => 58
                new Workout{ Name = "Dumbbell Pendlay Row", SportId = bodybuildingId, Description = "" },                                            // index => 59
                new Workout{ Name = "Dumbbell Single Arm Row", SportId = bodybuildingId, Description = "" },                                         // index => 60
                new Workout{ Name = "Dumbbell Single Arm Row Knee", SportId = bodybuildingId, Description = "" },                                    // index => 61
                new Workout{ Name = "Lawnmower Row", SportId = bodybuildingId, Description = "" },                                                   // index => 62
                new Workout{ Name = "Dumbbell Knee Lawnmower Row", SportId = bodybuildingId, Description = "" },                                     // index => 63
                new Workout{ Name = "Dumbbell Supinated Row", SportId = bodybuildingId, Description = "" },                                          // index => 64
                new Workout{ Name = "Dumbbell Rear Delt Row", SportId = bodybuildingId, Description = "" },                                          // index => 65
                new Workout{ Name = "Dumbbell Preacher Curl", SportId = bodybuildingId, Description = "" },                                          // index => 66
                new Workout{ Name = "Dumbbell Incline Curl", SportId = bodybuildingId, Description = "" },                                           // index => 67
                new Workout{ Name = "Dumbbell Weighted Chin Ups", SportId = bodybuildingId, Description = "" },                                      // index => 68
                new Workout{ Name = "Dumbbell Laying Curl", SportId = bodybuildingId, Description = "" },                                            // index => 69

                // biceps // cables
                new Workout{ Name = "Cable Pull In", SportId = bodybuildingId, Description = "" },                                                  // index => 70
                new Workout{ Name = "Cable Twisting Curl", SportId = bodybuildingId, Description = "" },                                            // index => 71
                new Workout{ Name = "Cable Single Arm Bayesian Curl", SportId = bodybuildingId, Description = "" },                                 // index => 72
                new Workout{ Name = "Cable Single Arm Reverse Curl", SportId = bodybuildingId, Description = "" },                                  // index => 73
                new Workout{ Name = "Cable Single Arm Hammer Curl", SportId = bodybuildingId, Description = "" },                                   // index => 74
                new Workout{ Name = "Cable Row Bar Standing Row", SportId = bodybuildingId, Description = "" },                                     // index => 75
                new Workout{ Name = "Cable Single Arm Underhand Grip Row", SportId = bodybuildingId, Description = "" },                            // index => 76
                new Workout{ Name = "Cable Single Arm Neutral Grip Row", SportId = bodybuildingId, Description = "" },                              // index => 77
                new Workout{ Name = "Cable Supinating Row", SportId = bodybuildingId, Description = "" },                                           // index => 78
                new Workout{ Name = "Cable Archer Row", SportId = bodybuildingId, Description = "" },                                               // index => 79
                new Workout{ Name = "Cable Seated Bayesian Reverse Curl", SportId = bodybuildingId, Description = "" },                             // index => 80
                new Workout{ Name = "Cable Seated Bayesian Hammer Curl", SportId = bodybuildingId, Description = "" },                              // index => 81
                new Workout{ Name = "Cable Seated Bayesian Curl", SportId = bodybuildingId, Description = "" },                                     // index => 82
                new Workout{ Name = "Cable Bar Curl", SportId = bodybuildingId, Description = "" },                                                 // index => 83
                new Workout{ Name = "Cable Rope Hammer Curl", SportId = bodybuildingId, Description = "" },                                         // index => 84
                new Workout{ Name = "Cable Hammer Bayesian Curl", SportId = bodybuildingId, Description = "" },                                     // index => 85
                new Workout{ Name = "Cable Reverse Bayesian Curl", SportId = bodybuildingId, Description = "" },                                    // index => 86
                new Workout{ Name = "Cable Bayesian Curl", SportId = bodybuildingId, Description = "" },                                            // index => 87
                new Workout{ Name = "Cable High Bayesian Curl", SportId = bodybuildingId, Description = "" },                                       // index => 88

                // biceps // TRX
                new Workout{ Name = "TRX Curl", SportId = crossfitId, Description = "" },                                                           // index => 89
                new Workout{ Name = "TRX Hammer Curl", SportId = crossfitId, Description = "" },                                                    // index => 90
                new Workout{ Name = "TRX Reverse Curl", SportId = crossfitId, Description = "" },                                                   // index => 91
                new Workout{ Name = "TRX Rotating Row", SportId = crossfitId, Description = "" },                                                   // index => 92
                new Workout{ Name = "TRX Single Arm row", SportId = crossfitId, Description = "" },                                                 // index => 93

                #region Others
                new Workout{ Name = "Kettlebell Goblet Curl", SportId = 1, Description = "" }, // index => 3
                new Workout{ Name = "Kettlebell Concentration Curl", SportId = 1, Description = "" }, // index => 4
                new Workout{ Name = "Kettlebell Preacher Curl", SportId = 1, Description = "" }, // index => 5
                new Workout{ Name = "Kettlebell Single Arm Curl", SportId = 1, Description = "" }, // index => 6
                new Workout{ Name = "Band Bayesian Curl", SportId = 1, Description = "" }, // index => 16
                new Workout{ Name = "Band Bayesian Hammer Curl", SportId = 1, Description = "" }, // index => 17
                new Workout{ Name = "Band Bayesian Reverse Curl", SportId = 1, Description = "" }, // index => 18
                new Workout{ Name = "Band High Curl", SportId = 1, Description = "" }, // index => 32
                new Workout{ Name = "Band High Hammer Curl", SportId = 1, Description = "" }, // index => 34
                new Workout{ Name = "Band High Reverse Curl", SportId = 1, Description = "" }, // index => 35
                new Workout{ Name = "Band Curl", SportId = 1, Description = "" }, // index => 36
                new Workout{ Name = "Band Reverse Curl", SportId = 1, Description = "" }, // index => 37
                new Workout{ Name = "Chin Ups", SportId = 1, Description = "" }, // index => 43
                new Workout{ Name = "Band Kneeling Single Arm Pulldown", SportId = 1, Description = "" }, // index => 44
                new Workout{ Name = "Corpse Pose", SportId = 1, Description = "" }, // index => 62
                new Workout{ Name = "Crow Pose", SportId = 1, Description = "" }, // index => 63
                new Workout{ Name = "Downward Dog", SportId = 1, Description = "" }, // index => 64
                new Workout{ Name = "Downward Dog With Fingers Facing Feet", SportId = 1, Description = "" }, // index => 65
                new Workout{ Name = "Scorpion Twist Pose", SportId = 1, Description = "" }, // index => 66
                new Workout{ Name = "Seated Arm Stretch", SportId = 1, Description = "" }, // index => 67
                new Workout{ Name = "Vitruvian Hammer Curl", SportId = 1, Description = "" }, // index => 72
                new Workout{ Name = "Vitruvian Row", SportId = 1, Description = "" }, // index => 73
                new Workout{ Name = "Vitruvian Single Arm Row", SportId = 1, Description = "" }, // index => 74
                new Workout{ Name = "Kettlebell Alternating Row", SportId = 1, Description = "" }, // index => 75
                new Workout{ Name = "Kettlebell Curl", SportId = 1, Description = "" }, // index => 76
                new Workout{ Name = "Kettlebell Gorilla Row", SportId = 1, Description = "" }, // index => 77
                new Workout{ Name = "Kettlebell Reverse Curl", SportId = 1, Description = "" }, // index => 78
                new Workout{ Name = "Kettlebell Row", SportId = 1, Description = "" }, // index => 79
                new Workout{ Name = "Kettlebell Single Arm Reverse Curl", SportId = 1, Description = "" }, // index => 96
                new Workout{ Name = "Kettlebell Single Arm Row On Bench", SportId = 1, Description = "" }, // index => 97
                new Workout{ Name = "Cardio Band Hammer Curl Jacks", SportId = 1, Description = "" }, // index => 101
                new Workout{ Name = "Band Row", SportId = 1, Description = "" }, // index => 105
                new Workout{ Name = "Kettlebell Row (Single)", SportId = 1, Description = "" }, // index => 106
                new Workout{ Name = "Kettlebell Single Arm Row", SportId = 1, Description = "" }, // index => 107
                new Workout{ Name = "Kettlebell Rear Delt Row", SportId = 1, Description = "" }, // index => 109
                new Workout{ Name = "Kettlebell Rear Delt Row (Double)", SportId = 1, Description = "" }, // index => 101
                new Workout{ Name = "Core Stability 2 Opposite Shoulder Tap 4Pt Position", SportId = 1, Description = "" }, // index => 104
                new Workout{ Name = "Cardio Row Erg Rower", SportId = 1, Description = "" }, // index => 105
                new Workout{ Name = "Cardio Row Erg Rower Arms Only", SportId = 1, Description = "" }, // index => 106
                new Workout{ Name = "Cardio Row Erg Rower Four Stroke Sprint Start", SportId = 1, Description = "" }, // index => 107
                new Workout{ Name = "Bodyweight Assisted Chin Up", SportId = 1, Description = "" }, // index => 116
                new Workout{ Name = "Bodyweight Assisted Gironda Chin Up", SportId = 1, Description = "" }, // index => 117
                new Workout{ Name = "Bodyweight Assisted Mixed Grip Pullup", SportId = 1, Description = "" }, // index => 118
                new Workout{ Name = "Bodyweight Assisted Pull Up", SportId = 1, Description = "" }, // index => 119
                new Workout{ Name = "Bodyweight Inverted Curl", SportId = 1, Description = "" }, // index => 120
                new Workout{ Name = "Bodyweight Close Grip Inverted Curl", SportId = 1, Description = "" }, // index => 121
                new Workout{ Name = "Bodyweight Concentration Curl", SportId = 1, Description = "" }, // index => 122
                new Workout{ Name = "Bodyweight Underhand Inverted Row", SportId = 1, Description = "" }, // index => 123
                new Workout{ Name = "Ring Row", SportId = 1, Description = "" }, // index => 124
                new Workout{ Name = "Ring Curl", SportId = 1, Description = "" }, // index => 125
                new Workout{ Name = "Dumbbell Service Exercise", SportId = 1, Description = "" }, // index => 127
                new Workout{ Name = "Seated Ulnar Nerve Slider", SportId = 1, Description = "" }, // index => 128
                new Workout{ Name = "Seated Ulnar Nerve Tensioner", SportId = 1, Description = "" }, // index => 129
                new Workout{ Name = "L Sit Chin Up", SportId = 1, Description = "" }, // index => 132
                new Workout{ Name = "Band Squat Hold Row", SportId = 1, Description = "" }, // index => 133
                new Workout{ Name = "Band Squat Hold Single Arm Row", SportId = 1, Description = "" }, // index => 134
                new Workout{ Name = "Band Single Arm Row", SportId = 1, Description = "" }, // index => 135
                new Workout{ Name = "Band Single Arm Pulldown", SportId = 1, Description = "" }, // index => 136
	            #endregion
            };
        };

        var workoutInstruction = new List<WorkoutInstruction>();
        if (!await context.WorkoutInstructions.AnyAsync())
        {
            workoutInstruction = new List<WorkoutInstruction>
            {
                #region Biceps & Barbell
                new WorkoutInstruction{ WorkoutId = workouts[0].Id , Step = 1 , Instruction = "While holding the upper arms stationary, curl the weights forward while contracting the biceps as you breathe out."},
                new WorkoutInstruction{ WorkoutId = workouts[0].Id , Step = 2 , Instruction = "Continue the movement until your biceps are fully contracted and the bar is at shoulder level."},
                new WorkoutInstruction{ WorkoutId = workouts[0].Id , Step = 3 , Instruction = "Hold the contracted position for a second and squeeze the biceps hard."},
                new WorkoutInstruction{ WorkoutId = workouts[0].Id , Step = 4 , Instruction = "Slowly bring the weight back down to the starting position."},

                new WorkoutInstruction{ WorkoutId = workouts[1].Id , Step = 1 , Instruction = "Take a double overhand grip that's about shoulder width. Flex your elbows while keeping your elbows tucked in. Try not to let them flare out."},
                new WorkoutInstruction{ WorkoutId = workouts[1].Id , Step = 2 , Instruction = "Curl until your forearm presses into your bicep. Then fully extend your elbows at the bottom of each rep."},

                new WorkoutInstruction{ WorkoutId = workouts[2].Id , Step = 1 , Instruction = "Position a barbell in a landmine or corner of a room and stand facing it with your feet shoulder-width apart."},
                new WorkoutInstruction{ WorkoutId = workouts[2].Id , Step = 2 , Instruction = "Grasp the end of the barbell with a neutral grip, keeping your arms straight and your shoulders relaxed."},
                new WorkoutInstruction{ WorkoutId = workouts[2].Id , Step = 3 , Instruction = "Bend at the hips and knees to lower your torso until it is almost parallel to the ground."},
                new WorkoutInstruction{ WorkoutId = workouts[2].Id , Step = 4 , Instruction = "Pull the barbell towards your chest, squeezing your shoulder blades together as you row the weight up."},

                new WorkoutInstruction{ WorkoutId = workouts[3].Id , Step = 1 , Instruction = "Position a barbell in a landmine or corner of a room and stand facing it with your feet shoulder-width apart."},
                new WorkoutInstruction{ WorkoutId = workouts[3].Id , Step = 2 , Instruction = "Grasp the end of the barbell with an overhand grip, keeping your arms straight and your shoulders relaxed."},
                new WorkoutInstruction{ WorkoutId = workouts[3].Id , Step = 3 , Instruction = "Bend at the hips and knees to lower your torso until it is almost parallel to the ground."},
                new WorkoutInstruction{ WorkoutId = workouts[3].Id , Step = 4 , Instruction = "Pull the barbell towards your chest, squeezing your shoulder blades together as you row the weight up."},

                new WorkoutInstruction{ WorkoutId = workouts[4].Id , Step = 1 , Instruction = "Position a barbell in a landmine or corner of a room and stand facing sideways with a staggered stance and your feet shoulder-width apart."},
                new WorkoutInstruction{ WorkoutId = workouts[4].Id , Step = 2 , Instruction = "Grasp the end of the barbell with an overhand grip, keeping your arms straight and your shoulders relaxed."},
                new WorkoutInstruction{ WorkoutId = workouts[4].Id , Step = 3 , Instruction = "Bend at the hips and knees to lower your torso until it is almost parallel to the ground."},
                new WorkoutInstruction{ WorkoutId = workouts[4].Id , Step = 4 , Instruction = "Pull the barbell towards your chest, squeezing your shoulder blades together as you row the weight up."},
                new WorkoutInstruction{ WorkoutId = workouts[4].Id , Step = 5 , Instruction = "*Named after the late John Meadows"},

                new WorkoutInstruction{ WorkoutId = workouts[5].Id , Step = 1 , Instruction = "Start hinged forward with a flat back and the plates resting on the floor. Make sure your elbows are fully extended."},
                new WorkoutInstruction{ WorkoutId = workouts[5].Id , Step = 2 , Instruction = "Pull the bar to your sternum."},
                new WorkoutInstruction{ WorkoutId = workouts[5].Id , Step = 3 , Instruction = "Return the plates back to the floor and let the bar come to a full dead stop."},
                new WorkoutInstruction{ WorkoutId = workouts[5].Id , Step = 4 , Instruction = "Then initiate the next rep."},

                new WorkoutInstruction{ WorkoutId = workouts[6].Id , Step = 1 , Instruction = "Grab the barbell with an overhand grip. Hinge forward while keeping your back flat until your torso is about parallel with the ground."},
                new WorkoutInstruction{ WorkoutId = workouts[6].Id , Step = 2 , Instruction = "Let your arms hang freely."},
                new WorkoutInstruction{ WorkoutId = workouts[6].Id , Step = 3 , Instruction = "Pull the bar to your torso while tucking your elbows in slightly."},
                new WorkoutInstruction{ WorkoutId = workouts[6].Id , Step = 4 , Instruction = "Extend your elbows fully before initiating the next rep."},

                new WorkoutInstruction{ WorkoutId = workouts[7].Id , Step = 1 , Instruction = "Begin by standing in front of a barbell with your feet about hip-width apart and your palms facing towards your body."},
                new WorkoutInstruction{ WorkoutId = workouts[7].Id , Step = 2 , Instruction = "Bend at the hips and knees to grab the barbell with a pronated (overhand) grip, positioning the barbell about an inch away from your shins."},
                new WorkoutInstruction{ WorkoutId = workouts[7].Id , Step = 3 , Instruction = "Keeping your back straight and your core engaged, use your back muscles to lift the barbell straight up towards your chest."},
                new WorkoutInstruction{ WorkoutId = workouts[7].Id , Step = 4 , Instruction = "As the barbell reaches your chest, rotate your wrists so that your palms are facing towards your body (supinated grip), and then lower the barbell back to the starting position."},

                new WorkoutInstruction{ WorkoutId = workouts[8].Id , Step = 1 , Instruction = "Begin by standing in front of a barbell with your feet about hip-width apart."},
                new WorkoutInstruction{ WorkoutId = workouts[8].Id , Step = 2 , Instruction = "Bend at the hips and knees to grab the barbell with a supinated (underhand) grip, positioning the barbell about an inch away from your shins."},
                new WorkoutInstruction{ WorkoutId = workouts[8].Id , Step = 3 , Instruction = "Keeping your back straight and your core engaged, use your back muscles to lift the barbell straight up towards your chest."},
                new WorkoutInstruction{ WorkoutId = workouts[8].Id , Step = 4 , Instruction = "As the barbell reaches your chest, pause briefly, and then lower the barbell back to the starting position."},

                new WorkoutInstruction{ WorkoutId = workouts[9].Id , Step = 1 , Instruction = "Stand beside the landmine with your feet shoulder-width apart while grasping the end of the landmine barbell with the hand farther away from the landmine attachment, palm facing up and your elbow close to your side."},
                new WorkoutInstruction{ WorkoutId = workouts[9].Id , Step = 2 , Instruction = "Curl the barbell up towards your opposite shoulder, contracting your bicep muscles, then slowly lower the barbell back down."},
                new WorkoutInstruction{ WorkoutId = workouts[9].Id , Step = 3 , Instruction = "Repeat for the desired number of reps before switching sides."},

                new WorkoutInstruction{ WorkoutId = workouts[10].Id , Step = 1 , Instruction = "Start on one knee facing the landmine, holding the end of the barbell with your hand on the side of your forward leg."},
                new WorkoutInstruction{ WorkoutId = workouts[10].Id , Step = 2 , Instruction = "While keeping your elbow braced against the inside of your knee, curl the barbell upward towards your shoulder, then lower it back down with control."},
                new WorkoutInstruction{ WorkoutId = workouts[10].Id , Step = 3 , Instruction = "Repeat for the desired number of reps before switching sides."},

                new WorkoutInstruction{ WorkoutId = workouts[11].Id , Step = 1 , Instruction = "Grab a barbell with an underhand grip."},
                new WorkoutInstruction{ WorkoutId = workouts[11].Id , Step = 2 , Instruction = "Pull your elbows straight back and let the bar drag against your upper body (or very close to it)."},

                new WorkoutInstruction{ WorkoutId = workouts[12].Id , Step = 1 , Instruction = "Grab a v bar and place it under the bar's collar."},
                new WorkoutInstruction{ WorkoutId = workouts[12].Id , Step = 2 , Instruction = "Hinge forward with a flat back and pull your elbows straight back toward the ceiling."},
                new WorkoutInstruction{ WorkoutId = workouts[12].Id , Step = 3 , Instruction = "Fully extend your elbows before initiating the next rep."},

                new WorkoutInstruction{ WorkoutId = workouts[13].Id , Step = 1 , Instruction = "Grab a barbell with a shoulder width pronated or supinated grip."},
                new WorkoutInstruction{ WorkoutId = workouts[13].Id , Step = 2 , Instruction = "Bend forward at your hips while maintaining a flat back."},
                new WorkoutInstruction{ WorkoutId = workouts[13].Id , Step = 3 , Instruction = "Pull the weight toward your upper abdomen."},
                new WorkoutInstruction{ WorkoutId = workouts[13].Id , Step = 4 , Instruction = "Lower the weight in a controlled manner and repeat."},

                new WorkoutInstruction{ WorkoutId = workouts[14].Id , Step = 1 , Instruction = "Position yourself on preacher bench; grasp EZ bar with underhand grip, elbows extended."},
                new WorkoutInstruction{ WorkoutId = workouts[14].Id , Step = 2 , Instruction = "Slowly curl bar towards shoulders; keep upper arms stationary, focus on biceps."},
                new WorkoutInstruction{ WorkoutId = workouts[14].Id , Step = 3 , Instruction = "Lower bar back to starting position; maintain control, repeat for reps."},

                new WorkoutInstruction{ WorkoutId = workouts[15].Id , Step = 1 , Instruction = "Sit on preacher bench, grip EZ bar overhand at shoulder width, elbows resting on pad."},
                new WorkoutInstruction{ WorkoutId = workouts[15].Id , Step = 2 , Instruction = "Curl bar towards chin, keep elbows stable."},
                new WorkoutInstruction{ WorkoutId = workouts[15].Id , Step = 3 , Instruction = "Lower bar slowly to starting position, maintaining control throughout."},
                #endregion

                #region biceps & Machine
                new WorkoutInstruction{ WorkoutId = workouts[16].Id , Step = 1 , Instruction = "Sit with your back straight on the machine and grip the handles." },
                new WorkoutInstruction{ WorkoutId = workouts[16].Id , Step = 2 , Instruction = "Pull the handles back using your arms. Your legs and torso should be at a 90° angle. Push out your chest." },
                new WorkoutInstruction{ WorkoutId = workouts[16].Id , Step = 3 , Instruction = "Pull the handles towards your body until your hands are beside your abdomen." },

                new WorkoutInstruction{ WorkoutId = workouts[17].Id , Step = 1 , Instruction = "Use the Straight Bar attachment." },
                new WorkoutInstruction{ WorkoutId = workouts[17].Id , Step = 2 , Instruction = "Hold the attachment as you sit on the machine and put your legs under the leg pads." },
                new WorkoutInstruction{ WorkoutId = workouts[17].Id , Step = 3 , Instruction = "Pull the bar to your clavicle, then raise back up until your arm are extended." },

                new WorkoutInstruction{ WorkoutId = workouts[18].Id , Step = 1 , Instruction = "Use the V Bar attachment." },
                new WorkoutInstruction{ WorkoutId = workouts[18].Id , Step = 2 , Instruction = "Hold the attachment as you sit on the machine and put your legs under the leg pads." },
                new WorkoutInstruction{ WorkoutId = workouts[18].Id , Step = 3 , Instruction = "Pull the bar to your clavicle, then raise back up until your arm are extended." },

                new WorkoutInstruction{ WorkoutId = workouts[19].Id , Step = 1 , Instruction = "Use the Straight Bar attachment. Hold with an underhand grip." },
                new WorkoutInstruction{ WorkoutId = workouts[19].Id , Step = 2 , Instruction = "Hold the attachment as you sit on the machine and put your legs under the leg pads." },
                new WorkoutInstruction{ WorkoutId = workouts[19].Id , Step = 3 , Instruction = "Pull the bar to your clavicle, then raise back up until your arm are extended." },

                new WorkoutInstruction{ WorkoutId = workouts[20].Id , Step = 1 , Instruction = "Adjust weight for assistance. Stand on platform, grip handles above shoulder-width. Knees on pad if available." },
                new WorkoutInstruction{ WorkoutId = workouts[20].Id , Step = 2 , Instruction = "Slowly pull up until chin is above the bar. Keep elbows close, core engaged." },
                new WorkoutInstruction{ WorkoutId = workouts[20].Id , Step = 3 , Instruction = "Lower back with control. Pause at bottom. Repeat for reps." },

                new WorkoutInstruction{ WorkoutId = workouts[21].Id , Step = 1 , Instruction = "Adjust weight for assistance. Stand on platform, grip handles above shoulder-width. Knees on pad if available." },
                new WorkoutInstruction{ WorkoutId = workouts[21].Id , Step = 2 , Instruction = "Slowly pull up until chin is above the bar. Keep elbows close, core engaged." },
                new WorkoutInstruction{ WorkoutId = workouts[21].Id , Step = 3 , Instruction = "Lower back with control. Pause at bottom. Repeat for reps." },

                new WorkoutInstruction{ WorkoutId = workouts[22].Id , Step = 1 , Instruction = "Adjust weight for assistance. Stand on platform, grip handles above shoulder-width. Knees on pad if available." },
                new WorkoutInstruction{ WorkoutId = workouts[22].Id , Step = 2 , Instruction = "Slowly pull up until chin is above the bar. Keep elbows close, core engaged." },
                new WorkoutInstruction{ WorkoutId = workouts[22].Id , Step = 3 , Instruction = "Lower back with control. Pause at bottom. Repeat for reps." },

                new WorkoutInstruction{ WorkoutId = workouts[23].Id , Step = 1 , Instruction = "Adjust weight for assistance. Stand on platform, grip handles above shoulder-width. Knees on pad if available." },
                new WorkoutInstruction{ WorkoutId = workouts[23].Id , Step = 2 , Instruction = "Slowly pull up until chin is above the bar. Keep elbows close, core engaged." },
                new WorkoutInstruction{ WorkoutId = workouts[23].Id , Step = 3 , Instruction = "Lower back with control. Pause at bottom. Repeat for reps." },

                new WorkoutInstruction{ WorkoutId = workouts[24].Id , Step = 1 , Instruction = "Sit on the machine, feet flat, and grab the handles with palms facing up, keeping your back straight." },
                new WorkoutInstruction{ WorkoutId = workouts[24].Id , Step = 2 , Instruction = "Pull handles towards your lower abdomen, squeezing your shoulder blades together. Keep elbows close to your body." },
                new WorkoutInstruction{ WorkoutId = workouts[24].Id , Step = 3 , Instruction = "Slowly return to the starting position, fully extending your arms without locking elbows. Repeat for desired reps." },

                new WorkoutInstruction{ WorkoutId = workouts[25].Id , Step = 1 , Instruction = "Grip the handles with the palms facing down." },
                new WorkoutInstruction{ WorkoutId = workouts[25].Id , Step = 2 , Instruction = "Sit on the machine and press your knees into the knee pad." },
                new WorkoutInstruction{ WorkoutId = workouts[25].Id , Step = 3 , Instruction = "Pull the handles until your upper arm is even with your torso, or just behind your torso." },
                new WorkoutInstruction{ WorkoutId = workouts[25].Id , Step = 4 , Instruction = "Extend until your elbows are fully extended before initiating the next rep." },

                new WorkoutInstruction{ WorkoutId = workouts[26].Id , Step = 1 , Instruction = "Rest the back of your arms on the preacher bench." },
                new WorkoutInstruction{ WorkoutId = workouts[26].Id , Step = 2 , Instruction = "Grab the handles. Curl the weight up until your elbows are fully flexed." },
                new WorkoutInstruction{ WorkoutId = workouts[26].Id , Step = 3 , Instruction = "Lower until the point just before the weight rests at the bottom." },

                new WorkoutInstruction{ WorkoutId = workouts[27].Id , Step = 1 , Instruction = "Sit at the bench and rest the back of your arms on the preacher bench." },
                new WorkoutInstruction{ WorkoutId = workouts[27].Id , Step = 2 , Instruction = "Grab the handles. Curl the weight up until your elbows are fully flexed." },
                new WorkoutInstruction{ WorkoutId = workouts[27].Id , Step = 3 , Instruction = "Lower until the point just before the weight rests at the bottom." },

                new WorkoutInstruction{ WorkoutId = workouts[28].Id , Step = 1 , Instruction = "Adjust the seat to fit your height and place your elbows on the elbow pad." },
                new WorkoutInstruction{ WorkoutId = workouts[28].Id , Step = 2 , Instruction = "Grab the handles and flex your elbows." },
                #endregion

                #region biceps & stretches
                new WorkoutInstruction{ WorkoutId = workouts[29].Id , Step = 1 , Instruction = "Stand upright with your feet shoulder width apart." },
                new WorkoutInstruction{ WorkoutId = workouts[29].Id , Step = 2 , Instruction = "Raise your arms out to your sides, bringing them up to shoulder level." },
                new WorkoutInstruction{ WorkoutId = workouts[29].Id , Step = 3 , Instruction = "Rotate your palms so they are facing the ceiling." },
                new WorkoutInstruction{ WorkoutId = workouts[29].Id , Step = 4 , Instruction = "Then, change direction and rotate the arms as much as you can." },

                new WorkoutInstruction{ WorkoutId = workouts[30].Id , Step = 1 , Instruction = "Stand an arms width away from the wall." },
                new WorkoutInstruction{ WorkoutId = workouts[30].Id , Step = 2 , Instruction = "Raise your arms out behind you, and place them on the wall with your fingers pointing up." },
                new WorkoutInstruction{ WorkoutId = workouts[30].Id , Step = 3 , Instruction = "Bend your knees whilst keeping your hands in the same position." },

                new WorkoutInstruction{ WorkoutId = workouts[31].Id , Step = 1 , Instruction = "Bend your arm at the elbow, raising your hand to your shoulder." },
                new WorkoutInstruction{ WorkoutId = workouts[31].Id , Step = 2 , Instruction = "Using your other hand, stretch the arm down to its full extent." },

                new WorkoutInstruction{ WorkoutId = workouts[32].Id , Step = 1 , Instruction = "Stand facing the wall, an arm's width away." },
                new WorkoutInstruction{ WorkoutId = workouts[32].Id , Step = 2 , Instruction = "Place your hand on the wall with your fingers pointing down." },
                new WorkoutInstruction{ WorkoutId = workouts[32].Id , Step = 3 , Instruction = "Lean slightly into the wall to feel the stretch in your bicep." },

                new WorkoutInstruction{ WorkoutId = workouts[33].Id , Step = 1 , Instruction = "Stand one foot in front of the other with the wall to your right, an arms width away." },
                new WorkoutInstruction{ WorkoutId = workouts[33].Id , Step = 2 , Instruction = "Place your hand on the wall, fingers pointing away from you." },
                new WorkoutInstruction{ WorkoutId = workouts[33].Id , Step = 3 , Instruction = "Gently lean forward, keeping your hand stationary." },
                new WorkoutInstruction{ WorkoutId = workouts[33].Id , Step = 4 , Instruction = "Repeat with the other arm." },
                #endregion

                #region biceps & plate
                new WorkoutInstruction{ WorkoutId = workouts[34].Id , Step = 1 , Instruction = "" },

                new WorkoutInstruction{ WorkoutId = workouts[35].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart and the plate in front of the torso, palms facing forward." },
                new WorkoutInstruction{ WorkoutId = workouts[35].Id , Step = 2 , Instruction = "Curl the plate up to the front of the shoulder while keeping the elbows close to the body." },
                new WorkoutInstruction{ WorkoutId = workouts[35].Id , Step = 3 , Instruction = "Rotate the palms to face forward and press the plate overhead, locking out the arms." },
                new WorkoutInstruction{ WorkoutId = workouts[35].Id , Step = 4 , Instruction = "Lower the plate back to the starting position, keeping control of it, and repeat for desired reps." },

                new WorkoutInstruction{ WorkoutId = workouts[36].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart and the plate in front of the torso, palms facing forward." },
                new WorkoutInstruction{ WorkoutId = workouts[36].Id , Step = 2 , Instruction = "Curl the plate up to the front of the shoulder while keeping the elbows close to the body." },
                new WorkoutInstruction{ WorkoutId = workouts[36].Id , Step = 3 , Instruction = "Rotate the palms to face forward and press the plate overhead, locking out the arms." },
                new WorkoutInstruction{ WorkoutId = workouts[36].Id , Step = 4 , Instruction = "Lower the plate back behind the head to the starting position of a tricep extension." },
                new WorkoutInstruction{ WorkoutId = workouts[36].Id , Step = 5 , Instruction = "Push the plate back up overhead, then lower it back to the starting position and repeat for desired reps." },

                new WorkoutInstruction{ WorkoutId = workouts[37].Id , Step = 1 , Instruction = "Lower into a squat position, keeping the plate at chest height." },
                new WorkoutInstruction{ WorkoutId = workouts[37].Id , Step = 2 , Instruction = "Slowly curl the plate towards your shoulders, keeping your elbows close to your body." },
                new WorkoutInstruction{ WorkoutId = workouts[37].Id , Step = 3 , Instruction = "Hold for a moment at the top of the curl before lowering the plate back to chest height." },
                new WorkoutInstruction{ WorkoutId = workouts[37].Id , Step = 4 , Instruction = "Repeat the curls as you hold the squat position." },

                new WorkoutInstruction{ WorkoutId = workouts[38].Id , Step = 1 , Instruction = "Make sure to keep your elbow close to your body and your core engaged throughout the movement." },
                new WorkoutInstruction{ WorkoutId = workouts[38].Id , Step = 2 , Instruction = "Bend forward at your hips while maintaining a flat back." },
                new WorkoutInstruction{ WorkoutId = workouts[38].Id , Step = 3 , Instruction = "Pull the plate toward your upper abdomen." },
                new WorkoutInstruction{ WorkoutId = workouts[38].Id , Step = 4 , Instruction = "Lower the weight in a controlled manner and repeat." },

                new WorkoutInstruction{ WorkoutId = workouts[39].Id , Step = 1 , Instruction = "Grab the bar shoulder width apart with a supinated grip (palms facing you). Use a dip belt and the let the weight hang between your legs." },
                new WorkoutInstruction{ WorkoutId = workouts[39].Id , Step = 2 , Instruction = "With your body hanging and arms fully extended, pull yourself up until your chin is past the bar." },
                new WorkoutInstruction{ WorkoutId = workouts[39].Id , Step = 3 , Instruction = "Slowly return to starting position. Repeat." },
                #endregion

                #region Bosu ball
                new WorkoutInstruction{ WorkoutId = workouts[40].Id , Step = 1 , Instruction = "Hold the bosu vertically." },
                new WorkoutInstruction{ WorkoutId = workouts[40].Id , Step = 2 , Instruction = "Flex your elbows curling the bosu toward your chin." },

                new WorkoutInstruction{ WorkoutId = workouts[41].Id , Step = 1 , Instruction = "Hold bosu and hinge forward." },
                new WorkoutInstruction{ WorkoutId = workouts[41].Id , Step = 2 , Instruction = "Pull bosu towards chest, squeezing shoulder blades." },
                #endregion

                #region smith machine
                new WorkoutInstruction{ WorkoutId = workouts[42].Id , Step = 1 , Instruction = "Grab the bar with an underhand grip." },
                new WorkoutInstruction{ WorkoutId = workouts[42].Id , Step = 2 , Instruction = "Pull your elbows straight back and let the bar drag against your upper body (or very close to it)." },

                new WorkoutInstruction{ WorkoutId = workouts[43].Id , Step = 1 , Instruction = "Begin by standing in front of a bar with your feet about hip-width apart." },
                new WorkoutInstruction{ WorkoutId = workouts[43].Id , Step = 2 , Instruction = "Bend at the hips and knees to grab the bar with a supinated (underhand) grip, positioning the bar about an inch away from your shins." },
                new WorkoutInstruction{ WorkoutId = workouts[43].Id , Step = 3 , Instruction = "Keeping your back straight and your core engaged, use your back muscles to lift the bar straight up towards your chest." },
                new WorkoutInstruction{ WorkoutId = workouts[43].Id , Step = 4 , Instruction = "As the bar reaches your chest, pause briefly, and then lower the bar back to the starting position." },

                new WorkoutInstruction{ WorkoutId = workouts[44].Id , Step = 1 , Instruction = "Start hinged forward with a flat back. Make sure your elbows are fully extended." },
                new WorkoutInstruction{ WorkoutId = workouts[44].Id , Step = 2 , Instruction = "Pull the bar to your sternum." },

                #endregion

                #region dumbell
                new WorkoutInstruction{ WorkoutId = workouts[45].Id , Step = 1 , Instruction = "Stand up straight with a dumbbell in each hand at arm's length." },
                new WorkoutInstruction{ WorkoutId = workouts[45].Id , Step = 2 , Instruction = "Raise one dumbbell and twist your forearm until it is vertical and your palm faces the shoulder." },
                new WorkoutInstruction{ WorkoutId = workouts[45].Id , Step = 3 , Instruction = "Lower to original position and repeat with opposite arm" },

                new WorkoutInstruction{ WorkoutId = workouts[46].Id , Step = 1 , Instruction = "Hold the dumbbells with a neutral grip (thumbs facing the ceiling)." },
                new WorkoutInstruction{ WorkoutId = workouts[46].Id , Step = 2 , Instruction = "Slowly lift the dumbbell up to chest height." },
                new WorkoutInstruction{ WorkoutId = workouts[46].Id , Step = 3 , Instruction = "Return to starting position and repeat." },

                new WorkoutInstruction{ WorkoutId = workouts[47].Id , Step = 1 , Instruction = "Grab the dumbbells with a pronated (overhand) grip. You can do this exercise thumbless if it's more comfortable on your wrists." },
                new WorkoutInstruction{ WorkoutId = workouts[47].Id , Step = 2 , Instruction = "Flex at the elbows until your biceps touch your forearms. Try not to let your elbows flair outward." },

                new WorkoutInstruction{ WorkoutId = workouts[48].Id , Step = 1 , Instruction = "Hold the dumbbells with a neutral grip (thumbs facing the ceiling). Seated on an incline bench." },
                new WorkoutInstruction{ WorkoutId = workouts[48].Id , Step = 2 , Instruction = "Slowly lift the dumbbell up to chest height." },
                new WorkoutInstruction{ WorkoutId = workouts[48].Id , Step = 3 , Instruction = "Return to starting position and repeat." },

                new WorkoutInstruction{ WorkoutId = workouts[49].Id , Step = 1 , Instruction = "Lay on an incline bench." },
                new WorkoutInstruction{ WorkoutId = workouts[49].Id , Step = 2 , Instruction = "Grab the dumbbells with a pronated (overhand) grip. You can do this exercise thumbless if it's more comfortable on your wrists." },
                new WorkoutInstruction{ WorkoutId = workouts[49].Id , Step = 3 , Instruction = "Flex at the elbows until your biceps touch your forearms. Try not to let your elbows flair outward." },

                new WorkoutInstruction{ WorkoutId = workouts[50].Id , Step = 1 , Instruction = "Lay on an incline bench with your palms facing forward." },
                new WorkoutInstruction{ WorkoutId = workouts[50].Id , Step = 2 , Instruction = "Flex at the elbows until your forearms touch your biceps." },
                new WorkoutInstruction{ WorkoutId = workouts[50].Id , Step = 3 , Instruction = "When you hit the top of the movement, rotate your palms and then lower the dumbbells slowly." },

                new WorkoutInstruction{ WorkoutId = workouts[51].Id , Step = 1 , Instruction = "Start with a with a dumbbell in one hand and your elbow resting on the bench." },
                new WorkoutInstruction{ WorkoutId = workouts[51].Id , Step = 2 , Instruction = "From this starting position, curl the dumbbell up towards your shoulder, keeping your upper arm stationary on the bench." },

                new WorkoutInstruction{ WorkoutId = workouts[52].Id , Step = 1 , Instruction = "Lay on an incline or preacher curl bench." },
                new WorkoutInstruction{ WorkoutId = workouts[52].Id , Step = 2 , Instruction = "Let your arms hang freely off the edge of the bench." },
                new WorkoutInstruction{ WorkoutId = workouts[52].Id , Step = 3 , Instruction = "Fully flex your elbow and fully extend your elbow on each rep." },

                new WorkoutInstruction{ WorkoutId = workouts[53].Id , Step = 1 , Instruction = "Start by placing your forearms on a flat bench and holding a dumbbell in each hand." },
                new WorkoutInstruction{ WorkoutId = workouts[53].Id , Step = 2 , Instruction = "From this starting position, curl the dumbbells up towards your shoulders, keeping your elbows close to your body and your core engaged." },
                new WorkoutInstruction{ WorkoutId = workouts[53].Id , Step = 3 , Instruction = "Slowly lower the dumbbells back down to the starting position, and repeat for the desired number of repetitions." },

                new WorkoutInstruction{ WorkoutId = workouts[54].Id , Step = 1 , Instruction = "Start by standing with your feet shoulder-width apart and holding a dumbbell in each hand." },
                new WorkoutInstruction{ WorkoutId = workouts[54].Id , Step = 2 , Instruction = "Bring the dumbbells to your sides, with your palms facing inward and your elbows bent." },
                new WorkoutInstruction{ WorkoutId = workouts[54].Id , Step = 3 , Instruction = "From this starting position, curl the dumbbells up towards your shoulders while rotating your wrists so that your palms face your shoulders at the top of the movement." },

                new WorkoutInstruction{ WorkoutId = workouts[55].Id , Step = 1 , Instruction = "Sit on a flat bench with your feet flat on the floor and your back straight." },
                new WorkoutInstruction{ WorkoutId = workouts[55].Id , Step = 2 , Instruction = "Lean forward and place your elbow on the inside of your leg." },
                new WorkoutInstruction{ WorkoutId = workouts[55].Id , Step = 3 , Instruction = "Curl the dumbbell while keeping your elbow against your leg. Make sure to fully extend your elbow on each rep." },

                new WorkoutInstruction{ WorkoutId = workouts[56].Id , Step = 1 , Instruction = "The dumbbells should be set on the ground. Hinge forward while keeping a flat back." },
                new WorkoutInstruction{ WorkoutId = workouts[56].Id , Step = 2 , Instruction = "Pull one elbow back toward the ceiling and then return the dumbbell to the ground softly." },
                new WorkoutInstruction{ WorkoutId = workouts[56].Id , Step = 3 , Instruction = "Then pull with the other arm." },

                new WorkoutInstruction{ WorkoutId = workouts[57].Id , Step = 1 , Instruction = "Place one hand and one knee on a bench. Make sure you keep a flat back." },
                new WorkoutInstruction{ WorkoutId = workouts[57].Id , Step = 2 , Instruction = "Pull the dumbbell toward the ceiling." },
                new WorkoutInstruction{ WorkoutId = workouts[57].Id , Step = 3 , Instruction = "Make sure to avoid any jerking or rotating." },

                new WorkoutInstruction{ WorkoutId = workouts[58].Id , Step = 1 , Instruction = "Lay on an incline bench that is between 30-45 degrees high." },
                new WorkoutInstruction{ WorkoutId = workouts[58].Id , Step = 2 , Instruction = "Let your arms hang freely. Pull your elbows straight back toward the ceiling." },

                new WorkoutInstruction{ WorkoutId = workouts[59].Id , Step = 1 , Instruction = "The dumbbells should be placed on the floor." },
                new WorkoutInstruction{ WorkoutId = workouts[59].Id , Step = 2 , Instruction = "Hinge forward with a flat back and grab the dumbbells." },
                new WorkoutInstruction{ WorkoutId = workouts[59].Id , Step = 3 , Instruction = "Pull both dumbbells back and your elbows toward the ceiling." },
                new WorkoutInstruction{ WorkoutId = workouts[59].Id , Step = 4 , Instruction = "Return the dumbbells back to the floor softly on each rep." },

                new WorkoutInstruction{ WorkoutId = workouts[60].Id , Step = 1 , Instruction = "Start by standing in front of a flat bench with your feet shoulder-width apart and holding a dumbbell in one hand." },
                new WorkoutInstruction{ WorkoutId = workouts[60].Id , Step = 2 , Instruction = "Place your other hand on the bench for support, and bend at the waist so that your chest is parallel to the ground." },
                new WorkoutInstruction{ WorkoutId = workouts[60].Id , Step = 3 , Instruction = "From this starting position, row the dumbbell up towards your chest, squeezing your shoulder blade together as you do so." },
                new WorkoutInstruction{ WorkoutId = workouts[60].Id , Step = 4 , Instruction = "Make sure to keep your elbow close to your body and your core engaged throughout the movement." },

                new WorkoutInstruction{ WorkoutId = workouts[61].Id , Step = 1 , Instruction = "Start by placing your elbow on one knee." },
                new WorkoutInstruction{ WorkoutId = workouts[61].Id , Step = 2 , Instruction = "Hold a dumbbell in your other hand, with your palm facing inwards towards your body." },
                new WorkoutInstruction{ WorkoutId = workouts[61].Id , Step = 3 , Instruction = "From this starting position, row the dumbbell up towards your chest, keeping your elbow close to your body and your core engaged." },

                new WorkoutInstruction{ WorkoutId = workouts[62].Id , Step = 1 , Instruction = "Stand with feet staggered and one hand on a bench/box. Hold a dumbbell in the opposing hand." },
                new WorkoutInstruction{ WorkoutId = workouts[62].Id , Step = 2 , Instruction = "Hinge forward at the hips, keeping the back flat, and eyes facing forward. The weight should hang directly below the shoulders." },
                new WorkoutInstruction{ WorkoutId = workouts[62].Id , Step = 3 , Instruction = "Start with an overhand grip, as you pull rotate the dumbbell. When your upper arm reaches your side your palm should be facing forward." },

                new WorkoutInstruction{ WorkoutId = workouts[63].Id , Step = 1 , Instruction = "Stand with feet staggered and one hand on your knee. Hold a dumbbell in the opposing hand." },
                new WorkoutInstruction{ WorkoutId = workouts[63].Id , Step = 2 , Instruction = "Hinge forward at the hips, keeping the back flat, and eyes facing forward. The weight should hang directly below the shoulders." },
                new WorkoutInstruction{ WorkoutId = workouts[63].Id , Step = 3 , Instruction = "Start with an overhand grip, as you pull rotate the dumbbell. When your upper arm reaches your side your palm should be facing forward." },

                new WorkoutInstruction{ WorkoutId = workouts[64].Id , Step = 1 , Instruction = "Grab both dumbbells and hinge forward at the hips. Make sure you keep a flat back." },
                new WorkoutInstruction{ WorkoutId = workouts[64].Id , Step = 2 , Instruction = "The closer your torso is to parallel with the ground the longer the range of motion will be at your shoulder. The better the results you'll get from the exercise." },
                new WorkoutInstruction{ WorkoutId = workouts[64].Id , Step = 3 , Instruction = "Let your arms hang freely, maintain an underhand grip, and then pull your elbow joint straight back toward the ceiling." },

                new WorkoutInstruction{ WorkoutId = workouts[65].Id , Step = 1 , Instruction = "Hinge forward at the hips while maintaining a flat back. Try to get your torso as close to parallel with the ground as your mobility will allow for." },
                new WorkoutInstruction{ WorkoutId = workouts[65].Id , Step = 2 , Instruction = "Let your arms hang in front of you. Pull your elbows back towards the ceiling while flaring your elbows outward." },

                new WorkoutInstruction{ WorkoutId = workouts[66].Id , Step = 1 , Instruction = "Sit at preacher bench, hold dumbbells in each hand with arm extended, palm facing up." },
                new WorkoutInstruction{ WorkoutId = workouts[66].Id , Step = 2 , Instruction = "Curl dumbbells towards shoulder, keeping upper arm stationary and elbows in." },
                new WorkoutInstruction{ WorkoutId = workouts[66].Id , Step = 3 , Instruction = "Lower dumbbell slowly back to start." },

                new WorkoutInstruction{ WorkoutId = workouts[67].Id , Step = 1 , Instruction = "Hold the dumbbells with an underhand grip. Seated on an incline bench." },
                new WorkoutInstruction{ WorkoutId = workouts[67].Id , Step = 2 , Instruction = "Slowly lift the dumbbell up to chest height." },
                new WorkoutInstruction{ WorkoutId = workouts[67].Id , Step = 3 , Instruction = "Return to starting position and repeat." },

                new WorkoutInstruction{ WorkoutId = workouts[68].Id , Step = 1 , Instruction = "Grab the bar shoulder width apart with a supinated grip (palms facing you). Use a dip belt and the let the weight hang between your legs." },
                new WorkoutInstruction{ WorkoutId = workouts[68].Id , Step = 2 , Instruction = "With your body hanging and arms fully extended, pull yourself up until your chin is past the bar." },
                new WorkoutInstruction{ WorkoutId = workouts[68].Id , Step = 3 , Instruction = "Slowly return to starting position. Repeat." },

                new WorkoutInstruction{ WorkoutId = workouts[69].Id , Step = 1 , Instruction = "Hold the dumbbells with an underhand grip. Seated on a bench." },
                new WorkoutInstruction{ WorkoutId = workouts[69].Id , Step = 2 , Instruction = "Start with the dumbbells pointed toward the ceiling, then lower the dumbbells toward your sides." },
                new WorkoutInstruction{ WorkoutId = workouts[69].Id , Step = 3 , Instruction = "Fully extend your elbows, but don't let your upper arm fall behind your torso." },

                #endregion

                #region Cables
                new WorkoutInstruction{ WorkoutId = workouts[70].Id , Step = 1 , Instruction = "Use a handle attachment set all the way to the top of the cable crossover machine." },
                new WorkoutInstruction{ WorkoutId = workouts[70].Id , Step = 2 , Instruction = "Walk a few steps away from the cable machine. Face your body sideways." },
                new WorkoutInstruction{ WorkoutId = workouts[70].Id , Step = 3 , Instruction = "Face your palm up toward the ceiling. Then pull your elbow in toward your rib cage." },

                new WorkoutInstruction{ WorkoutId = workouts[71].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
                new WorkoutInstruction{ WorkoutId = workouts[71].Id , Step = 2 , Instruction = "Face away from the cable machine. Stagger your stance so you have a better base of support." },
                new WorkoutInstruction{ WorkoutId = workouts[71].Id , Step = 3 , Instruction = "Start with a neutral grip. Flex at the elbow. While flexing twist your palm. When you hit the top of the movement your palm should be facing upward." },

                new WorkoutInstruction{ WorkoutId = workouts[72].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
                new WorkoutInstruction{ WorkoutId = workouts[72].Id , Step = 2 , Instruction = "Face away from the cable machine." },
                new WorkoutInstruction{ WorkoutId = workouts[72].Id , Step = 3 , Instruction = "Stagger your stance so you have a better base of support. Face your palm forward. Flex at the elbow and extend." },

                new WorkoutInstruction{ WorkoutId = workouts[73].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
                new WorkoutInstruction{ WorkoutId = workouts[73].Id , Step = 2 , Instruction = "Face away from the cable machine. Stagger your stance so you have a better base of support." },
                new WorkoutInstruction{ WorkoutId = workouts[73].Id , Step = 3 , Instruction = "Face your palm downwards. Flex at the elbow and extend." },

                new WorkoutInstruction{ WorkoutId = workouts[74].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
                new WorkoutInstruction{ WorkoutId = workouts[74].Id , Step = 2 , Instruction = "Face away from the cable machine. Stagger your stance so you have a better base of support." },
                new WorkoutInstruction{ WorkoutId = workouts[74].Id , Step = 3 , Instruction = "Use a neutral grip thumb facing up pinky-facing down). Flex at the elbow and extend." },

                new WorkoutInstruction{ WorkoutId = workouts[75].Id , Step = 1 , Instruction = "Place the cable at shoulder height. Use a row bar." },
                new WorkoutInstruction{ WorkoutId = workouts[75].Id , Step = 2 , Instruction = "Pull the handles back using your arms. Push out your chest." },
                new WorkoutInstruction{ WorkoutId = workouts[75].Id , Step = 3 , Instruction = "Pull the handles towards your body until your hands are beside your abdomen." },

                new WorkoutInstruction{ WorkoutId = workouts[76].Id , Step = 1 , Instruction = "Place the cable at shoulder height. Use a handle attachment. Face your palm upward." },
                new WorkoutInstruction{ WorkoutId = workouts[76].Id , Step = 2 , Instruction = "Pull the handle back using your arms. Push out your chest." },
                new WorkoutInstruction{ WorkoutId = workouts[76].Id , Step = 3 , Instruction = "Pull the handle towards your body until your hands are beside your abdomen." },

                new WorkoutInstruction{ WorkoutId = workouts[77].Id , Step = 1 , Instruction = "Place the cable at shoulder height. Use a handle attachment. Face your palm toward the midline of your body." },
                new WorkoutInstruction{ WorkoutId = workouts[77].Id , Step = 2 , Instruction = "Pull the handle back using your arms. Push out your chest." },
                new WorkoutInstruction{ WorkoutId = workouts[77].Id , Step = 3 , Instruction = "Pull the handle towards your body until your hands are beside your abdomen." },

                new WorkoutInstruction{ WorkoutId = workouts[78].Id , Step = 1 , Instruction = "Place the cable at shoulder height." },
                new WorkoutInstruction{ WorkoutId = workouts[78].Id , Step = 2 , Instruction = "Start with an overhand grip. As you pull your elbow back, rotate your palm until it faces upward." },

                new WorkoutInstruction{ WorkoutId = workouts[79].Id , Step = 1 , Instruction = "Place the cable at shoulder height." },
                new WorkoutInstruction{ WorkoutId = workouts[79].Id , Step = 2 , Instruction = "On the same side as the working arm, step back and rotate outwards." },
                new WorkoutInstruction{ WorkoutId = workouts[79].Id , Step = 3 , Instruction = "Pull your elbow back while flaring your elbow out." },

                new WorkoutInstruction{ WorkoutId = workouts[80].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
                new WorkoutInstruction{ WorkoutId = workouts[80].Id , Step = 2 , Instruction = "Face away from the cable machine and sit on the bench. Stagger your stance so you have a better base of support." },
                new WorkoutInstruction{ WorkoutId = workouts[80].Id , Step = 3 , Instruction = "Face your palm downwards. Flex at the elbow and extend." },

                new WorkoutInstruction{ WorkoutId = workouts[81].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
                new WorkoutInstruction{ WorkoutId = workouts[81].Id , Step = 2 , Instruction = "Face away from the cable machine and sit on the bench. Stagger your stance so you have a better base of support." },
                new WorkoutInstruction{ WorkoutId = workouts[81].Id , Step = 3 , Instruction = "Use a neutral grip thumb facing up pinky-facing down). Flex at the elbow and extend." },

                new WorkoutInstruction{ WorkoutId = workouts[82].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
                new WorkoutInstruction{ WorkoutId = workouts[82].Id , Step = 2 , Instruction = "Sit on a bench facing away from the cable machine." },
                new WorkoutInstruction{ WorkoutId = workouts[82].Id , Step = 3 , Instruction = "Stagger your stance so you have a better base of support. Face your palm forward. Flex at the elbow and extend." },

                new WorkoutInstruction{ WorkoutId = workouts[83].Id , Step = 1 , Instruction = "Use a bar attachment. The cable should be set all the way to the bottom of the machine." },
                new WorkoutInstruction{ WorkoutId = workouts[83].Id , Step = 2 , Instruction = "Face the cable machine." },
                new WorkoutInstruction{ WorkoutId = workouts[83].Id , Step = 3 , Instruction = "Stagger your stance so you have a better base of support. Face your palm forward. Flex at the elbow and extend." },

                new WorkoutInstruction{ WorkoutId = workouts[84].Id , Step = 1 , Instruction = "Use a rope attachment. The cable should be set all the way to the bottom of the machine." },
                new WorkoutInstruction{ WorkoutId = workouts[84].Id , Step = 2 , Instruction = "Face away from the cable machine. Stagger your stance so you have a better base of support." },
                new WorkoutInstruction{ WorkoutId = workouts[84].Id , Step = 3 , Instruction = "Use a neutral grip thumb facing up pinky-facing down). Flex at the elbow and extend." },

                new WorkoutInstruction{ WorkoutId = workouts[85].Id , Step = 1 , Instruction = "Stand facing away from the cables and grab two handle attachments." },
                new WorkoutInstruction{ WorkoutId = workouts[85].Id , Step = 2 , Instruction = "Take a neutral grip, flex your elbows, and extend." },

                new WorkoutInstruction{ WorkoutId = workouts[86].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
                new WorkoutInstruction{ WorkoutId = workouts[86].Id , Step = 2 , Instruction = "Face away from the cable machine. Stagger your stance so you have a better base of support." },
                new WorkoutInstruction{ WorkoutId = workouts[86].Id , Step = 3 , Instruction = "Face your palm downwards. Flex at the elbow and extend." },

                new WorkoutInstruction{ WorkoutId = workouts[87].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
                new WorkoutInstruction{ WorkoutId = workouts[87].Id , Step = 2 , Instruction = "Face away from the cable machine." },
                new WorkoutInstruction{ WorkoutId = workouts[87].Id , Step = 3 , Instruction = "Stagger your stance so you have a better base of support. Face your palm forward. Flex at the elbow and extend." },

                new WorkoutInstruction{ WorkoutId = workouts[88].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set to about elbow height." },
                new WorkoutInstruction{ WorkoutId = workouts[88].Id , Step = 2 , Instruction = "Face away from the cable machine." },
                new WorkoutInstruction{ WorkoutId = workouts[88].Id , Step = 3 , Instruction = "Stagger your stance so you have a better base of support. Face your palm forward. Flex at the elbow and extend." },
                #endregion

                #region TRX
                new WorkoutInstruction{ WorkoutId = workouts[89].Id , Step = 1 , Instruction = "Hold the TRX straps with an underhand grip and lean back and away from the anchor point." },
                new WorkoutInstruction{ WorkoutId = workouts[89].Id , Step = 2 , Instruction = "Keep your elbows high as you flex your elbows. Pull your fists toward your forehead." },

                new WorkoutInstruction{ WorkoutId = workouts[90].Id , Step = 1 , Instruction = "Grab the TRX straps and lean away from the anchor point." },
                new WorkoutInstruction{ WorkoutId = workouts[90].Id , Step = 2 , Instruction = "Maintain a neutral grip. Flex your elbows and pull your fists to either sides of your temples." },

                new WorkoutInstruction{ WorkoutId = workouts[91].Id , Step = 1 , Instruction = "Stand facing the TRX straps and grasp the handles with both hands, palms facing away from your body." },
                new WorkoutInstruction{ WorkoutId = workouts[91].Id , Step = 2 , Instruction = "Walk back until the straps are taut, keeping your arms straight." },
                new WorkoutInstruction{ WorkoutId = workouts[91].Id , Step = 3 , Instruction = "Slowly curl your hands towards your shoulders, keeping your elbows close to your body." },

                new WorkoutInstruction{ WorkoutId = workouts[92].Id , Step = 1 , Instruction = "Grab the TRX straps and lean away from the anchor point until the strap is taut." },
                new WorkoutInstruction{ WorkoutId = workouts[92].Id , Step = 2 , Instruction = "Start with an overhand grip. Pull your elbows back and rotate your grip." },
                new WorkoutInstruction{ WorkoutId = workouts[92].Id , Step = 3 , Instruction = "By the time your elbows reach your side, your palms should be facing upwards." },

                new WorkoutInstruction{ WorkoutId = workouts[93].Id , Step = 1 , Instruction = "Hold the TRX strap with one hand." },
                new WorkoutInstruction{ WorkoutId = workouts[93].Id , Step = 2 , Instruction = "Lean back until the strap is taut. Fully extend your elbow." },
                new WorkoutInstruction{ WorkoutId = workouts[93].Id , Step = 3 , Instruction = "Pull your elbow behind the body. Make sure to avoid twisting. Try to keep your shoulders even." },
                #endregion

                new WorkoutInstruction{ WorkoutId = workouts[70].Id , Step = 1 , Instruction = "" },

            };
        };

        var workoutEquipment = new List<WorkoutEquipment>();
        if (!await context.WorkoutEquipment.AnyAsync())
        {
            var barbellId  = context.Equipments.Where(x => x.Name == "Barbell").Select(x => x.Id).FirstOrDefault();
            var ezbarId  = context.Equipments.Where(x => x.Name == "E-Z Curl Bar").Select(x => x.Id).FirstOrDefault();
            var cableMachineId = context.Equipments.Where(x => x.Name == "Cable Machine").Select(x => x.Id).FirstOrDefault();
            var pullUpMachineId = context.Equipments.Where(x => x.Name == "Pull Up Machine").Select(x => x.Id).FirstOrDefault();
            var machineId = context.Equipments.Where(x => x.Name == "Machine").Select(x => x.Id).FirstOrDefault();
            var stretchesId = context.Equipments.Where(x => x.Name == "stretches").Select(x => x.Id).FirstOrDefault();
            var plateId = context.Equipments.Where(x => x.Name == "Plate").Select(x => x.Id).FirstOrDefault();
            var bosuballId  = context.Equipments.Where(x => x.Name == "Bosu-Ball").Select(x => x.Id).FirstOrDefault();
            var smithMachineId  = context.Equipments.Where(x => x.Name == "Smith Machine").Select(x => x.Id).FirstOrDefault();
            var dumbellId  = context.Equipments.Where(x => x.Name == "Dumbells").Select(x => x.Id).FirstOrDefault();
            var cableId = context.Equipments.Where(x => x.Name == "Cable").Select(x => x.Id).FirstOrDefault();
            var trxId = context.Equipments.Where(x => x.Name == "TRX").Select(x => x.Id).FirstOrDefault();
            

            workoutEquipment = new List<WorkoutEquipment>
            {
                #region Barbell & biceps
                new WorkoutEquipment{ WorkoutId = workouts[0].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[1].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[2].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[3].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[4].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[5].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[6].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[7].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[8].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[9].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[10].Id, EquipmentId =barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[11].Id, EquipmentId =barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[12].Id, EquipmentId =barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[13].Id, EquipmentId =barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[14].Id, EquipmentId =ezbarId },
                new WorkoutEquipment{ WorkoutId = workouts[15].Id, EquipmentId =ezbarId },
                #endregion

                #region Biceps & Machine
                new WorkoutEquipment{ WorkoutId = workouts[16].Id, EquipmentId = cableMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[17].Id, EquipmentId = cableMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[18].Id, EquipmentId = cableMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[19].Id, EquipmentId = cableMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[20].Id, EquipmentId = pullUpMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[21].Id, EquipmentId = pullUpMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[22].Id, EquipmentId = pullUpMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[23].Id, EquipmentId = pullUpMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[24].Id, EquipmentId = machineId },
                new WorkoutEquipment{ WorkoutId = workouts[25].Id, EquipmentId = machineId },
                new WorkoutEquipment{ WorkoutId = workouts[26].Id, EquipmentId = machineId },
                new WorkoutEquipment{ WorkoutId = workouts[27].Id, EquipmentId = machineId },
                new WorkoutEquipment{ WorkoutId = workouts[28].Id, EquipmentId = machineId },
                #endregion

                #region biceps & stretches
                new WorkoutEquipment{ WorkoutId = workouts[29].Id, EquipmentId = stretchesId },
                new WorkoutEquipment{ WorkoutId = workouts[30].Id, EquipmentId = stretchesId },
                new WorkoutEquipment{ WorkoutId = workouts[31].Id, EquipmentId = stretchesId },
                new WorkoutEquipment{ WorkoutId = workouts[32].Id, EquipmentId = stretchesId },
                new WorkoutEquipment{ WorkoutId = workouts[33].Id, EquipmentId = stretchesId },
                #endregion

                #region biceps & plate
                new WorkoutEquipment{ WorkoutId = workouts[34].Id, EquipmentId = plateId },
                new WorkoutEquipment{ WorkoutId = workouts[35].Id, EquipmentId = plateId },
                new WorkoutEquipment{ WorkoutId = workouts[36].Id, EquipmentId = plateId },
                new WorkoutEquipment{ WorkoutId = workouts[37].Id, EquipmentId = plateId },
                new WorkoutEquipment{ WorkoutId = workouts[38].Id, EquipmentId = plateId },
                new WorkoutEquipment{ WorkoutId = workouts[39].Id, EquipmentId = plateId },
                #endregion

                #region bosuball
                new WorkoutEquipment{ WorkoutId = workouts[40].Id, EquipmentId = bosuballId },
                new WorkoutEquipment{ WorkoutId = workouts[41].Id, EquipmentId = bosuballId },
                #endregion

                #region smithMachine
                new WorkoutEquipment{ WorkoutId = workouts[42].Id, EquipmentId = smithMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[43].Id, EquipmentId = smithMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[44].Id, EquipmentId = smithMachineId },
                #endregion

                #region dumbell
                new WorkoutEquipment{ WorkoutId = workouts[45].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[46].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[47].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[48].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[49].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[50].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[51].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[52].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[53].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[54].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[55].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[56].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[57].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[58].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[59].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[60].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[61].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[62].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[63].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[64].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[65].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[66].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[67].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[68].Id, EquipmentId = dumbellId },
                new WorkoutEquipment{ WorkoutId = workouts[69].Id, EquipmentId = dumbellId },
                #endregion

                #region Cables
                new WorkoutEquipment{ WorkoutId = workouts[70].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[71].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[72].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[73].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[74].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[75].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[76].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[77].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[78].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[79].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[80].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[81].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[82].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[83].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[84].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[85].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[86].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[87].Id, EquipmentId = cableId },
                new WorkoutEquipment{ WorkoutId = workouts[88].Id, EquipmentId = cableId },
                #endregion

                #region TRX
                new WorkoutEquipment{ WorkoutId = workouts[89].Id, EquipmentId = trxId },
                new WorkoutEquipment{ WorkoutId = workouts[90].Id, EquipmentId = trxId },
                new WorkoutEquipment{ WorkoutId = workouts[91].Id, EquipmentId = trxId },
                new WorkoutEquipment{ WorkoutId = workouts[92].Id, EquipmentId = trxId },
                new WorkoutEquipment{ WorkoutId = workouts[93].Id, EquipmentId = trxId },
                #endregion

                new WorkoutEquipment{ WorkoutId = workouts[40].Id, EquipmentId = 21 },

            };
        };

        var workoutLevel = new List<WorkoutLevel>();
        if (!await context.WorkoutLevels.AnyAsync())
        {
            workoutLevel = new List<WorkoutLevel>
            {
                #region barbell & biceps
                new WorkoutLevel{ WorkoutId = workouts[0].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[1].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[2].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[3].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[4].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[5].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[6].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[7].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[8].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[9].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[10].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[11].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[12].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[13].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[14].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[15].Id , Level = Difficulty.Novice},
                #endregion

                #region biceps & Machine
                new WorkoutLevel{ WorkoutId = workouts[16].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[17].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[18].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[19].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[20].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[21].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[22].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[23].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[24].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[25].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[26].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[27].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[28].Id , Level = Difficulty.Novice},
                #endregion

                #region biceps & stretches
                new WorkoutLevel{ WorkoutId = workouts[29].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[30].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[31].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[32].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[33].Id , Level = Difficulty.Novice},
                #endregion

                #region biceps & plate
                new WorkoutLevel{ WorkoutId = workouts[34].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[35].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[36].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[37].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[38].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[39].Id , Level = Difficulty.Advanced},
                #endregion

                #region bosu Ball
                new WorkoutLevel{ WorkoutId = workouts[40].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[41].Id , Level = Difficulty.Beginner},
                #endregion

                #region smith Machine
                new WorkoutLevel{ WorkoutId = workouts[42].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[43].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[44].Id , Level = Difficulty.Beginner},
                #endregion

                #region dumbell
                new WorkoutLevel{ WorkoutId = workouts[45].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[46].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[47].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[48].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[49].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[50].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[51].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[52].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[53].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[54].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[55].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[56].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[57].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[58].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[59].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[60].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[61].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[62].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[63].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[64].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[65].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[66].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[67].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[68].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[69].Id , Level = Difficulty.Beginner},
                #endregion

                #region Cables
                new WorkoutLevel{ WorkoutId = workouts[70].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[71].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[72].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[73].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[74].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[75].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[76].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[77].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[78].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[79].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[80].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[81].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[82].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[83].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[84].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[85].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[86].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[87].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[88].Id , Level = Difficulty.Beginner},
                #endregion

                #region TRX
                new WorkoutLevel{ WorkoutId = workouts[89].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[90].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[91].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[92].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[93].Id , Level = Difficulty.Beginner},

                #endregion
                new WorkoutLevel{ WorkoutId = workouts[70].Id , Level = Difficulty.Advanced},

            };
        };

        var bodyWorkouts = new List<BodyWorkout>();
        if (!await context.BodyWorkouts.AnyAsync())
        {
            var bicepId = await context.Bodies.Where(z => z.Name == "Biceps").Select(z => z.Id).FirstOrDefaultAsync();
            bodyWorkouts = new List<BodyWorkout>
            {
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[0].Id, Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[1].Id  ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[2].Id  ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[3].Id  ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[4].Id  ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[5].Id  ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[6].Id  ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[7].Id  ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[8].Id  ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[9].Id  ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[10].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[11].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[12].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[13].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[14].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[15].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[16].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[17].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[18].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[19].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[20].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[21].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[22].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[23].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[24].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[25].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[26].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[27].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[28].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[29].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[30].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[31].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[32].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[33].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[34].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[35].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[36].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[37].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[38].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[39].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[40].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[41].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[42].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[43].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[44].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[45].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[46].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[47].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[48].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[49].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[50].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[51].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[52].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[53].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[54].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[55].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[56].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[57].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[58].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[59].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[60].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[61].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[62].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[63].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[64].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[65].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[66].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[67].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[68].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[69].Id ,Target = PriorityTarget.Primary  },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[70].Id ,Target = PriorityTarget.Secondary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[71].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[72].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[73].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[74].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[75].Id ,Target = PriorityTarget.Secondary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[76].Id ,Target = PriorityTarget.Secondary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[77].Id ,Target = PriorityTarget.Secondary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[78].Id ,Target = PriorityTarget.Tertiary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[79].Id ,Target = PriorityTarget.Tertiary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[80].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[81].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[82].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[83].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[84].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[85].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[86].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[87].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[88].Id ,Target = PriorityTarget.Primary  },


                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[89].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[90].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[91].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[92].Id ,Target = PriorityTarget.Secondary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[93].Id ,Target = PriorityTarget.Secondary  },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[94].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[95].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[96].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[97].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[98].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[99].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[100].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[101].Id ,Target = PriorityTarget.Primary  },

            };
        };

        var workoutSex = new List<WorkoutSex>();
        if (!await context.WorkoutSex.AnyAsync())
        {
            workoutSex = new List<WorkoutSex>
            {
                new WorkoutSex{ WorkoutId = workouts[0].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[0].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[1].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[1].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[2].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[2].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[3].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[3].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[4].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[4].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[5].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[5].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[6].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[6].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[7].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[7].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[8].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[8].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[9].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[9].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[10].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[10].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[11].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[11].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[12].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[12].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[13].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[13].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[14].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[14].Id, Sex = Sex.Female},
            };
        };



        await context.WorkoutInstructions.AddRangeAsync(workoutInstruction);
        await context.SaveChangesAsync();

        await transactions.CommitAsync();

    }

}
