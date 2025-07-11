﻿namespace Presentation.Seed;

public static class BackWorkoutDbInitializer
{
    // Traps (mid-back) // Lower Back
    public static async Task<List<Workout>> BackWorkoutSeedAsync(FitnessContext context)
    {
        var backWorkouts = new List<Workout>();
        
        var bodybuildingId = await context.Sports.Where(s => s.Name == "Body Building").Select(z => z.Id).FirstOrDefaultAsync();
        var cardioSportId = await context.Sports.Where(s => s.Name == "Cardio").Select(z => z.Id).FirstOrDefaultAsync();
        var crossfitId = await context.Sports.Where(s => s.Name == "Cross Fit").Select(z => z.Id).FirstOrDefaultAsync();
        var yogaSportId = await context.Sports.Where(s => s.Name == "Yoga").Select(z => z.Id).FirstOrDefaultAsync();

        backWorkouts = new List<Workout>
        {
            // Traps (mid-back) // Barbell
            new Workout{ Name = "Barbell Landmine Row", SportId = bodybuildingId, Description = "" },                                   // index => 0
            new Workout{ Name = "Barbell Deadlift", SportId = bodybuildingId, Description = "" },                                       // index => 1
            new Workout{ Name = "Barbell High Pull", SportId = bodybuildingId, Description = "" },                                      // index => 2
            new Workout{ Name = "Barbell Snatch Grip High Pull", SportId = bodybuildingId, Description = "" },                          // index => 3
            
            // Traps (mid-back) // Machine
            new Workout{ Name = "Machine Seated Cable Row", SportId = bodybuildingId, Description = "" },                               // index => 4
            new Workout{ Name = "Narrow Pulldown", SportId = bodybuildingId, Description = "" },                                        // index => 5
            new Workout{ Name = "Neutral Pulldown", SportId = bodybuildingId, Description = "" },                                       // index => 6
            new Workout{ Name = "Machine Plate Loaded Low Row", SportId = bodybuildingId, Description = "" },                           // index => 7

            // Traps (mid-back) // Stretches
            new Workout{ Name = "Traps mid back Stretch Variation Two", SportId = cardioSportId, Description = "" },                    // index => 8
            new Workout{ Name = "Traps mid back Stretch Variation One", SportId = cardioSportId, Description = "" },                    // index => 9

            // Traps (mid-back) // Plate
            new Workout{ Name = "Plate Internally Rotated Rear Delt Fly", SportId = bodybuildingId, Description = "" },                 // index => 10
            new Workout{ Name = "Plate Rear Delt Fly", SportId = bodybuildingId, Description = "" },                                    // index => 11
            new Workout{ Name = "Plate Weighted Inverted Row", SportId = bodybuildingId, Description = "" },                            // index => 12
            new Workout{ Name = "Weighted Pull Ups", SportId = bodybuildingId, Description = "" },                                      // index => 13

            // Traps (mid-back) // smith-machine
            new Workout{ Name = "Smith Machine Inverted Row", SportId = bodybuildingId, Description = "" },                             // index => 14
            new Workout{ Name = "Smith Machine Assisted Pullup", SportId = bodybuildingId, Description = "" },                          // index => 15
            
            // Traps (mid-back) // dumbells
            new Workout{ Name = "Dumbbell Laying Silverback Shrug", SportId = bodybuildingId, Description = "" },                       // index => 16
            new Workout{ Name = "Dumbbell Silverback Shrug", SportId = bodybuildingId, Description = "" },                              // index => 17
            new Workout{ Name = "Dumbbell Row Bilateral", SportId = bodybuildingId, Description = "" },                                 // index => 18
            new Workout{ Name = "Dumbbell Row Unilateral", SportId = bodybuildingId, Description = "" },                                // index => 19
            new Workout{ Name = "Dumbbell Rear Delt Row", SportId = bodybuildingId, Description = "" },                                 // index => 20
            new Workout{ Name = "Dumbbell Seated Rear Delt Row", SportId = bodybuildingId, Description = "" },                          // index => 21
            new Workout{ Name = "Dumbbell Weighted Pull Ups", SportId = bodybuildingId, Description = "" },                             // index => 22

            // Traps (mid-back) // Cables
            new Workout{ Name = "Cable Silverback Shrug", SportId = bodybuildingId, Description = "" },                                 // index => 23
            new Workout{ Name = "Cable Row Bar Standing Row", SportId = bodybuildingId, Description = "" },                             // index => 24
            new Workout{ Name = "Cable Single Arm Underhand Grip Row", SportId = bodybuildingId, Description = "" },                    // index => 25
            new Workout{ Name = "Cable Single Arm Neutral Grip Row", SportId = bodybuildingId, Description = "" },                      // index => 26
            new Workout{ Name = "Cable Single Arm Rear Delt Row", SportId = bodybuildingId, Description = "" },                         // index => 27

            // Traps (mid-back) // TRX
            new Workout{ Name = "TRX Rear Delt Fly", SportId = bodybuildingId, Description = "" },                                      // index => 28
            new Workout{ Name = "TRX Rear Delt Row", SportId = bodybuildingId, Description = "" },                                      // index => 29
            new Workout{ Name = "TRX W Raise", SportId = bodybuildingId, Description = "" },                                            // index => 30

            // Traps (mid-back) // Vitruvian
            new Workout{ Name = "Vitruvian Row", SportId = bodybuildingId, Description = "" },                                          // index => 31
            new Workout{ Name = "Vitruvian Single Arm Row", SportId = bodybuildingId, Description = "" },                               // index => 32

            // Traps (mid-back) // Recovery
            new Workout{ Name = "Laying Ts", SportId = cardioSportId, Description = "" },                                               // index => 33
            new Workout{ Name = "Scapular Retraction", SportId = cardioSportId, Description = "" },                                     // index => 34

            // Traps (mid-back) // Bodyweight
            new Workout{ Name = "Pull Ups", SportId = bodybuildingId, Description = "" },                                               // index => 35
            new Workout{ Name = "Inverted Row", SportId = bodybuildingId, Description = "" },                                           // index => 36
            new Workout{ Name = "Elevated Pike Press", SportId = bodybuildingId, Description = "" },                                    // index => 37
            new Workout{ Name = "Bodyweight Pike Press", SportId = bodybuildingId, Description = "" },                                  // index => 38
            new Workout{ Name = "Bodyweight Overhand Inverted Row", SportId = bodybuildingId, Description = "" },                       // index => 39
            new Workout{ Name = "Bodyweight Standing Inverted Row", SportId = bodybuildingId, Description = "" },                       // index => 40
            new Workout{ Name = "L Sit Pull Up", SportId = bodybuildingId, Description = "" },                                          // index => 41

            // Traps (mid-back) // KettleBells
            new Workout{ Name = "Kettlebell Incline Shrug", SportId = bodybuildingId, Description = "" },                               // index => 42
            new Workout{ Name = "Kettlebell Deadlift (Single)", SportId = bodybuildingId, Description = "" },                           // index => 43
            new Workout{ Name = "Kettlebell Row (Single)", SportId = bodybuildingId, Description = "" },                                // index => 44
            new Workout{ Name = "Kettlebell Silverback Shrug (Single)", SportId = bodybuildingId, Description = "" },                   // index => 45
            new Workout{ Name = "Kettlebell Rear Delt Row (Double)", SportId = bodybuildingId, Description = "" },                   // index => 46
            new Workout{ Name = "Kettlebell Silverback Shrug", SportId = bodybuildingId, Description = "" },                            // index => 47

            // Traps (mid-back) // Band
            new Workout{ Name = "Band Horizontal Shrug", SportId = cardioSportId, Description = "" },                                   // index => 48
            new Workout{ Name = "Band Pull Apart", SportId = cardioSportId, Description = "" },                                         // index => 49
            new Workout{ Name = "Band High Face Pull", SportId = cardioSportId, Description = "" },                                     // index => 50
            new Workout{ Name = "Band Rear Delt Fly", SportId = cardioSportId, Description = "" },                                      // index => 51

            // Traps (mid-back) // Yoga
            new Workout{ Name = "Cat Pose", SportId = yogaSportId, Description = "" },                                                  // index => 52
            new Workout{ Name = "Easy Seated Twist Pose", SportId = yogaSportId, Description = "" },                                    // index => 53
            new Workout{ Name = "Revolved Side Angle Pose With Prayer Hands", SportId = yogaSportId, Description = "" },                // index => 54
            new Workout{ Name = "Revolved Side Angle Pose With Prayer Hands Beginner", SportId = yogaSportId, Description = "" },       // index => 55
            new Workout{ Name = "Seated Twist", SportId = yogaSportId, Description = "" },                                              // index => 56

            // Lower Back // Barbell
            new Workout{ Name = "Barbell Sumo Deadlift", SportId = bodybuildingId, Description = "" },                                  // index => 57
            new Workout{ Name = "Barbell Romanian Deadlift", SportId = bodybuildingId, Description = "" },                              // index => 58
            new Workout{ Name = "Barbell Low Bar Squat", SportId = bodybuildingId, Description = "" },                                  // index => 59
            new Workout{ Name = "Barbell Coan Deadlift", SportId = bodybuildingId, Description = "" },                                  // index => 60
            new Workout{ Name = "Barbell Pause Squat", SportId = bodybuildingId, Description = "" },                                    // index => 61
            new Workout{ Name = "Landmine Romanian Deadlift", SportId = bodybuildingId, Description = "" },                             // index => 62
            new Workout{ Name = "Landmine Single Leg Romanian Deadlift", SportId = bodybuildingId, Description = "" },                  // index => 63
            new Workout{ Name = "Landmine Snatch", SportId = bodybuildingId, Description = "" },                                        // index => 64
            new Workout{ Name = "Barbell Sumo Pause Deadlift", SportId = bodybuildingId, Description = "" },                            // index => 65
            new Workout{ Name = "Barbell Conventional Pause Deadlift", SportId = bodybuildingId, Description = "" },                    // index => 66
            new Workout{ Name = "Barbell Block Conventional Deadlift", SportId = bodybuildingId, Description = "" },                    // index => 67
            new Workout{ Name = "Barbell Deficit Conventional Deadlift", SportId = bodybuildingId, Description = "" },                  // index => 68
            new Workout{ Name = "Barbell Muscle Snatch", SportId = bodybuildingId, Description = "" },                                  // index => 69
            new Workout{ Name = "Machine 45 Degree Back Extension", SportId = bodybuildingId, Description = "" },                       // index => 70
            new Workout{ Name = "Barbell Power Snatch", SportId = bodybuildingId, Description = "" },                                   // index => 71
            new Workout{ Name = "Machine Back Extension", SportId = bodybuildingId, Description = "" },                                 // index => 72
            new Workout{ Name = "Barbell High Bar Good Morning", SportId = bodybuildingId, Description = "" },                          // index => 73
            new Workout{ Name = "Barbell Low Bar Good Morning", SportId = bodybuildingId, Description = "" },                           // index => 74
            new Workout{ Name = "Barbell Staggered Deadlift", SportId = bodybuildingId, Description = "" },                             // index => 75
            new Workout{ Name = "Barbell Single Leg Deadlift", SportId = bodybuildingId, Description = "" },                            // index => 76
            new Workout{ Name = "Barbell Pause Box Squat", SportId = bodybuildingId, Description = "" },                                // index => 77
            new Workout{ Name = "Barbell Pronated Pendlay Row", SportId = bodybuildingId, Description = "" },                           // index => 78
            new Workout{ Name = "Barbell Reverse Deadlift", SportId = bodybuildingId, Description = "" },                               // index => 79
            new Workout{ Name = "Barbell Snatch Grip Deadlift", SportId = bodybuildingId, Description = "" },                           // index => 80
            new Workout{ Name = "Barbell Snatch Grip Romanian Deadlift", SportId = bodybuildingId, Description = "" },                  // index => 81
            new Workout{ Name = "Barbell Suitcase Deadlift", SportId = bodybuildingId, Description = "" },                              // index => 82
            new Workout{ Name = "Barbell Supinated Pendlay Row", SportId = bodybuildingId, Description = "" },                          // index => 83
            new Workout{ Name = "Barbell Supinated Row", SportId = bodybuildingId, Description = "" },                                  // index => 84
            new Workout{ Name = "Barbell Zercher Good Morning", SportId = bodybuildingId, Description = "" },                           // index => 85
            new Workout{ Name = "Barbell Zercher Squat", SportId = bodybuildingId, Description = "" },                                  // index => 86
            new Workout{ Name = "Landmine Staggered Romanian Deadlift", SportId = bodybuildingId, Description = "" },                   // index => 87
            new Workout{ Name = "Barbell Suitcase Carry", SportId = bodybuildingId, Description = "" },                                 // index => 88
            new Workout{ Name = "Barbell Jefferson Deadlift", SportId = bodybuildingId, Description = "" },                             // index => 89
            new Workout{ Name = "Barbell Clean And Jerk", SportId = bodybuildingId, Description = "" },                                 // index => 90
            new Workout{ Name = "Barbell Snatch", SportId = bodybuildingId, Description = "" },                                         // index => 91
            new Workout{ Name = "Barbell Zercher Deficit Lunge", SportId = bodybuildingId, Description = "" },                          // index => 92
            new Workout{ Name = "Landmine T Bar Rows", SportId = bodybuildingId, Description = "" },                                    // index => 93

            new Workout{ Name = "Machine Reverse Hyperextension", SportId = bodybuildingId, Description = "" },                         // index => 94

            // Lower Back // stretches
            new Workout{ Name = "Lower back Stretch Variation One", SportId = bodybuildingId, Description = "" },                       // index => 95
            new Workout{ Name = "Lower back Stretch Variation Two", SportId = bodybuildingId, Description = "" },                       // index => 96
            new Workout{ Name = "Lower back Stretch Variation Three", SportId = bodybuildingId, Description = "" },                     // index => 97
            new Workout{ Name = "Lower back Stretch Variation Four", SportId = bodybuildingId, Description = "" },                      // index => 98

            // Lower Back // Plate
            new Workout{ Name = "Plate Deadlift", SportId = bodybuildingId, Description = "" },                                         // index => 99
            new Workout{ Name = "Plate Single Leg Pinch Grip Deadlift", SportId = bodybuildingId, Description = "" },                   // index => 100
            new Workout{ Name = "Plate Good Morning Anterior", SportId = bodybuildingId, Description = "" },                            // index => 101
            new Workout{ Name = "Plate Good Morning", SportId = bodybuildingId, Description = "" },                                     // index => 102
            new Workout{ Name = "Plate Single Leg Deadlift", SportId = bodybuildingId, Description = "" },                              // index => 103
            new Workout{ Name = "Plate Pinch Grip Deadlift", SportId = bodybuildingId, Description = "" },                              // index => 104
            new Workout{ Name = "Plate Staggered Deadlift", SportId = bodybuildingId, Description = "" },                               // index => 105
            new Workout{ Name = "Plate Staggered Pinch Grip Deadlift", SportId = bodybuildingId, Description = "" },                    // index => 106
            new Workout{ Name = "Plate Superman", SportId = bodybuildingId, Description = "" },                                         // index => 107
            new Workout{ Name = "Plate Superman Hold", SportId = bodybuildingId, Description = "" },                                    // index => 108
            new Workout{ Name = "Plate Staggered Waiters Bow", SportId = bodybuildingId, Description = "" },                            // index => 109
            new Workout{ Name = "Plate Waiters Bow", SportId = bodybuildingId, Description = "" },                                      // index => 110

            // Lower Back // Bosu
            new Workout{ Name = "Bosu Ball Single Leg Hip Thrust", SportId = bodybuildingId, Description = "" },                        // index => 111
            new Workout{ Name = "Bosu Ball Superman", SportId = bodybuildingId, Description = "" },                                     // index => 112

            // Lower Back // smith machine
            new Workout{ Name = "Smith Machine Underhand Row", SportId = bodybuildingId, Description = "" },                            // index => 113
            new Workout{ Name = "Smith Machine Overhand Row", SportId = bodybuildingId, Description = "" },                             // index => 114
            new Workout{ Name = "Smith Machine Sumo Romanian Deadlift", SportId = bodybuildingId, Description = "" },                   // index => 115
            new Workout{ Name = "Smith Machine Staggered Deadlift", SportId = bodybuildingId, Description = "" },                       // index => 116
            new Workout{ Name = "Smith Machine Romanian Deadlift", SportId = bodybuildingId, Description = "" },                        // index => 117

            // Lower Back // Dumbbell
            new Workout{ Name = "Dumbbell Superman", SportId = bodybuildingId, Description = "" },                                      // index => 118
            new Workout{ Name = "Dumbbell Goblet Good Morning", SportId = bodybuildingId, Description = "" },                           // index => 119
            new Workout{ Name = "Dumbbell Romanian Deadlift", SportId = bodybuildingId, Description = "" },                             // index => 120
            new Workout{ Name = "Dumbbell Front Rack Pause Squat", SportId = bodybuildingId, Description = "" },                        // index => 121
            new Workout{ Name = "Dumbbell Single Leg Single Arm Deadlift", SportId = bodybuildingId, Description = "" },                // index => 122
            new Workout{ Name = "Dumbbell Single Leg Stiff Leg Deadlift", SportId = bodybuildingId, Description = "" },                 // index => 123
            new Workout{ Name = "Dumbbell Staggered Deadlift", SportId = bodybuildingId, Description = "" },                            // index => 124
            new Workout{ Name = "Dumbbell Sumo Squat", SportId = bodybuildingId, Description = "" },                                    // index => 125
            new Workout{ Name = "Dumbbell Swing", SportId = bodybuildingId, Description = "" },                                         // index => 126
            new Workout{ Name = "Dumbbell Superman Hold", SportId = bodybuildingId, Description = "" },                                 // index => 127
            new Workout{ Name = "Dumbbell Cross Body Romanian Deadlift", SportId = bodybuildingId, Description = "" },                  // index => 128
            new Workout{ Name = "Dumbbell Alternating Pendlay Row", SportId = bodybuildingId, Description = "" },                       // index => 129
            new Workout{ Name = "Dumbbell Box Squat", SportId = bodybuildingId, Description = "" },                                     // index => 130
            new Workout{ Name = "Dumbbell Staggered Waiters Bow", SportId = bodybuildingId, Description = "" },                         // index => 131
            new Workout{ Name = "Dumbbell Waiters Bow", SportId = bodybuildingId, Description = "" },                                   // index => 132
            

            // Lower Back // Medicine Ball
            new Workout{ Name = "Medicine Ball Single Leg Deadlift", SportId = bodybuildingId, Description = "" },                      // index => 133

            // Lower Back // Cables
            new Workout{ Name = "Cable Goblet Squat", SportId = cardioSportId, Description = "" },                                     // index => 134
            new Workout{ Name = "Cable Bar Romanian Deadlift", SportId = cardioSportId, Description = "" },                            // index => 135
            new Workout{ Name = "Cable Single Leg Deadlift", SportId = cardioSportId, Description = "" },                              // index => 136
            new Workout{ Name = "Cable Pull Through", SportId = cardioSportId, Description = "" },                                     // index => 137
            new Workout{ Name = "Cable Standing Straight Leg Glute Kickback", SportId = cardioSportId, Description = "" },             // index => 138
            new Workout{ Name = "Cable Zercher Squat", SportId = cardioSportId, Description = "" },                                    // index => 139
            new Workout{ Name = "Cable Incline Bench Straight Leg Kickback", SportId = cardioSportId, Description = "" },              // index => 140
            new Workout{ Name = "Cable Bench Straight Leg Kickback", SportId = cardioSportId, Description = "" },                      // index => 141
            new Workout{ Name = "Cable Standing Mid Kickback", SportId = cardioSportId, Description = "" },                            // index => 142
            new Workout{ Name = "Cable Standing Straight Leg Mid Kickback", SportId = cardioSportId, Description = "" },               // index => 143
            new Workout{ Name = "Cable Zercher Good Morning", SportId = cardioSportId, Description = "" },                             // index => 144
            new Workout{ Name = "Cable Bar Staggered Romanian Deadlift", SportId = cardioSportId, Description = "" },                  // index => 145
            new Workout{ Name = "Cable Elevated Deadlift", SportId = cardioSportId, Description = "" },                                // index => 146

            // Lower Back // TRX
            new Workout{ Name = "TRX Ab Rollout", SportId = cardioSportId, Description = "" },                                         // index => 147
            
            // Lower Back // Vitruvian
            new Workout{ Name = "Vitruvian Romanian Deadlift", SportId = cardioSportId, Description = "" },                             // index => 148
            new Workout{ Name = "Vitruvian Single Leg Deadlift", SportId = cardioSportId, Description = "" },                           // index => 149
            new Workout{ Name = "Vitruvian Staggered Deadlift", SportId = cardioSportId, Description = "" },                            // index => 150

            // Lower Back // Recovery
            new Workout{ Name = "Cobra Stretch 1", SportId = yogaSportId, Description = "" },                                           // index => 151
            new Workout{ Name = "Cobra Stretch 2", SportId = yogaSportId, Description = "" },                                           // index => 152
            new Workout{ Name = "Deadlift Bounces Stretch", SportId = yogaSportId, Description = "" },                                  // index => 153
            new Workout{ Name = "I Into W", SportId = yogaSportId, Description = "" },                                                  // index => 154
            new Workout{ Name = "Knee Pull And Lumbar Rotation", SportId = yogaSportId, Description = "" },                             // index => 155
            new Workout{ Name = "Partner Lower Back Extensions", SportId = yogaSportId, Description = "" },                             // index => 156
            new Workout{ Name = "Lower Back Extensions 2", SportId = yogaSportId, Description = "" },                                   // index => 157
            new Workout{ Name = "Lower Back Extensions 3", SportId = yogaSportId, Description = "" },                                   // index => 158
            new Workout{ Name = "Lower Back Extensions 4", SportId = yogaSportId, Description = "" },                                   // index => 159
            new Workout{ Name = "Lumbar Extensor Mobilisation Supine Bent Knees Peanut Tool", SportId = yogaSportId, Description = "" },// index => 160
            new Workout{ Name = "Floor Knee Pull Bilateral", SportId = yogaSportId, Description = "" },                                 // index => 161
            new Workout{ Name = "Lumbar Rotation 1", SportId = yogaSportId, Description = "" },                                         // index => 162
            new Workout{ Name = "Lumbar Rotation 2", SportId = yogaSportId, Description = "" },                                         // index => 163
            new Workout{ Name = "Lumbar Rotation 3", SportId = yogaSportId, Description = "" },                                         // index => 164
            new Workout{ Name = "Lumbar Rotation 4", SportId = yogaSportId, Description = "" },                                         // index => 165
            new Workout{ Name = "Lumbar Rotation 5", SportId = yogaSportId, Description = "" },                                         // index => 166
            new Workout{ Name = "Prayer Stretch 1", SportId = yogaSportId, Description = "" },                                          // index => 167
            new Workout{ Name = "Prayer Stretch 2 Roller", SportId = yogaSportId, Description = "" },                                   // index => 168
            new Workout{ Name = "QL Mobilisation Floor Foam Roller", SportId = yogaSportId, Description = "" },                         // index => 169
            new Workout{ Name = "Box Supported Single Leg Deadlift", SportId = yogaSportId, Description = "" },                         // index => 170
            new Workout{ Name = "Skydiver", SportId = yogaSportId, Description = "" },                                                  // index => 171
            new Workout{ Name = "Swipe Around", SportId = yogaSportId, Description = "" },                                              // index => 172
            new Workout{ Name = "Alternating Swipe Around", SportId = yogaSportId, Description = "" },                                  // index => 173
            new Workout{ Name = "Bodyweight Deadlift", SportId = yogaSportId, Description = "" },                                       // index => 174
            new Workout{ Name = "Inchworm", SportId = yogaSportId, Description = "" },                                                  // index => 175

            // Lower Back // BodyWeight
            new Workout{ Name = "Supermans", SportId = yogaSportId, Description = "" },                                                 // index => 176
            new Workout{ Name = "Good Mornings", SportId = yogaSportId, Description = "" },                                             // index => 177
            new Workout{ Name = "Single Legged Romanian Deadlifts", SportId = yogaSportId, Description = "" },                          // index => 178
            new Workout{ Name = "Bodyweight Staggered Waiters Bow", SportId = yogaSportId, Description = "" },                          // index => 179
            new Workout{ Name = "Bodyweight Waiters Bow", SportId = yogaSportId, Description = "" },                                    // index => 180
            new Workout{ Name = "Bodyweight Stability Ball Hyperextension", SportId = yogaSportId, Description = "" },                  // index => 181
            new Workout{ Name = "Stability Ball Reverse Hyperextension", SportId = yogaSportId, Description = "" },                     // index => 182

            // Lower Back // Kettlebells
            new Workout{ Name = "Kettlebell Swing", SportId = bodybuildingId, Description = "" },                                       // index => 183
            new Workout{ Name = "Kettlebell Staggered Deadlift (Single)", SportId = bodybuildingId, Description = "" },                 // index => 184
            new Workout{ Name = "Kettlebell Goblet Good Morning", SportId = bodybuildingId, Description = "" },                         // index => 185
            new Workout{ Name = "Kettlebell Alternating Swing", SportId = bodybuildingId, Description = "" },                           // index => 186
            new Workout{ Name = "Kettlebell Conventional Deadlift (Double)", SportId = bodybuildingId, Description = "" },              // index => 187
            new Workout{ Name = "Kettlebell Swing (Double)", SportId = bodybuildingId, Description = "" },                              // index => 188
            new Workout{ Name = "Kettlebell Full Swing", SportId = bodybuildingId, Description = "" },                                  // index => 189
            new Workout{ Name = "Kettlebell Romanian Deadlift", SportId = bodybuildingId, Description = "" },                           // index => 190
            new Workout{ Name = "Kettlebell Single Arm Swing", SportId = bodybuildingId, Description = "" },                            // index => 191
            new Workout{ Name = "Kettlebell Staggered Deadlift", SportId = bodybuildingId, Description = "" },                          // index => 192
            new Workout{ Name = "Kettlebell Staggered Swing", SportId = bodybuildingId, Description = "" },                             // index => 193
            new Workout{ Name = "Kettlebell Sumo Deadlift", SportId = bodybuildingId, Description = "" },                               // index => 194
            new Workout{ Name = "Kettlebell Superman", SportId = bodybuildingId, Description = "" },                                    // index => 195
            new Workout{ Name = "Kettlebell Superman Hold", SportId = bodybuildingId, Description = "" },                               // index => 196
            new Workout{ Name = "Swing To Upright Row", SportId = bodybuildingId, Description = "" },                                   // index => 197
            new Workout{ Name = "Kettlebell Single Leg Deadlift", SportId = bodybuildingId, Description = "" },                         // index => 198
            new Workout{ Name = "Kettlebell Suitcase Deadlift", SportId = bodybuildingId, Description = "" },                           // index => 199
            new Workout{ Name = "Kettlebell Box Squat", SportId = bodybuildingId, Description = "" },                                   // index => 200
            new Workout{ Name = "Kettlebell Staggered Waiters Bow", SportId = bodybuildingId, Description = "" },                       // index => 201
            new Workout{ Name = "Kettlebell Waiters Bow", SportId = bodybuildingId, Description = "" },                                 // index => 202

            // Lower back & Band
            new Workout{ Name = "Band Good Morning", SportId = yogaSportId, Description = "" },                                         // index => 203
            new Workout{ Name = "Band Pullthrough", SportId = yogaSportId, Description = "" },                                          // index => 204
            new Workout{ Name = "Band Romanian Deadlift", SportId = yogaSportId, Description = "" },                                    // index => 205

            // Lower Back & Yoga
            new Workout{ Name = "Happy Baby", SportId = yogaSportId, Description = "" },                                                // index => 206
            new Workout{ Name = "Sphinx Pose", SportId = yogaSportId, Description = "" },                                               // index => 207
            new Workout{ Name = "Cobra Pose", SportId = yogaSportId, Description = "" },                                                // index => 208
        };
        return backWorkouts;
        //await context.Workouts.AddRangeAsync(backWorkouts);
        //await context.SaveChangesAsync();

        // ***************************************************************** //
        var backWorkoutInstruction = new List<WorkoutInstruction>();
        backWorkoutInstruction = new List<WorkoutInstruction>
        {
            #region Traps & Barbell
            new WorkoutInstruction{ WorkoutId = backWorkouts[0].Id , Step = 1 , Instruction = "Position a barbell in a landmine or corner of a room and stand facing it with your feet shoulder-width apart."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[0].Id , Step = 2 , Instruction = "Grasp the end of the barbell with a neutral grip, keeping your arms straight and your shoulders relaxed."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[0].Id , Step = 3 , Instruction = "Bend at the hips and knees to lower your torso until it is almost parallel to the ground."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[0].Id , Step = 4 , Instruction = "Pull the barbell towards your chest, squeezing your shoulder blades together as you row the weight up."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[1].Id , Step = 1 , Instruction = "Stand with your mid-foot under the bar and grip the bar with your hands, about a shoulder width apart."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[1].Id , Step = 2 , Instruction = "Bend your knees, then lift the bar by straightening your back. It is important to keep your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[1].Id , Step = 3 , Instruction = "Stand to your full height and hold."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[1].Id , Step = 4 , Instruction = "Lower the bar to the floor by bending your knees and keeping your back straight."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[2].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, grip the barbell slightly wider than shoulder-width, and keep your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[2].Id , Step = 2 , Instruction = "Drive through your legs, extending your hips, knees, and ankles explosively while pulling the barbell upward."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[2].Id , Step = 3 , Instruction = "As the bar rises, pull it close to your body, leading with your elbows until it reaches chest level."},
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[3].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, gripping the barbell with a wide (snatch-width) grip. Keep your back straight, chest up, and bar close to your body."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[3].Id , Step = 2 , Instruction = "Drive through your legs, extending your hips, knees, and ankles while pulling the barbell up explosively."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[3].Id , Step = 3 , Instruction = "Shrug your shoulders forcefully and pull the bar as high as possible, keeping elbows above the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[3].Id , Step = 4 , Instruction = "Lower the bar back to the starting position in a controlled manner and reset for the next rep."},
            #endregion

            #region Traps & Machine
            new WorkoutInstruction{ WorkoutId = backWorkouts[4].Id , Step = 1 , Instruction = "Sit with your back straight on the machine and grip the handles."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[4].Id , Step = 2 , Instruction = "Pull the handles back using your arms. Your legs and torso should be at a 90° angle. Push out your chest."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[4].Id , Step = 3 , Instruction = "Pull the handles towards your body until your hands are beside your abdomen."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[5].Id , Step = 1 , Instruction = "Use the Straight Bar attachment."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[5].Id , Step = 1 , Instruction = "Hold the attachment as you sit on the machine and put your legs under the leg pads."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[5].Id , Step = 1 , Instruction = "Pull the bar to your clavicle, then raise back up until your arm are extended."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[6].Id , Step = 1 , Instruction = "Use the V Bar attachment."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[6].Id , Step = 1 , Instruction = "Hold the attachment as you sit on the machine and put your legs under the leg pads."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[6].Id , Step = 1 , Instruction = "Pull the bar to your clavicle, then raise back up until your arm are extended."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[7].Id , Step = 1 , Instruction = "Press your chest into the chest pad and grab the horizontal handles with an overhand grip."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[7].Id , Step = 1 , Instruction = "Pull the handles toward you, make sure your elbows stay flared out."},
            #endregion

            #region Traps & Stretches
            new WorkoutInstruction{ WorkoutId = backWorkouts[8].Id , Step = 1 , Instruction = "Sit on the ground and lay one leg flat and the other over the top."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[8].Id , Step = 2 , Instruction = "Hold your leg with the same side arm and slowly rotate your hips and back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[8].Id , Step = 3 , Instruction = "Hold at the peak of the stretch, then slowly return to starting position."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[8].Id , Step = 4 , Instruction = "Switch sides and repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[9].Id , Step = 1 , Instruction = "Stand up with your feet shoulder width apart. Place one arm across the front of your chest at shoulder height, press the forearm of your other arm above the elbow, hooking the stretching arm with your hand."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[9].Id , Step = 2 , Instruction = "Press the arm until it is straight and rotate your upper torso to engage the stretch even deeper."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[9].Id , Step = 3 , Instruction = "Repeat with your other arm."},
            #endregion

            #region Traps & Plate
            new WorkoutInstruction{ WorkoutId = backWorkouts[10].Id , Step = 1 , Instruction = "With plates in either hand, bend your knees with your feet slightly bowed out. Hinge forward with a flat back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[10].Id , Step = 2 , Instruction = "Maintain an overhand grip and internally rotated shoulders."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[10].Id , Step = 3 , Instruction = "Raise your arms backward toward the ceiling while maintaining a light band in your elbows."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[11].Id , Step = 1 , Instruction = "Keep your back straight and bend forward slightly at the waist."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[11].Id , Step = 2 , Instruction = "With arms extended, raise the weights out to your sides until they are in line with your shoulders."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[11].Id , Step = 3 , Instruction = "Pause briefly and then lower the weights back to the starting position."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[12].Id , Step = 1 , Instruction = "Lay underneath a fixed horizontal bar and grab the bar with a wide overhand grip. Place a plate on your chest."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[12].Id , Step = 2 , Instruction = "Pull your body straight up to the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[12].Id , Step = 3 , Instruction = "Return to the starting position, your arms fully extended. Repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[13].Id , Step = 1 , Instruction = "Grasp the bar with an overhand grip, arms and shoulders fully extended. Weight hanging between your legs."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[13].Id , Step = 2 , Instruction = "Pull your body up until your chin is above the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[13].Id , Step = 3 , Instruction = "Lower your body back to starting position."},
            #endregion

            #region Traps & Smith-Machine
            new WorkoutInstruction{ WorkoutId = backWorkouts[14].Id , Step = 1 , Instruction = "Lay underneath a fixed horizontal bar and grab the bar with a wide overhand grip."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[14].Id , Step = 2 , Instruction = "Pull your body straight up to the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[14].Id , Step = 3 , Instruction = "Return to the starting position, your arms fully extended. Repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[15].Id , Step = 1 , Instruction = "Grasp the bar with an overhand grip, arms and shoulders fully extended. Leave your feet on the floor."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[15].Id , Step = 2 , Instruction = "Pull your body up until your chin is above the bar. Use your legs top assist you up."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[15].Id , Step = 3 , Instruction = "Lower your body back to starting position."},
            #endregion

            #region Traps & Dumbell
            new WorkoutInstruction{ WorkoutId = backWorkouts[16].Id , Step = 1 , Instruction = "Lay on an incline bench with your arms hanging freely."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[16].Id , Step = 2 , Instruction = "Pull your shoulder blades back toward the ceiling."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[17].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart holding dumbbells with both hands in front just past shoulder width."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[17].Id , Step = 2 , Instruction = "Bend forward at the hips with a slight bend in your knees, keeping your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[17].Id , Step = 3 , Instruction = "Engage your shoulder blades, as if you are trying to touch them together."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[18].Id , Step = 1 , Instruction = "Grab both dumbbells and hinge forward at the hips. Make sure you keep a flat back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[18].Id , Step = 2 , Instruction = "The closer your torso is to parallel with the ground the longer the range of motion will be at your shoulder. The better the results you'll get from the exercise."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[18].Id , Step = 3 , Instruction = "Let your arms hang freely, and then pull your elbow joint straight back toward the ceiling."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[19].Id , Step = 1 , Instruction = "Brace your off arm against something stable (bench, box). Stagger your stance so your leg on the side of your working arm is back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[19].Id , Step = 2 , Instruction = "Try to get your torso to parallel with the ground. That will extend your range of motion."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[19].Id , Step = 3 , Instruction = "Let your arm hang freely and then pull your elbow back. Imagine you've got a tennis ball in your armpit and squeeze it each rep."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[20].Id , Step = 1 , Instruction = "Hinge forward at the hips while maintaining a flat back. Try to get your torso as close to parallel with the ground as your mobility will allow for."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[20].Id , Step = 2 , Instruction = "Let your arms hang in front of you. Pull your elbows back towards the ceiling while flaring your elbows outward."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[21].Id , Step = 1 , Instruction = "Sit on a bench. Put your chest in your lap. Try to get your torso as close to parallel with the ground as your mobility will allow for."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[21].Id , Step = 2 , Instruction = "Let your arms hang in front of you. Pull your elbows back towards the ceiling while flaring your elbows outward."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[22].Id , Step = 1 , Instruction = "Grasp the bar with an overhand grip, arms and shoulders fully extended."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[22].Id , Step = 2 , Instruction = "Pull your body up until your chin is above the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[22].Id , Step = 3 , Instruction = "Lower your body back to starting position."},
            #endregion

            #region Traps & Cables
            new WorkoutInstruction{ WorkoutId = backWorkouts[23].Id , Step = 1 , Instruction = "Use a bar attachment. Cable should be set all the way to the bottom."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[23].Id , Step = 2 , Instruction = "Stand up with the attachment in hand, walk a couple of steps back make sure you are standing upright and not leaning backwards."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[23].Id , Step = 3 , Instruction = "Retract your shoulder blades and then protract to return to the starting position."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[24].Id , Step = 1 , Instruction = "Place the cable at shoulder height. Use a row bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[24].Id , Step = 2 , Instruction = "Pull the handles back using your arms. Push out your chest."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[24].Id , Step = 3 , Instruction = "Pull the handles towards your body until your hands are beside your abdomen."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[25].Id , Step = 1 , Instruction = "Place the cable at shoulder height. Use a handle attachment. Face your palm upward."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[25].Id , Step = 2 , Instruction = "Pull the handle back using your arms. Push out your chest."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[25].Id , Step = 3 , Instruction = "Pull the handle towards your body until your hands are beside your abdomen."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[26].Id , Step = 1 , Instruction = "Place the cable at shoulder height. Use a handle attachment. Face your palm toward the midline of your body."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[26].Id , Step = 2 , Instruction = "Pull the handle back using your arms. Push out your chest."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[26].Id , Step = 3 , Instruction = "Pull the handle towards your body until your hands are beside your abdomen."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[27].Id , Step = 1 , Instruction = "Use a handle attachment, grab with an overhand grip and take a position with the cable crossing your body."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[27].Id , Step = 2 , Instruction = "Pull your elbows back while flaring your elbows outward."},
            #endregion

            #region Traps & TRX
            new WorkoutInstruction{ WorkoutId = backWorkouts[28].Id , Step = 1 , Instruction = "Stand facing away from the TRX straps and grab the handles with both hands."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[28].Id , Step = 2 , Instruction = "Step forward so that your body is in a plank position, with your arms straight and your body in a straight line from your head to your heels."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[28].Id , Step = 3 , Instruction = "Keeping your arms straight, slowly lift your arms out to the side, keeping them at the same height as your shoulders. Your body should form a \"T\" shape."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[29].Id , Step = 1 , Instruction = "Stand facing away from the TRX straps and grab the handles with both hands."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[29].Id , Step = 2 , Instruction = "Step away so your body is leaning away from the anchor point."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[29].Id , Step = 3 , Instruction = "Flex your elbows and pull your elbows straight back behind your body."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[29].Id , Step = 4 , Instruction = "Make sure to keep your elbows flared outward."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[30].Id , Step = 1 , Instruction = "Hold the TRX straps and lean away from the anchor point."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[30].Id , Step = 2 , Instruction = "Pull your elbows back while externally rotating your shoulder joint. Your arms should make a W shape at the back portion of the exercise."},
            #endregion

            #region Traps & Vitruvian
            new WorkoutInstruction{ WorkoutId = backWorkouts[31].Id , Step = 1 , Instruction = "Hold bosu and hinge forward."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[31].Id , Step = 2 , Instruction = "Pull bosu towards chest, squeezing shoulder blades."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[32].Id , Step = 1 , Instruction = "Take a staggered stance and hinge forward."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[32].Id , Step = 2 , Instruction = "Grab one of the handle attachments and pull your elbow toward the ceiling."},
            #endregion

            #region Traps & Recovery
            new WorkoutInstruction{ WorkoutId = backWorkouts[33].Id , Step = 1 , Instruction = "Lie on your front, arms outstretched to the side."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[33].Id , Step = 2 , Instruction = "Raise head and chest off the ground."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[33].Id , Step = 3 , Instruction = "Raise and lower your arms (flapping wings motion) by contracting and relaxing the muscles in between your shoulder blades."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[34].Id , Step = 1 , Instruction = "From the standing or seated position straighten your back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[34].Id , Step = 2 , Instruction = "Pull the shoulders back but keep them relaxed."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[34].Id , Step = 3 , Instruction = "Move shoulders backwards and return to the starting, relaxed position."},
            #endregion

            #region Traps & BodyWeight
            new WorkoutInstruction{ WorkoutId = backWorkouts[35].Id , Step = 1 , Instruction = "Grasp the bar with an overhand grip, arms and shoulders fully extended."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[35].Id , Step = 2 , Instruction = "Pull your body up until your chin is above the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[35].Id , Step = 3 , Instruction = "Lower your body back to starting position."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[36].Id , Step = 1 , Instruction = "Lay underneath a fixed horizontal bar and grab the bar with a wide overhand grip."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[36].Id , Step = 2 , Instruction = "Pull your body straight up to the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[36].Id , Step = 3 , Instruction = "Return to the starting position, your arms fully extended. Repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[37].Id , Step = 1 , Instruction = "Use a bench or an object to elevate your feet."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[37].Id , Step = 2 , Instruction = "Lower your head towards the floor by bending your elbows."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[37].Id , Step = 3 , Instruction = "Push through your hands and return to the starting pike position."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[37].Id , Step = 4 , Instruction = "Repeat"},

            new WorkoutInstruction{ WorkoutId = backWorkouts[38].Id , Step = 1 , Instruction = "Start in a plank position. Push your hips up toward the ceiling."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[38].Id , Step = 2 , Instruction = "Lower your head towards the floor by bending your elbows."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[38].Id , Step = 3 , Instruction = "Push through your hands and return to the starting pike position."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[38].Id , Step = 4 , Instruction = "Repeat"},

            new WorkoutInstruction{ WorkoutId = backWorkouts[39].Id , Step = 1 , Instruction = "Lay underneath a fixed horizontal bar and grab the bar with a wide overhand grip."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[39].Id , Step = 2 , Instruction = "Pull your body straight up to the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[39].Id , Step = 3 , Instruction = "Return to the starting position, your arms fully extended. Repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[40].Id , Step = 1 , Instruction = "Grab a door frame or a rack and place your feet near the frame."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[40].Id , Step = 2 , Instruction = "Start with your elbows extended, row your body towards your hands."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[40].Id , Step = 3 , Instruction = "Return to the starting position, your arms fully extended. Repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[41].Id , Step = 1 , Instruction = "Grasp the bar with an overhand grip, arms and shoulders fully extended. Pull your legs up until you're in an \"L\" position."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[41].Id , Step = 2 , Instruction = "Pull your body up until your chin is above the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[41].Id , Step = 3 , Instruction = "Lower your body back to starting position."},
            #endregion

            #region Traps & Kettlebells
            new WorkoutInstruction{ WorkoutId = backWorkouts[42].Id , Step = 1 , Instruction = "Leaning across the back section of the bench, with feet firmly on the floor and with arms hanging to the sides."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[42].Id , Step = 2 , Instruction = "Holding the kettlebell in both hands engage your shoulder blades, as if you are trying to touch them together. Release the shrug."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[43].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart holding the kettlebell with both hands in front of your thighs."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[43].Id , Step = 2 , Instruction = "Bend forward at the hips bringing the kettlebell to the floor while you slightly bend your knees, keeping your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[43].Id , Step = 3 , Instruction = "Return to standing position and repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[44].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart holding the kettlebell with both hands in front of your thighs."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[44].Id , Step = 2 , Instruction = "Bend forward at the hips bringing the kettlebell to the floor while you slightly bend your knees, keeping your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[44].Id , Step = 3 , Instruction = "Lift the kettlebell upwards towards your chest and lower - repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[45].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart holding the kettlebell with both hands in front of your thighs."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[45].Id , Step = 2 , Instruction = "Bend forward at the hips bringing the kettlebell to the floor while you slightly bend your knees, keeping your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[45].Id , Step = 3 , Instruction = "Holding the kettlebell in both hands engage your shoulder blades, as if you are trying to touch them together. Release the shrug."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[46].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, kettlebell in each hand, hinge at hips."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[46].Id , Step = 2 , Instruction = "Pull kettlebells while flaring your elbows, squeezing shoulder blades. Keep back flat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[47].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, hold one kettlebell in each hand at your sides, and lean forward."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[47].Id , Step = 2 , Instruction = "Lift your shoulders backward while keeping arms straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[47].Id , Step = 3 , Instruction = "Lower shoulders back down, repeat for desired reps."},
            #endregion

            #region Traps & Band
            new WorkoutInstruction{ WorkoutId = backWorkouts[48].Id , Step = 1 , Instruction = "Anchor the band at shoulder height. Take a few steps away until the band is taut."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[48].Id , Step = 2 , Instruction = "Retract your shoulder blades straight back in schools. Then protract to the starting position."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[49].Id , Step = 1 , Instruction = "Grab the band with a shoulder width grip. Point your arms straight in front of you."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[49].Id , Step = 2 , Instruction = "Retract your shoulder blades and shoulder joint until the band taps your chest."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[50].Id , Step = 1 , Instruction = "Start with a band anchored to a high point. Stagger your stance."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[50].Id , Step = 2 , Instruction = "Pull the band to the bridge of your nose."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[51].Id , Step = 1 , Instruction = "Start by standing between the two anchored bands with your feet shoulder-width apart and the bands positioned at a high point."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[51].Id , Step = 2 , Instruction = "Grasp the ends of each band with your hands, keeping your palms facing each other.\r\n"},
            new WorkoutInstruction{ WorkoutId = backWorkouts[51].Id , Step = 3 , Instruction = "Keeping your arms slightly bent and your back straight, slowly pull the bands away from your body until your arms are extended straight out to the sides. Hold for a second, then slowly release back to the starting position. Repeat for desired reps."},
            #endregion

            #region Traps & Yoga
            new WorkoutInstruction{ WorkoutId = backWorkouts[52].Id , Step = 1 , Instruction = "Begin on your hands and knees with your wrists directly under your shoulders and your knees directly under your hips."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[52].Id , Step = 1 , Instruction = "Inhale and arch your back, lifting your tailbone and head towards the ceiling, while lowering your belly towards the floor."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[52].Id , Step = 1 , Instruction = "Exhale and round your spine, tucking your chin towards your chest, and bringing your tailbone towards your knees."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[52].Id , Step = 1 , Instruction = "Repeat these movements, flowing smoothly between the two poses, for several breaths."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Begin seated with your legs extended in front of you."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Bend your right knee and place your foot on the floor next to your left thigh."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Inhale and reach your left arm up towards the ceiling."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Exhale and twist to the right, placing your left elbow on the outside of your right knee. Hold for a few breaths and then repeat on the other side."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Begin seated with your legs extended in front of you."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Bend your right knee and place your foot on the floor next to your left thigh."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Inhale and reach your left arm up towards the ceiling."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Exhale and twist to the right, placing your left elbow on the outside of your right knee. Hold for a few breaths and then repeat on the other side."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[54].Id , Step = 1 , Instruction = "Begin in Warrior II pose, with your right foot forward and your left foot back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[54].Id , Step = 1 , Instruction = "Bring your hands together in a prayer position at your heart."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[54].Id , Step = 1 , Instruction = "Exhale and twist your torso to the right, placing your left elbow on the outside of your right knee."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[54].Id , Step = 1 , Instruction = "Hold for several breaths and then repeat on the other side."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[55].Id , Step = 1 , Instruction = "Begin in a low lunge position with your right foot forward and your left knee on the ground."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[55].Id , Step = 1 , Instruction = "Bring your hands together in a prayer position at your heart."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[55].Id , Step = 1 , Instruction = "Exhale and twist your torso to the right, placing your left elbow on the outside of your right knee."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[55].Id , Step = 1 , Instruction = "Hold for several breaths and then repeat on the other side."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[56].Id , Step = 1 , Instruction = "Begin seated with your legs extended in front of you."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[56].Id , Step = 1 , Instruction = "Bend your right knee and place your foot on the floor next to your left thigh."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[56].Id , Step = 1 , Instruction = "Inhale and reach your left arm up towards the ceiling."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[56].Id , Step = 1 , Instruction = "Exhale and twist to the right, placing your left elbow on the outside of your right knee. Hold for a few breaths and then repeat on the other side."},
            #endregion

            #region Lower back & Barbell
            new WorkoutInstruction{ WorkoutId = backWorkouts[57].Id , Step = 1 , Instruction = "Stance width can vary with a sumo DL. Some prefer toes near the plates. Others prefer a more narrow stance to get more drive off the floor."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[57].Id , Step = 2 , Instruction = "Make sure your arms are inside your legs. The bar should be just over your mid-foot. Flatten your back and push your heels into the floor."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[57].Id , Step = 3 , Instruction = "Try to extend your knees and hips simultaneously."},
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[58].Id , Step = 1 , Instruction = "Take a shoulder width, double overhand or mixed grip."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[58].Id , Step = 2 , Instruction = "Push your hips back while leaving your knees mostly extended. Look for a stretch in your hamstrings."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[58].Id , Step = 3 , Instruction = "When you feel the stretch, push your hips forward until you're back in a standing position."},
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[59].Id , Step = 1 , Instruction = "Pull your shoulder blades back really hard and place the bar on your posterior delts."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[59].Id , Step = 2 , Instruction = "Push your hips back and break at the knees to initiate the squat."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[59].Id , Step = 3 , Instruction = "Aim to get your hamstrings to parallel with the ground. Push your heels into the floor and squat back up to a standing position."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[60].Id , Step = 1 , Instruction = "Stand with your feet hip-width apart and place a barbell on the floor in front of you."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[60].Id , Step = 2 , Instruction = "Bend at the hips and knees to grasp the barbell with an overhand grip, positioning your hands just outside of your hips."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[60].Id , Step = 3 , Instruction = "Keeping your back straight and your core engaged, lift the barbell off the floor by extending your hips and knees."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[60].Id , Step = 4 , Instruction = "As you lift the barbell, pull your shoulders back and squeeze your glutes to fully extend your hips at the top of the movement."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[61].Id , Step = 1 , Instruction = "Stand with your feet shoulder-width apart and a barbell resting on your upper back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[61].Id , Step = 2 , Instruction = "Lower your body into a squat position, pausing for a moment at the bottom of the movement before standing back up."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[61].Id , Step = 3 , Instruction = "Push through your heels to return to the standing position."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[62].Id , Step = 1 , Instruction = "Stand in front of the landmine with your feet hip-width apart and your knees slightly bent. Grasp the landmine barbell with both hands, palms facing each other, and hold it in front of your thighs."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[62].Id , Step = 2 , Instruction = "Keeping your back straight and your core engaged, hinge at the hips and push your hips back, allowing the landmine to travel down your thighs. Lower the landmine by bending forward at the hips while keeping your back flat, allowing the barbell to move closer to the floor. Continue the movement until you feel a stretch in your hamstrings, keeping your legs relatively straight but with a slight bend in the knees."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[62].Id , Step = 3 , Instruction = "Reverse the movement by pushing your hips forward and driving through your heels while keeping your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[62].Id , Step = 4 , Instruction = "Repeat for the desired number of reps."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[63].Id , Step = 1 , Instruction = "Grab the end of the landmine and stand perpendicular to the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[63].Id , Step = 2 , Instruction = "Lift your inside leg and keep your outside leg planted."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[63].Id , Step = 3 , Instruction = "Push your hips back keeping your knees mostly extended. When you feel the stretch in your hams, push your hips forward until you are standing upright."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[64].Id , Step = 1 , Instruction = "Hold the end of the bar in front of you."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[64].Id , Step = 2 , Instruction = "Pop your hips, pull your elbows up to the ceiling, and get underneath the bar."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[65].Id , Step = 1 , Instruction = "Set up for a sumo deadlift, grip the barbell." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[65].Id , Step = 2 , Instruction = "Lift, pause at knee height." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[65].Id , Step = 3 , Instruction = "Hold briefly, then complete the lift; reset and repeat for desired reps." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[66].Id , Step = 1 , Instruction = "Set up for a standard deadlift, grip the barbell."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[66].Id , Step = 1 , Instruction = "Lift, pause at knee height."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[66].Id , Step = 1 , Instruction = "Hold briefly, then complete the lift; reset and repeat for desired reps."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[67].Id , Step = 1 , Instruction = "Stand with your mid-foot under the bar, plates should be on blocks, and grip the bar with your hands, about a shoulder width apart." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[67].Id , Step = 2 , Instruction = "Bend your knees, then lift the bar by straightening your back. It is important to keep your back straight." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[67].Id , Step = 3 , Instruction = "Stand to your full height and hold." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[67].Id , Step = 4 , Instruction = "Lower the bar to the floor by bending your knees and keeping your back straight." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[68].Id , Step = 1 , Instruction = "Stand with your mid-foot under the bar, feet should be on a plate or elevated platform, and grip the bar with your hands, about a shoulder width apart."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[68].Id , Step = 2 , Instruction = "Bend your knees, then lift the bar by straightening your back. It is important to keep your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[68].Id , Step = 3 , Instruction = "Stand to your full height and hold."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[68].Id , Step = 4 , Instruction = "Lower the bar to the floor by bending your knees and keeping your back straight."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[69].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, grip the barbell with a wide overhand grip, and keep your back straight and core engaged."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[69].Id , Step = 2 , Instruction = "Lift the barbell by explosively extending your hips, knees, and ankles while keeping the bar close to your body."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[69].Id , Step = 3 , Instruction = "As the bar reaches chest level, rotate your wrists and elbows up and back, transitioning into an overhead press."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[69].Id , Step = 4 , Instruction = "Fully extend your arms overhead, stabilize the bar, then lower it back to the starting position with control."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[70].Id , Step = 1 , Instruction = "Position your thighs on the padding and hook your feet on the platform supports."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[70].Id , Step = 2 , Instruction = "Keeping your back straight, slowly bend at your waist until your legs and back are at a 45° angle."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[70].Id , Step = 3 , Instruction = "Slowly raise your body to the starting position."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[71].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, barbell over midfoot. Grip the bar wide (outside shoulders), hook grip recommended."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[71].Id , Step = 2 , Instruction = "Keep chest up, back straight, and drive through heels to lift the bar off the ground, keeping it close to your body."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[71].Id , Step = 3 , Instruction = "As the bar reaches mid-thigh, explode upwards by extending hips, knees, and ankles, shrugging shoulders and pulling the bar high."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[71].Id , Step = 4 , Instruction = "Drop under the bar slightly, catching it overhead with arms locked out. Stand up fully to complete the lift."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[72].Id , Step = 1 , Instruction = "Sit on the machine and place your upper back on the rolling pad." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[72].Id , Step = 2 , Instruction = "Extend your hips and lower back. Make sure not to hyperextend your spine." },
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[73].Id , Step = 1 , Instruction = "Place the bar on your traps. You may need a pad so the bar doesn't dig into your cervical spine." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[73].Id , Step = 2 , Instruction = "Push your hips straight back. Your knees should stay MOSTLY extended (think soft knees). Also make sure to" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[73].Id , Step = 3 , Instruction = "Look for what feels like a stretch in your hamstrings. The stretch feeling means you're likely nearing the end of your Range of Motion without rounding your spine." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[73].Id , Step = 4 , Instruction = "When you feel the stretch push your hips forward until you're in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[74].Id , Step = 1 , Instruction = "Place the bar between your traps and rear delts. Pull your shoulder blades back to give the bar a shelf to sit on." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[74].Id , Step = 2 , Instruction = "Push your hips back until you feel a stretch in your hamstrings. This means you're nearing the end of your Range of Motion with out rounding your spine." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[74].Id , Step = 3 , Instruction = "When you feel the stretch push your hips forward until you're in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[75].Id , Step = 1 , Instruction = "Place one foot behind. You should only be on your toes on that back foot. Your front foot should be planted flat the entire time." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[75].Id , Step = 2 , Instruction = "Bend your back knee and push your hips back. Look for a stretch in your front hamstring." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[75].Id , Step = 3 , Instruction = "When you feel the stretch, push your hips forward again until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[76].Id , Step = 1 , Instruction = "Start by pushing your hips straight back and extending your non-working leg behind you. It is ok to touch your other foot back to the ground each rep." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[76].Id , Step = 2 , Instruction = "Leave your knee mostly extended. Look for a stretch in your hamstring. When you feel the stretch, push your hips forward until you're back in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[77].Id , Step = 1 , Instruction = "Stand in front of a box or bench with your feet shoulder-width apart and a barbell resting on your upper back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[77].Id , Step = 2 , Instruction = "Lower your body into a squat position, sitting back onto the box and pausing for a moment before standing back up." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[77].Id , Step = 3 , Instruction = "Push through your heels to return to the standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[78].Id , Step = 1 , Instruction = "Start hinged forward with a flat back and the plates resting on the floor. Make sure your elbows are fully extended." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[78].Id , Step = 2 , Instruction = "Pull the bar to your sternum." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[78].Id , Step = 3 , Instruction = "Return the plates back to the floor and let the bar come to a full dead stop." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[78].Id , Step = 4 , Instruction = "Then initiate the next rep." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[79].Id , Step = 1 , Instruction = "Start by standing with your feet about hip-width apart, with your toes pointed slightly outward." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[79].Id , Step = 2 , Instruction = "Place a barbell on the floor behind you, with the weight plates on either side." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[79].Id , Step = 3 , Instruction = "Bend down and grab the barbell with an overhand grip, your hands slightly wider than shoulder-width apart. Keep your back straight and your shoulders down as you grip the bar." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[79].Id , Step = 4 , Instruction = "Stand up straight, lifting the barbell off the ground and pulling it toward your hips. Keep your elbows close to your body and your shoulders down as you do this." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[80].Id , Step = 1 , Instruction = "Start by standing with your feet about hip-width apart, with your toes pointed slightly outward." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[80].Id , Step = 2 , Instruction = "Place a barbell on the floor in front of you, with the weight plates on either side. Make sure that the bar is directly in line with your feet." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[80].Id , Step = 3 , Instruction = "Bend down and grab the barbell with an overhand grip, your hands much wider than shoulder-width apart. Keep your back straight and your shoulders down as you grip the bar." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[80].Id , Step = 4 , Instruction = "Stand up straight, lifting the barbell off the ground and pulling it toward your hips. Keep your elbows close to your body and your shoulders down as you do this." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[80].Id , Step = 5 , Instruction = "Slowly lower the barbell back to the ground, making sure to keep your back straight and your shoulders down throughout the movement." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[81].Id , Step = 1 , Instruction = "Start by standing with your feet about hip-width apart. The bar should be in a rack or box so it's lifted off the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[81].Id , Step = 2 , Instruction = "Grab the barbell with an overhand grip, your hands should be much wider than shoulder-width apart." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[81].Id , Step = 3 , Instruction = "Hing forward at the hips keeping your knees mostly extended. Hinge until you feel a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[81].Id , Step = 4 , Instruction = "When you feel the stretch, push your hips forward until you are back in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[82].Id , Step = 1 , Instruction = "Begin by standing with your feet hip-width apart and holding a barbell at one side of your body, with your palms facing your thighs." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[82].Id , Step = 2 , Instruction = "Keeping your core engaged and your back straight, bend at the hips and knees to lower the barbell down towards the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[82].Id , Step = 3 , Instruction = "As the barbell reaches the ground, use your legs and glutes to push through your heels and extend your hips and knees to raise your body back to the starting position." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[82].Id , Step = 4 , Instruction = "Repeat the movement for the desired number of reps, then switch sides and repeat the exercise with the barbell on the opposite side of your body." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[83].Id , Step = 1 , Instruction = "Begin by standing in front of a barbell with your feet about hip-width apart and your palms facing towards your body." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[83].Id , Step = 2 , Instruction = "Bend at the hips and knees to grab the barbell with a pronated (overhand) grip, positioning the barbell about an inch away from your shins." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[83].Id , Step = 3 , Instruction = "Keeping your back straight and your core engaged, use your back muscles to lift the barbell straight up towards your chest." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[83].Id , Step = 4 , Instruction = "As the barbell reaches your chest, rotate your wrists so that your palms are facing towards your body (supinated grip), and then lower the barbell back to the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[84].Id , Step = 1 , Instruction = "Begin by standing in front of a barbell with your feet about hip-width apart." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[84].Id , Step = 2 , Instruction = "Bend at the hips and knees to grab the barbell with a supinated (underhand) grip, positioning the barbell about an inch away from your shins." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[84].Id , Step = 3 , Instruction = "Keeping your back straight and your core engaged, use your back muscles to lift the barbell straight up towards your chest." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[84].Id , Step = 4 , Instruction = "As the barbell reaches your chest, pause briefly, and then lower the barbell back to the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[85].Id , Step = 1 , Instruction = "Begin by standing with your feet about hip-width apart and holding a barbell in the crook of your elbows, with your palms facing towards your body." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[85].Id , Step = 2 , Instruction = "Keeping your core engaged and your back straight, bend at the hips and lower your torso forward until it is nearly parallel to the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[85].Id , Step = 3 , Instruction = "Push through your heels to extend your hips and raise your body back to the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[86].Id , Step = 1 , Instruction = "Begin by standing with your feet about hip-width apart and holding a barbell in the crook of your arms, near your belly. Your palms should be facing towards your body." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[86].Id , Step = 2 , Instruction = "Sit back and lower your body down until your thighs are parallel to the ground, keeping your back straight and your core engaged." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[86].Id , Step = 3 , Instruction = "Push through your heels to extend your hips and stand back up to the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[87].Id , Step = 1 , Instruction = "Stand in a staggered position. With the back leg bent and the front mostly extended." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[87].Id , Step = 2 , Instruction = "Push your hips back until you feel a stretch through your front hamstring." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[87].Id , Step = 3 , Instruction = "Push your hips back forward until you are standing." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[88].Id , Step = 1 , Instruction = "Begin by standing with your feet hip-width apart with the bar on the ground at your side." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[88].Id , Step = 2 , Instruction = "Lift the bar to your side and walk for the allotted amount of time or distance." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[88].Id , Step = 3 , Instruction = "Set the bar down and switch sides." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[89].Id , Step = 1 , Instruction = "Stand centered over the barbell, feet shoulder-width apart." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[89].Id , Step = 2 , Instruction = "Grip the bar with both hands, one in front, one behind." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[89].Id , Step = 3 , Instruction = "Lift by driving through your heels, keeping your back straight, then lower slowly." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[90].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, grip the bar just outside your knees. Pull the bar from the floor by driving through your legs, keeping your back straight." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[90].Id , Step = 2 , Instruction = "As the bar reaches your hips, extend explosively, shrug, and drop under to catch it in a front squat position with elbows high. Stand up tall." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[90].Id , Step = 3 , Instruction = "Dip slightly, then drive through your legs to push the bar overhead." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[90].Id , Step = 4 , Instruction = "Stabilize the bar overhead, lock arms, then bring feet together before lowering the bar safely." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[91].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart, barbell over midfoot. Grip the bar wide with an overhand grip, chest up, and back straight." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[91].Id , Step = 2 , Instruction = "Lift the bar by driving through your legs, keeping it close to your body. Extend your hips and knees while maintaining a straight back." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[91].Id , Step = 3 , Instruction = "Explosively extend your hips, knees, and ankles while shrugging your shoulders. Pull yourself under the bar as it moves upward." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[91].Id , Step = 4 , Instruction = "Drop into a deep squat while locking the bar overhead. Stabilize, then stand up fully to complete the lift." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[92].Id , Step = 1 , Instruction = "Begin by standing with your feet on a plate and holding a barbell in the crook of your arms, near your belly. Your palms should be facing towards your body." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[92].Id , Step = 2 , Instruction = "Step back with one foot off the plate and lower your back knee to the floor." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[92].Id , Step = 3 , Instruction = "Push through your front leg and bring your back foot to the plate." },
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[93].Id , Step = 1 , Instruction = "Grab a v bar and place it under the bar's collar." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[93].Id , Step = 2 , Instruction = "Hinge forward with a flat back and pull your elbows straight back toward the ceiling." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[93].Id , Step = 3 , Instruction = "Fully extend your elbows before initiating the next rep." },
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[94].Id , Step = 1 , Instruction = "Lay on the pad and grab the handles." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[94].Id , Step = 1 , Instruction = "Slip your legs into the belt loop." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[94].Id , Step = 1 , Instruction = "Push your legs back until they are horizontal with the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[94].Id , Step = 1 , Instruction = "Lower back to the starting position." },


            #endregion

            #region Lower Back & Stretches
            new WorkoutInstruction{ WorkoutId = backWorkouts[95].Id , Step = 1 , Instruction = "Sit on the floor with the tops of your feet pointed and flat on the ground. Move your arms out in front of you in the diving position, placing your palms flat against the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[95].Id , Step = 2 , Instruction = "With your arms fully extended, rest your buttocks on the heels of your feet, you can crawl your hands forward to extend the stretch if need be." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[95].Id , Step = 3 , Instruction = "Hold the extended position for a few seconds, and return to starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[96].Id , Step = 1 , Instruction = "Lay flat on the floor with your arms at either side." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[96].Id , Step = 2 , Instruction = "With one leg, hook one foot under the joint of your other leg." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[96].Id , Step = 3 , Instruction = "Rotate your hips so that your knees are pointing sideways, keeping your hooked leg flat against the floor." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[96].Id , Step = 4 , Instruction = "Pause at the apex of the stretch and repeat with your other leg." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[97].Id , Step = 1 , Instruction = "Lay on your back with your arms at either side." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[97].Id , Step = 2 , Instruction = "Raise your knees so that they are pointing straight towards the ceiling. Keeping your legs pressed together, rotate your hips to either side." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[97].Id , Step = 3 , Instruction = "Repeat this motion as necessary." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[98].Id , Step = 1 , Instruction = "Lay flat against the ground with your knees at an angle and your feet flat against the floor." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[98].Id , Step = 2 , Instruction = "Grab your legs just below the knees, and pull your legs towards your chest." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[98].Id , Step = 3 , Instruction = "Pause at the apex of the stretch, then return to the starting position." },
            #endregion

            #region Lower Back & Plate
            new WorkoutInstruction{ WorkoutId = backWorkouts[99].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, the plate in front of the feet, and the knees slightly bent." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[99].Id , Step = 2 , Instruction = "Bend the hips and knees to grip the plate with palms facing the body." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[99].Id , Step = 3 , Instruction = "Keeping the back straight, stand up while lifting the plate off the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[99].Id , Step = 4 , Instruction = "Return the plate back to the starting position by bending the hips and knees, keeping control of the plate." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[100].Id , Step = 1 , Instruction = "Stand with your feet shoulder-width apart and facing forwards. Grip the sides of a weight plate with your palms facing down." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[100].Id , Step = 2 , Instruction = "Balance on one foot, as you raise the weight keep your arms and back straight, while you bring your other foot back towards the ground" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[100].Id , Step = 3 , Instruction = "Keep four raised leg straight and in alignment with your back as you lower the plate back down to the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[101].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, the plate held in front of you, and the knees slightly bent." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[101].Id , Step = 2 , Instruction = "Bend forward at the hips, keeping the back straight, until the torso is parallel to the floor." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[101].Id , Step = 3 , Instruction = "Push through the hips to return to the starting position." },
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[102].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, the plate held behind the neck and the knees slightly bent." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[102].Id , Step = 2 , Instruction = "Bend forward at the hips, keeping the back straight, until the torso is parallel to the floor." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[102].Id , Step = 3 , Instruction = "Push through the hips to return to the starting position." },
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[103].Id , Step = 1 , Instruction = "Engage your core and straighten your legs to lift the plate off the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[103].Id , Step = 2 , Instruction = "Stand on one leg, keeping the other leg off the ground, while holding the plate in front of your body." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[103].Id , Step = 3 , Instruction = "Keep your back straight and maintain a neutral head position while looking straight ahead." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[103].Id , Step = 4 , Instruction = "Lower the plate back down to the ground while keeping your balance on one leg." },
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[104].Id , Step = 1 , Instruction = "Stand facing the plate with your feet shoulder-width apart and the plate positioned between your feet." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[104].Id , Step = 2 , Instruction = "Bend down and grasp the plate from the top edges with both hands, making sure your thumbs and fingers are evenly spaced." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[104].Id , Step = 3 , Instruction = "Keep your back straight, chest up and core engaged, and stand up with the plate, keeping it close to your body." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[104].Id , Step = 4 , Instruction = "Lower the plate back down to the ground, keeping control and maintaining good posture." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[105].Id , Step = 1 , Instruction = "Start by standing with your feet shoulder-width apart and holding a weight plate." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[105].Id , Step = 2 , Instruction = "Place one foot slightly behind the other, with the heel of your back foot elevated." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[105].Id , Step = 3 , Instruction = "From this starting position, bend at the hips and knees to lower the plate towards the ground, keeping your back straight and your core engaged." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[105].Id , Step = 4 , Instruction = "Once the plate is below your knees, drive through your heels to stand back up to the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[106].Id , Step = 1 , Instruction = "Start by standing with your feet shoulder-width apart and holding two plates with a pinch grip." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[106].Id , Step = 2 , Instruction = "Place one foot slightly behind the other, with the heel of your back foot elevated." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[106].Id , Step = 3 , Instruction = "From this starting position, bend at the hips and knees to lower the plates towards the ground, keeping your back straight and your core engaged." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[107].Id , Step = 1 , Instruction = "Lay flat on the ground on your stomach with your arms extended overhead. Hold a plate with a neutral grip." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[107].Id , Step = 2 , Instruction = "Lift your legs and chest off the ground simultaneously and hold for a 1 count at the top." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[107].Id , Step = 3 , Instruction = "Relax your lower back and lower your legs and chest back to the floor." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[108].Id , Step = 1 , Instruction = "Hold a plate in both hands." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[108].Id , Step = 2 , Instruction = "Pull your arms and legs off the ground while and hold that position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[109].Id , Step = 1 , Instruction = "Set up a bar at mid way up your quad. Place the working leg against the bar." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[109].Id , Step = 2 , Instruction = "Place one foot behind. You should only be on your toes on that back foot. Your front foot should be planted flat the entire time." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[109].Id , Step = 3 , Instruction = "Bend your back knee and push your hips back. Look for a stretch in your front hamstring." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[109].Id , Step = 4 , Instruction = "When you feel the stretch, push your hips forward again until you're back in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[110].Id , Step = 1 , Instruction = "Place a barbell at about midway up your thigh. Press your quads into the barbell. Hold a plate up to your chest." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[110].Id , Step = 2 , Instruction = "Push your hips back while leaving your knees mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[110].Id , Step = 3 , Instruction = "When you feel the stretch, push your hips forward until you're back in a standing position." },
            #endregion

            new WorkoutInstruction{ WorkoutId = backWorkouts[111].Id , Step = 1 , Instruction = "Sit on Bosu, lean back, one foot on the floor." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[111].Id , Step = 2 , Instruction = "Drive hips upward, squeezing glutes, one leg extended." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[111].Id , Step = 3 , Instruction = "Lower hips back down and switch legs." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[112].Id , Step = 1 , Instruction = "Lie face down on Bosu, arms extended." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[112].Id , Step = 2 , Instruction = "Lift arms, chest, and legs off the Bosu." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[112].Id , Step = 3 , Instruction = "Hold for a moment, then lower back down." },

            #region Lower Back & Smith machine
            new WorkoutInstruction{ WorkoutId = backWorkouts[113].Id , Step = 1 , Instruction = "Begin by standing in front of a bar with your feet about hip-width apart." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[113].Id , Step = 1 , Instruction = "Bend at the hips and knees to grab the bar with a supinated (underhand) grip, positioning the bar about an inch away from your shins." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[113].Id , Step = 1 , Instruction = "Keeping your back straight and your core engaged, use your back muscles to lift the bar straight up towards your chest." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[113].Id , Step = 1 , Instruction = "As the bar reaches your chest, pause briefly, and then lower the bar back to the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[114].Id , Step = 1 , Instruction = "Start hinged forward with a flat back. Make sure your elbows are fully extended." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[114].Id , Step = 2 , Instruction = "Pull the bar to your sternum." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[115].Id , Step = 1 , Instruction = "Stance width can vary with a sumo DL. Some prefer toes near the plates. Others prefer a more narrow stance to get more drive off the floor." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[115].Id , Step = 2 , Instruction = "Make sure your arms are inside your legs. The bar should be just over your mid-foot. Flatten your back and unrack the bar" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[115].Id , Step = 3 , Instruction = "Leave your knees mostly extended and flex and extend your hips." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[116].Id , Step = 1 , Instruction = "Place one foot behind. You should only be on your toes on that back foot. Your front foot should be planted flat the entire time." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[116].Id , Step = 2 , Instruction = "Bend your back knee and push your hips back. Look for a stretch in your front hamstring." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[116].Id , Step = 3 , Instruction = "When you feel the stretch, push your hips forward again until you're back in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[117].Id , Step = 1 , Instruction = "Take a shoulder width, double overhand or mixed grip." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[117].Id , Step = 1 , Instruction = "Push your hips back while leaving your knees mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[117].Id , Step = 1 , Instruction = "When you feel the stretch, push your hips forward until you're back in a standing position." },

            #endregion


            #region Lower Back & Dumbbell
            new WorkoutInstruction{ WorkoutId = backWorkouts[118].Id , Step = 1 , Instruction = "Lay flat on the ground on your stomach with your arms extended overhead. Hold a dumbbell with a neutral grip." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[118].Id , Step = 2 , Instruction = "Lift your legs and chest off the ground simultaneously and hold for a 1 count at the top." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[118].Id , Step = 3 , Instruction = "Relax your lower back and lower your legs and chest back to the floor." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[119].Id , Step = 1 , Instruction = "Hold the dumbbell in a goblet position. With your elbows directly under your fists." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[119].Id , Step = 2 , Instruction = "Push your hips back while leaving your knees MOSTLY extended. You should feel a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[119].Id , Step = 3 , Instruction = "When you feel the stretch push your hips forward until you're back in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[120].Id , Step = 1 , Instruction = "Stand with a shoulder width stance. Push your butt back while leaving your knees MOSTLY extended." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[120].Id , Step = 2 , Instruction = "You should feel a stretch in your hamstrings. When you feel the stretch, push your hips forward to complete the rep." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[120].Id , Step = 3 , Instruction = "Do not push your hips all the way forward. This will hyperextend your spine. Just go to a normal standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[121].Id , Step = 1 , Instruction = "Place two dumbbells on your shoulders and make sure you force your elbows upward." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[121].Id , Step = 2 , Instruction = "Push your hips back and break at the knees." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[121].Id , Step = 3 , Instruction = "When you reach parallel (hamstrings parallel with the ground) pause for 1-3 seconds. Then push through your heels back to the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[122].Id , Step = 1 , Instruction = "Start by standing on one leg with a dumbbell in one hand." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[122].Id , Step = 2 , Instruction = "Slowly bend at the hips and lower the dumbbell towards the ground while extending your free leg behind you." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[122].Id , Step = 3 , Instruction = "Keep your core engaged and your back straight as you lower the weight." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[122].Id , Step = 4 , Instruction = "Once the dumbbell is close to the ground, push through your heel to return to the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[123].Id , Step = 1 , Instruction = "Start by standing on one leg with your feet shoulder-width apart and holding two dumbbells." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[123].Id , Step = 2 , Instruction = "From this starting position, hinge at the hips to lower the dumbbell towards the ground, keeping your back straight and your core engaged." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[123].Id , Step = 3 , Instruction = "Once you feel a stretch in your hamstring, slowly return to the starting position." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[123].Id , Step = 4 , Instruction = "Make sure to keep your standing leg slightly bent and avoid rounding your back as you lower the dumbbell." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[124].Id , Step = 1 , Instruction = "Start by standing with your feet shoulder-width apart and holding a dumbbell in each hand." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[124].Id , Step = 2 , Instruction = "Place one foot slightly behind the other, with the heel of your back foot elevated on a step or weight plate." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[124].Id , Step = 3 , Instruction = "From this starting position, bend at the hips and knees to lower the dumbbells towards the ground, keeping your back straight and your core engaged." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[124].Id , Step = 4 , Instruction = "Once the dumbbells are below your knees, drive through your heels to stand back up to the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[125].Id , Step = 1 , Instruction = "Start by standing with your feet wider than shoulder-width apart and holding a dumbbell in each hand." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[125].Id , Step = 2 , Instruction = "Place the dumbbells on the ground between your feet." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[125].Id , Step = 3 , Instruction = "From this starting position, bend your knees and lower your body down into a squat." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[125].Id , Step = 4 , Instruction = "Make sure to keep your core engaged and your back straight throughout the movement." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[126].Id , Step = 1 , Instruction = "Start by standing with your feet shoulder-width apart and holding a dumbbell in both hands." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[126].Id , Step = 2 , Instruction = "Bend your knees slightly and hinge at the hips to swing the dumbbell between your legs." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[126].Id , Step = 3 , Instruction = "From this starting position, explosively extend your hips and swing the dumbbell up to chest height." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[126].Id , Step = 4 , Instruction = "Allow the momentum of the swing to carry the dumbbell back down between your legs, and then repeat the movement for the desired number of repetitions." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[127].Id , Step = 1 , Instruction = "Lie face down on a mat." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[127].Id , Step = 2 , Instruction = "Hold dumbbells out in front." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[127].Id , Step = 3 , Instruction = "Lift arms and legs simultaneously, squeezing lower back." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[128].Id , Step = 1 , Instruction = "Stand with a shoulder width stance holding one dumbbell. Push your butt back while leaving your knees MOSTLY extended." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[128].Id , Step = 2 , Instruction = "Reach toward the opposing leg. You should feel a stretch in your hamstrings. When you feel the stretch, push your hips forward to complete the rep." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[128].Id , Step = 3 , Instruction = "Do not push your hips all the way forward. This will hyperextend your spine. Just go to a normal standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[129].Id , Step = 1 , Instruction = "The dumbbells should be set on the ground. Hinge forward while keeping a flat back." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[129].Id , Step = 2 , Instruction = "Pull one elbow back toward the ceiling and then return the dumbbell to the ground softly." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[129].Id , Step = 3 , Instruction = "Then pull with the other arm." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[130].Id , Step = 1 , Instruction = "Stand in front of a box or bench with your feet shoulder-width apart with a dumbbell in a goblet position." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[130].Id , Step = 2 , Instruction = "Lower your body into a squat position, sitting back onto the box and pausing for a moment before standing back up." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[130].Id , Step = 3 , Instruction = "Push through your heels to return to the standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[131].Id , Step = 1 , Instruction = "Set up a bar at mid way up your quad. Place the working leg against the bar." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[131].Id , Step = 2 , Instruction = "Place one foot behind. You should only be on your toes on that back foot. Your front foot should be planted flat the entire time." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[131].Id , Step = 3 , Instruction = "Bend your back knee and push your hips back. Look for a stretch in your front hamstring." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[131].Id , Step = 4 , Instruction = "When you feel the stretch, push your hips forward again until you're back in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[132].Id , Step = 1 , Instruction = "Place a barbell at about midway up your thigh. Press your quads into the barbell." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[132].Id , Step = 2 , Instruction = "Push your hips back while leaving your knees mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[132].Id , Step = 3 , Instruction = "When you feel the stretch, push your hips forward until you're back in a standing position." },
            #endregion

            new WorkoutInstruction{ WorkoutId = backWorkouts[133].Id , Step = 1 , Instruction = "Hold medicine ball while standing on one leg." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[133].Id , Step = 2 , Instruction = "Hold medicine ball while standing on one leg." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[133].Id , Step = 3 , Instruction = "Return to starting position. Repeat on other leg." },

            #region Lower Back & Cables
            new WorkoutInstruction{ WorkoutId = backWorkouts[134].Id , Step = 1 , Instruction = "Start with a straight bar or easy bar attachment ." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[134].Id , Step = 2 , Instruction = "Get your elbows directly underneath the bar, squat straight up and then walk back a few steps." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[134].Id , Step = 3 , Instruction = "Break at your knees and hips to initiate the squat. Make sure you maintain a flat back." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[134].Id , Step = 4 , Instruction = "Squat all the way back to a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[135].Id , Step = 1 , Instruction = "Start with a straight bar or ez bar attachment set to the bottom of the machine. Squat the weight up into a standing position and walk a few steps back" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[135].Id , Step = 2 , Instruction = "Push your butt back to initiate the movement and then push your butt forward until you're back in a standing position." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[135].Id , Step = 3 , Instruction = "To protect yourself from injury, always maintain a flat back on any exercise." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[136].Id , Step = 1 , Instruction = "Start with a straight bar or easy bar attachment. Squat the weight up into a standing position and walk a few steps back." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[136].Id , Step = 2 , Instruction = "Push your butt back to initiate the movement while lifting one of your legs. Then push your butt forward until you're back in a standing position." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[136].Id , Step = 3 , Instruction = "Compete your given amount of reps, then switch to opposite leg." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[136].Id , Step = 4 , Instruction = "To protect yourself from injury, always maintain a flat back." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[137].Id , Step = 1 , Instruction = "This exercise works best with a rope attachment but can be done with anything. The attachment should be set to the bottom of the machine." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[137].Id , Step = 2 , Instruction = "Face away from the cable machine, straddle the cable itself, and grab the attachment. Walk a few steps away." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[137].Id , Step = 3 , Instruction = "Break at the hips while maintaining a flat back and mostly extended knees." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[137].Id , Step = 4 , Instruction = "Push hips forward until you are back in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[138].Id , Step = 1 , Instruction = "Use an ankle attachment. The cable should be set to the bottom of the crossover machine." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[138].Id , Step = 2 , Instruction = "Push your ankle straight back, extending at the hip. Hold for a one count when you feel a contraction in your glutes." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[138].Id , Step = 3 , Instruction = "Then flex at the hips until you are back into your original position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[139].Id , Step = 1 , Instruction = "Start with a straight bar or easy bar attachment ." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[139].Id , Step = 2 , Instruction = "Place the bar in your elbows, squat straight up and then walk back a few steps." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[139].Id , Step = 3 , Instruction = "Break at your knees and hips to initiate the squat. Make sure you maintain a flat back." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[139].Id , Step = 4 , Instruction = "Squat all the way back to a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[140].Id , Step = 1 , Instruction = "Use an ankle attachment. Bring a bench over to the cables. Put the bench at incline level. The cable should be set to shoulder height." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[140].Id , Step = 2 , Instruction = "Push your ankle straight back, extending at the hip. Hold for a one count when you feel a contraction in your glutes." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[140].Id , Step = 3 , Instruction = "Then flex at the hips until you are back into your original position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[141].Id , Step = 1 , Instruction = "Use an ankle attachment. Bring a bench over to the cables. The cable should be set to hip height." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[141].Id , Step = 2 , Instruction = "Push your ankle straight back, extending at the hip. Hold for a one count when you feel a contraction in your glutes." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[141].Id , Step = 3 , Instruction = "Then flex at the hips until you are back into your original position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[142].Id , Step = 1 , Instruction = "Use an ankle attachment. The cable should be set halfway up the crossover machine." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[142].Id , Step = 2 , Instruction = "Start with a bent knee position. Push your ankle straight back, extending at the hip. Hold for a one count when you feel a contraction in your glutes." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[142].Id , Step = 3 , Instruction = "Then flex at the hips until you are back into your original position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[143].Id , Step = 1 , Instruction = "Use an ankle attachment. The cable should be set to halfway up the crossover machine." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[143].Id , Step = 2 , Instruction = "Push your ankle straight back, extending at the hip. Hold for a one count when you feel a contraction in your glutes." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[143].Id , Step = 3 , Instruction = "Then flex at the hips until you are back into your original position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[144].Id , Step = 1 , Instruction = "Begin by standing with your feet about hip-width apart and holding the bar in the crook of your elbows, with your palms facing towards your body." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[144].Id , Step = 2 , Instruction = "Keeping your core engaged and your back straight, bend at the hips and lower your torso forward until it is nearly parallel to the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[144].Id , Step = 3 , Instruction = "Push through your heels to extend your hips and raise your body back to the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[145].Id , Step = 1 , Instruction = "Start with a straight bar attachment set to the bottom of the machine. Squat the weight up into a standing position and walk a few steps back." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[145].Id , Step = 2 , Instruction = "Stand with a staggered stance. Push your butt back to initiate the movement and then push your butt forward until you're back in a standing position." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[145].Id , Step = 3 , Instruction = "To protect yourself from injury, always maintain a flat back on any exercise." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[146].Id , Step = 1 , Instruction = "Start with handles set to the bottom of the machine. Grab a box, stand on top of the box, squat the weight up into a standing position." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[146].Id , Step = 2 , Instruction = "Push your butt back to initiate the movement and then push your butt forward until you're back in a standing position." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[146].Id , Step = 3 , Instruction = "To protect yourself from injury, always maintain a flat back on any exercise." },
            #endregion

            new WorkoutInstruction{ WorkoutId = backWorkouts[147].Id , Step = 1 , Instruction = "Grasp the TRX handles with both hands, keeping your arms extended and your shoulders away from your ears." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[147].Id , Step = 2 , Instruction = "Keep your abs engaged, roll forward onto your toes, and extend your arms in front of you." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[147].Id , Step = 3 , Instruction = "Slowly lower your body down to the ground, keeping your arms straight and your abs engaged." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[147].Id , Step = 4 , Instruction = "When your head gets between your arms, pause for a moment and then use your abs to pull your body back up to the starting position." },

            #region Lower Back & Vitruvian
            new WorkoutInstruction{ WorkoutId = backWorkouts[148].Id , Step = 1 , Instruction = "Take an overhand grip." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[148].Id , Step = 2 , Instruction = "Keep your knees mostly extended and hinge forward at the hips." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[148].Id , Step = 3 , Instruction = "Keep a flat back." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[149].Id , Step = 1 , Instruction = "" },

            new WorkoutInstruction{ WorkoutId = backWorkouts[150].Id , Step = 1 , Instruction = "Place one foot firmly on the ground and one foot behind the other. Bend the knee on your back leg." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[150].Id , Step = 2 , Instruction = "Hinge forward until you feel a stretch in your front leg." },
            #endregion

            #region Lower back & Recovery
            new WorkoutInstruction{ WorkoutId = backWorkouts[151].Id , Step = 1 , Instruction = "Lay on your front placing your palms under your shoulders" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[151].Id , Step = 2 , Instruction = "Keep the elbows bent and close to your body" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[151].Id , Step = 3 , Instruction = "Lift your upper body off the ground supporting your weight on your forearms" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[151].Id , Step = 4 , Instruction = "Keep the hips on the ground" },

            new WorkoutInstruction{ WorkoutId = backWorkouts[152].Id , Step = 1 , Instruction = "Lay on your front placing your palms under your shoulders" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[152].Id , Step = 2 , Instruction = "Keep the elbows bent and close to your body" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[152].Id , Step = 3 , Instruction = "Lift your upper body off the ground supporting your weight on your palms" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[152].Id , Step = 4 , Instruction = "Keep the hips on the ground" },

            new WorkoutInstruction{ WorkoutId = backWorkouts[153].Id , Step = 1 , Instruction = "Stand up straight with a good form." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[153].Id , Step = 2 , Instruction = "Send your hips back and start tilting the upper body." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[153].Id , Step = 3 , Instruction = "Maintain a straight back as you aim for your toes." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[153].Id , Step = 4 , Instruction = "Your range depends on your hamstring flexibility." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[154].Id , Step = 1 , Instruction = "Lie on your front with your arms extended and above your head." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[154].Id , Step = 2 , Instruction = "Point the thumbs up. Try to raise your arms off the ground keeping them straight." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[154].Id , Step = 3 , Instruction = "Bend your elbows to the side and form the letter \"W\" with your arms." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[154].Id , Step = 4 , Instruction = "Extend to the \"I\" position but do not rest on the ground." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[155].Id , Step = 1 , Instruction = "Lie on your back and flatten you lower back against the ground" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[155].Id , Step = 2 , Instruction = "Pull one knee towards your chest and then across your body till it forces your lower back into a rotated position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[156].Id , Step = 1 , Instruction = "Lie on your front leaning your forehead on the back of your palms." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[156].Id , Step = 2 , Instruction = "Ask someone to hold your ankles or secure them under a supportive structure." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[156].Id , Step = 3 , Instruction = "Squeeze your glutes and tilt your hips backwards (flattens the front of your hips against the ground)." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[156].Id , Step = 4 , Instruction = "Raise your chest off the ground and lower it without resting on the ground before the next rep." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[157].Id , Step = 1 , Instruction = "Lie on your front leaning your forehead on the back of your palms." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[157].Id , Step = 2 , Instruction = "Squeeze your glutes and tilt your hips backwards (flattens the front of your hips against the ground)." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[157].Id , Step = 3 , Instruction = "Raise your chest off the ground and lower it without resting on the ground before the next rep" },

            new WorkoutInstruction{ WorkoutId = backWorkouts[158].Id , Step = 1 , Instruction = "Lie on your front and bring your arms into the \"W\" position." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[158].Id , Step = 2 , Instruction = "Squeeze your glutes and tilt your hips backwards (flattens the front of your hips against the ground)." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[158].Id , Step = 3 , Instruction = "Raise your chest off the ground and lower it without resting on the ground before the next rep." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[159].Id , Step = 1 , Instruction = "Lie on your front and bring your arms in the \"I\" position, thumbs pointing the ceiling." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[159].Id , Step = 2 , Instruction = "Squeeze your glutes and tilt your hips backwards (flattens the front of your hips against the ground)." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[159].Id , Step = 3 , Instruction = "Raise your chest off the ground and lower it without resting on the ground before the next rep." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[160].Id , Step = 1 , Instruction = "Lie on your back with your feet on a bench. Place a peanut tool under your lower back." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[160].Id , Step = 2 , Instruction = "Adjust pressure by pressing your heels into the bench. Roll back and forth or side to side" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[160].Id , Step = 3 , Instruction = "Maintain a neutral lower back (do not tilt the pelvis)." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[161].Id , Step = 1 , Instruction = "Lie on your back with bent knees." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[161].Id , Step = 2 , Instruction = "Hug your knees and pull them towards your chest." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[161].Id , Step = 3 , Instruction = "Feel your lower back come off the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[161].Id , Step = 4 , Instruction = "You can add a you can add an abduction to target the hips as well." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[162].Id , Step = 1 , Instruction = "Lie on your back with your knees bent and the feet flat on the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[162].Id , Step = 2 , Instruction = "Keep your knees and ankles together. Drop both knees towards the same side." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[162].Id , Step = 3 , Instruction = "Stay in this position and breathe deep and slow." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[162].Id , Step = 4 , Instruction = "To increase the intensity of the stretch you can reach up with your arms." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[163].Id , Step = 1 , Instruction = "Lie on your back with your knees bent and the feet flat on the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[163].Id , Step = 2 , Instruction = "Drop your knees towards one side before moving towards the other." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[163].Id , Step = 3 , Instruction = "To increase the intensity of the stretch you can reach up with your arms." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[164].Id , Step = 1 , Instruction = "Lie on your back with your knees bent and the feet flat on the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[164].Id , Step = 2 , Instruction = "Drop your knees towards one side then place your ankle on the opposite knee." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[164].Id , Step = 3 , Instruction = "To increase the intensity of the stretch you can reach up with your arms." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[165].Id , Step = 1 , Instruction = "Lie on your back with your knees bent and the feet flat on the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[165].Id , Step = 2 , Instruction = "Cross your legs. Drop your knees towards one side before moving towards the other." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[165].Id , Step = 3 , Instruction = "To increase the intensity of the stretch you can reach up with your arms." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[166].Id , Step = 1 , Instruction = "Lie on your back with your knees bent and the feet flat on the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[166].Id , Step = 2 , Instruction = "Drop your knees towards one side and add a kick at the end of range." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[166].Id , Step = 3 , Instruction = "To increase the intensity of the stretch you can reach up with your arms." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[167].Id , Step = 1 , Instruction = "Sit on your heels and reach out your arms on the floor while pressing the chest towards the ground." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[168].Id , Step = 1 , Instruction = "Sit on your heels and reach out your arms on a box or foam roller while pressing the chest towards the ground." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[169].Id , Step = 1 , Instruction = "Lie on the floor keeping your knees bent and the feet on the floor." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[169].Id , Step = 2 , Instruction = "Place a massage ball under your lower back and move around till the ball presses into a tight/sore spot." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[169].Id , Step = 3 , Instruction = "If you use a foam roller you would have to be seated and leaning back into the roller." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[170].Id , Step = 1 , Instruction = "Place a box behind you and one foot on it. Keep your chest up and the back straight" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[170].Id , Step = 2 , Instruction = "Tilt at the hips to perform a deadlift. Use the box for balance and support" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[170].Id , Step = 3 , Instruction = "Make sure you straighten your back leg when performing the deadlift." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[170].Id , Step = 4 , Instruction = "As you get comfortable with the movement, try to lift the leg off the box when you reach the end range of the deadlift." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[171].Id , Step = 1 , Instruction = "Lie on your front with your arms by your side, palms facing down." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[171].Id , Step = 2 , Instruction = "Tense your back muscles to raise both ends of your body off the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[171].Id , Step = 3 , Instruction = "Keep your core engaged as you will be supporting your weight on your belly." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[172].Id , Step = 1 , Instruction = "Lie on your front, arms above head. Squeeze glutes to protect lower back" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[172].Id , Step = 2 , Instruction = "Raise your chest and arms off the ground. Adduct (bring your arms by your hips)" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[172].Id , Step = 3 , Instruction = "You can touch down and repeat the whole movement, or remain off the ground and just perform the \"swipes.\"" },

            new WorkoutInstruction{ WorkoutId = backWorkouts[173].Id , Step = 1 , Instruction = "Lie on your front, arms above head. Squeeze glutes to protect lower back" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[173].Id , Step = 2 , Instruction = "Raise your chest and arms off the ground. Adduct (bring your arms by your hips) in an alternating fashion." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[173].Id , Step = 3 , Instruction = "You can touch down and repeat the whole movement, or remain off the ground and just perform the \"swipes.\"" },

            new WorkoutInstruction{ WorkoutId = backWorkouts[174].Id , Step = 1 , Instruction = "Stand up straight with a good form." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[174].Id , Step = 2 , Instruction = "Send your hips back and start tilting the upper body." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[174].Id , Step = 3 , Instruction = "Maintain a straight back as you aim for your toes." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[174].Id , Step = 4 , Instruction = "Lower the bar to the floor by bending your knees and keeping your back straight." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[175].Id , Step = 1 , Instruction = "Stand tall, hinge at hips, and reach hands to the floor." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[175].Id , Step = 2 , Instruction = "Walk hands forward into a plank position." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[175].Id , Step = 3 , Instruction = "Walk feet towards hands and repeat the motion." },
            #endregion

            #region lower back & Bodyweight
            new WorkoutInstruction{ WorkoutId = backWorkouts[176].Id , Step = 1 , Instruction = "Lie face down on the floor with your arms fully extended in front of you." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[176].Id , Step = 2 , Instruction = "Simultaneously raise your arms, legs and chest off of the floor and hold the position." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[176].Id , Step = 3 , Instruction = "Slowly lower your arms, legs and chest back to the starting position. Repeat." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[177].Id , Step = 1 , Instruction = "Stand with your feet a little past shoulder width apart with a slight bend at your knee. Place your hands behind the back of your head." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[177].Id , Step = 2 , Instruction = "Keeping your back straight, rotate your hips to bring your shoulders down towards the floor. Stop when your chest is parallel with the floor." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[178].Id , Step = 1 , Instruction = "Stand with your feet shoulder-width apart and knees slightly bent and raise one leg." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[178].Id , Step = 2 , Instruction = "Without changing the bend in your knee, bend at your hips, and lower your torso until it's almost parallel to the floor." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[178].Id , Step = 3 , Instruction = "Tense your glutes and then bring yourself back to the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[179].Id , Step = 1 , Instruction = "Set up a bar at mid way up your quad. Place the working leg against the bar." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[179].Id , Step = 2 , Instruction = "Place one foot behind. You should only be on your toes on that back foot. Your front foot should be planted flat the entire time." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[179].Id , Step = 3 , Instruction = "Bend your back knee and push your hips back. Look for a stretch in your front hamstring." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[179].Id , Step = 4 , Instruction = "When you feel the stretch, push your hips forward again until you're back in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[180].Id , Step = 1 , Instruction = "Place a barbell at about midway up your thigh. Press your quads into the barbell." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[180].Id , Step = 2 , Instruction = "Push your hips back while leaving your knees mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[180].Id , Step = 3 , Instruction = "When you feel the stretch, push your hips forward until you're back in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[181].Id , Step = 1 , Instruction = "Lie face-down on a stability ball, hips centered, feet anchored, hands behind your head." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[181].Id , Step = 2 , Instruction = "Engage your core, lift your upper body until aligned with legs, keeping your neck neutral." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[181].Id , Step = 3 , Instruction = "Lower your torso slowly back to the starting position, maintaining control and steady breathing." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[182].Id , Step = 1 , Instruction = "Lie face down on a stability ball, hands on the floor, legs extended straight." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[182].Id , Step = 2 , Instruction = "Engage glutes and lower back, raising legs until aligned with your torso." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[182].Id , Step = 3 , Instruction = "Slowly lower legs back down without touching the ground, maintaining core engagement. Repeat." },

            #endregion

            #region Lower back & Kettlebell

            new WorkoutInstruction{ WorkoutId = backWorkouts[183].Id , Step = 1 , Instruction = "Stand with your feet slightly wider than shoulder width apart holding the kettlebell between your legs, with your knees slightly bent." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[183].Id , Step = 2 , Instruction = "Keeping your back straight, swing the kettlebell upwards until the kettlebell is level with your chest and carefully lower." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[183].Id , Step = 3 , Instruction = "Repeat" },

            new WorkoutInstruction{ WorkoutId = backWorkouts[184].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart, shifting one foot behind you. Hold the kettlebell in both hands in front of your thighs." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[184].Id , Step = 2 , Instruction = "Bend forward at the hips bringing the kettlebell to the floor while you slightly bend your knees and keep your back straight." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[184].Id , Step = 3 , Instruction = "Return to the upright position and repeat." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[185].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart holding the kettlebell with both hands in front of your chest." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[185].Id , Step = 2 , Instruction = "Bend forward at the hips keeping your back and knees straight and the kettlebell close to your chest." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[185].Id , Step = 3 , Instruction = "Return to standing position and thrust your pelvis forward." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[186].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart, kettlebell between legs." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[186].Id , Step = 2 , Instruction = "Hinge at hips, swing kettlebell between legs." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[186].Id , Step = 3 , Instruction = "Swing kettlebell up, switch hands at the top, and repeat in a fluid motion." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[187].Id , Step = 1 , Instruction = "Stand with feet hip-width apart." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[187].Id , Step = 2 , Instruction = "Bend at hips and knees to lift kettlebells." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[187].Id , Step = 3 , Instruction = "Stand tall, then lower." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[188].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart, kettlebells outside legs" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[188].Id , Step = 2 , Instruction = "Hinge at hips, swing kettlebells forward, then back." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[188].Id , Step = 3 , Instruction = "Thrust hips to swing kettlebells upward, keeping arms straight." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[189].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart, kettlebell between legs." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[189].Id , Step = 2 , Instruction = "Hinge at hips, grip kettlebell, and swing it overhead." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[189].Id , Step = 3 , Instruction = "Extend hips and knees, lock out arms at the top." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[190].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, holding kettlebells in front." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[190].Id , Step = 2 , Instruction = "Hinge at hips, keeping back straight, and lower kettlebells towards ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[190].Id , Step = 3 , Instruction = "Return to start position, squeezing glutes at the top." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[191].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart, kettlebell between legs, grip with one hand, hinge at hips." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[191].Id , Step = 2 , Instruction = "Swing kettlebell forcefully forward, using hip thrust, arm straight." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[191].Id , Step = 3 , Instruction = "Swing kettlebell back between legs, repeat for desired reps." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[192].Id , Step = 1 , Instruction = "Begin with feet hip-width apart, one foot forward, kettlebell between feet." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[192].Id , Step = 2 , Instruction = "Hinge at hips, grip kettlebell, and stand tall." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[193].Id , Step = 3 , Instruction = "Lower kettlebell with control, then repeat." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[193].Id , Step = 1 , Instruction = "Lower kettlebell with control, then repeat." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[193].Id , Step = 2 , Instruction = "Explosively thrust hips forward, swing kettlebell to chest height." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[193].Id , Step = 3 , Instruction = "Repeat for desired reps, keeping core engaged and maintaining a staggered stance for balance." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[194].Id , Step = 1 , Instruction = "Stand with feet wide apart, toes pointing slightly outward, and kettlebell on the floor between your feet." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[194].Id , Step = 2 , Instruction = "Bend at hips and knees, keeping back straight, and grip the kettlebell handle." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[194].Id , Step = 3 , Instruction = "Lift the kettlebell by extending hips and knees, stand up straight, and return to the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[195].Id , Step = 1 , Instruction = "Begin by lying face down on the floor with a kettlebell in each hand, arms extended." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[195].Id , Step = 2 , Instruction = "Lift your chest and legs off the ground simultaneously while squeezing your glutes and raising the kettlebells." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[195].Id , Step = 3 , Instruction = "Lower your body and kettlebells back to the floor, then repeat for the desired number of reps." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[196].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, kettlebell in one hand, arm fully extended, and hinge at hips." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[196].Id , Step = 2 , Instruction = "Lift opposite leg straight behind you, forming a straight line from head to heel." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[196].Id , Step = 3 , Instruction = "Hold for 15-30 seconds, switch sides, and repeat for a balanced kettlebell superman hold." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[197].Id , Step = 1 , Instruction = "Start with a kettlebell between your legs, hinge at hips, swing it upward." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[197].Id , Step = 2 , Instruction = "Lift kettlebell to chest level, elbows high, engaging shoulders." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[197].Id , Step = 3 , Instruction = "Lower kettlebell back down, maintaining control. Repeat for desired reps." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[198].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart, lifting one foot off the floor behind you. Hold the kettlebell in the same arm as the lifted leg." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[198].Id , Step = 2 , Instruction = "Bend forward at the hips bringing the kettlebell to the floor while you extend your lifted leg behind you, keeping your back straight - holding out your arm to the side for balance." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[198].Id , Step = 3 , Instruction = "Return to the upright position and repeat." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[199].Id , Step = 1 , Instruction = "Begin by standing with your feet hip-width apart and holding a kettlebell at one side of your body, with your palms facing your thighs." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[199].Id , Step = 2 , Instruction = "Keeping your core engaged and your back straight, bend at the hips and knees to lower the kettlebell down towards the ground." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[199].Id , Step = 3 , Instruction = "As the kettlebell reaches the ground, use your legs and glutes to push through your heels and extend your hips and knees to raise your body back to the starting position." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[199].Id , Step = 4 , Instruction = "Repeat the movement for the desired number of reps, then switch sides and repeat the exercise with the kettlebell on the opposite side of your body." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[200].Id , Step = 1 , Instruction = "Stand in front of a box or bench with your feet shoulder-width apart with a kettlebell in a goblet position." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[200].Id , Step = 2 , Instruction = "Lower your body into a squat position, sitting back onto the box and pausing for a moment before standing back up." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[200].Id , Step = 3 , Instruction = "Push through your heels to return to the standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[201].Id , Step = 1 , Instruction = "Set up a bar at mid way up your quad. Place the working leg against the bar." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[201].Id , Step = 2 , Instruction = "Place one foot behind. You should only be on your toes on that back foot. Your front foot should be planted flat the entire time." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[201].Id , Step = 3 , Instruction = "Bend your back knee and push your hips back. Look for a stretch in your front hamstring." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[201].Id , Step = 4 , Instruction = "When you feel the stretch, push your hips forward again until you're back in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[202].Id , Step = 1 , Instruction = "Place a barbell at about midway up your thigh. Press your quads into the barbell." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[202].Id , Step = 2 , Instruction = "Push your hips back while leaving your knees mostly extended. Look for a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[202].Id , Step = 3 , Instruction = "When you feel the stretch, push your hips forward until you're back in a standing position." },
            #endregion

            #region Lower back & Band
            new WorkoutInstruction{ WorkoutId = backWorkouts[203].Id , Step = 1 , Instruction = "Anchor the band at hip level. Take a few steps away until the band is taut." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[203].Id , Step = 2 , Instruction = "Push your hips back while keeping your back flat until you feel a stretch in your hamstrings." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[204].Id , Step = 1 , Instruction = "Anchor the band to the lowest point possible. Straddle the band and then grab with both hands." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[204].Id , Step = 2 , Instruction = "Take a few steps away until the band is taut." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[204].Id , Step = 3 , Instruction = "Push your butt back until you feel a stretch in your hamstrings. Then extend the hips back into the starting position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[205].Id , Step = 1 , Instruction = "Stand on your band with both feet." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[205].Id , Step = 2 , Instruction = "Hinge forward at the hips while keeping a flat back." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[205].Id , Step = 3 , Instruction = "Hinge until you feel a stretch in your hamstrings." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[205].Id , Step = 4 , Instruction = "Push your hips back forward until you are in a standing position." },
            #endregion

            #region Lower Back & Yoga
            new WorkoutInstruction{ WorkoutId = backWorkouts[206].Id , Step = 1 , Instruction = "Lie down on your back with your knees bent and feet flat on the floor." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[206].Id , Step = 2 , Instruction = "Lift your feet off the floor and bring your knees towards your chest." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[206].Id , Step = 3 , Instruction = "Reach inside your knees and hold onto the outside edges of your feet." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[206].Id , Step = 4 , Instruction = "Gently pull your knees towards your armpits and rock side to side for a few breaths." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[207].Id , Step = 1 , Instruction = "Start by lying down on your stomach on a yoga mat or a comfortable surface." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[207].Id , Step = 2 , Instruction = "Place your elbows underneath your shoulders, keeping your forearms parallel to each other." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[207].Id , Step = 3 , Instruction = "Press your palms and forearms firmly into the ground to lift your chest up, while keeping your hips and legs relaxed." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[207].Id , Step = 4 , Instruction = "Make sure your shoulders are relaxed and away from your ears. Gently roll your shoulder blades down and back to open up your chest." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[207].Id , Step = 5 , Instruction = "Lengthen your spine by lifting the crown of your head towards the ceiling, while keeping your chin tucked in slightly." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[208].Id , Step = 1 , Instruction = "Start prone, hands under shoulders." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[208].Id , Step = 2 , Instruction = "Inhale, lift chest, arch back." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[208].Id , Step = 3 , Instruction = "Elongate neck, gaze up. Breathe, hold. Release, exhale." },
            #endregion

        };
        //await context.WorkoutInstructions.AddRangeAsync(backWorkoutInstruction);
        //await context.SaveChangesAsync();


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
            #region Traps & Barbell
            new WorkoutEquipment{ WorkoutId = backWorkouts[0].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[1].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[2].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[3].Id, EquipmentId = barbellId },
            #endregion

            #region Traps & Machine
            new WorkoutEquipment{ WorkoutId = backWorkouts[4].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[5].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[6].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[7].Id, EquipmentId = machineId },
            #endregion

            #region Traps & Stretches
            new WorkoutEquipment{ WorkoutId = backWorkouts[8].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[9].Id, EquipmentId = stretchesId },
            #endregion

            #region Traps & Plate
            new WorkoutEquipment{ WorkoutId = backWorkouts[10].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[11].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[12].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[13].Id, EquipmentId = plateId },
            #endregion

            #region Traps & Smith-Machine
            new WorkoutEquipment{ WorkoutId = backWorkouts[14].Id, EquipmentId = smithMachineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[15].Id, EquipmentId = smithMachineId },
            #endregion

            #region Traps & Dumbell
            new WorkoutEquipment{ WorkoutId = backWorkouts[16].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[17].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[18].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[19].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[20].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[21].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[22].Id, EquipmentId = dumbellId },
            #endregion

            #region Traps & Cables
            new WorkoutEquipment{ WorkoutId = backWorkouts[23].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[24].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[25].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[26].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[27].Id, EquipmentId = barbellId },
            #endregion

            #region Traps & TRX
            new WorkoutEquipment{ WorkoutId = backWorkouts[28].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[29].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[30].Id, EquipmentId = trxId },
            #endregion

            #region Traps & Vitruvian
            new WorkoutEquipment{ WorkoutId = backWorkouts[31].Id, EquipmentId = vitruvianId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[32].Id, EquipmentId = vitruvianId },
            #endregion

            #region Traps & Recovery
            new WorkoutEquipment{ WorkoutId = backWorkouts[33].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[34].Id, EquipmentId = cardioId },
            #endregion

            #region Traps & BodyWeight
            new WorkoutEquipment{ WorkoutId = backWorkouts[35].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[36].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[37].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[38].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[39].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[40].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[41].Id, EquipmentId = bodyweightId },
            #endregion

            #region Traps & Kettlebells
            new WorkoutEquipment{ WorkoutId = backWorkouts[42].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[43].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[44].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[45].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[46].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[47].Id, EquipmentId = kettlebellId },
            #endregion

            #region Traps & Band
            new WorkoutEquipment{ WorkoutId = backWorkouts[48].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[49].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[50].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[51].Id, EquipmentId = BandsId },
            #endregion

            #region Traps & Yoga
            new WorkoutEquipment{ WorkoutId = backWorkouts[52].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[53].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[54].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[55].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[56].Id, EquipmentId = yogaId },
            #endregion

            #region lower back & Barbell
            new WorkoutEquipment{ WorkoutId = backWorkouts[57].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[58].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[59].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[60].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[61].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[62].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[63].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[64].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[65].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[66].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[67].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[68].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[69].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[70].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[71].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[72].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[73].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[74].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[75].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[76].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[77].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[78].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[79].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[80].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[81].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[82].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[83].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[84].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[85].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[86].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[87].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[88].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[89].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[90].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[91].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[92].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[93].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[94].Id, EquipmentId = machineId },
            #endregion

            #region Lower Back & Stretches
            new WorkoutEquipment{ WorkoutId = backWorkouts[95].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[96].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[97].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[98].Id, EquipmentId = stretchesId },
            #endregion

            #region Lower Back & Plate
            new WorkoutEquipment{ WorkoutId = backWorkouts[99].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[100].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[101].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[102].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[103].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[104].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[105].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[106].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[107].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[108].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[109].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[110].Id, EquipmentId = plateId },
            #endregion

            new WorkoutEquipment{ WorkoutId = backWorkouts[111].Id, EquipmentId = bosuballId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[112].Id, EquipmentId = bosuballId },

            #region Lower Back & Smith machine
            new WorkoutEquipment{ WorkoutId = backWorkouts[113].Id, EquipmentId = smithMachineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[114].Id, EquipmentId = smithMachineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[115].Id, EquipmentId = smithMachineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[116].Id, EquipmentId = smithMachineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[117].Id, EquipmentId = smithMachineId },
            #endregion

            #region Lower Back & Dumbbell
            new WorkoutEquipment{ WorkoutId = backWorkouts[118].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[119].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[120].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[121].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[122].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[123].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[124].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[125].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[126].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[127].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[128].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[129].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[130].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[131].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[132].Id, EquipmentId = dumbellId },
            #endregion

            new WorkoutEquipment{ WorkoutId = backWorkouts[133].Id, EquipmentId = medicineId },

            #region Lower Back & Cables
            new WorkoutEquipment{ WorkoutId = backWorkouts[134].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[135].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[136].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[137].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[138].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[139].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[140].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[141].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[142].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[143].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[144].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[145].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[146].Id, EquipmentId = cableId },
            #endregion
            new WorkoutEquipment{ WorkoutId = backWorkouts[147].Id, EquipmentId = trxId },

            #region Lower Back & Vitruvian
            new WorkoutEquipment{ WorkoutId = backWorkouts[148].Id, EquipmentId = vitruvianId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[149].Id, EquipmentId = vitruvianId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[150].Id, EquipmentId = vitruvianId },
            #endregion

            #region Lower back & Recovery
            new WorkoutEquipment{ WorkoutId = backWorkouts[151].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[152].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[153].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[154].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[155].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[156].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[157].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[158].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[159].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[160].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[161].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[162].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[163].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[164].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[165].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[166].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[167].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[168].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[169].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[170].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[171].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[172].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[173].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[174].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[175].Id, EquipmentId = cardioId },
            #endregion

            #region lower back & Bodyweight
            new WorkoutEquipment{ WorkoutId = backWorkouts[176].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[177].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[178].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[179].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[180].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[181].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[182].Id, EquipmentId = bodyweightId },
            #endregion

            #region Lower back & Kettlebell
            new WorkoutEquipment{ WorkoutId = backWorkouts[183].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[184].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[185].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[186].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[187].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[188].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[189].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[190].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[191].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[192].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[193].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[194].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[195].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[196].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[197].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[198].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[199].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[200].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[201].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[202].Id, EquipmentId = kettlebellId },
            #endregion

            #region Lower back & Band
            new WorkoutEquipment{ WorkoutId = backWorkouts[203].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[204].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[205].Id, EquipmentId = BandsId },
            #endregion

            #region Lower Back & Yoga
            new WorkoutEquipment{ WorkoutId = backWorkouts[206].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[207].Id, EquipmentId = cableId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[208].Id, EquipmentId = cableId },
            #endregion

        };
        await context.WorkoutEquipment.AddRangeAsync(workoutEquipment);
        await context.SaveChangesAsync();
        // ***************************************************************** //
        var workoutLevel = new List<WorkoutLevel>();
        workoutLevel = new List<WorkoutLevel>
        {
            #region Traps & Barbell
            new WorkoutLevel{ WorkoutId = backWorkouts[0].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[1].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[2].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[3].Id , Level = Difficulty.Intermediate},
            #endregion

            #region Traps & Machine
            new WorkoutLevel{ WorkoutId = backWorkouts[4].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[5].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[6].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[7].Id , Level = Difficulty.Novice},
            #endregion

            #region Traps & Stretches
            new WorkoutLevel{ WorkoutId = backWorkouts[8].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = backWorkouts[9].Id , Level = Difficulty.Beginner},
            #endregion

            #region Traps & Plate
            new WorkoutLevel{ WorkoutId = backWorkouts[10].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[11].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = backWorkouts[12].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[13].Id , Level = Difficulty.Advanced},
            #endregion

            #region Traps & Smith-Machine
            new WorkoutLevel{ WorkoutId = backWorkouts[14].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = backWorkouts[15].Id , Level = Difficulty.Novice},
            #endregion

            #region Traps & Dumbell
            new WorkoutLevel{ WorkoutId = backWorkouts[16].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[17].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = backWorkouts[18].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = backWorkouts[19].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[20].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[21].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = backWorkouts[22].Id , Level = Difficulty.Intermediate},
            #endregion
            
            #region Traps & Cables
            new WorkoutLevel{ WorkoutId = backWorkouts[23].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[24].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[25].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[26].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[27].Id , Level = Difficulty.Advanced},
            #endregion

            #region Traps & TRX
            new WorkoutLevel{ WorkoutId = backWorkouts[28].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[29].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[30].Id , Level = Difficulty.Beginner },
            #endregion

            #region Traps & Vitruvian
            new WorkoutLevel{ WorkoutId = backWorkouts[31].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[32].Id , Level = Difficulty.Beginner },
            #endregion

            #region Traps & Recovery
            new WorkoutLevel{ WorkoutId = backWorkouts[33].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[34].Id , Level = Difficulty.Novice },
            #endregion

            #region Traps & BodyWeight
            new WorkoutLevel{ WorkoutId = backWorkouts[35].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[36].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[37].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[38].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[39].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[40].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[41].Id , Level = Difficulty.Intermediate },
            #endregion

            #region Traps & Kettlebells
            new WorkoutLevel{ WorkoutId = backWorkouts[42].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[43].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[44].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[45].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[46].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[47].Id , Level = Difficulty.Beginner },
            #endregion

            #region Traps & Band
            new WorkoutLevel{ WorkoutId = backWorkouts[48].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[49].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[50].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[51].Id , Level = Difficulty.Intermediate },
            #endregion

            #region Traps & Yoga
            new WorkoutLevel{ WorkoutId = backWorkouts[52].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[53].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[54].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[55].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[56].Id , Level = Difficulty.Beginner },
            #endregion

            #region lower back and barbell
            new WorkoutLevel{ WorkoutId = backWorkouts[57].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[58].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[59].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[60].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[61].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[62].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[63].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[64].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[65].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[66].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[67].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[68].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[69].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[70].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[71].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[72].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[73].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[74].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[75].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[76].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[77].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[78].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[79].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[80].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[81].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[82].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[83].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[84].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[85].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[86].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[87].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[88].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[89].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[90].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[91].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[92].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[93].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[94].Id , Level = Difficulty.Novice },
            #endregion

            #region Lower Back & Stretches
            new WorkoutLevel{ WorkoutId = backWorkouts[95].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[96].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[97].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[98].Id , Level = Difficulty.Beginner },
            #endregion

            #region Lower Back & Plate
            new WorkoutLevel{ WorkoutId = backWorkouts[99].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[100].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[101].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[102].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[103].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[104].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[105].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[106].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[107].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[108].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[109].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[110].Id , Level = Difficulty.Intermediate },
            #endregion

            new WorkoutLevel{ WorkoutId = backWorkouts[111].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[112].Id , Level = Difficulty.Beginner },

            #region Lower Back & Smith machine
            new WorkoutLevel{ WorkoutId = backWorkouts[113].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[114].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = backWorkouts[115].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[116].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[117].Id , Level = Difficulty.Beginner },
            #endregion

            #region Lower Back & Dumbbell
            new WorkoutLevel{ WorkoutId = backWorkouts[118].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[119].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[120].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[121].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[122].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[123].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[124].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[125].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[126].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[127].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[128].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[129].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[130].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[131].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[132].Id , Level = Difficulty.Intermediate },
            #endregion

            new WorkoutLevel{ WorkoutId = backWorkouts[133].Id , Level = Difficulty.Intermediate },
            
            #region Lower Back & Cables
            new WorkoutLevel{ WorkoutId = backWorkouts[134].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[135].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[136].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[137].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[138].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[139].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[140].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[141].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[142].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[143].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[144].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[145].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[146].Id , Level = Difficulty.Intermediate },
            #endregion
            new WorkoutLevel{ WorkoutId = backWorkouts[147].Id , Level = Difficulty.Advanced },

            #region Lower Back & Vitruvian
            new WorkoutLevel{ WorkoutId = backWorkouts[148].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[149].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[150].Id , Level = Difficulty.Intermediate },
            #endregion

            #region Lower back & Recovery
            new WorkoutLevel{ WorkoutId = backWorkouts[151].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[152].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[153].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[154].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[155].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[156].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[157].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[158].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[159].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[160].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[161].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[162].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[163].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[164].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[165].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[166].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[167].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[168].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[169].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[170].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[171].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[172].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[173].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[174].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[175].Id , Level = Difficulty.Beginner },
            #endregion

            #region lower back & Bodyweight
            new WorkoutLevel{ WorkoutId = backWorkouts[176].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[177].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[178].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[179].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[180].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[181].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[182].Id , Level = Difficulty.Novice },
            #endregion

            #region Lower back & Kettlebell
            new WorkoutLevel{ WorkoutId = backWorkouts[183].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[184].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[185].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[186].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[187].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[188].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[189].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[190].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[191].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[192].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[193].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[194].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[195].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[196].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[197].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[198].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[199].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[200].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[201].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[202].Id , Level = Difficulty.Intermediate },
            #endregion

            #region Lower back & Band
            new WorkoutLevel{ WorkoutId = backWorkouts[203].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[204].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[205].Id , Level = Difficulty.Novice },
            #endregion

            #region Lower Back & Yoga
            new WorkoutLevel{ WorkoutId = backWorkouts[206].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[207].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[208].Id , Level = Difficulty.Beginner },
            #endregion

        };
        await context.WorkoutLevels.AddRangeAsync(workoutLevel);
        await context.SaveChangesAsync();

        // ***************************************************************** //

        var bodyWorkouts = new List<BodyWorkout>();
        var backId = await context.Bodies.Where(z => z.Name == "Back").Select(z => z.Id).FirstOrDefaultAsync();
        var upperBackId = await context.Bodies.Where(z => z.Name == "Upper Back (Upper Traps)").Select(z => z.Id).FirstOrDefaultAsync();
        var trapsId = await context.Bodies.Where(z => z.Name == "Trapezius (Traps)").Select(z => z.Id).FirstOrDefaultAsync();
        var lowerBackId = await context.Bodies.Where(z => z.Name == "Lower Back (Lower Traps)").Select(z => z.Id).FirstOrDefaultAsync();

        bodyWorkouts = new List<BodyWorkout>
        {
            #region Traps & Barbell
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[0].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[1].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[1].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[2].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[2].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[3].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[3].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & Machine
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[4].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[5].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[6].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[7].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & Stretches
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[8].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[9].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & Plate
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[10].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[11].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[12].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[13].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Traps & Smith-Machine
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[14].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[15].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Traps & Dumbell
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[16].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[17].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[18].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[18].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[19].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[20].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[21].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[22].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Traps & Cables
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[23].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[24].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[25].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[26].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[27].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Traps & Medicine-Ball
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[28].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[29].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[30].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & Vitruvian
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[31].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[32].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & Recovery
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[33].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[34].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & BodyWeight
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[35].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[36].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[37].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[38].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[39].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[40].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[41].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Traps & Kettlebells
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[42].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[43].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[44].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[45].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[46].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[47].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & Band
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[48].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[49].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[50].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[51].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Traps & Yoga
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[52].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[53].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[54].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[55].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[56].Id, Target = PriorityTarget.Primary },
            #endregion

            #region lower back & Barbell
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[57].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[58].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[59].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[60].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[61].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[62].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[63].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[64].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[65].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[66].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[67].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[68].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[69].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[70].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[71].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[72].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[73].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[74].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[75].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[76].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[77].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[78].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[79].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[80].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[81].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[82].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[83].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[84].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[85].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[86].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[87].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[88].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[89].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[90].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[91].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[92].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[93].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[94].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Lower Back & Stretches
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[95].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[96].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[97].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[98].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Lower Back & Plate
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[99].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[100].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[101].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[102].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[103].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[104].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[105].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[106].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[107].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[108].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[109].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[110].Id, Target = PriorityTarget.Secondary },
            #endregion

            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[111].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[112].Id, Target = PriorityTarget.Primary },

            #region Lower Back & Smith machine
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[113].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[114].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[115].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[116].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[117].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Lower Back & Dumbbell
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[118].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[119].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[120].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[121].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[122].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[123].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[124].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[125].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[126].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[127].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[128].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[129].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[129].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[129].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[129].Id, Target = PriorityTarget.Secondary },
            #endregion

            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[133].Id, Target = PriorityTarget.Tertiary },

            #region Lower Back & Cables
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[134].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[135].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[136].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[137].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[138].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[139].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[140].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[141].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[142].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[143].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[144].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[145].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[146].Id, Target = PriorityTarget.Tertiary },
            #endregion

            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[147].Id, Target = PriorityTarget.Tertiary },

            #region Lower Back & Vitruvian
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[148].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[149].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[150].Id, Target = PriorityTarget.Tertiary },
            #endregion

            #region Lower back & Recovery
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[151].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[152].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[153].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[154].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[155].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[156].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[157].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[158].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[159].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[160].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[161].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[162].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[163].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[164].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[165].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[166].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[167].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[168].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[169].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[170].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[171].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[172].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[173].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[174].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[175].Id, Target = PriorityTarget.Primary },
            #endregion

            #region lower back & Bodyweight
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[176].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[177].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[178].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[179].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[180].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[181].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[182].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Lower back & Kettlebell
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[43].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[183].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[184].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[185].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[186].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[187].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[188].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[189].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[190].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[191].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[192].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[193].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[194].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[195].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[196].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[197].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[198].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[299].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[200].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[201].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[202].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Lower back & Band
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[203].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[204].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[205].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Lower Back & Yoga
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[206].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[207].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[208].Id, Target = PriorityTarget.Primary },
            #endregion

        };
        await context.BodyWorkouts.AddRangeAsync(bodyWorkouts);
        await context.SaveChangesAsync();
        // ***************************************************************** //
        var workoutSex = new List<WorkoutSex>();
        workoutSex = new List<WorkoutSex>
        {
            #region Traps & Barbell
            new WorkoutSex{ WorkoutId = backWorkouts[0].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[0].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[1].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[1].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[2].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[2].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[3].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[3].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[4].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[4].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[5].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[5].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[6].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[6].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[7].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[7].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[8].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[8].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[9].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[9].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[10].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[10].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[11].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[11].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[12].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[12].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[13].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[13].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[14].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[14].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[15].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[15].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[16].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[16].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[17].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[17].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[18].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[18].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[19].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[19].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[20].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[20].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[21].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[21].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[22].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[22].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[23].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[23].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[24].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[24].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[25].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[25].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[26].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[26].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[27].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[27].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[28].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[28].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[29].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[29].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[30].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[30].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[31].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[31].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[32].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[32].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[33].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[33].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[34].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[34].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[35].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[35].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[36].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[36].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[37].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[37].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[38].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[38].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[39].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[39].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[40].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[40].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[41].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[41].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[42].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[42].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[43].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[43].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[44].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[44].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[45].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[45].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[46].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[46].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[47].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[47].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[48].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[48].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[49].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[49].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[50].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[50].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[51].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[51].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[52].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[52].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[53].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[53].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[54].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[54].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[55].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[55].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[56].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[56].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[57].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[57].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[58].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[58].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[59].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[59].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[60].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[60].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[61].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[61].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[62].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[62].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[63].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[63].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[64].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[64].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[65].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[65].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[66].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[66].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[67].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[67].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[68].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[68].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[69].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[69].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[70].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[70].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[71].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[71].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[72].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[72].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[73].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[73].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[74].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[74].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[75].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[75].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[76].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[76].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[77].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[77].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[78].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[78].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[79].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[79].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[80].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[80].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[81].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[81].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[82].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[82].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[83].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[83].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[84].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[84].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[85].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[85].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[86].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[86].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[87].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[87].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[88].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[88].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[89].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[89].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[90].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[90].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[91].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[91].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[92].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[92].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[93].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[93].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[94].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[94].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[95].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[95].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[96].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[96].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[97].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[97].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[98].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[98].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[99].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[99].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[100].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[100].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[101].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[101].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[102].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[102].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[103].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[103].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[104].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[104].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[105].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[105].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[106].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[106].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[107].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[107].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[108].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[108].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[109].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[109].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[110].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[110].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[111].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[111].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[112].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[112].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[113].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[113].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[114].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[114].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[115].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[115].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[116].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[116].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[117].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[117].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[118].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[118].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[119].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[119].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[120].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[120].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[121].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[121].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[122].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[122].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[123].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[123].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[124].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[124].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[125].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[125].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[126].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[126].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[127].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[127].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[128].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[128].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[129].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[129].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[130].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[130].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[131].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[131].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[132].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[132].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[133].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[133].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[134].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[134].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[135].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[135].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[136].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[136].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[137].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[137].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[138].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[138].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[139].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[139].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[140].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[140].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[141].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[141].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[142].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[142].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[143].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[143].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[144].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[144].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[145].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[145].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[146].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[146].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[147].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[147].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[148].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[148].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[149].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[149].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[150].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[150].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[151].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[151].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[152].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[152].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[153].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[153].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[154].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[154].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[155].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[155].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[156].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[156].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[157].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[157].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[158].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[158].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[159].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[159].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[160].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[160].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[161].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[161].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[162].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[162].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[163].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[163].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[164].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[164].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[165].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[165].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[166].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[166].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[167].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[167].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[168].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[168].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[169].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[169].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[170].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[170].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[171].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[171].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[172].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[172].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[173].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[173].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[174].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[174].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[175].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[175].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[176].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[176].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[177].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[177].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[178].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[178].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[179].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[179].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[180].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[180].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[181].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[181].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[182].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[182].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[183].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[183].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[184].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[184].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[185].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[185].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[186].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[186].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[187].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[187].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[188].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[188].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[189].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[189].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[190].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[190].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[191].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[191].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[192].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[192].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[193].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[193].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[194].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[194].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[195].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[195].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[196].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[196].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[197].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[197].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[198].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[198].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[199].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[199].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[200].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[200].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[201].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[201].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[202].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[202].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[203].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[203].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[204].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[204].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[205].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[205].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[206].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[206].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[207].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[207].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[208].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[208].Id, Sex = Sex.Female},
            #endregion
        };
        //await context.WorkoutSex.AddRangeAsync(workoutSex);
        //await context.SaveChangesAsync();
    }
}
