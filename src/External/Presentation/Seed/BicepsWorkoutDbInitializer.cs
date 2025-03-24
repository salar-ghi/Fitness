namespace Presentation.Seed;

public static class BicepsWorkoutDbInitializer
{
    public static async Task BicepsWorkoutSeedAsync(FitnessContext context)
    {
        //using var transactions = await context.Database.BeginTransactionAsync();

        var bicepsWorkouts = new List<Workout>();

        var bodybuildingId = await context.Sports.Where(s => s.Name == "Body Building").Select(z => z.Id).FirstOrDefaultAsync();
        var cardioSportId = await context.Sports.Where(s => s.Name == "Cardio").Select(z => z.Id).FirstOrDefaultAsync();
        var crossfitId = await context.Sports.Where(s => s.Name == "Cross Fit").Select(z => z.Id).FirstOrDefaultAsync();
        var yogaSportId = await context.Sports.Where(s => s.Name == "Yoga").Select(z => z.Id).FirstOrDefaultAsync();

        bicepsWorkouts = new List<Workout>
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
            new Workout{ Name = "Biceps Stretch Variation Five", SportId = cardioSportId, Description = "" },                        // index => 29
            new Workout{ Name = "Biceps Stretch Variation Four", SportId = cardioSportId, Description = "" },                        // index => 30
            new Workout{ Name = "Biceps Stretch Variation Three", SportId = cardioSportId, Description = "" },                       // index => 31
            new Workout{ Name = "Biceps Stretch Variation Two", SportId = cardioSportId, Description = "" },                         // index => 32
            new Workout{ Name = "Biceps Stretch Variation One", SportId = cardioSportId, Description = "" },                         // index => 33

            // biceps // plate
            new Workout{ Name = "Plate Bicep Curl", SportId = bodybuildingId, Description = "" },                                   // index => 34
            new Workout{ Name = "Plate Curl To Overhead Press", SportId = bodybuildingId, Description = "" },                       // index => 35
            new Workout{ Name = "Plate Curl To Overhead Press To Tricep Extension", SportId = bodybuildingId, Description = "" },   // index => 36
            new Workout{ Name = "Plate Squat Hold Curl", SportId = bodybuildingId, Description = "" },                              // index => 37
            new Workout{ Name = "Plate Pinch Grip Row", SportId = bodybuildingId, Description = "" },                               // index => 38
            new Workout{ Name = "Weighted Chin Ups", SportId = bodybuildingId, Description = "" },                                  // index => 39

            // biceps // bosu-ball
            new Workout{ Name = "Bosu Ball Curl", SportId = cardioSportId, Description = "" },                                           // index => 40
            new Workout{ Name = "Bosu Ball Row", SportId = cardioSportId, Description = "" },                                            // index => 41

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

            // biceps // Vitruvian
            new Workout{ Name = "Vitruvian Hammer Curl", SportId = bodybuildingId, Description = "" },                                          // index => 94
            new Workout{ Name = "Vitruvian Single Arm Row", SportId = bodybuildingId, Description = "" },                                       // index => 95

            // biceps // Recovery
            new Workout{ Name = "Core Stability 2 Opposite Shoulder Tap 4Pt Position", SportId = cardioSportId, Description = "" },                  // index => 96
            new Workout{ Name = "Dumbbell Service Exercise", SportId = cardioSportId, Description = "" },                                            // index => 97
            new Workout{ Name = "Seated Ulnar Nerve Slider", SportId = cardioSportId, Description = "" },                                            // index => 98
            new Workout{ Name = "Seated Ulnar Nerve Tensioner", SportId = cardioSportId, Description = "" },                                         // index => 99

            // biceps // bodyweight
            new Workout{ Name = "Chin Ups", SportId = crossfitId, Description = "" },                                                             // index => 100
            new Workout{ Name = "Bodyweight Assisted Chin Up", SportId = crossfitId, Description = "" },                                          // index => 101
            new Workout{ Name = "Bodyweight Assisted Gironda Chin Up", SportId = crossfitId, Description = "" },                                  // index => 102
            new Workout{ Name = "Bodyweight Assisted Mixed Grip Pullup", SportId = crossfitId, Description = "" },                                // index => 103
            new Workout{ Name = "Bodyweight Assisted Pull Up", SportId = crossfitId, Description = "" },                                          // index => 104
            new Workout{ Name = "Bodyweight Inverted Curl", SportId = crossfitId, Description = "" },                                             // index => 105
            new Workout{ Name = "Bodyweight Close Grip Inverted Curl", SportId = crossfitId, Description = "" },                                  // index => 106
            new Workout{ Name = "Bodyweight Concentration Curl", SportId = crossfitId, Description = "" },                                        // index => 107
            new Workout{ Name = "Bodyweight Underhand Inverted Row", SportId = crossfitId, Description = "" },                                    // index => 108
            new Workout{ Name = "Ring Row", SportId = crossfitId, Description = "" },                                                             // index => 109
            new Workout{ Name = "Ring Curl", SportId = crossfitId, Description = "" },                                                            // index => 110
            new Workout{ Name = "L Sit Chin Up", SportId = crossfitId, Description = "" },                                                        // index => 111

            //biceps // kettlebells
            new Workout{ Name = "Kettlebell Goblet Curl", SportId = bodybuildingId, Description = "" },                                             // index => 112
            new Workout{ Name = "Kettlebell Concentration Curl", SportId = bodybuildingId, Description = "" },                                      // index => 113
            new Workout{ Name = "Kettlebell Preacher Curl", SportId = bodybuildingId, Description = "" },                                           // index => 114
            new Workout{ Name = "Kettlebell Single Arm Curl", SportId = bodybuildingId, Description = "" },                                         // index => 115
            new Workout{ Name = "Kettlebell Alternating Row", SportId = bodybuildingId, Description = "" },                                         // index => 116
            new Workout{ Name = "Kettlebell Curl", SportId = bodybuildingId, Description = "" },                                                    // index => 117
            new Workout{ Name = "Kettlebell Gorilla Row", SportId = bodybuildingId, Description = "" },                                             // index => 118
            new Workout{ Name = "Kettlebell Reverse Curl", SportId = bodybuildingId, Description = "" },                                            // index => 119
            new Workout{ Name = "Kettlebell Row", SportId = bodybuildingId, Description = "" },                                                     // index => 120
            new Workout{ Name = "Kettlebell Single Arm Reverse Curl", SportId = bodybuildingId, Description = "" },                                 // index => 121
            new Workout{ Name = "Kettlebell Single Arm Row On Bench", SportId = bodybuildingId, Description = "" },                                 // index => 122
            new Workout{ Name = "Kettlebell Row (Single)", SportId = bodybuildingId, Description = "" },                                            // index => 123
            new Workout{ Name = "Kettlebell Single Arm Row", SportId = bodybuildingId, Description = "" },                                          // index => 124
            new Workout{ Name = "Kettlebell Rear Delt Row", SportId = bodybuildingId, Description = "" },                                           // index => 125
            new Workout{ Name = "Kettlebell Rear Delt Row (Double)", SportId = bodybuildingId, Description = "" },                                  // index => 126

            //biceps // bands
            new Workout{ Name = "Band Bayesian Curl", SportId = cardioSportId, Description = "" },                                                       // index => 127
            new Workout{ Name = "Band Bayesian Hammer Curl", SportId = cardioSportId, Description = "" },                                                // index => 128
            new Workout{ Name = "Band Kneeling Single Arm Pulldown", SportId = cardioSportId, Description = "" },                                        // index => 129
            new Workout{ Name = "Band Bayesian Reverse Curl", SportId = cardioSportId, Description = "" },                                               // index => 130
            new Workout{ Name = "Band Row", SportId = cardioSportId, Description = "" },                                                                 // index => 131
            new Workout{ Name = "Band High Curl", SportId = cardioSportId, Description = "" },                                                           // index => 132
            new Workout{ Name = "Band High Hammer Curl", SportId = cardioSportId, Description = "" },                                                    // index => 133
            new Workout{ Name = "Band High Reverse Curl", SportId = cardioSportId, Description = "" },                                                   // index => 134
            new Workout{ Name = "Band Curl", SportId = cardioSportId, Description = "" },                                                                // index => 135
            new Workout{ Name = "Band Reverse Curl", SportId = cardioSportId, Description = "" },                                                        // index => 136
            new Workout{ Name = "Band Squat Hold Single Arm Row", SportId = cardioSportId, Description = "" },                                           // index => 137
            new Workout{ Name = "Band Squat Hold Row", SportId = cardioSportId, Description = "" },                                                      // index => 138
            new Workout{ Name = "Band Single Arm Pulldown", SportId = cardioSportId, Description = "" },                                                 // index => 139
            new Workout{ Name = "Band Single Arm Row", SportId = cardioSportId, Description = "" },                                                      // index => 140
                
            // biceps // Yoga
            new Workout{ Name = "Corpse Pose", SportId = yogaSportId, Description = "" },                                                                // index => 141
            new Workout{ Name = "Crow Pose", SportId = yogaSportId, Description = "" },                                                                  // index => 142
            new Workout{ Name = "Downward Dog", SportId = yogaSportId, Description = "" },                                                               // index => 143
            new Workout{ Name = "Downward Dog With Fingers Facing Feet", SportId = yogaSportId, Description = "" },                                      // index => 144
            new Workout{ Name = "Scorpion Twist Pose", SportId = yogaSportId, Description = "" },                                                        // index => 145
            new Workout{ Name = "Seated Arm Stretch", SportId = yogaSportId, Description = "" },                                                         // index => 146

            // biceps // Cardio
            new Workout{ Name = "Cardio Band Hammer Curl Jacks", SportId = cardioSportId, Description = "" },                                             // index => 147
            new Workout{ Name = "Cardio Row Erg Rower Arms Only", SportId = cardioSportId, Description = "" },                                           // index => 148
            new Workout{ Name = "Cardio Row Erg Rower Four Stroke Sprint Start", SportId = cardioSportId, Description = "" },                            // index => 149
            new Workout{ Name = "Cardio Row Erg Rower", SportId = cardioSportId, Description = "" },                                                     // index => 150
        };
        await context.Workouts.AddRangeAsync(bicepsWorkouts);
        await context.SaveChangesAsync();

        // ***************************************************************** //
        var bicepsWorkoutInstruction = new List<WorkoutInstruction>();
        bicepsWorkoutInstruction = new List<WorkoutInstruction>
        {
            #region Biceps & Barbell
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[0].Id , Step = 1 , Instruction = "While holding the upper arms stationary, curl the weights forward while contracting the biceps as you breathe out."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[0].Id , Step = 2 , Instruction = "Continue the movement until your biceps are fully contracted and the bar is at shoulder level."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[0].Id , Step = 3 , Instruction = "Hold the contracted position for a second and squeeze the biceps hard."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[0].Id , Step = 4 , Instruction = "Slowly bring the weight back down to the starting position."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[1].Id , Step = 1 , Instruction = "Take a double overhand grip that's about shoulder width. Flex your elbows while keeping your elbows tucked in. Try not to let them flare out."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[1].Id , Step = 2 , Instruction = "Curl until your forearm presses into your bicep. Then fully extend your elbows at the bottom of each rep."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[2].Id , Step = 1 , Instruction = "Position a barbell in a landmine or corner of a room and stand facing it with your feet shoulder-width apart."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[2].Id , Step = 2 , Instruction = "Grasp the end of the barbell with a neutral grip, keeping your arms straight and your shoulders relaxed."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[2].Id , Step = 3 , Instruction = "Bend at the hips and knees to lower your torso until it is almost parallel to the ground."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[2].Id , Step = 4 , Instruction = "Pull the barbell towards your chest, squeezing your shoulder blades together as you row the weight up."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[3].Id , Step = 1 , Instruction = "Position a barbell in a landmine or corner of a room and stand facing it with your feet shoulder-width apart."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[3].Id , Step = 2 , Instruction = "Grasp the end of the barbell with an overhand grip, keeping your arms straight and your shoulders relaxed."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[3].Id , Step = 3 , Instruction = "Bend at the hips and knees to lower your torso until it is almost parallel to the ground."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[3].Id , Step = 4 , Instruction = "Pull the barbell towards your chest, squeezing your shoulder blades together as you row the weight up."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[4].Id , Step = 1 , Instruction = "Position a barbell in a landmine or corner of a room and stand facing sideways with a staggered stance and your feet shoulder-width apart."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[4].Id , Step = 2 , Instruction = "Grasp the end of the barbell with an overhand grip, keeping your arms straight and your shoulders relaxed."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[4].Id , Step = 3 , Instruction = "Bend at the hips and knees to lower your torso until it is almost parallel to the ground."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[4].Id , Step = 4 , Instruction = "Pull the barbell towards your chest, squeezing your shoulder blades together as you row the weight up."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[4].Id , Step = 5 , Instruction = "*Named after the late John Meadows"},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[5].Id , Step = 1 , Instruction = "Start hinged forward with a flat back and the plates resting on the floor. Make sure your elbows are fully extended."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[5].Id , Step = 2 , Instruction = "Pull the bar to your sternum."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[5].Id , Step = 3 , Instruction = "Return the plates back to the floor and let the bar come to a full dead stop."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[5].Id , Step = 4 , Instruction = "Then initiate the next rep."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[6].Id , Step = 1 , Instruction = "Grab the barbell with an overhand grip. Hinge forward while keeping your back flat until your torso is about parallel with the ground."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[6].Id , Step = 2 , Instruction = "Let your arms hang freely."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[6].Id , Step = 3 , Instruction = "Pull the bar to your torso while tucking your elbows in slightly."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[6].Id , Step = 4 , Instruction = "Extend your elbows fully before initiating the next rep."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[7].Id , Step = 1 , Instruction = "Begin by standing in front of a barbell with your feet about hip-width apart and your palms facing towards your body."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[7].Id , Step = 2 , Instruction = "Bend at the hips and knees to grab the barbell with a pronated (overhand) grip, positioning the barbell about an inch away from your shins."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[7].Id , Step = 3 , Instruction = "Keeping your back straight and your core engaged, use your back muscles to lift the barbell straight up towards your chest."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[7].Id , Step = 4 , Instruction = "As the barbell reaches your chest, rotate your wrists so that your palms are facing towards your body (supinated grip), and then lower the barbell back to the starting position."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[8].Id , Step = 1 , Instruction = "Begin by standing in front of a barbell with your feet about hip-width apart."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[8].Id , Step = 2 , Instruction = "Bend at the hips and knees to grab the barbell with a supinated (underhand) grip, positioning the barbell about an inch away from your shins."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[8].Id , Step = 3 , Instruction = "Keeping your back straight and your core engaged, use your back muscles to lift the barbell straight up towards your chest."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[8].Id , Step = 4 , Instruction = "As the barbell reaches your chest, pause briefly, and then lower the barbell back to the starting position."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[9].Id , Step = 1 , Instruction = "Stand beside the landmine with your feet shoulder-width apart while grasping the end of the landmine barbell with the hand farther away from the landmine attachment, palm facing up and your elbow close to your side."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[9].Id , Step = 2 , Instruction = "Curl the barbell up towards your opposite shoulder, contracting your bicep muscles, then slowly lower the barbell back down."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[9].Id , Step = 3 , Instruction = "Repeat for the desired number of reps before switching sides."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[10].Id , Step = 1 , Instruction = "Start on one knee facing the landmine, holding the end of the barbell with your hand on the side of your forward leg."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[10].Id , Step = 2 , Instruction = "While keeping your elbow braced against the inside of your knee, curl the barbell upward towards your shoulder, then lower it back down with control."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[10].Id , Step = 3 , Instruction = "Repeat for the desired number of reps before switching sides."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[11].Id , Step = 1 , Instruction = "Grab a barbell with an underhand grip."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[11].Id , Step = 2 , Instruction = "Pull your elbows straight back and let the bar drag against your upper body (or very close to it)."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[12].Id , Step = 1 , Instruction = "Grab a v bar and place it under the bar's collar."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[12].Id , Step = 2 , Instruction = "Hinge forward with a flat back and pull your elbows straight back toward the ceiling."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[12].Id , Step = 3 , Instruction = "Fully extend your elbows before initiating the next rep."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[13].Id , Step = 1 , Instruction = "Grab a barbell with a shoulder width pronated or supinated grip."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[13].Id , Step = 2 , Instruction = "Bend forward at your hips while maintaining a flat back."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[13].Id , Step = 3 , Instruction = "Pull the weight toward your upper abdomen."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[13].Id , Step = 4 , Instruction = "Lower the weight in a controlled manner and repeat."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[14].Id , Step = 1 , Instruction = "Position yourself on preacher bench; grasp EZ bar with underhand grip, elbows extended."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[14].Id , Step = 2 , Instruction = "Slowly curl bar towards shoulders; keep upper arms stationary, focus on biceps."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[14].Id , Step = 3 , Instruction = "Lower bar back to starting position; maintain control, repeat for reps."},

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[15].Id , Step = 1 , Instruction = "Sit on preacher bench, grip EZ bar overhand at shoulder width, elbows resting on pad."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[15].Id , Step = 2 , Instruction = "Curl bar towards chin, keep elbows stable."},
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[15].Id , Step = 3 , Instruction = "Lower bar slowly to starting position, maintaining control throughout."},
            #endregion

            #region biceps & Machine
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[16].Id , Step = 1 , Instruction = "Sit with your back straight on the machine and grip the handles." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[16].Id , Step = 2 , Instruction = "Pull the handles back using your arms. Your legs and torso should be at a 90° angle. Push out your chest." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[16].Id , Step = 3 , Instruction = "Pull the handles towards your body until your hands are beside your abdomen." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[17].Id , Step = 1 , Instruction = "Use the Straight Bar attachment." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[17].Id , Step = 2 , Instruction = "Hold the attachment as you sit on the machine and put your legs under the leg pads." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[17].Id , Step = 3 , Instruction = "Pull the bar to your clavicle, then raise back up until your arm are extended." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[18].Id , Step = 1 , Instruction = "Use the V Bar attachment." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[18].Id , Step = 2 , Instruction = "Hold the attachment as you sit on the machine and put your legs under the leg pads." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[18].Id , Step = 3 , Instruction = "Pull the bar to your clavicle, then raise back up until your arm are extended." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[19].Id , Step = 1 , Instruction = "Use the Straight Bar attachment. Hold with an underhand grip." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[19].Id , Step = 2 , Instruction = "Hold the attachment as you sit on the machine and put your legs under the leg pads." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[19].Id , Step = 3 , Instruction = "Pull the bar to your clavicle, then raise back up until your arm are extended." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[20].Id , Step = 1 , Instruction = "Adjust weight for assistance. Stand on platform, grip handles above shoulder-width. Knees on pad if available." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[20].Id , Step = 2 , Instruction = "Slowly pull up until chin is above the bar. Keep elbows close, core engaged." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[20].Id , Step = 3 , Instruction = "Lower back with control. Pause at bottom. Repeat for reps." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[21].Id , Step = 1 , Instruction = "Adjust weight for assistance. Stand on platform, grip handles above shoulder-width. Knees on pad if available." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[21].Id , Step = 2 , Instruction = "Slowly pull up until chin is above the bar. Keep elbows close, core engaged." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[21].Id , Step = 3 , Instruction = "Lower back with control. Pause at bottom. Repeat for reps." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[22].Id , Step = 1 , Instruction = "Adjust weight for assistance. Stand on platform, grip handles above shoulder-width. Knees on pad if available." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[22].Id , Step = 2 , Instruction = "Slowly pull up until chin is above the bar. Keep elbows close, core engaged." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[22].Id , Step = 3 , Instruction = "Lower back with control. Pause at bottom. Repeat for reps." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[23].Id , Step = 1 , Instruction = "Adjust weight for assistance. Stand on platform, grip handles above shoulder-width. Knees on pad if available." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[23].Id , Step = 2 , Instruction = "Slowly pull up until chin is above the bar. Keep elbows close, core engaged." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[23].Id , Step = 3 , Instruction = "Lower back with control. Pause at bottom. Repeat for reps." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[24].Id , Step = 1 , Instruction = "Sit on the machine, feet flat, and grab the handles with palms facing up, keeping your back straight." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[24].Id , Step = 2 , Instruction = "Pull handles towards your lower abdomen, squeezing your shoulder blades together. Keep elbows close to your body." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[24].Id , Step = 3 , Instruction = "Slowly return to the starting position, fully extending your arms without locking elbows. Repeat for desired reps." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[25].Id , Step = 1 , Instruction = "Grip the handles with the palms facing down." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[25].Id , Step = 2 , Instruction = "Sit on the machine and press your knees into the knee pad." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[25].Id , Step = 3 , Instruction = "Pull the handles until your upper arm is even with your torso, or just behind your torso." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[25].Id , Step = 4 , Instruction = "Extend until your elbows are fully extended before initiating the next rep." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[26].Id , Step = 1 , Instruction = "Rest the back of your arms on the preacher bench." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[26].Id , Step = 2 , Instruction = "Grab the handles. Curl the weight up until your elbows are fully flexed." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[26].Id , Step = 3 , Instruction = "Lower until the point just before the weight rests at the bottom." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[27].Id , Step = 1 , Instruction = "Sit at the bench and rest the back of your arms on the preacher bench." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[27].Id , Step = 2 , Instruction = "Grab the handles. Curl the weight up until your elbows are fully flexed." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[27].Id , Step = 3 , Instruction = "Lower until the point just before the weight rests at the bottom." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[28].Id , Step = 1 , Instruction = "Adjust the seat to fit your height and place your elbows on the elbow pad." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[28].Id , Step = 2 , Instruction = "Grab the handles and flex your elbows." },
            #endregion

            #region biceps & stretches
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[29].Id , Step = 1 , Instruction = "Stand upright with your feet shoulder width apart." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[29].Id , Step = 2 , Instruction = "Raise your arms out to your sides, bringing them up to shoulder level." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[29].Id , Step = 3 , Instruction = "Rotate your palms so they are facing the ceiling." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[29].Id , Step = 4 , Instruction = "Then, change direction and rotate the arms as much as you can." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[30].Id , Step = 1 , Instruction = "Stand an arms width away from the wall." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[30].Id , Step = 2 , Instruction = "Raise your arms out behind you, and place them on the wall with your fingers pointing up." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[30].Id , Step = 3 , Instruction = "Bend your knees whilst keeping your hands in the same position." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[31].Id , Step = 1 , Instruction = "Bend your arm at the elbow, raising your hand to your shoulder." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[31].Id , Step = 2 , Instruction = "Using your other hand, stretch the arm down to its full extent." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[32].Id , Step = 1 , Instruction = "Stand facing the wall, an arm's width away." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[32].Id , Step = 2 , Instruction = "Place your hand on the wall with your fingers pointing down." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[32].Id , Step = 3 , Instruction = "Lean slightly into the wall to feel the stretch in your bicep." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[33].Id , Step = 1 , Instruction = "Stand one foot in front of the other with the wall to your right, an arms width away." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[33].Id , Step = 2 , Instruction = "Place your hand on the wall, fingers pointing away from you." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[33].Id , Step = 3 , Instruction = "Gently lean forward, keeping your hand stationary." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[33].Id , Step = 4 , Instruction = "Repeat with the other arm." },
            #endregion

            #region biceps & plate
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[34].Id , Step = 1 , Instruction = "" },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[35].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart and the plate in front of the torso, palms facing forward." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[35].Id , Step = 2 , Instruction = "Curl the plate up to the front of the shoulder while keeping the elbows close to the body." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[35].Id , Step = 3 , Instruction = "Rotate the palms to face forward and press the plate overhead, locking out the arms." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[35].Id , Step = 4 , Instruction = "Lower the plate back to the starting position, keeping control of it, and repeat for desired reps." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[36].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart and the plate in front of the torso, palms facing forward." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[36].Id , Step = 2 , Instruction = "Curl the plate up to the front of the shoulder while keeping the elbows close to the body." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[36].Id , Step = 3 , Instruction = "Rotate the palms to face forward and press the plate overhead, locking out the arms." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[36].Id , Step = 4 , Instruction = "Lower the plate back behind the head to the starting position of a tricep extension." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[36].Id , Step = 5 , Instruction = "Push the plate back up overhead, then lower it back to the starting position and repeat for desired reps." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[37].Id , Step = 1 , Instruction = "Lower into a squat position, keeping the plate at chest height." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[37].Id , Step = 2 , Instruction = "Slowly curl the plate towards your shoulders, keeping your elbows close to your body." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[37].Id , Step = 3 , Instruction = "Hold for a moment at the top of the curl before lowering the plate back to chest height." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[37].Id , Step = 4 , Instruction = "Repeat the curls as you hold the squat position." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[38].Id , Step = 1 , Instruction = "Make sure to keep your elbow close to your body and your core engaged throughout the movement." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[38].Id , Step = 2 , Instruction = "Bend forward at your hips while maintaining a flat back." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[38].Id , Step = 3 , Instruction = "Pull the plate toward your upper abdomen." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[38].Id , Step = 4 , Instruction = "Lower the weight in a controlled manner and repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[39].Id , Step = 1 , Instruction = "Grab the bar shoulder width apart with a supinated grip (palms facing you). Use a dip belt and the let the weight hang between your legs." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[39].Id , Step = 2 , Instruction = "With your body hanging and arms fully extended, pull yourself up until your chin is past the bar." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[39].Id , Step = 3 , Instruction = "Slowly return to starting position. Repeat." },
            #endregion

            #region Bosu ball
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[40].Id , Step = 1 , Instruction = "Hold the bosu vertically." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[40].Id , Step = 2 , Instruction = "Flex your elbows curling the bosu toward your chin." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[41].Id , Step = 1 , Instruction = "Hold bosu and hinge forward." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[41].Id , Step = 2 , Instruction = "Pull bosu towards chest, squeezing shoulder blades." },
            #endregion

            #region smith machine
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[42].Id , Step = 1 , Instruction = "Grab the bar with an underhand grip." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[42].Id , Step = 2 , Instruction = "Pull your elbows straight back and let the bar drag against your upper body (or very close to it)." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[43].Id , Step = 1 , Instruction = "Begin by standing in front of a bar with your feet about hip-width apart." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[43].Id , Step = 2 , Instruction = "Bend at the hips and knees to grab the bar with a supinated (underhand) grip, positioning the bar about an inch away from your shins." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[43].Id , Step = 3 , Instruction = "Keeping your back straight and your core engaged, use your back muscles to lift the bar straight up towards your chest." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[43].Id , Step = 4 , Instruction = "As the bar reaches your chest, pause briefly, and then lower the bar back to the starting position." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[44].Id , Step = 1 , Instruction = "Start hinged forward with a flat back. Make sure your elbows are fully extended." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[44].Id , Step = 2 , Instruction = "Pull the bar to your sternum." },

            #endregion

            #region dumbell
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[45].Id , Step = 1 , Instruction = "Stand up straight with a dumbbell in each hand at arm's length." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[45].Id , Step = 2 , Instruction = "Raise one dumbbell and twist your forearm until it is vertical and your palm faces the shoulder." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[45].Id , Step = 3 , Instruction = "Lower to original position and repeat with opposite arm" },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[46].Id , Step = 1 , Instruction = "Hold the dumbbells with a neutral grip (thumbs facing the ceiling)." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[46].Id , Step = 2 , Instruction = "Slowly lift the dumbbell up to chest height." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[46].Id , Step = 3 , Instruction = "Return to starting position and repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[47].Id , Step = 1 , Instruction = "Grab the dumbbells with a pronated (overhand) grip. You can do this exercise thumbless if it's more comfortable on your wrists." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[47].Id , Step = 2 , Instruction = "Flex at the elbows until your biceps touch your forearms. Try not to let your elbows flair outward." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[48].Id , Step = 1 , Instruction = "Hold the dumbbells with a neutral grip (thumbs facing the ceiling). Seated on an incline bench." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[48].Id , Step = 2 , Instruction = "Slowly lift the dumbbell up to chest height." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[48].Id , Step = 3 , Instruction = "Return to starting position and repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[49].Id , Step = 1 , Instruction = "Lay on an incline bench." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[49].Id , Step = 2 , Instruction = "Grab the dumbbells with a pronated (overhand) grip. You can do this exercise thumbless if it's more comfortable on your wrists." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[49].Id , Step = 3 , Instruction = "Flex at the elbows until your biceps touch your forearms. Try not to let your elbows flair outward." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[50].Id , Step = 1 , Instruction = "Lay on an incline bench with your palms facing forward." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[50].Id , Step = 2 , Instruction = "Flex at the elbows until your forearms touch your biceps." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[50].Id , Step = 3 , Instruction = "When you hit the top of the movement, rotate your palms and then lower the dumbbells slowly." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[51].Id , Step = 1 , Instruction = "Start with a with a dumbbell in one hand and your elbow resting on the bench." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[51].Id , Step = 2 , Instruction = "From this starting position, curl the dumbbell up towards your shoulder, keeping your upper arm stationary on the bench." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[52].Id , Step = 1 , Instruction = "Lay on an incline or preacher curl bench." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[52].Id , Step = 2 , Instruction = "Let your arms hang freely off the edge of the bench." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[52].Id , Step = 3 , Instruction = "Fully flex your elbow and fully extend your elbow on each rep." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[53].Id , Step = 1 , Instruction = "Start by placing your forearms on a flat bench and holding a dumbbell in each hand." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[53].Id , Step = 2 , Instruction = "From this starting position, curl the dumbbells up towards your shoulders, keeping your elbows close to your body and your core engaged." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[53].Id , Step = 3 , Instruction = "Slowly lower the dumbbells back down to the starting position, and repeat for the desired number of repetitions." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[54].Id , Step = 1 , Instruction = "Start by standing with your feet shoulder-width apart and holding a dumbbell in each hand." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[54].Id , Step = 2 , Instruction = "Bring the dumbbells to your sides, with your palms facing inward and your elbows bent." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[54].Id , Step = 3 , Instruction = "From this starting position, curl the dumbbells up towards your shoulders while rotating your wrists so that your palms face your shoulders at the top of the movement." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[55].Id , Step = 1 , Instruction = "Sit on a flat bench with your feet flat on the floor and your back straight." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[55].Id , Step = 2 , Instruction = "Lean forward and place your elbow on the inside of your leg." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[55].Id , Step = 3 , Instruction = "Curl the dumbbell while keeping your elbow against your leg. Make sure to fully extend your elbow on each rep." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[56].Id , Step = 1 , Instruction = "The dumbbells should be set on the ground. Hinge forward while keeping a flat back." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[56].Id , Step = 2 , Instruction = "Pull one elbow back toward the ceiling and then return the dumbbell to the ground softly." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[56].Id , Step = 3 , Instruction = "Then pull with the other arm." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[57].Id , Step = 1 , Instruction = "Place one hand and one knee on a bench. Make sure you keep a flat back." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[57].Id , Step = 2 , Instruction = "Pull the dumbbell toward the ceiling." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[57].Id , Step = 3 , Instruction = "Make sure to avoid any jerking or rotating." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[58].Id , Step = 1 , Instruction = "Lay on an incline bench that is between 30-45 degrees high." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[58].Id , Step = 2 , Instruction = "Let your arms hang freely. Pull your elbows straight back toward the ceiling." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[59].Id , Step = 1 , Instruction = "The dumbbells should be placed on the floor." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[59].Id , Step = 2 , Instruction = "Hinge forward with a flat back and grab the dumbbells." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[59].Id , Step = 3 , Instruction = "Pull both dumbbells back and your elbows toward the ceiling." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[59].Id , Step = 4 , Instruction = "Return the dumbbells back to the floor softly on each rep." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[60].Id , Step = 1 , Instruction = "Start by standing in front of a flat bench with your feet shoulder-width apart and holding a dumbbell in one hand." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[60].Id , Step = 2 , Instruction = "Place your other hand on the bench for support, and bend at the waist so that your chest is parallel to the ground." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[60].Id , Step = 3 , Instruction = "From this starting position, row the dumbbell up towards your chest, squeezing your shoulder blade together as you do so." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[60].Id , Step = 4 , Instruction = "Make sure to keep your elbow close to your body and your core engaged throughout the movement." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[61].Id , Step = 1 , Instruction = "Start by placing your elbow on one knee." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[61].Id , Step = 2 , Instruction = "Hold a dumbbell in your other hand, with your palm facing inwards towards your body." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[61].Id , Step = 3 , Instruction = "From this starting position, row the dumbbell up towards your chest, keeping your elbow close to your body and your core engaged." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[62].Id , Step = 1 , Instruction = "Stand with feet staggered and one hand on a bench/box. Hold a dumbbell in the opposing hand." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[62].Id , Step = 2 , Instruction = "Hinge forward at the hips, keeping the back flat, and eyes facing forward. The weight should hang directly below the shoulders." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[62].Id , Step = 3 , Instruction = "Start with an overhand grip, as you pull rotate the dumbbell. When your upper arm reaches your side your palm should be facing forward." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[63].Id , Step = 1 , Instruction = "Stand with feet staggered and one hand on your knee. Hold a dumbbell in the opposing hand." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[63].Id , Step = 2 , Instruction = "Hinge forward at the hips, keeping the back flat, and eyes facing forward. The weight should hang directly below the shoulders." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[63].Id , Step = 3 , Instruction = "Start with an overhand grip, as you pull rotate the dumbbell. When your upper arm reaches your side your palm should be facing forward." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[64].Id , Step = 1 , Instruction = "Grab both dumbbells and hinge forward at the hips. Make sure you keep a flat back." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[64].Id , Step = 2 , Instruction = "The closer your torso is to parallel with the ground the longer the range of motion will be at your shoulder. The better the results you'll get from the exercise." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[64].Id , Step = 3 , Instruction = "Let your arms hang freely, maintain an underhand grip, and then pull your elbow joint straight back toward the ceiling." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[65].Id , Step = 1 , Instruction = "Hinge forward at the hips while maintaining a flat back. Try to get your torso as close to parallel with the ground as your mobility will allow for." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[65].Id , Step = 2 , Instruction = "Let your arms hang in front of you. Pull your elbows back towards the ceiling while flaring your elbows outward." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[66].Id , Step = 1 , Instruction = "Sit at preacher bench, hold dumbbells in each hand with arm extended, palm facing up." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[66].Id , Step = 2 , Instruction = "Curl dumbbells towards shoulder, keeping upper arm stationary and elbows in." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[66].Id , Step = 3 , Instruction = "Lower dumbbell slowly back to start." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[67].Id , Step = 1 , Instruction = "Hold the dumbbells with an underhand grip. Seated on an incline bench." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[67].Id , Step = 2 , Instruction = "Slowly lift the dumbbell up to chest height." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[67].Id , Step = 3 , Instruction = "Return to starting position and repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[68].Id , Step = 1 , Instruction = "Grab the bar shoulder width apart with a supinated grip (palms facing you). Use a dip belt and the let the weight hang between your legs." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[68].Id , Step = 2 , Instruction = "With your body hanging and arms fully extended, pull yourself up until your chin is past the bar." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[68].Id , Step = 3 , Instruction = "Slowly return to starting position. Repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[69].Id , Step = 1 , Instruction = "Hold the dumbbells with an underhand grip. Seated on a bench." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[69].Id , Step = 2 , Instruction = "Start with the dumbbells pointed toward the ceiling, then lower the dumbbells toward your sides." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[69].Id , Step = 3 , Instruction = "Fully extend your elbows, but don't let your upper arm fall behind your torso." },

            #endregion

            #region Cables
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[70].Id , Step = 1 , Instruction = "Use a handle attachment set all the way to the top of the cable crossover machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[70].Id , Step = 2 , Instruction = "Walk a few steps away from the cable machine. Face your body sideways." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[70].Id , Step = 3 , Instruction = "Face your palm up toward the ceiling. Then pull your elbow in toward your rib cage." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[71].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[71].Id , Step = 2 , Instruction = "Face away from the cable machine. Stagger your stance so you have a better base of support." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[71].Id , Step = 3 , Instruction = "Start with a neutral grip. Flex at the elbow. While flexing twist your palm. When you hit the top of the movement your palm should be facing upward." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[72].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[72].Id , Step = 2 , Instruction = "Face away from the cable machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[72].Id , Step = 3 , Instruction = "Stagger your stance so you have a better base of support. Face your palm forward. Flex at the elbow and extend." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[73].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[73].Id , Step = 2 , Instruction = "Face away from the cable machine. Stagger your stance so you have a better base of support." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[73].Id , Step = 3 , Instruction = "Face your palm downwards. Flex at the elbow and extend." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[74].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[74].Id , Step = 2 , Instruction = "Face away from the cable machine. Stagger your stance so you have a better base of support." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[74].Id , Step = 3 , Instruction = "Use a neutral grip thumb facing up pinky-facing down). Flex at the elbow and extend." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[75].Id , Step = 1 , Instruction = "Place the cable at shoulder height. Use a row bar." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[75].Id , Step = 2 , Instruction = "Pull the handles back using your arms. Push out your chest." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[75].Id , Step = 3 , Instruction = "Pull the handles towards your body until your hands are beside your abdomen." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[76].Id , Step = 1 , Instruction = "Place the cable at shoulder height. Use a handle attachment. Face your palm upward." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[76].Id , Step = 2 , Instruction = "Pull the handle back using your arms. Push out your chest." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[76].Id , Step = 3 , Instruction = "Pull the handle towards your body until your hands are beside your abdomen." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[77].Id , Step = 1 , Instruction = "Place the cable at shoulder height. Use a handle attachment. Face your palm toward the midline of your body." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[77].Id , Step = 2 , Instruction = "Pull the handle back using your arms. Push out your chest." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[77].Id , Step = 3 , Instruction = "Pull the handle towards your body until your hands are beside your abdomen." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[78].Id , Step = 1 , Instruction = "Place the cable at shoulder height." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[78].Id , Step = 2 , Instruction = "Start with an overhand grip. As you pull your elbow back, rotate your palm until it faces upward." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[79].Id , Step = 1 , Instruction = "Place the cable at shoulder height." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[79].Id , Step = 2 , Instruction = "On the same side as the working arm, step back and rotate outwards." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[79].Id , Step = 3 , Instruction = "Pull your elbow back while flaring your elbow out." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[80].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[80].Id , Step = 2 , Instruction = "Face away from the cable machine and sit on the bench. Stagger your stance so you have a better base of support." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[80].Id , Step = 3 , Instruction = "Face your palm downwards. Flex at the elbow and extend." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[81].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[81].Id , Step = 2 , Instruction = "Face away from the cable machine and sit on the bench. Stagger your stance so you have a better base of support." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[81].Id , Step = 3 , Instruction = "Use a neutral grip thumb facing up pinky-facing down). Flex at the elbow and extend." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[82].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[82].Id , Step = 2 , Instruction = "Sit on a bench facing away from the cable machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[82].Id , Step = 3 , Instruction = "Stagger your stance so you have a better base of support. Face your palm forward. Flex at the elbow and extend." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[83].Id , Step = 1 , Instruction = "Use a bar attachment. The cable should be set all the way to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[83].Id , Step = 2 , Instruction = "Face the cable machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[83].Id , Step = 3 , Instruction = "Stagger your stance so you have a better base of support. Face your palm forward. Flex at the elbow and extend." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[84].Id , Step = 1 , Instruction = "Use a rope attachment. The cable should be set all the way to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[84].Id , Step = 2 , Instruction = "Face away from the cable machine. Stagger your stance so you have a better base of support." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[84].Id , Step = 3 , Instruction = "Use a neutral grip thumb facing up pinky-facing down). Flex at the elbow and extend." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[85].Id , Step = 1 , Instruction = "Stand facing away from the cables and grab two handle attachments." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[85].Id , Step = 2 , Instruction = "Take a neutral grip, flex your elbows, and extend." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[86].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[86].Id , Step = 2 , Instruction = "Face away from the cable machine. Stagger your stance so you have a better base of support." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[86].Id , Step = 3 , Instruction = "Face your palm downwards. Flex at the elbow and extend." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[87].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set all the way to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[87].Id , Step = 2 , Instruction = "Face away from the cable machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[87].Id , Step = 3 , Instruction = "Stagger your stance so you have a better base of support. Face your palm forward. Flex at the elbow and extend." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[88].Id , Step = 1 , Instruction = "Use a handle attachment. The cable should be set to about elbow height." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[88].Id , Step = 2 , Instruction = "Face away from the cable machine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[88].Id , Step = 3 , Instruction = "Stagger your stance so you have a better base of support. Face your palm forward. Flex at the elbow and extend." },
            #endregion

            #region TRX
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[89].Id , Step = 1 , Instruction = "Hold the TRX straps with an underhand grip and lean back and away from the anchor point." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[89].Id , Step = 2 , Instruction = "Keep your elbows high as you flex your elbows. Pull your fists toward your forehead." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[90].Id , Step = 1 , Instruction = "Grab the TRX straps and lean away from the anchor point." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[90].Id , Step = 2 , Instruction = "Maintain a neutral grip. Flex your elbows and pull your fists to either sides of your temples." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[91].Id , Step = 1 , Instruction = "Stand facing the TRX straps and grasp the handles with both hands, palms facing away from your body." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[91].Id , Step = 2 , Instruction = "Walk back until the straps are taut, keeping your arms straight." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[91].Id , Step = 3 , Instruction = "Slowly curl your hands towards your shoulders, keeping your elbows close to your body." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[92].Id , Step = 1 , Instruction = "Grab the TRX straps and lean away from the anchor point until the strap is taut." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[92].Id , Step = 2 , Instruction = "Start with an overhand grip. Pull your elbows back and rotate your grip." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[92].Id , Step = 3 , Instruction = "By the time your elbows reach your side, your palms should be facing upwards." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[93].Id , Step = 1 , Instruction = "Hold the TRX strap with one hand." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[93].Id , Step = 2 , Instruction = "Lean back until the strap is taut. Fully extend your elbow." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[93].Id , Step = 3 , Instruction = "Pull your elbow behind the body. Make sure to avoid twisting. Try to keep your shoulders even." },
            #endregion

            #region Vitruvian
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[94].Id , Step = 1 , Instruction = "Hold a neutral grip." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[94].Id , Step = 2 , Instruction = "Flex your elbows until your forearms touch your biceps." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[94].Id , Step = 3 , Instruction = "Extend your elbows fully to finish each rep." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[95].Id , Step = 1 , Instruction = "Take a staggered stance and hinge forward." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[95].Id , Step = 2 , Instruction = "Grab one of the handle attachments and pull your elbow toward the ceiling." },
            #endregion
                
            #region Recovery
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[96].Id , Step = 1 , Instruction = "Bring yourself to the 4 point position (on all fours). 90° angles at hips and shoulder and neutral spine." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[96].Id , Step = 2 , Instruction = "Lift your knees slightly off the ground supporting your weight on palms and toes." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[96].Id , Step = 3 , Instruction = "Maintain a toe placement roughly at shoulder width (the wider the leg stance the easier the exercise - the narrower the stance the more difficult it becomes." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[96].Id , Step = 4 , Instruction = "Tap your opposite shoulder with your fingertips." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[97].Id , Step = 1 , Instruction = "Stand up straight and hold a dumbbell in one arm. Perform a bicep curl across your body" },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[97].Id , Step = 2 , Instruction = "Bring the dumbbell to your shoulder and rotate palm and elbow out." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[97].Id , Step = 3 , Instruction = "Point the elbow towards the ceiling while the dumbbell remains just over the shoulder." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[97].Id , Step = 4 , Instruction = "Extend your elbow to raise the dumbbell over your head. Start lowering your arm to your side as you turn the palm to face down" },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[98].Id , Step = 1 , Instruction = "Abduct your arm at 90° palm facing down." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[98].Id , Step = 2 , Instruction = "Bend your elbow and wrist bringing your front of your fingertips to your temple while leaning the head towards the the arm." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[98].Id , Step = 3 , Instruction = "Lean the head away from the arm as you extend the elbow and flex the wrist." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[98].Id , Step = 4 , Instruction = "Alternate between positions to mobilise the ulnar nerve." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[99].Id , Step = 1 , Instruction = "Abduct your arm at 90° palm facing down." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[99].Id , Step = 2 , Instruction = "Bend your elbow and wrist to bring the palm to face the ceiling while leaning the head towards the opposite shoulder." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[99].Id , Step = 3 , Instruction = "Find the position of maximum tension (without pain) and hold." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[99].Id , Step = 4 , Instruction = "To increase the stretch, press the palm against the face and try to point the elbow up." },
            #endregion

            #region bodyweight
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[100].Id , Step = 1 , Instruction = "Grab the bar shoulder width apart with a supinated grip (palms facing you)" },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[100].Id , Step = 2 , Instruction = "With your body hanging and arms fully extended, pull yourself up until your chin is past the bar." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[100].Id , Step = 3 , Instruction = "Slowly return to starting position. Repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[101].Id , Step = 1 , Instruction = "Grasp the chin-up bar with an underhand grip, shoulder-width apart." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[101].Id , Step = 2 , Instruction = "Place your feet on the ground, legs bent slightly." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[101].Id , Step = 3 , Instruction = "Use your legs to assist as you pull your chin above the bar." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[102].Id , Step = 1 , Instruction = "Grasp the chin-up bar with an underhand grip, shoulder-width apart." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[102].Id , Step = 2 , Instruction = "Place your feet on the ground, legs bent slightly." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[102].Id , Step = 3 , Instruction = "Use your legs to assist as you pull your chest to the bar." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[103].Id , Step = 1 , Instruction = "Grasp the chin-up bar with a mixed grip, shoulder-width apart." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[103].Id , Step = 2 , Instruction = "Place your feet on the ground, legs bent slightly." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[103].Id , Step = 3 , Instruction = "Use your legs to assist as you pull your chin above the bar." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[104].Id , Step = 1 , Instruction = "Grasp the chin-up bar with an overhand grip, shoulder-width apart." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[104].Id , Step = 2 , Instruction = "Place your feet on the ground, legs bent slightly." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[104].Id , Step = 3 , Instruction = "Use your legs to assist as you pull your chin above the bar." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[105].Id , Step = 1 , Instruction = "Hang from a bar with your feet on the floor." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[105].Id , Step = 2 , Instruction = "Break at the elbows and curl your body towards the bar." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[106].Id , Step = 1 , Instruction = "Grab the bar with a close grip. Feet on the floor." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[106].Id , Step = 2 , Instruction = "Break at the elbow and curl your body toward the bar." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[107].Id , Step = 1 , Instruction = "Place your elbow on one knee and your hand underneath the other leg. Keep the leg that's over your hand extended." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[107].Id , Step = 2 , Instruction = "Curl the working arm and use your leg as the resistance." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[108].Id , Step = 1 , Instruction = "Lay underneath a fixed horizontal bar and grab the bar with an underhand grip." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[108].Id , Step = 2 , Instruction = "Pull your body straight up to the bar." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[108].Id , Step = 3 , Instruction = "Return to the starting position, your arms fully extended. Repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[109].Id , Step = 1 , Instruction = "Set up rings at a high point." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[109].Id , Step = 2 , Instruction = "Grip rings and lean back, arms extended." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[109].Id , Step = 3 , Instruction = "Pull chest to rings, keeping body straight." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[110].Id , Step = 1 , Instruction = "Stand holding gymnastic rings with your arms extended in front of you, palms facing up." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[110].Id , Step = 2 , Instruction = "Curl rings towards shoulders, squeezing biceps." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[110].Id , Step = 3 , Instruction = "Slowly lower rings back to starting position, keeping control. Repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[111].Id , Step = 1 , Instruction = "Grab the bar shoulder width apart with a supinated grip (palms facing you)." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[111].Id , Step = 2 , Instruction = "With your body in an \"L\" position and arms fully extended, pull yourself up until your chin is past the bar." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[111].Id , Step = 3 , Instruction = "Slowly return to starting position. Repeat." },
            #endregion

            #region kettlebells
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[112].Id , Step = 1 , Instruction = "Stand up straight with a kettlebell in both hands in front of your pelvis." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[112].Id , Step = 2 , Instruction = "Raise the kettlebell bending your arms at the elbow until the kettlebell is level with your chest." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[112].Id , Step = 3 , Instruction = "Lower to the starting position and repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[113].Id , Step = 1 , Instruction = "Sitting on a chair with your legs apart, rest your arm against your thigh and hold the kettlebell with your arm extended towards the floor." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[113].Id , Step = 2 , Instruction = "Bending your arm at the elbow, lift the kettlebell until your palm faces your shoulder." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[113].Id , Step = 3 , Instruction = "Lower to the starting position and repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[114].Id , Step = 1 , Instruction = "Stand behind a bench, with your chest leaning over the edge of the bench." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[114].Id , Step = 2 , Instruction = "With one arm resting on the bench, hold the kettlebell, bending the arm at the elbow." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[114].Id , Step = 3 , Instruction = "Lower your arm using the bench as a guide, keeping your forearm straight." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[114].Id , Step = 4 , Instruction = "Return to the starting position and repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[115].Id , Step = 1 , Instruction = "Stand up straight with a kettlebell in one hand with your forearm facing out." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[115].Id , Step = 2 , Instruction = "Raise the kettlebell, bending your arm at the elbow and keeping your forearm vertical until your palm faces the shoulder." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[115].Id , Step = 3 , Instruction = "Lower to the starting position and repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[116].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart, kettlebell in one hand." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[116].Id , Step = 2 , Instruction = "Bend at hips, row kettlebell to chest." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[116].Id , Step = 3 , Instruction = "Alternate hands for each row." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[117].Id , Step = 1 , Instruction = "Grab two kettlebells, stand tall." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[117].Id , Step = 2 , Instruction = "Curl kettlebells toward chest." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[117].Id , Step = 3 , Instruction = "Lower kettlebells, repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[118].Id , Step = 1 , Instruction = "Stand with kettlebell between legs." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[118].Id , Step = 2 , Instruction = "Hinge at hips, grab kettlebell, pull to chest and rotate at the torso." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[119].Id , Step = 1 , Instruction = "Stand with feet hip-width apart." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[119].Id , Step = 2 , Instruction = "Hold kettlebell with palms facing down." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[119].Id , Step = 3 , Instruction = "Lift kettlebell toward shoulders, squeezing biceps, then lower with control." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[120].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart, hold a kettlebell in each hand." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[120].Id , Step = 2 , Instruction = "Hinge at hips, keep back straight, and pull both kettlebells to hips." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[121].Id , Step = 1 , Instruction = "Stand with feet hip-width apart." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[121].Id , Step = 2 , Instruction = "Hold a kettlebell with palms facing down." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[121].Id , Step = 3 , Instruction = "Lift kettlebell toward shoulders, squeezing biceps, then lower with control." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[122].Id , Step = 1 , Instruction = "Start by standing in front of a flat bench with your feet shoulder-width apart and holding a kettlebell in one hand." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[122].Id , Step = 2 , Instruction = "Place your other hand on the bench for support, and bend at the waist so that your chest is parallel to the ground." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[122].Id , Step = 3 , Instruction = "From this starting position, row the kettlebell up towards your chest, squeezing your shoulder blade together as you do so." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[122].Id , Step = 4 , Instruction = "Make sure to keep your elbow close to your body and your core engaged throughout the movement." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[123].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart holding the kettlebell with both hands in front of your thighs." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[123].Id , Step = 2 , Instruction = "Bend forward at the hips bringing the kettlebell to the floor while you slightly bend your knees, keeping your back straight." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[123].Id , Step = 3 , Instruction = "Lift the kettlebell upwards towards your chest and lower - repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[124].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart, shifting one foot behind you. Hold the kettlebell in the same hand as the leg shifted backwards." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[124].Id , Step = 2 , Instruction = "Bend forwards at the hips bringing the kettlebell to the floor while you slightly bend your knee, keeping your back straight." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[124].Id , Step = 3 , Instruction = "Lift the kettlebell upwards towards your chest and lower - repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[125].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart, holding the kettlebell with both hands in front of your thighs." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[125].Id , Step = 2 , Instruction = "Bend forward at the hips bringing the kettlebell to the floor while you slightly bend your knees, keeping your back straight." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[125].Id , Step = 3 , Instruction = "Lift the kettlebell upwards towards your upper chest and then lower the kettlebell- repeat." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[126].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, kettlebell in each hand, hinge at hips." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[126].Id , Step = 2 , Instruction = "Pull kettlebells while flaring your elbows, squeezing shoulder blades. Keep back flat." },
            #endregion

            #region bands
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[127].Id , Step = 1 , Instruction = "Attach band to a low anchor point. Point your palms straight forward." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[127].Id , Step = 2 , Instruction = "Flex your elbow until you feel your biceps contract. Then fully extend elbows." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[128].Id , Step = 1 , Instruction = "Attach band to a low anchor point. Use a neutral grip." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[128].Id , Step = 2 , Instruction = "Flex your elbow until you feel your biceps contract. Then fully extend elbows." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[129].Id , Step = 1 , Instruction = "Place the band at about eye level. Fall into a kneeling position." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[129].Id , Step = 2 , Instruction = "The knee that is on the ground should be the same side as the working arm. Stick your chest out." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[129].Id , Step = 3 , Instruction = "And then pull your elbow straight back. Flex your lats and then extend into the starting position." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[130].Id , Step = 1 , Instruction = "Attach band to a low anchor point. . Point your palms toward your thighs." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[130].Id , Step = 2 , Instruction = "Flex your elbow until you feel your biceps contract. Then fully extend elbows." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[131].Id , Step = 1 , Instruction = "Stand on your band with both feet." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[131].Id , Step = 2 , Instruction = "Hinge forward at the hips while keeping a flat back." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[131].Id , Step = 3 , Instruction = "Let your arms hang freely, then pull your elbows straight back toward the ceiling." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[132].Id , Step = 1 , Instruction = "Anchor a band to a high point." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[132].Id , Step = 2 , Instruction = "Start with your feet staggered and your elbows high." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[132].Id , Step = 3 , Instruction = "Flex your elbows while keeping your arms high. Curl the band to your forehead." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[133].Id , Step = 1 , Instruction = "Start with the band anchored to something high with your feet staggered and a neutral grip." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[133].Id , Step = 2 , Instruction = "Keep your elbows high. Curl until your fists are at your forehead." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[134].Id , Step = 1 , Instruction = "Start with a band attached to a high point, your feet staggered, and an overhand grip." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[134].Id , Step = 2 , Instruction = "Flex your elbows pulling your forearms to your biceps. Your fists should land by your forehead." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[135].Id , Step = 1 , Instruction = "Stand with your feet shoulder-width apart, with the band under both feet." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[135].Id , Step = 2 , Instruction = "Grasp the handles of the band with both hands, keeping your arms straight and extended in front of you." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[135].Id , Step = 3 , Instruction = "Keep your back straight, abs engaged, and shoulders relaxed as you curl your hands towards your shoulders, bending at the elbows." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[136].Id , Step = 1 , Instruction = "Start by standing on the center of the band with both feet, shoulder-width apart." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[136].Id , Step = 2 , Instruction = "Hold the band with both hands, palms facing down, arms extended straight in front of you." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[136].Id , Step = 3 , Instruction = "Slowly curl your hands towards your shoulders, pulling the band tight, then lower your arms back to the starting position, keeping tension on the band throughout the exercise." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[137].Id , Step = 1 , Instruction = "Anchor the band to a stable point and take a half squat position." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[137].Id , Step = 2 , Instruction = "Hold the band loop in one hand and pull your elbow straight back." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[138].Id , Step = 1 , Instruction = "Anchor the band to a stable point." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[138].Id , Step = 2 , Instruction = "Take a half squat position and hold there." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[138].Id , Step = 3 , Instruction = "Perform a row while holding the squat position." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[139].Id , Step = 1 , Instruction = "Anchor the band to a high point. Go into a seated position." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[139].Id , Step = 2 , Instruction = "Grab the loop of the band and pull your upper arm to your side." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[140].Id , Step = 1 , Instruction = "Anchor band to a stable point." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[140].Id , Step = 2 , Instruction = "Step back until there is no slack in the band and hold the end of the band with one hand." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[140].Id , Step = 3 , Instruction = "Pull through the elbow straight back." },
            #endregion

            #region Yoga
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[141].Id , Step = 1 , Instruction = "Lie down on your back with your legs straight and arms at your sides." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[141].Id , Step = 2 , Instruction = "Close your eyes and take deep breaths in through your nose and out through your mouth." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[141].Id , Step = 3 , Instruction = "Allow your body to completely relax and let go of any tension." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[141].Id , Step = 4 , Instruction = "Hold for several minutes and then slowly come back up to a seated position." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[142].Id , Step = 1 , Instruction = "Begin in a squatting position with your feet together and your knees apart." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[142].Id , Step = 2 , Instruction = "Place your hands on the floor in front of you, shoulder-width apart. Keep your arms straight and engage your core." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[142].Id , Step = 3 , Instruction = "Slowly shift your weight forward and lift your feet off the ground, coming onto your tiptoes." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[142].Id , Step = 4 , Instruction = "Bend your elbows and lean your weight onto your hands, shifting your knees towards your upper arms." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[142].Id , Step = 5 , Instruction = "Gently lift one foot off the ground, and then the other, balancing on your hands. Hold the pose for a few breaths before releasing back to the ground." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[143].Id , Step = 1 , Instruction = "Begin on your hands and knees with your hands shoulder-width apart and your knees hip-width apart." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[143].Id , Step = 2 , Instruction = "Spread your fingers wide and press down into your palms, making sure that your fingers are evenly spaced and facing forward." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[143].Id , Step = 3 , Instruction = "Tuck your toes under and lift your knees off the ground, straightening your legs as much as possible." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[143].Id , Step = 4 , Instruction = "Press your hips up and back, bringing your body into an inverted \"V\" shape." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[143].Id , Step = 5 , Instruction = "Keep your arms straight and your shoulder blades spread apart, and try to press your heels down towards the ground." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[143].Id , Step = 6 , Instruction = "Hold the pose for several breaths, then release and return to your starting position." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[144].Id , Step = 1 , Instruction = "Begin in the same starting position as the previous exercise, with your hands and knees on the ground." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[144].Id , Step = 2 , Instruction = "Spread your fingers wide and turn your hands so that your fingers are facing towards your feet." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[144].Id , Step = 3 , Instruction = "Tuck your toes under and lift your knees off the ground, straightening your legs as much as possible." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[144].Id , Step = 4 , Instruction = "Press your hips up and back, bringing your body into an inverted \"V\" shape." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[144].Id , Step = 5 , Instruction = "Keep your arms straight and your shoulder blades spread apart, and try to press your heels down towards the ground." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[144].Id , Step = 6 , Instruction = "Hold the pose for several breaths, then release and return to your starting position." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[145].Id , Step = 1 , Instruction = "Begin in a downward-facing dog pose." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[145].Id , Step = 2 , Instruction = "Slowly lift one leg up towards the ceiling, keeping your hips level and your toes pointed." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[145].Id , Step = 3 , Instruction = "Bend your lifted leg and try to touch your toes to the back of your head." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[145].Id , Step = 4 , Instruction = "Once you have a firm grip with your toes, slowly begin to twist your torso towards the lifted leg." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[145].Id , Step = 5 , Instruction = "Keep your hands and feet firmly planted on the ground as you hold the pose for a few breaths. Release the pose and repeat on the other side." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[146].Id , Step = 1 , Instruction = "Sit cross-legged on the floor." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[146].Id , Step = 2 , Instruction = "Extend your arms straight out in front of you, palms facing forward." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[146].Id , Step = 3 , Instruction = "Cross your right arm over your left arm and interlace your fingers." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[146].Id , Step = 4 , Instruction = "Pull your hands away from your body and hold for a few breaths, then release and repeat with the opposite arm on top." },

            #endregion

            #region Cardio
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[147].Id , Step = 1 , Instruction = "Stand with a band looped under both feet and the band grasped in both hands." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[147].Id , Step = 2 , Instruction = "Do a light hop and bring your feet outward while simultaneously flexing the elbows." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[147].Id , Step = 3 , Instruction = "Bring both feet back together and extend the elbows." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[148].Id , Step = 1 , Instruction = "Make sure your feet are strapped in tightly." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[148].Id , Step = 2 , Instruction = "Without bending your legs, pull the handle to your ribcage." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[148].Id , Step = 3 , Instruction = "Fully extend your elbows before initiating the next rep." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[149].Id , Step = 1 , Instruction = "Sit on seat, feet strapped in, grip handle with arms extended." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[149].Id , Step = 2 , Instruction = "Push with legs, lean back slightly. Do four small pulls with increasing distance on each rep." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[149].Id , Step = 3 , Instruction = "Extend arms, lean forward from hips, bend knees to return to start." },

            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[150].Id , Step = 1 , Instruction = "Sit on seat, feet strapped in, grip handle with arms extended." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[150].Id , Step = 2 , Instruction = "Push with legs, lean back slightly, pull handle to lower ribs." },
            new WorkoutInstruction{ WorkoutId = bicepsWorkouts[150].Id , Step = 3 , Instruction = "Extend arms, lean forward from hips, bend knees to return to start." },
	        #endregion

        };
        await context.WorkoutInstructions.AddRangeAsync(bicepsWorkoutInstruction);
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
            #region Barbell & biceps
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[0].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[1].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[2].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[3].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[4].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[5].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[6].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[7].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[8].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[9].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[10].Id, EquipmentId =barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[11].Id, EquipmentId =barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[12].Id, EquipmentId =barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[13].Id, EquipmentId =barbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[14].Id, EquipmentId =ezbarId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[15].Id, EquipmentId =ezbarId },
            #endregion

            #region Biceps & Machine
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[16].Id, EquipmentId = cableMachineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[17].Id, EquipmentId = cableMachineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[18].Id, EquipmentId = cableMachineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[19].Id, EquipmentId = cableMachineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[20].Id, EquipmentId = pullUpMachineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[21].Id, EquipmentId = pullUpMachineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[22].Id, EquipmentId = pullUpMachineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[23].Id, EquipmentId = pullUpMachineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[24].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[25].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[26].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[27].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[28].Id, EquipmentId = machineId },
            #endregion

            #region biceps & stretches
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[29].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[30].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[31].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[32].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[33].Id, EquipmentId = stretchesId },
            #endregion

            #region biceps & plate
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[34].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[35].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[36].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[37].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[38].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[39].Id, EquipmentId = plateId },
            #endregion

            #region bosuball
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[40].Id, EquipmentId = bosuballId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[41].Id, EquipmentId = bosuballId },
            #endregion

            #region smithMachine
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[42].Id, EquipmentId = smithMachineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[43].Id, EquipmentId = smithMachineId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[44].Id, EquipmentId = smithMachineId },
            #endregion

            #region dumbell
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[45].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[46].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[47].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[48].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[49].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[50].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[51].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[52].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[53].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[54].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[55].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[56].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[57].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[58].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[59].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[60].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[61].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[62].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[63].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[64].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[65].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[66].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[67].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[68].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[69].Id, EquipmentId = dumbellId },
            #endregion

            #region Cables
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[70].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[71].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[72].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[73].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[74].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[75].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[76].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[77].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[78].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[79].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[80].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[81].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[82].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[83].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[84].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[85].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[86].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[87].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[88].Id, EquipmentId = cableId },
            #endregion

            #region TRX
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[89].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[90].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[91].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[92].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[93].Id, EquipmentId = trxId },
            #endregion

            #region Vitruvian
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[94].Id, EquipmentId = vitruvianId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[95].Id, EquipmentId = vitruvianId },
            #endregion
                
            #region Recovery
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[96].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[97].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[98].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[99].Id, EquipmentId = cardioId },
            #endregion

            #region bodyweight
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[100].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[101].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[102].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[103].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[104].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[105].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[106].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[107].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[108].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[109].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[110].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[111].Id, EquipmentId = bodyweightId },
            #endregion

            #region kettlebells
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[112].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[112].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[112].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[112].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[112].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[112].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[112].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[112].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[112].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[126].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[126].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[126].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[126].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[126].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[126].Id, EquipmentId = kettlebellId },
            #endregion

            #region bands
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[127].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[128].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[129].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[130].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[131].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[132].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[133].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[134].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[135].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[136].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[137].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[138].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[139].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[140].Id, EquipmentId = BandsId },
            #endregion

            #region Yoga
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[141].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[142].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[143].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[144].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[145].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[146].Id, EquipmentId = yogaId },
            #endregion

            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[147].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[148].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[149].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = bicepsWorkouts[150].Id, EquipmentId = BandsId },
        };
        await context.WorkoutEquipment.AddRangeAsync(workoutEquipment);
        await context.SaveChangesAsync();

        // ***************************************************************** //
        var workoutLevel = new List<WorkoutLevel>();
        workoutLevel = new List<WorkoutLevel>
        {
            #region barbell & biceps
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[0].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[1].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[2].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[3].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[4].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[5].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[6].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[7].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[8].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[9].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[10].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[11].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[12].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[13].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[14].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[15].Id , Level = Difficulty.Novice},
            #endregion

            #region biceps & Machine
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[16].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[17].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[18].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[19].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[20].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[21].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[22].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[23].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[24].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[25].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[26].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[27].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[28].Id , Level = Difficulty.Novice},
            #endregion

            #region biceps & stretches
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[29].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[30].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[31].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[32].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[33].Id , Level = Difficulty.Novice},
            #endregion

            #region biceps & plate
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[34].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[35].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[36].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[37].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[38].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[39].Id , Level = Difficulty.Advanced},
            #endregion

            #region bosu Ball
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[40].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[41].Id , Level = Difficulty.Beginner},
            #endregion

            #region smith Machine
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[42].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[43].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[44].Id , Level = Difficulty.Beginner},
            #endregion

            #region dumbell
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[45].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[46].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[47].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[48].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[49].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[50].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[51].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[52].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[53].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[54].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[55].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[56].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[57].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[58].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[59].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[60].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[61].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[62].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[63].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[64].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[65].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[66].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[67].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[68].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[69].Id , Level = Difficulty.Beginner},
            #endregion

            #region Cables
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[70].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[71].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[72].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[73].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[74].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[75].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[76].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[77].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[78].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[79].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[80].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[81].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[82].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[83].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[84].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[85].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[86].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[87].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[88].Id , Level = Difficulty.Beginner},
            #endregion

            #region TRX
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[89].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[90].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[91].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[92].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[93].Id , Level = Difficulty.Beginner},

            #endregion

            #region Vitruvian
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[94].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[95].Id , Level = Difficulty.Beginner },
                
            #endregion
                
            #region Recovery
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[96].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[97].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[98].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[99].Id , Level = Difficulty.Novice},
            #endregion

            #region bodyweight
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[100].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[101].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[102].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[103].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[104].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[105].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[106].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[107].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[108].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[109].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[110].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[111].Id , Level = Difficulty.Intermediate},
            #endregion

            #region kettlebells
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[112].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[112].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[112].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[112].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[112].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[112].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[112].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[112].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[120].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[120].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[120].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[120].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[120].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[120].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[126].Id , Level = Difficulty.Beginner},
            #endregion

            #region bands
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[127].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[128].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[129].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[130].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[131].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[132].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[133].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[134].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[135].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[136].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[137].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[138].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[139].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[140].Id , Level = Difficulty.Novice },
            #endregion

            #region Yoga
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[141].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[142].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[143].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[144].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[145].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[146].Id , Level = Difficulty.Beginner},
            #endregion

            new WorkoutLevel{ WorkoutId = bicepsWorkouts[147].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[148].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[149].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = bicepsWorkouts[150].Id , Level = Difficulty.Beginner},

        };
        await context.WorkoutLevels.AddRangeAsync(workoutLevel);
        await context.SaveChangesAsync();

        // ***************************************************************** //
        var bodyWorkouts = new List<BodyWorkout>();
        var bicepId = await context.Bodies.Where(z => z.Name == "Biceps").Select(z => z.Id).FirstOrDefaultAsync();
        var longHeadBicepId = await context.Bodies.Where(z => z.Name == "Long Head Bicep").Select(z => z.Id).FirstOrDefaultAsync();
        var shortHeadBicepId = await context.Bodies.Where(z => z.Name == "Short Head Bicep").Select(z => z.Id).FirstOrDefaultAsync();

        if (!await context.BodyWorkouts.AnyAsync(z => z.BodyId == bicepId))
        {
            bodyWorkouts = new List<BodyWorkout>
            {
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[0].Id, Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = longHeadBicepId, WorkoutId = bicepsWorkouts[0].Id, Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = shortHeadBicepId, WorkoutId = bicepsWorkouts[0].Id, Target = PriorityTarget.Primary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[1].Id  ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[2].Id  ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[3].Id  ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[4].Id  ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[5].Id  ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[6].Id  ,Target = PriorityTarget.Secondary},
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[7].Id  ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[8].Id  ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[9].Id  ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[10].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[11].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = longHeadBicepId, WorkoutId = bicepsWorkouts[11].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = shortHeadBicepId, WorkoutId = bicepsWorkouts[11].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[12].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[13].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[14].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[15].Id ,Target = PriorityTarget.Primary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[16].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[17].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[18].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[19].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[20].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[21].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[22].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[23].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[24].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[25].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[26].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[27].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[28].Id ,Target = PriorityTarget.Primary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[29].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[30].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[31].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[32].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[33].Id ,Target = PriorityTarget.Primary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[34].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[35].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[36].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[37].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[38].Id ,Target = PriorityTarget.Tertiary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[39].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[40].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[41].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[42].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = longHeadBicepId, WorkoutId = bicepsWorkouts[42].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = shortHeadBicepId, WorkoutId = bicepsWorkouts[42].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[43].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[44].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[45].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[46].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = shortHeadBicepId, WorkoutId = bicepsWorkouts[46].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[47].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[48].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = longHeadBicepId, WorkoutId = bicepsWorkouts[48].Id ,Target = PriorityTarget.Primary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[49].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = longHeadBicepId, WorkoutId = bicepsWorkouts[49].Id ,Target = PriorityTarget.Primary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[50].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = longHeadBicepId, WorkoutId = bicepsWorkouts[50].Id ,Target = PriorityTarget.Primary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[51].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[52].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[53].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[54].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[55].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[56].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[57].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[58].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[59].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[60].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[61].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[62].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[63].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[64].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[65].Id ,Target = PriorityTarget.Tertiary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[66].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[67].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[68].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[69].Id ,Target = PriorityTarget.Primary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[70].Id ,Target = PriorityTarget.Secondary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[71].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[72].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = longHeadBicepId, WorkoutId = bicepsWorkouts[72].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = shortHeadBicepId, WorkoutId = bicepsWorkouts[72].Id ,Target = PriorityTarget.Primary  },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[73].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[74].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[75].Id ,Target = PriorityTarget.Secondary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[76].Id ,Target = PriorityTarget.Secondary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[77].Id ,Target = PriorityTarget.Secondary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[78].Id ,Target = PriorityTarget.Tertiary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[79].Id ,Target = PriorityTarget.Tertiary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[80].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[81].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[82].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = longHeadBicepId, WorkoutId = bicepsWorkouts[82].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = shortHeadBicepId, WorkoutId = bicepsWorkouts[82].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[83].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = longHeadBicepId, WorkoutId = bicepsWorkouts[83].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = shortHeadBicepId, WorkoutId = bicepsWorkouts[83].Id ,Target = PriorityTarget.Primary  },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[84].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = longHeadBicepId, WorkoutId = bicepsWorkouts[84].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = shortHeadBicepId, WorkoutId = bicepsWorkouts[84].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[85].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = longHeadBicepId, WorkoutId = bicepsWorkouts[85].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[86].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[87].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = longHeadBicepId, WorkoutId = bicepsWorkouts[87].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = shortHeadBicepId, WorkoutId = bicepsWorkouts[87].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[88].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = longHeadBicepId, WorkoutId = bicepsWorkouts[88].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = shortHeadBicepId, WorkoutId = bicepsWorkouts[88].Id ,Target = PriorityTarget.Primary  },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[89].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[90].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[91].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[92].Id ,Target = PriorityTarget.Secondary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[93].Id ,Target = PriorityTarget.Secondary  },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[94].Id ,Target = PriorityTarget.Primary  },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[95].Id ,Target = PriorityTarget.Secondary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[96].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[97].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[98].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[99].Id ,Target = PriorityTarget.Primary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[100].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[101].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[102].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[103].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[104].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[105].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[106].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[107].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[108].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[109].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[110].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[111].Id ,Target = PriorityTarget.Secondary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[112].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[113].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[114].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[115].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[116].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[117].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[118].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[119].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[120].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[121].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[122].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[123].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[124].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[125].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[126].Id ,Target = PriorityTarget.Tertiary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[127].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[128].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[129].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[130].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[131].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[132].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[133].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[134].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[135].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[136].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[137].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[138].Id ,Target = PriorityTarget.Secondary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[139].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[140].Id ,Target = PriorityTarget.Primary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[141].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[142].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[143].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[144].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[145].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[146].Id ,Target = PriorityTarget.Primary },

                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[147].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[148].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[149].Id ,Target = PriorityTarget.Primary },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = bicepsWorkouts[150].Id ,Target = PriorityTarget.Primary },
            };
        }
        await context.BodyWorkouts.AddRangeAsync(bodyWorkouts);
        await context.SaveChangesAsync();

        // ***************************************************************** //
        var workoutSex = new List<WorkoutSex>();
        workoutSex = new List<WorkoutSex>
        {
            new WorkoutSex{ WorkoutId = bicepsWorkouts[0].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[0].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[1].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[1].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[2].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[2].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[3].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[3].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[4].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[4].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[5].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[5].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[6].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[6].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[7].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[7].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[8].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[8].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[9].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[9].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[10].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[10].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[11].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[11].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[12].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[12].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[13].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[13].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[14].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[14].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[15].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[15].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[16].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[16].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[17].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[17].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[18].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[18].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[19].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[19].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[20].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[20].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[21].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[21].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[22].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[22].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[23].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[23].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[24].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[24].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[25].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[25].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[26].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[26].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[27].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[27].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[28].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[28].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[29].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[29].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[30].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[30].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[31].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[31].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[32].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[32].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[33].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[33].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[34].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[34].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[35].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[35].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[36].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[36].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[37].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[37].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[38].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[38].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[39].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[39].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[40].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[40].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[41].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[41].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[42].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[42].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[43].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[43].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[44].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[44].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[45].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[45].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[46].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[46].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[47].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[47].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[48].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[48].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[49].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[49].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[50].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[50].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[51].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[51].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[52].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[52].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[53].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[53].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[54].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[54].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[55].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[55].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[56].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[56].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[57].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[57].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[58].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[58].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[59].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[59].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[60].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[60].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[61].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[61].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[62].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[62].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[63].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[63].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[64].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[64].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[65].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[65].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[66].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[66].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[67].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[67].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[68].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[68].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[69].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[69].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[70].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[70].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[71].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[71].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[72].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[72].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[73].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[73].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[74].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[74].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[75].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[75].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[76].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[76].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[77].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[77].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[78].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[78].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[79].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[79].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[80].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[80].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[81].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[81].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[82].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[82].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[83].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[83].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[84].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[84].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[85].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[85].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[86].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[86].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[87].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[87].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[88].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[88].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[89].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[89].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[90].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[90].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[91].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[91].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[92].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[92].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[93].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[93].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[94].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[94].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[95].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[95].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[96].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[96].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[97].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[97].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[98].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[98].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[99].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[99].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[100].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[100].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[101].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[101].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[102].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[102].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[103].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[103].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[104].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[104].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[105].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[105].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[106].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[106].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[107].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[107].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[108].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[108].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[109].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[109].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[110].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[110].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[111].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[111].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[112].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[112].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[113].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[113].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[114].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[114].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[115].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[115].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[116].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[116].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[117].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[117].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[118].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[118].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[119].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[119].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[120].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[120].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[121].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[121].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[122].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[122].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[123].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[123].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[124].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[124].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[125].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[125].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[126].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[126].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[127].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[127].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[128].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[128].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[129].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[129].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[130].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[130].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[131].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[131].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[132].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[132].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[133].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[133].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[134].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[134].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[135].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[135].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[136].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[136].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[137].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[137].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[138].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[138].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[139].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[139].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[140].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[140].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[141].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[141].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[142].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[142].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[143].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[143].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[144].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[144].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[145].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[145].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[146].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[146].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[147].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[147].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[148].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[148].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[149].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[149].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[150].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = bicepsWorkouts[150].Id, Sex = Sex.Female},
        };
        await context.WorkoutSex.AddRangeAsync(workoutSex);
        await context.SaveChangesAsync();
    }
}
