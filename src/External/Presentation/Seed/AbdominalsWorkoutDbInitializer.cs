using System;
using System.Collections.Generic;

namespace Presentation.Seed;

public class AbdominalsWorkoutDbInitializer
{
    //private readonly FitnessContext _context;

    //public AbdominalsWorkoutDbInitializer(FitnessContext context)
    //{
    //    _context = context;
    //}

    // Abdominals // lower Abdominals // Upper Abdominals // Obliques
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
            new Workout{ Name = "TRX Ab Rollout", SportId = crossfitId, Description = "" },                                             // index => 53
            new Workout{ Name = "TRX Forearm Plank", SportId = crossfitId, Description = "" },                                          // index => 54
            new Workout{ Name = "TRX Hand Plank", SportId = crossfitId, Description = "" },                                             // index => 55
            new Workout{ Name = "TRX Kneeling Ab Rollout", SportId = crossfitId, Description = "" },                                    // index => 56
            new Workout{ Name = "TRX Knee Tuck", SportId = crossfitId, Description = "" },                                              // index => 57
            new Workout{ Name = "TRX Mountain Climber", SportId = bodybuildingId, Description = "" },                                   // index => 58
            new Workout{ Name = "TRX Pike", SportId = crossfitId, Description = "" },                                                   // index => 59

            // Abdominals // Vitruvian
            new Workout{ Name = "Vitruvian Crunch", SportId = bodybuildingId, Description = "" },                                       // index => 60

            // Abdominals // Recovery
            new Workout{ Name = "Core Stability 1 Crosslateral Limb Raise 4Pt Position", SportId = yogaSportId, Description = "" },     // index => 61
            new Workout{ Name = "Core Stability 2 Opposite Shoulder Tap 4Pt Position", SportId = yogaSportId, Description = "" },       // index => 62
            new Workout{ Name = "Core Stability 4 Crosslateral Limb Raise Push Up Position", SportId = yogaSportId, Description = "" }, // index => 63
            new Workout{ Name = "Core Stability 5 Crosslateral Limb Raise Into Knee Elbow Tuck Push Up Position", SportId = yogaSportId, Description = "" }, // index => 64
            new Workout{ Name = "Core Stability Regression Crosslateral Limb Raise Push Up Position", SportId = yogaSportId, Description = "" },             // index => 65
            new Workout{ Name = "Dead Bugs Cross Lateral", SportId = yogaSportId, Description = "" },                                   // index => 66
            new Workout{ Name = "Dead Bugs Same Side", SportId = yogaSportId, Description = "" },                                       // index => 67
            new Workout{ Name = "Leg Lowers", SportId = yogaSportId, Description = "" },                                                // index => 68
            new Workout{ Name = "Serratus Activation Active Plank", SportId = yogaSportId, Description = "" },                          // index => 69
            new Workout{ Name = "Bosu Serratus Activation Active Plank", SportId = yogaSportId, Description = "" },                     // index => 70
            
            // Abdominals // Bodyweight
            new Workout{ Name = "Crunches", SportId = crossfitId, Description = "" },                                                   // index => 71
            new Workout{ Name = "Laying Leg Raises", SportId = crossfitId, Description = "" },                                          // index => 72
            new Workout{ Name = "Forearm Plank", SportId = crossfitId, Description = "" },                                              // index => 73
            new Workout{ Name = "Hanging Knee Raises", SportId = crossfitId, Description = "" },                                        // index => 74
            new Workout{ Name = "Long Lever Plank", SportId = crossfitId, Description = "" },                                           // index => 75
            new Workout{ Name = "Hand Plank", SportId = crossfitId, Description = "" },                                                 // index => 76
            new Workout{ Name = "Hollow Hold", SportId = crossfitId, Description = "" },                                                // index => 77
            new Workout{ Name = "Mountain Climber", SportId = crossfitId, Description = "" },                                           // index => 78
            new Workout{ Name = "Bodyweight Russian Twist", SportId = crossfitId, Description = "" },                                   // index => 79
            new Workout{ Name = "Burpee", SportId = crossfitId, Description = "" },                                                     // index => 80
            new Workout{ Name = "Bicycle Crunch", SportId = crossfitId, Description = "" },                                             // index => 81
            new Workout{ Name = "Bird Dog", SportId = crossfitId, Description = "" },                                                   // index => 82
            new Workout{ Name = "Dead Bug", SportId = crossfitId, Description = "" },                                                   // index => 83
            new Workout{ Name = "Long Lever Forearm Plank", SportId = crossfitId, Description = "" },                                   // index => 84
            new Workout{ Name = "Reverse Crunch", SportId = crossfitId, Description = "" },                                             // index => 85
            new Workout{ Name = "Situp", SportId = crossfitId, Description = "" },                                                      // index => 86
            new Workout{ Name = "Bodyweight Knee Plank Up Down", SportId = crossfitId, Description = "" },                              // index => 87
            new Workout{ Name = "Bodyweight Plank Up Down", SportId = crossfitId, Description = "" },                                   // index => 88
            new Workout{ Name = "Plank Saw", SportId = crossfitId, Description = "" },                                                  // index => 89
            new Workout{ Name = "Alternating Bent Leg Raise", SportId = crossfitId, Description = "" },                                 // index => 90
            new Workout{ Name = "Alternating Heel Touch", SportId = crossfitId, Description = "" },                                     // index => 91
            new Workout{ Name = "Laying Alternating Leg Raise", SportId = crossfitId, Description = "" },                               // index => 92
            new Workout{ Name = "Laying Bent Leg Raise", SportId = crossfitId, Description = "" },                                      // index => 93
            new Workout{ Name = "Bodyweight Hanging Knee Tuck", SportId = crossfitId, Description = "" },                               // index => 94
            new Workout{ Name = "Bodyweight Hanging L Sit", SportId = crossfitId, Description = "" },                                   // index => 95
            new Workout{ Name = "Eccentric Dragonflag", SportId = crossfitId, Description = "" },                                       // index => 96
            new Workout{ Name = "Elbow Plank Mountain Climber", SportId = crossfitId, Description = "" },                               // index => 97
            new Workout{ Name = "Frog Crunch", SportId = crossfitId, Description = "" },                                                // index => 98
            new Workout{ Name = "Frog Sit Up", SportId = crossfitId, Description = "" },                                                // index => 99
            new Workout{ Name = "Jumping Mountain Climber", SportId = crossfitId, Description = "" },                                   // index => 100
            new Workout{ Name = "Reach And Catch", SportId = crossfitId, Description = "" },                                            // index => 101
            new Workout{ Name = "Switch Jump Mountain Climber", SportId = crossfitId, Description = "" },                               // index => 102
            new Workout{ Name = "Slow Tempo Mountain Climber", SportId = crossfitId, Description = "" },                                // index => 103
            new Workout{ Name = "Slalom Mountain Climber", SportId = crossfitId, Description = "" },                                    // index => 104
            new Workout{ Name = "Sideways Scissor Kick", SportId = crossfitId, Description = "" },                                      // index => 105
            new Workout{ Name = "Scissor Kick", SportId = crossfitId, Description = "" },                                               // index => 106
            new Workout{ Name = "Ring Standing Roll Out", SportId = crossfitId, Description = "" },                                     // index => 107
            new Workout{ Name = "Reverse Crunch Kick Up", SportId = crossfitId, Description = "" },                                     // index => 108
            new Workout{ Name = "Bodyweight Plank Arm Lift", SportId = crossfitId, Description = "" },                                  // index => 109
            new Workout{ Name = "Bodyweight Plank Jack", SportId = crossfitId, Description = "" },                                      // index => 110
            new Workout{ Name = "Hanging L Sit", SportId = crossfitId, Description = "" },                                              // index => 111
            new Workout{ Name = "Bodyweight Stability Ball Crunch", SportId = crossfitId, Description = "" },                           // index => 112
            new Workout{ Name = "Stability Ball Atomic Push Up", SportId = crossfitId, Description = "" },                              // index => 113
            new Workout{ Name = "Stability Ball Knee Tuck", SportId = crossfitId, Description = "" },                                   // index => 114
            new Workout{ Name = "Stability Ball Pike", SportId = crossfitId, Description = "" },                                        // index => 115
            new Workout{ Name = "Stability Ball Stir The Pot", SportId = crossfitId, Description = "" },                                // index => 116
            new Workout{ Name = "Stability Ball V Up Pass", SportId = crossfitId, Description = "" },                                   // index => 117
            new Workout{ Name = "Stability Ball Windshield Wiper", SportId = crossfitId, Description = "" },                            // index => 118

            // Abdominals // Kettlebells
            new Workout{ Name = "Kettlebell Situp", SportId = bodybuildingId, Description = "" },                                       // index => 119
            new Workout{ Name = "Kettlebell Russian Twist", SportId = bodybuildingId, Description = "" },                               // index => 120
            new Workout{ Name = "Kettlebell Windmill", SportId = bodybuildingId, Description = "" },                                    // index => 121
            new Workout{ Name = "Kettlebell Front Rack Curtsy Lunge (Double)", SportId = bodybuildingId, Description = "" },            // index => 122
            new Workout{ Name = "Kettlebell Hollow Hold", SportId = bodybuildingId, Description = "" },                                 // index => 123
            new Workout{ Name = "Kettlebell Windmill Bottom Hand", SportId = bodybuildingId, Description = "" },                        // index => 124
            new Workout{ Name = "Kettlebell Front Rack Forward Lunge (Double)", SportId = bodybuildingId, Description = "" },           // index => 125
            new Workout{ Name = "Kettlebell Front Rack Lateral Lunge (Double)", SportId = bodybuildingId, Description = "" },           // index => 126
            new Workout{ Name = "Kettlebell Front Rack Reverse Lunge (Double)", SportId = bodybuildingId, Description = "" },           // index => 127
            new Workout{ Name = "Kettlebell Front Rack Single Arm Lateral Lunge", SportId = bodybuildingId, Description = "" },         // index => 128
            new Workout{ Name = "Kettlebell Front Rack Squat", SportId = bodybuildingId, Description = "" },                            // index => 129
            new Workout{ Name = "Kettlebell Front Rack Step Up", SportId = bodybuildingId, Description = "" },                          // index => 130
            new Workout{ Name = "Kettlebell Single Arm Front Rack Forward Lunge", SportId = bodybuildingId, Description = "" },         // index => 131
            new Workout{ Name = "Kettlebell Single Arm Front Rack Step Up", SportId = bodybuildingId, Description = "" },               // index => 132

            // Abdominals // Band
            new Workout{ Name = "Band Crunch", SportId = bodybuildingId, Description = "" },                                            // index => 133

            // Abdominals // Yoga
            new Workout{ Name = "Urdhva Dhanurasana Wheel Pose", SportId = yogaSportId, Description = "" },                             // index => 134
            new Workout{ Name = "Cobra Pose", SportId = yogaSportId, Description = "" },                                                // index => 135

            // Abdominals // Cardio
            new Workout{ Name = "Toe Tap", SportId = cardioSportId, Description = "" },                                                 // index => 136
            new Workout{ Name = "Cardio Forward Scissor", SportId = cardioSportId, Description = "" },                                  // index => 137
            new Workout{ Name = "Cardio In And Out Forward", SportId = cardioSportId, Description = "" },                               // index => 138
            new Workout{ Name = "Cardio Ski Erg", SportId = cardioSportId, Description = "" },                                          // index => 139

            // Lower Abdominals // Recovery
            new Workout{ Name = "Bench Lift Off Active", SportId = cardioSportId, Description = "" },                                   // index => 140
            new Workout{ Name = "Bench Lift Off Static", SportId = cardioSportId, Description = "" },                                   // index => 141
            new Workout{ Name = "Leg Lowers", SportId = cardioSportId, Description = "" },                                              // index => 142

            // Obliques // Barbell
            new Workout{ Name = "Barbell Landmine Side Bend", SportId = cardioSportId, Description = "" },                              // index => 143
            new Workout{ Name = "Barbell Suitcase Deadlift", SportId = cardioSportId, Description = "" },                               // index => 144
            new Workout{ Name = "Landmine Alternating Lunge And Twist", SportId = cardioSportId, Description = "" },                    // index => 145
            new Workout{ Name = "Landmine Kneeling Twist", SportId = cardioSportId, Description = "" },                                 // index => 146
            new Workout{ Name = "Landmine Oblique Twist", SportId = cardioSportId, Description = "" },                                  // index => 147
            new Workout{ Name = "Landmine Russian Twist", SportId = cardioSportId, Description = "" },                                  // index => 148
            new Workout{ Name = "Landmine Stationary Twist", SportId = cardioSportId, Description = "" },                               // index => 149
            new Workout{ Name = "Landmine Rotational Lift To Press", SportId = cardioSportId, Description = "" },                       // index => 150
            new Workout{ Name = "Barbell Suitcase Carry", SportId = cardioSportId, Description = "" },                                  // index => 151

            // Obliques // Plate
            new Workout{ Name = "Plate Reverse Lunge Twist", SportId = cardioSportId, Description = "" },                               // index => 152
            new Workout{ Name = "Plate Pinch Grip Side Bend", SportId = cardioSportId, Description = "" },                              // index => 153
            new Workout{ Name = "Plate Standing Twist", SportId = cardioSportId, Description = "" },                                    // index => 154
            new Workout{ Name = "Plate Wood Chopper", SportId = cardioSportId, Description = "" },                                      // index => 155

            // Obliques // Bosu-Ball
            new Workout{ Name = "Bosu Ball Forearm Sideplank", SportId = cardioSportId, Description = "" },                             // index => 156
            new Workout{ Name = "Bosu Ball Hand Sideplank", SportId = cardioSportId, Description = "" },                                // index => 157
            new Workout{ Name = "Bosu Ball Hand Sideplank Hip Abduction", SportId = cardioSportId, Description = "" },                  // index => 158
            new Workout{ Name = "Bosu Ball Wood Chopper", SportId = cardioSportId, Description = "" },                                  // index => 159

            // Obliques // Smith Machine
            new Workout{ Name = "Smith Machine Oblique Crunch", SportId = cardioSportId, Description = "" },                            // index => 160
            new Workout{ Name = "Smith Machine Side Plank Up Down", SportId = cardioSportId, Description = "" },                        // index => 161
            new Workout{ Name = "Smith Machine Side Bend", SportId = cardioSportId, Description = "" },                                 // index => 162

            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 163
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 164
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 165
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 166
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 167
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 168
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 169
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 170
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 171
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 172
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 173
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 174
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 175
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 176
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 177
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 178
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 179
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 180
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 181
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 182
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 183
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 184
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 185
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 186
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 187
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 188
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 189
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 190
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 191
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 192
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 193
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 194
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 195
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 196
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 197
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 198
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 199
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 200
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 201
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 202
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 203
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 204
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 205
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 206
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 207
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 208
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 209
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 210
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 211
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 212
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 213
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 214
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 215
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 216
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 217
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 218
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 219
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 220
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 221
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 222
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 223
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 224
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 225
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 226
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 227
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 228
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 229
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 230
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 231
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 232
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 233
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 234
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 235
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 236
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 237
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 238
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 239
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 240
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 241
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 242
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 243
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 244
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 245
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 246
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 247
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 248
            new Workout{ Name = "", SportId = cardioSportId, Description = "" },                                              // index => 249
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
            
            #region Abdominals && Vitruvian
            new WorkoutInstruction{ WorkoutId = Workouts[60].Id , Step = 1 , Instruction = "Hold the rope attachment and lay flat."},
            new WorkoutInstruction{ WorkoutId = Workouts[60].Id , Step = 2 , Instruction = "Flex your spine and curl your upper back off the ground."},
            #endregion

            #region Abdominals && Recovery
            new WorkoutInstruction{ WorkoutId = Workouts[61].Id , Step = 1 , Instruction = "Bring yourself to the 4 point position (on all fours)"},
            new WorkoutInstruction{ WorkoutId = Workouts[61].Id , Step = 2 , Instruction = "90° angles at hips and shoulder and neutral spine"},
            new WorkoutInstruction{ WorkoutId = Workouts[61].Id , Step = 3 , Instruction = "Raise opposite limbs till they are parallel to the ground"},
            new WorkoutInstruction{ WorkoutId = Workouts[61].Id , Step = 4 , Instruction = "Hold for a split second and bring back to starting position"},

            new WorkoutInstruction{ WorkoutId = Workouts[62].Id , Step = 1 , Instruction = "Bring yourself to the 4 point position (on all fours). 90° angles at hips and shoulder and neutral spine."},
            new WorkoutInstruction{ WorkoutId = Workouts[62].Id , Step = 2 , Instruction = "Lift your knees slightly off the ground supporting your weight on palms and toes."},
            new WorkoutInstruction{ WorkoutId = Workouts[62].Id , Step = 3 , Instruction = "Maintain a toe placement roughly at shoulder width (the wider the leg stance the easier the exercise - the narrower the stance the more difficult it becomes."},
            new WorkoutInstruction{ WorkoutId = Workouts[62].Id , Step = 4 , Instruction = "Tap your opposite shoulder with your fingertips."},

            new WorkoutInstruction{ WorkoutId = Workouts[63].Id , Step = 1 , Instruction = "Bring yourself to a strict push-up position"},
            new WorkoutInstruction{ WorkoutId = Workouts[63].Id , Step = 2 , Instruction = "Maintain a toe placement roughly at shoulder width (the wider the leg stance the easier the exercise - the narrower the stance the more difficult it becomes."},
            new WorkoutInstruction{ WorkoutId = Workouts[63].Id , Step = 3 , Instruction = "Tap your opposite shoulder with your fingertips."},
            new WorkoutInstruction{ WorkoutId = Workouts[63].Id , Step = 4 , Instruction = "Do not tilt or shift your hips. Do not round or arch your back."},

            new WorkoutInstruction{ WorkoutId = Workouts[64].Id , Step = 1 , Instruction = "Bring yourself to a strict push-up position"},
            new WorkoutInstruction{ WorkoutId = Workouts[64].Id , Step = 2 , Instruction = "Raise opposite limbs till they are parallel to the ground"},
            new WorkoutInstruction{ WorkoutId = Workouts[64].Id , Step = 3 , Instruction = "Hold for a split second and then try to bring your elbow to your opposite knee by driving both towards the centre of the body."},
            new WorkoutInstruction{ WorkoutId = Workouts[64].Id , Step = 4 , Instruction = "Spine might curve slightly but you should not shift your hips during the movement."},

            new WorkoutInstruction{ WorkoutId = Workouts[65].Id , Step = 1 , Instruction = "Bring yourself to a strict push-up position"},
            new WorkoutInstruction{ WorkoutId = Workouts[65].Id , Step = 2 , Instruction = "Tap the hand of the working arm on the ground to find your balance. Raise opposite limbs till they are parallel to the ground"},
            new WorkoutInstruction{ WorkoutId = Workouts[65].Id , Step = 3 , Instruction = "Hold for a split second and then try to bring your elbow to your opposite knee by driving both towards the centre of the body."},
            new WorkoutInstruction{ WorkoutId = Workouts[65].Id , Step = 4 , Instruction = "Spine might curve slightly but you should not shift your hips during the movement."},

            new WorkoutInstruction{ WorkoutId = Workouts[66].Id , Step = 1 , Instruction = "Lay on your back. Extend your straight arms above the chest and raise your bent knees till they are over your hips."},
            new WorkoutInstruction{ WorkoutId = Workouts[66].Id , Step = 2 , Instruction = "Lower opposite limbs towards the ground. You can feel the ground but do not rest on or tap off of the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[66].Id , Step = 3 , Instruction = "Maintain a flat lower back throughout the movement (lower back should be in contact with the ground)."},

            new WorkoutInstruction{ WorkoutId = Workouts[67].Id , Step = 1 , Instruction = "Lay on your back. Extend your straight arms above the chest and raise your bent knees till they are over your hips."},
            new WorkoutInstruction{ WorkoutId = Workouts[67].Id , Step = 2 , Instruction = "Lower limbs of the same side towards the ground. You can feel the ground but do not rest on or tap off of the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[67].Id , Step = 3 , Instruction = "Maintain a flat lower back throughout the movement (lower back should be in contact with the ground)."},

            new WorkoutInstruction{ WorkoutId = Workouts[68].Id , Step = 1 , Instruction = "Lie on your back. Raise your legs but bend your knees"},
            new WorkoutInstruction{ WorkoutId = Workouts[68].Id , Step = 2 , Instruction = "Keep a 90° angle at hips and knees. Lower your toes to the ground without bending your knees"},
            new WorkoutInstruction{ WorkoutId = Workouts[68].Id , Step = 3 , Instruction = "Make sure you maintain a flat lower back against the ground throughout the movement."},

            new WorkoutInstruction{ WorkoutId = Workouts[69].Id , Step = 1 , Instruction = "Support your weight on your forearms and toes (plank)."},
            new WorkoutInstruction{ WorkoutId = Workouts[69].Id , Step = 2 , Instruction = "Allow your upper back to sink in between the shoulder blades."},
            new WorkoutInstruction{ WorkoutId = Workouts[69].Id , Step = 3 , Instruction = "Push your elbows into the ground and slightly forward, and move the shoulder blades away from the spine."},

            new WorkoutInstruction{ WorkoutId = Workouts[70].Id , Step = 1 , Instruction = "Support your weight on your forearms and toes (plank)."},
            new WorkoutInstruction{ WorkoutId = Workouts[70].Id , Step = 2 , Instruction = "Allow your upper back to sink in between the shoulder blades."},
            new WorkoutInstruction{ WorkoutId = Workouts[70].Id , Step = 3 , Instruction = "Push your elbows into the ground and slightly forward, and move the shoulder blades away from the spine."},
            #endregion

            #region Abdominals && Bodyweight
            new WorkoutInstruction{ WorkoutId = Workouts[71].Id , Step = 1 , Instruction = "Lay flat on your back with your knees bent and your feet flat on the ground, about a foot from your lower back."},
            new WorkoutInstruction{ WorkoutId = Workouts[71].Id , Step = 2 , Instruction = "Place your fingertips on your temples with your palms facing out."},
            new WorkoutInstruction{ WorkoutId = Workouts[71].Id , Step = 3 , Instruction = "Draw your belly into the base of your spine to engage the muscles, then raise your head and shoulders off the floor. Return to starting position and repeat."},

            new WorkoutInstruction{ WorkoutId = Workouts[72].Id , Step = 1 , Instruction = "Lay on your back with your arms palms down on either side."},
            new WorkoutInstruction{ WorkoutId = Workouts[72].Id , Step = 2 , Instruction = "Keep your legs together and as straight as possible.s"},
            new WorkoutInstruction{ WorkoutId = Workouts[72].Id , Step = 3 , Instruction = "Slowly raise your legs to a 90° angle, pause at this position, or as high as you can reach your legs, and then slowly lower your legs back down."},
            new WorkoutInstruction{ WorkoutId = Workouts[72].Id , Step = 4 , Instruction = "Duration of these movements should be slow so that you do not utilize momentum, enabling you to get the most out of the exercise."},

            new WorkoutInstruction{ WorkoutId = Workouts[73].Id , Step = 1 , Instruction = "Place forearms on the ground with your elbows bent at a 90° angle aligned beneath your shoulders, with your arms parallel at shoulder-width."},
            new WorkoutInstruction{ WorkoutId = Workouts[73].Id , Step = 2 , Instruction = "Your feet should be together, with only your toes touching the floor."},
            new WorkoutInstruction{ WorkoutId = Workouts[73].Id , Step = 3 , Instruction = "Lift your belly off the floor and form a straight line from your heels to the crown of your head and hold."},

            new WorkoutInstruction{ WorkoutId = Workouts[74].Id , Step = 1 , Instruction = "Grab the bar and hang, your body still and your legs straight."},
            new WorkoutInstruction{ WorkoutId = Workouts[74].Id , Step = 2 , Instruction = "Slowly draw your knees up to your chest"},
            new WorkoutInstruction{ WorkoutId = Workouts[74].Id , Step = 3 , Instruction = "Once you have raised your knees as high as possible, lower your legs and repeat. Duration of these movements should be slow so that you do not utilize momentum, enabling you to get the most out of the exercise."},
            new WorkoutInstruction{ WorkoutId = Workouts[74].Id , Step = 4 , Instruction = "Duration of these movements should be slow so that you do not utilize momentum, enabling you to get the most out of the exercise."},

            new WorkoutInstruction{ WorkoutId = Workouts[75].Id , Step = 1 , Instruction = "Start in a hand plank position and walk your hands further out until your ears are between your biceps."},
            new WorkoutInstruction{ WorkoutId = Workouts[75].Id , Step = 2 , Instruction = "Hold in this position for the allotted amount of time."},
            new WorkoutInstruction{ WorkoutId = Workouts[75].Id , Step = 3 , Instruction = "Make sure you keep a flat back for the whole set."},

            new WorkoutInstruction{ WorkoutId = Workouts[76].Id , Step = 1 , Instruction = "Start in a kneeling position with your hands planted on the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[76].Id , Step = 2 , Instruction = "Pick your knees up off the ground. Hold in this position with a flat back."},

            new WorkoutInstruction{ WorkoutId = Workouts[77].Id , Step = 1 , Instruction = "Lay flat on the ground with your arms extended over head."},
            new WorkoutInstruction{ WorkoutId = Workouts[77].Id , Step = 2 , Instruction = "Pick your upper back and your legs off the ground. Your body should be in a banana shape."},
            new WorkoutInstruction{ WorkoutId = Workouts[77].Id , Step = 3 , Instruction = "Hold in this position."},

            new WorkoutInstruction{ WorkoutId = Workouts[78].Id , Step = 1 , Instruction = "To perform a bodyweight mountain climber, start in a plank position with your hands placed directly under your shoulders."},
            new WorkoutInstruction{ WorkoutId = Workouts[78].Id , Step = 2 , Instruction = "Bring your right knee towards your chest, keeping your foot close to your hand. Quickly switch legs, bringing your left knee towards your chest."},
            new WorkoutInstruction{ WorkoutId = Workouts[78].Id , Step = 3 , Instruction = "Continue this movement, alternating legs, at a quick pace for a set amount of time or repetitions."},

            new WorkoutInstruction{ WorkoutId = Workouts[79].Id , Step = 1 , Instruction = "Hover your heels just off the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[79].Id , Step = 2 , Instruction = "Stick your chest out and maintain a flat back. Make all the movement happen at your mid and upper spine."},
            new WorkoutInstruction{ WorkoutId = Workouts[79].Id , Step = 3 , Instruction = "Point your chest to the left, then rotate at the spine until your chest is pointed right."},

            new WorkoutInstruction{ WorkoutId = Workouts[80].Id , Step = 1 , Instruction = "Start standing with your feet hip-width apart. Lower your body into a squat position, placing your hands on the ground in front of you."},
            new WorkoutInstruction{ WorkoutId = Workouts[80].Id , Step = 2 , Instruction = "Quickly jump your feet back into a plank position, keeping your body in a straight line from your head to your toes."},
            new WorkoutInstruction{ WorkoutId = Workouts[80].Id , Step = 3 , Instruction = "Perform a push-up, keeping your core tight and your elbows close to your body."},
            new WorkoutInstruction{ WorkoutId = Workouts[80].Id , Step = 4 , Instruction = "Jump your feet back towards your hands, and then jump up into the air, reaching your arms overhead."},
            new WorkoutInstruction{ WorkoutId = Workouts[80].Id , Step = 5 , Instruction = "Land softly and immediately lower your body back into the squat position to repeat the movement."},

            new WorkoutInstruction{ WorkoutId = Workouts[81].Id , Step = 1 , Instruction = "Lie on your back."},
            new WorkoutInstruction{ WorkoutId = Workouts[81].Id , Step = 2 , Instruction = "Bend knees, hands behind head."},
            new WorkoutInstruction{ WorkoutId = Workouts[81].Id , Step = 3 , Instruction = "Twist torso, touch elbow to opposite knee. Repeat."},

            new WorkoutInstruction{ WorkoutId = Workouts[82].Id , Step = 1 , Instruction = "Start on hands and knees."},
            new WorkoutInstruction{ WorkoutId = Workouts[82].Id , Step = 2 , Instruction = "Extend right arm and left leg."},
            new WorkoutInstruction{ WorkoutId = Workouts[82].Id , Step = 3 , Instruction = "Hold for a few seconds, then switch sides."},

            new WorkoutInstruction{ WorkoutId = Workouts[83].Id , Step = 1 , Instruction = "Lie on your back, arms extended upward, legs raised with knees bent."},
            new WorkoutInstruction{ WorkoutId = Workouts[83].Id , Step = 2 , Instruction = "Lower opposite arm and leg to floor, keeping back pressed against ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[83].Id , Step = 3 , Instruction = "Alternate sides, maintain core engagement, and repeat for desired reps or time."},

            new WorkoutInstruction{ WorkoutId = Workouts[84].Id , Step = 1 , Instruction = "Start in a hand plank position and walk your elbows further out until your ears are between your biceps."},
            new WorkoutInstruction{ WorkoutId = Workouts[84].Id , Step = 2 , Instruction = "Hold in this position for the allotted amount of time."},
            new WorkoutInstruction{ WorkoutId = Workouts[84].Id , Step = 3 , Instruction = "Make sure you keep a flat back for the whole set."},

            new WorkoutInstruction{ WorkoutId = Workouts[85].Id , Step = 1 , Instruction = "Sit in a v position."},
            new WorkoutInstruction{ WorkoutId = Workouts[85].Id , Step = 2 , Instruction = "Pull legs and torso together."},
            new WorkoutInstruction{ WorkoutId = Workouts[85].Id , Step = 3 , Instruction = "Extend back into the starting position."},

            new WorkoutInstruction{ WorkoutId = Workouts[86].Id , Step = 1 , Instruction = "Lie flat, knees bent."},
            new WorkoutInstruction{ WorkoutId = Workouts[86].Id , Step = 2 , Instruction = "Lift upper body."},
            new WorkoutInstruction{ WorkoutId = Workouts[86].Id , Step = 3 , Instruction = "Lower back down"},

            new WorkoutInstruction{ WorkoutId = Workouts[87].Id , Step = 1 , Instruction = "Start from a kneeling plank position."},
            new WorkoutInstruction{ WorkoutId = Workouts[87].Id , Step = 2 , Instruction = "Go to one elbow then the other. Try to avoid rocking back and forth."},

            new WorkoutInstruction{ WorkoutId = Workouts[88].Id , Step = 1 , Instruction = "Start from a plank position."},
            new WorkoutInstruction{ WorkoutId = Workouts[88].Id , Step = 2 , Instruction = "Go to one elbow then the other. Try to avoid rocking back and forth."},

            new WorkoutInstruction{ WorkoutId = Workouts[89].Id , Step = 1 , Instruction = "Support your weight on forearms and toes."},
            new WorkoutInstruction{ WorkoutId = Workouts[89].Id , Step = 2 , Instruction = "Ensure you maintain a neutral lower back (do not poke the bum into the air)."},
            new WorkoutInstruction{ WorkoutId = Workouts[89].Id , Step = 3 , Instruction = "Point your toes to push your bodyweight forward then drive the elbows into the ground to push your bodyweight back."},

            new WorkoutInstruction{ WorkoutId = Workouts[90].Id , Step = 1 , Instruction = "Lie on your back, legs bent and lifted off the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[90].Id , Step = 2 , Instruction = "Lower one leg to the ground until your foot taps the ground, keep your other leg up."},
            new WorkoutInstruction{ WorkoutId = Workouts[90].Id , Step = 3 , Instruction = "Alternate sides for the prescribed amount of reps."},

            new WorkoutInstruction{ WorkoutId = Workouts[91].Id , Step = 1 , Instruction = "Lie on your back, knees bent, feet flat."},
            new WorkoutInstruction{ WorkoutId = Workouts[91].Id , Step = 2 , Instruction = "Reach right hand to right heel."},
            new WorkoutInstruction{ WorkoutId = Workouts[91].Id , Step = 3 , Instruction = "Switch sides, left hand to left heel. Repeat."},

            new WorkoutInstruction{ WorkoutId = Workouts[92].Id , Step = 1 , Instruction = "Lie on your back, arms by sides, legs straight."},
            new WorkoutInstruction{ WorkoutId = Workouts[92].Id , Step = 2 , Instruction = "Lift one leg to a 45-degree angle."},
            new WorkoutInstruction{ WorkoutId = Workouts[92].Id , Step = 3 , Instruction = "Lower leg, lift opposite leg; alternate smoothly."},

            new WorkoutInstruction{ WorkoutId = Workouts[93].Id , Step = 1 , Instruction = "Lie on your back, knees bent, feet flat on the floor."},
            new WorkoutInstruction{ WorkoutId = Workouts[93].Id , Step = 2 , Instruction = "Raise both knees towards your chest."},
            new WorkoutInstruction{ WorkoutId = Workouts[93].Id , Step = 3 , Instruction = "Lower back down without touching the floor; repeat for desired reps."},

            new WorkoutInstruction{ WorkoutId = Workouts[94].Id , Step = 1 , Instruction = "Grip bar, hang with arms extended, body straight."},
            new WorkoutInstruction{ WorkoutId = Workouts[94].Id , Step = 2 , Instruction = "Engage core, lift knees towards chest."},
            new WorkoutInstruction{ WorkoutId = Workouts[94].Id , Step = 3 , Instruction = "Lower legs back down, maintain controlled movement."},
            
            new WorkoutInstruction{ WorkoutId = Workouts[95].Id , Step = 1 , Instruction = "Grip bar, hang with arms extended, body straight."},
            new WorkoutInstruction{ WorkoutId = Workouts[95].Id , Step = 2 , Instruction = "Engage core, lift knees towards chest."},
            new WorkoutInstruction{ WorkoutId = Workouts[95].Id , Step = 3 , Instruction = "Hold that position for the specified amount of time."},

            new WorkoutInstruction{ WorkoutId = Workouts[96].Id , Step = 1 , Instruction = "Perform a reverse crunch and then kick your legs up toward the ceiling."},
            new WorkoutInstruction{ WorkoutId = Workouts[96].Id , Step = 2 , Instruction = "With your hips and knees extended, lower yourself slowly back to the start position."},

            new WorkoutInstruction{ WorkoutId = Workouts[97].Id , Step = 1 , Instruction = "Begin in an elbow plank position with your core engaged."},
            new WorkoutInstruction{ WorkoutId = Workouts[97].Id , Step = 2 , Instruction = "Bring your right knee towards your right elbow."},
            new WorkoutInstruction{ WorkoutId = Workouts[97].Id , Step = 3 , Instruction = "Return to plank, then switch legs quickly. Repeat."},

            new WorkoutInstruction{ WorkoutId = Workouts[98].Id , Step = 1 , Instruction = "Lie on your back, knees bent, hands behind head."},
            new WorkoutInstruction{ WorkoutId = Workouts[98].Id , Step = 2 , Instruction = "Crunch up, flexing the spine and your abs."},

            new WorkoutInstruction{ WorkoutId = Workouts[99].Id , Step = 1 , Instruction = "Lay on your back with knees bent and your feet together."},
            new WorkoutInstruction{ WorkoutId = Workouts[99].Id , Step = 2 , Instruction = "Keep your arms extended overhead. Swing your arms to generate some momentum and sit up."},

            new WorkoutInstruction{ WorkoutId = Workouts[100].Id , Step = 1 , Instruction = "Begin in a plank position, hands under shoulders, feet together."},
            new WorkoutInstruction{ WorkoutId = Workouts[100].Id , Step = 2 , Instruction = "Jump feet forward, landing outside hands in a low squat."},
            new WorkoutInstruction{ WorkoutId = Workouts[100].Id , Step = 3 , Instruction = "Explode back to plank, repeat continuously for desired reps."},

            new WorkoutInstruction{ WorkoutId = Workouts[101].Id , Step = 1 , Instruction = "Lay flat on your back with both hands over one leg."},
            new WorkoutInstruction{ WorkoutId = Workouts[101].Id , Step = 2 , Instruction = "Reach toward your knee flexing your abs and obliques."},
            new WorkoutInstruction{ WorkoutId = Workouts[101].Id , Step = 3 , Instruction = "Do the prescribed amount of reps, then switch sides."},

            new WorkoutInstruction{ WorkoutId = Workouts[102].Id , Step = 1 , Instruction = "Start in a plank position with hands under shoulders."},
            new WorkoutInstruction{ WorkoutId = Workouts[102].Id , Step = 2 , Instruction = "Jump one foot forward, switch legs mid-air."},
            new WorkoutInstruction{ WorkoutId = Workouts[102].Id , Step = 3 , Instruction = "Alternate legs quickly, maintaining a steady plank."},

            new WorkoutInstruction{ WorkoutId = Workouts[103].Id , Step = 1 , Instruction = "To perform a bodyweight mountain climber, start in a plank position with your hands placed directly under your shoulders."},
            new WorkoutInstruction{ WorkoutId = Workouts[103].Id , Step = 2 , Instruction = "Bring your right knee towards your chest, keeping your foot close to your hand. Quickly switch legs, bringing your left knee towards your chest."},
            new WorkoutInstruction{ WorkoutId = Workouts[103].Id , Step = 3 , Instruction = "Continue this movement, alternating legs, at a slow pace for a set amount of time or repetitions."},

            new WorkoutInstruction{ WorkoutId = Workouts[104].Id , Step = 1 , Instruction = "Start in a plank position with hands directly under shoulders."},
            new WorkoutInstruction{ WorkoutId = Workouts[104].Id , Step = 2 , Instruction = "Drive knees toward left elbow."},
            new WorkoutInstruction{ WorkoutId = Workouts[104].Id , Step = 3 , Instruction = "Go back to starting position, then drive knees to right elbow, mimicking a zigzag slalom motion."},

            new WorkoutInstruction{ WorkoutId = Workouts[105].Id , Step = 1 , Instruction = "Lift both legs off the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[105].Id , Step = 2 , Instruction = "Bring both legs outward, then cross both legs over one another."},
            new WorkoutInstruction{ WorkoutId = Workouts[105].Id , Step = 3 , Instruction = "Alternating which leg goes on top."},

            new WorkoutInstruction{ WorkoutId = Workouts[106].Id , Step = 1 , Instruction = "Lie on your back, hands under your buttocks or on the ground for support."},
            new WorkoutInstruction{ WorkoutId = Workouts[106].Id , Step = 2 , Instruction = "Lift legs off the ground, alternate crossing them in a scissor motion."},

            new WorkoutInstruction{ WorkoutId = Workouts[107].Id , Step = 1 , Instruction = "Grasp the rings, keeping your arms extended and your shoulders away from your ears."},
            new WorkoutInstruction{ WorkoutId = Workouts[107].Id , Step = 2 , Instruction = "Keep your abs engaged, roll forward onto your toes, and extend your arms in front of you."},
            new WorkoutInstruction{ WorkoutId = Workouts[107].Id , Step = 3 , Instruction = "Slowly lower your body down toward the ground, keeping your arms straight and your abs engaged."},
            new WorkoutInstruction{ WorkoutId = Workouts[107].Id , Step = 4 , Instruction = "When your head gets between your arms, pause for a moment and then use your abs to pull your body back up to the starting position."},

            new WorkoutInstruction{ WorkoutId = Workouts[108].Id , Step = 1 , Instruction = "Perform a reverse crunch and then kick your legs up toward the ceiling."},
            new WorkoutInstruction{ WorkoutId = Workouts[108].Id , Step = 2 , Instruction = "Flex at the hips and knees until your hips land back on the bench, then kick your legs back out to the starting position."},

            new WorkoutInstruction{ WorkoutId = Workouts[109].Id , Step = 1 , Instruction = "Start in a plank position."},
            new WorkoutInstruction{ WorkoutId = Workouts[109].Id , Step = 2 , Instruction = "Raise your arm out in front of you."},
            new WorkoutInstruction{ WorkoutId = Workouts[109].Id , Step = 3 , Instruction = "Return to the starting position, then raise the opposing arm."},
            new WorkoutInstruction{ WorkoutId = Workouts[109].Id , Step = 4 , Instruction = "Make sure to keep your hips stable. If you're unable to, try performing this exercise from the knees."},

            new WorkoutInstruction{ WorkoutId = Workouts[110].Id , Step = 1 , Instruction = "Start in a plank position, hands under shoulders, body straight."},
            new WorkoutInstruction{ WorkoutId = Workouts[110].Id , Step = 2 , Instruction = "Jump feet wide, then back together, like a jumping jack."},
            new WorkoutInstruction{ WorkoutId = Workouts[110].Id , Step = 3 , Instruction = "Keep core tight, maintain plank form, repeat for desired time or reps."},

            new WorkoutInstruction{ WorkoutId = Workouts[111].Id , Step = 1 , Instruction = "Hang from a bar with arms fully extended."},
            new WorkoutInstruction{ WorkoutId = Workouts[111].Id , Step = 2 , Instruction = "Lift legs to form an \"L\" shape."},
            new WorkoutInstruction{ WorkoutId = Workouts[111].Id , Step = 3 , Instruction = "Hold for allotted amount of time keeping your abs flexed."},

            new WorkoutInstruction{ WorkoutId = Workouts[112].Id , Step = 1 , Instruction = "Start by lying flat on your back on a ball with your feet flat on the floor and your knees bent."},
            new WorkoutInstruction{ WorkoutId = Workouts[112].Id , Step = 2 , Instruction = "Engage your core muscles and flex your spine until you feel your abs contract."},

            new WorkoutInstruction{ WorkoutId = Workouts[113].Id , Step = 1 , Instruction = "Place feet on a stability ball, hands on the floor in a push-up position."},
            new WorkoutInstruction{ WorkoutId = Workouts[113].Id , Step = 2 , Instruction = "Lower your chest toward the floor, then push up while tucking knees toward your chest."},
            new WorkoutInstruction{ WorkoutId = Workouts[113].Id , Step = 3 , Instruction = "Extend legs back to starting position, maintaining control and stability throughout the movement."},

            new WorkoutInstruction{ WorkoutId = Workouts[114].Id , Step = 1 , Instruction = "Start in a plank position with your feet on a stability ball and hands on the floor."},
            new WorkoutInstruction{ WorkoutId = Workouts[114].Id , Step = 2 , Instruction = "Engage your core and tuck your knees toward your chest, rolling the ball forward carefully."},
            new WorkoutInstruction{ WorkoutId = Workouts[114].Id , Step = 3 , Instruction = "Extend your legs back to the starting position, maintaining balance and control throughout the movement."},

            new WorkoutInstruction{ WorkoutId = Workouts[115].Id , Step = 1 , Instruction = "Place your feet on the ball and get in to a plank position."},
            new WorkoutInstruction{ WorkoutId = Workouts[115].Id , Step = 2 , Instruction = "Pull your hips straight up toward the ceiling."},
            new WorkoutInstruction{ WorkoutId = Workouts[115].Id , Step = 3 , Instruction = "Lower your hips until you're back in a plank position."},

            new WorkoutInstruction{ WorkoutId = Workouts[116].Id , Step = 1 , Instruction = "Kneel behind a stability ball, place forearms on top, and engage your core muscles."},
            new WorkoutInstruction{ WorkoutId = Workouts[116].Id , Step = 2 , Instruction = "Lift knees, balance on toes, and slowly move forearms in small controlled circles."},
            new WorkoutInstruction{ WorkoutId = Workouts[116].Id , Step = 3 , Instruction = "Maintain a stable torso, avoid excessive movement, and reverse direction after several rotations."},

            new WorkoutInstruction{ WorkoutId = Workouts[117].Id , Step = 1 , Instruction = "Lie on your back, holding a stability ball between your feet, arms extended overhead."},
            new WorkoutInstruction{ WorkoutId = Workouts[117].Id , Step = 2 , Instruction = "Engage your core, lift your legs and arms, passing the ball from feet to hands."},
            new WorkoutInstruction{ WorkoutId = Workouts[117].Id , Step = 3 , Instruction = "Lower arms and legs back down, then repeat, passing the ball back to feet."},

            new WorkoutInstruction{ WorkoutId = Workouts[118].Id , Step = 1 , Instruction = "Lie on your back, legs extended, stability ball between your feet, arms out for support."},
            new WorkoutInstruction{ WorkoutId = Workouts[118].Id , Step = 2 , Instruction = "Engage your core, lift your legs, and rotate them side to side in a controlled motion."},
            new WorkoutInstruction{ WorkoutId = Workouts[118].Id , Step = 3 , Instruction = "Keep your upper body stable, move slowly, and return to center before switching directions."},
            #endregion


            #region Abdominals && Kettlebells
            new WorkoutInstruction{ WorkoutId = Workouts[119].Id , Step = 1 , Instruction = "Lay flat on your back with straight legs and hold the kettle bell above your chest at arms length."},
            new WorkoutInstruction{ WorkoutId = Workouts[119].Id , Step = 2 , Instruction = "Draw your belly into the base of your spine to engage the muscles, then raise your head and shoulders off the floor with the kettlebell raised at arms length above your chest."},
            new WorkoutInstruction{ WorkoutId = Workouts[119].Id , Step = 3 , Instruction = "Return to the starting position and repeat."},

            new WorkoutInstruction{ WorkoutId = Workouts[120].Id , Step = 1 , Instruction = "Sit on the floor with your legs bent, knees together and feet raised slightly off the floor."},
            new WorkoutInstruction{ WorkoutId = Workouts[120].Id , Step = 2 , Instruction = "Starting on one side and sitting up straight with your core muscles engaged, lift the kettlebell off the floor with both hands and bring it across your body to the other side, rotating your chest towards the floor as you do so."},
            new WorkoutInstruction{ WorkoutId = Workouts[120].Id , Step = 3 , Instruction = "Tap the kettlebell lightly on the floor and bring the kettlebell back across your body to the starting position, rotating your chest towards the floor."},
            new WorkoutInstruction{ WorkoutId = Workouts[120].Id , Step = 4 , Instruction = "Repeat, keeping the legs bent and feet raised throughout the exercise."},

            new WorkoutInstruction{ WorkoutId = Workouts[121].Id , Step = 1 , Instruction = "Stand with feet slightly wider than shoulder width apart. Hold the kettlebell in one hand and extend your arm above your head."},
            new WorkoutInstruction{ WorkoutId = Workouts[121].Id , Step = 2 , Instruction = "Keeping your legs straight and the kettlebell above your head, lower the relaxed arm towards the ground, twisting your body towards the side of the raised arm."},
            new WorkoutInstruction{ WorkoutId = Workouts[121].Id , Step = 3 , Instruction = "Return to the starting potion, tilt your pelvis forward and repeat."},

            new WorkoutInstruction{ WorkoutId = Workouts[122].Id , Step = 1 , Instruction = "Hold kettlebells in front rack."},
            new WorkoutInstruction{ WorkoutId = Workouts[122].Id , Step = 2 , Instruction = "Step back and lunge diagonally."},

            new WorkoutInstruction{ WorkoutId = Workouts[123].Id , Step = 1 , Instruction = "Grab a kettlebell."},
            new WorkoutInstruction{ WorkoutId = Workouts[123].Id , Step = 2 , Instruction = "Lie on your back, lift legs & shoulders off floor."},
            new WorkoutInstruction{ WorkoutId = Workouts[123].Id , Step = 3 , Instruction = "Hold kettlebell above your head, engage core, and maintain position."},

            new WorkoutInstruction{ WorkoutId = Workouts[124].Id , Step = 1 , Instruction = "Stand with feet slightly wider than shoulder width apart. Hold the kettlebell in your bottom hand and extend the other arm above your head."},
            new WorkoutInstruction{ WorkoutId = Workouts[124].Id , Step = 2 , Instruction = "Keeping your legs straight and the kettlebell inside your thigh, lower the kettlebell towards the ground, twisting your body towards the side of the raised arm."},
            new WorkoutInstruction{ WorkoutId = Workouts[124].Id , Step = 3 , Instruction = "Return to the starting position, tilt your pelvis forward and repeat."},

            new WorkoutInstruction{ WorkoutId = Workouts[125].Id , Step = 1 , Instruction = "Start with kettlebells in front rack."},
            new WorkoutInstruction{ WorkoutId = Workouts[125].Id , Step = 2 , Instruction = "Step forward into lunge."},
            new WorkoutInstruction{ WorkoutId = Workouts[125].Id , Step = 3 , Instruction = "Return to starting position."},

            new WorkoutInstruction{ WorkoutId = Workouts[126].Id , Step = 1 , Instruction = "Hold kettlebell in front rack."},
            new WorkoutInstruction{ WorkoutId = Workouts[126].Id , Step = 2 , Instruction = "Step sideways into a lunge position."},
            new WorkoutInstruction{ WorkoutId = Workouts[126].Id , Step = 3 , Instruction = "Return to start position. Repeat."},

            new WorkoutInstruction{ WorkoutId = Workouts[127].Id , Step = 1 , Instruction = "Start with kettlebell in front rack."},
            new WorkoutInstruction{ WorkoutId = Workouts[127].Id , Step = 2 , Instruction = "Step back into lunge."},
            new WorkoutInstruction{ WorkoutId = Workouts[127].Id , Step = 3 , Instruction = "Return to start position."},

            new WorkoutInstruction{ WorkoutId = Workouts[128].Id , Step = 1 , Instruction = "Hold kettlebell in front rack."},
            new WorkoutInstruction{ WorkoutId = Workouts[128].Id , Step = 2 , Instruction = "Step sideways, lunge."},

            new WorkoutInstruction{ WorkoutId = Workouts[129].Id , Step = 1 , Instruction = "Hold kettlebells close to chest."},
            new WorkoutInstruction{ WorkoutId = Workouts[129].Id , Step = 2 , Instruction = "Squat down, keeping chest up."},
            new WorkoutInstruction{ WorkoutId = Workouts[129].Id , Step = 3 , Instruction = "Stand up, extending hips fully."},

            new WorkoutInstruction{ WorkoutId = Workouts[130].Id , Step = 1 , Instruction = "Stand in front of a step or bench with your feet shoulder-width apart and hold kettlebells at your shoulders."},
            new WorkoutInstruction{ WorkoutId = Workouts[130].Id , Step = 2 , Instruction = "Step up onto the bench with your right foot, pushing off your foot to raise your body up onto the bench."},

            new WorkoutInstruction{ WorkoutId = Workouts[131].Id , Step = 1 , Instruction = "Hold kettlebell in front rack position."},
            new WorkoutInstruction{ WorkoutId = Workouts[131].Id , Step = 2 , Instruction = "Step forward, lunge. Bringing your back knee to the floor."},
            new WorkoutInstruction{ WorkoutId = Workouts[131].Id , Step = 3 , Instruction = "Extend your knee and return to the starting position."},

            new WorkoutInstruction{ WorkoutId = Workouts[132].Id , Step = 1 , Instruction = "Stand in front of a step or bench with your feet shoulder-width apart and hold a kettlebell at one shoulder."},
            new WorkoutInstruction{ WorkoutId = Workouts[132].Id , Step = 2 , Instruction = "Step up onto the bench with your right foot, pushing off your foot to raise your body up onto the bench."},
            #endregion

            new WorkoutInstruction{ WorkoutId = Workouts[133].Id , Step = 1 , Instruction = "Place the band at the highest anchor point you have available. Grab both ends of the band and fall into a kneeling position."},
            new WorkoutInstruction{ WorkoutId = Workouts[133].Id , Step = 2 , Instruction = "Push your hips back flexing at the spine."},
            new WorkoutInstruction{ WorkoutId = Workouts[133].Id , Step = 3 , Instruction = "Squeeze your abs and then extend at the hips and spine back to the starting position."},

            new WorkoutInstruction{ WorkoutId = Workouts[134].Id , Step = 1 , Instruction = "Lie down on your back with your feet hip-distance apart and your knees bent."},
            new WorkoutInstruction{ WorkoutId = Workouts[134].Id , Step = 2 , Instruction = "Place your hands on the floor beside your head, fingertips pointing towards your shoulders."},
            new WorkoutInstruction{ WorkoutId = Workouts[134].Id , Step = 3 , Instruction = "Push your feet and hands into the floor, lift your hips up and straighten your arms."},
            new WorkoutInstruction{ WorkoutId = Workouts[134].Id , Step = 4 , Instruction = "Lift your chest towards the ceiling and hold the pose for a few breaths before lowering back down."},

            new WorkoutInstruction{ WorkoutId = Workouts[135].Id , Step = 1 , Instruction = ""},

            new WorkoutInstruction{ WorkoutId = Workouts[136].Id , Step = 1 , Instruction = "Stand in front of a low box."},
            new WorkoutInstruction{ WorkoutId = Workouts[136].Id , Step = 2 , Instruction = "Bring one foot to the edge of the box and alternate as quickly as possible."},
            new WorkoutInstruction{ WorkoutId = Workouts[136].Id , Step = 3 , Instruction = "Only lightly tap your feet to the box."},

            new WorkoutInstruction{ WorkoutId = Workouts[137].Id , Step = 1 , Instruction = "Do a light hop and split your stance."},
            new WorkoutInstruction{ WorkoutId = Workouts[137].Id , Step = 2 , Instruction = "Land lightly on your toes, and then bring the opposing leg forward."},

            new WorkoutInstruction{ WorkoutId = Workouts[138].Id , Step = 1 , Instruction = "Bring one leg forward and then the other."},
            new WorkoutInstruction{ WorkoutId = Workouts[138].Id , Step = 2 , Instruction = "Bring the original leg backwards and then the other."},

            new WorkoutInstruction{ WorkoutId = Workouts[139].Id , Step = 1 , Instruction = "Leap sideways, land on right foot, left leg behind to the side."},
            new WorkoutInstruction{ WorkoutId = Workouts[139].Id , Step = 2 , Instruction = "Drop into a single-leg burpee, right leg only, hands to ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[139].Id , Step = 3 , Instruction = "Return to standing on right, leap sideways to left, repeat with left leg."},

            
            new WorkoutInstruction{ WorkoutId = Workouts[140].Id , Step = 1 , Instruction = "While seated on a bench, place your palms on the bench by your sides."},
            new WorkoutInstruction{ WorkoutId = Workouts[140].Id , Step = 2 , Instruction = "Palm placement should allow room for the fingers to grip the edge of the bench."},
            new WorkoutInstruction{ WorkoutId = Workouts[140].Id , Step = 3 , Instruction = "Try to lift your bodyweight off the bench by pushing the palms into the bench."},
            new WorkoutInstruction{ WorkoutId = Workouts[140].Id , Step = 4 , Instruction = "Lockout your elbows and repeat or hold isometrically."},

            new WorkoutInstruction{ WorkoutId = Workouts[141].Id , Step = 1 , Instruction = "While seated on a bench, place your palms on the bench by your sides."},
            new WorkoutInstruction{ WorkoutId = Workouts[141].Id , Step = 2 , Instruction = "Palm placement should allow room for the fingers to grip the edge of the bench."},
            new WorkoutInstruction{ WorkoutId = Workouts[141].Id , Step = 3 , Instruction = "Try to lift your bodyweight off the bench by pushing the palms into the bench."},
            new WorkoutInstruction{ WorkoutId = Workouts[141].Id , Step = 4 , Instruction = "Lockout your elbows and hold isometrically"},

            new WorkoutInstruction{ WorkoutId = Workouts[142].Id , Step = 1 , Instruction = "Lie on your back. Raise your legs but bend your knees."},
            new WorkoutInstruction{ WorkoutId = Workouts[142].Id , Step = 2 , Instruction = "Keep a 90° angle at hips and knees. Lower your toes to the ground without bending your knees."},
            new WorkoutInstruction{ WorkoutId = Workouts[142].Id , Step = 3 , Instruction = "Make sure you maintain a flat lower back against the ground throughout the movement."},

            #region Obliques && Barbell
            new WorkoutInstruction{ WorkoutId = Workouts[143].Id , Step = 1 , Instruction = "Stand straight and hold the end of the Barbell"},
            new WorkoutInstruction{ WorkoutId = Workouts[143].Id , Step = 2 , Instruction = "Keep your hips and shoulders facing forward, bend to one side slowly"},
            new WorkoutInstruction{ WorkoutId = Workouts[143].Id , Step = 3 , Instruction = "Return to the upright position."},
            new WorkoutInstruction{ WorkoutId = Workouts[143].Id , Step = 4 , Instruction = "Switch hands and repeat."},

            new WorkoutInstruction{ WorkoutId = Workouts[144].Id , Step = 1 , Instruction = "Begin by standing with your feet hip-width apart and holding a barbell at one side of your body, with your palms facing your thighs."},
            new WorkoutInstruction{ WorkoutId = Workouts[144].Id , Step = 2 , Instruction = "Keeping your core engaged and your back straight, bend at the hips and knees to lower the barbell down towards the ground."},
            new WorkoutInstruction{ WorkoutId = Workouts[144].Id , Step = 3 , Instruction = "As the barbell reaches the ground, use your legs and glutes to push through your heels and extend your hips and knees to raise your body back to the starting position."},
            new WorkoutInstruction{ WorkoutId = Workouts[144].Id , Step = 4 , Instruction = "Repeat the movement for the desired number of reps, then switch sides and repeat the exercise with the barbell on the opposite side of your body."},

            new WorkoutInstruction{ WorkoutId = Workouts[145].Id , Step = 1 , Instruction = "Set up the landmine attachment and load weight."},
            new WorkoutInstruction{ WorkoutId = Workouts[145].Id , Step = 2 , Instruction = "Stand facing the landmine, holding the weight away from your chest."},
            new WorkoutInstruction{ WorkoutId = Workouts[145].Id , Step = 3 , Instruction = "Step backward with one leg, lunge down while twisting your torso toward the front leg, return to starting position, and repeat on the other side."},

            new WorkoutInstruction{ WorkoutId = Workouts[146].Id , Step = 1 , Instruction = "Kneel down facing the landmine with your knees hip-width apart and your back straight. Grasp the landmine barbell with both hands, interlacing your fingers and holding it above and slightly in front of your body."},
            new WorkoutInstruction{ WorkoutId = Workouts[146].Id , Step = 2 , Instruction = "Keeping your core engaged and your back straight, twist your torso to one side, rotating your arms and the landmine along with it. Pause briefly at the end of the twist, feeling the contraction in your oblique muscles."},
            new WorkoutInstruction{ WorkoutId = Workouts[146].Id , Step = 3 , Instruction = "Slowly rotate back to the starting position, then twist to the opposite side, repeating the same motion."},
            new WorkoutInstruction{ WorkoutId = Workouts[146].Id , Step = 4 , Instruction = "Repeat both sides of the rotation for the desired number of reps."},

            new WorkoutInstruction{ WorkoutId = Workouts[147].Id , Step = 1 , Instruction = "Stand facing the landmine, with your feet shoulder-width apart and your knees slightly bent. Grasp the landmine barbell with both hands, interlacing your fingers and holding it at chest height. Position your arms straight out in front of you, parallel to the floor, with your elbows slightly bent."},
            new WorkoutInstruction{ WorkoutId = Workouts[147].Id , Step = 2 , Instruction = "While keeping your core engaged, rotate your torso and the landmine to one side. Twist through your waist, using your oblique muscles to generate the movement. Pivot on the ball of your opposite foot as you rotate away from it."},
            new WorkoutInstruction{ WorkoutId = Workouts[147].Id , Step = 3 , Instruction = "Rotate back to the starting position, then perform the same movement in the opposite direction."},
            new WorkoutInstruction{ WorkoutId = Workouts[147].Id , Step = 4 , Instruction = "Repeat for the desired number of reps."},

            new WorkoutInstruction{ WorkoutId = Workouts[148].Id , Step = 1 , Instruction = "Start sitting on the ground facing the landmine attachment, holding the end of the bar in both hands slightly in front of and above your chest while holding your feet off the ground and knees bent."},
            new WorkoutInstruction{ WorkoutId = Workouts[148].Id , Step = 2 , Instruction = "Bending your elbows as little as possible and keeping your core tight and feet elevated, lower the end of the bar with control to the ground on one side of your body, then contract your obliques to return the bar to the center. Repeat on the other side."},
            new WorkoutInstruction{ WorkoutId = Workouts[148].Id , Step = 3 , Instruction = "Repeat for the desired number of reps."},

            new WorkoutInstruction{ WorkoutId = Workouts[149].Id , Step = 1 , Instruction = "Hold the end of the bar. Start with a shoulder width stance."},
            new WorkoutInstruction{ WorkoutId = Workouts[149].Id , Step = 2 , Instruction = "Bring both arms to one side and keep your elbows mostly extended."},
            new WorkoutInstruction{ WorkoutId = Workouts[149].Id , Step = 3 , Instruction = "Rotate back and forth and try to resist twisting too much."},

            new WorkoutInstruction{ WorkoutId = Workouts[150].Id , Step = 1 , Instruction = "Stand perpendicularly to the barbell with the end of the bar in front of your feet. Squat down and hold the end of the bar with your hand closer to the landmine attachment with your palm facing your body."},
            new WorkoutInstruction{ WorkoutId = Workouts[150].Id , Step = 2 , Instruction = "Drive your feet into the ground to start the motion. As your legs fully extend, pull the bar upwards with your hand and start to rotate your torso in towards the landmine attachment. As you do so, bring your other hand up to the bar and switch your grip. Press through the bar to extend your arm all the way upright, pivoting your back foot to allow for more trunk rotation."},
            new WorkoutInstruction{ WorkoutId = Workouts[150].Id , Step = 3 , Instruction = "Perform the movement in reverse to return to the starting position. Repeat for desired number of reps before switching sides."},

            new WorkoutInstruction{ WorkoutId = Workouts[151].Id , Step = 1 , Instruction = "Begin by standing with your feet hip-width apart with the bar on the ground at your side."},
            new WorkoutInstruction{ WorkoutId = Workouts[151].Id , Step = 2 , Instruction = "Lift the bar to your side and walk for the allotted amount of time or distance."},
            new WorkoutInstruction{ WorkoutId = Workouts[151].Id , Step = 3 , Instruction = "Set the bar down and switch sides."},
            #endregion

            #region Obliques && Plate
            new WorkoutInstruction{ WorkoutId = Workouts[152].Id , Step = 1 , Instruction = "Step back with your right foot into a lunge position, both knees bent at 90 degrees."},
            new WorkoutInstruction{ WorkoutId = Workouts[152].Id , Step = 2 , Instruction = "Twist your torso to the right, keeping the plate close to your chest."},
            new WorkoutInstruction{ WorkoutId = Workouts[152].Id , Step = 3 , Instruction = "Push through your front foot to return to the starting position and repeat on the other side."},

            new WorkoutInstruction{ WorkoutId = Workouts[153].Id , Step = 1 , Instruction = "Stand straight with the plate held at your side"},
            new WorkoutInstruction{ WorkoutId = Workouts[153].Id , Step = 2 , Instruction = "Keep your hips and shoulders facing forward, bend to one side slowly"},
            new WorkoutInstruction{ WorkoutId = Workouts[153].Id , Step = 3 , Instruction = "Return to the upright position."},
            new WorkoutInstruction{ WorkoutId = Workouts[153].Id , Step = 4 , Instruction = "Switch hands and repeat"},

            new WorkoutInstruction{ WorkoutId = Workouts[154].Id , Step = 1 , Instruction = "Stand with a plate extended away from your body. Elbows mostly extended."},
            new WorkoutInstruction{ WorkoutId = Workouts[154].Id , Step = 2 , Instruction = "Rotate at the upper spine while keeping your lumbar spine in a neutral position."},
            new WorkoutInstruction{ WorkoutId = Workouts[154].Id , Step = 3 , Instruction = "Do not let the plate go behind your body."},

            new WorkoutInstruction{ WorkoutId = Workouts[155].Id , Step = 1 , Instruction = "Stand with a shoulder width stance. Begin with the plate near one of your quads."},
            new WorkoutInstruction{ WorkoutId = Workouts[155].Id , Step = 2 , Instruction = "Rotate at your upper spine to engage the obliques."},
            new WorkoutInstruction{ WorkoutId = Workouts[155].Id , Step = 3 , Instruction = "You can pivot your back foot to keep from generating too much torque at the knee."},
            #endregion

            #region Obliques && Bosu-Ball
            new WorkoutInstruction{ WorkoutId = Workouts[156].Id , Step = 1 , Instruction = "Lie on one side, forearm on Bosu, elbow under shoulder."},
            new WorkoutInstruction{ WorkoutId = Workouts[156].Id , Step = 2 , Instruction = "Lift hips to create a side plank."},
            new WorkoutInstruction{ WorkoutId = Workouts[156].Id , Step = 3 , Instruction = "Hold the side plank position, then switch sides."},
            
            new WorkoutInstruction{ WorkoutId = Workouts[157].Id , Step = 1 , Instruction = "Place hand on Bosu, arm straight, facing sideways."},
            new WorkoutInstruction{ WorkoutId = Workouts[157].Id , Step = 2 , Instruction = "Stack feet and lift hips to side plank."},
            new WorkoutInstruction{ WorkoutId = Workouts[157].Id , Step = 3 , Instruction = "Hold the side plank position, then switch sides."},

            new WorkoutInstruction{ WorkoutId = Workouts[158].Id , Step = 1 , Instruction = "Start in a side plank with hand on Bosu."},
            new WorkoutInstruction{ WorkoutId = Workouts[158].Id , Step = 2 , Instruction = "Lift the top leg while keeping the body stable."},
            new WorkoutInstruction{ WorkoutId = Workouts[158].Id , Step = 3 , Instruction = "Lower the leg back down."},

            new WorkoutInstruction{ WorkoutId = Workouts[159].Id , Step = 1 , Instruction = "Hold medicine ball with both hands and arms extended."},
            new WorkoutInstruction{ WorkoutId = Workouts[159].Id , Step = 1 , Instruction = "Swing ball diagonally across body, engaging core."},
            #endregion

            new WorkoutInstruction{ WorkoutId = Workouts[155].Id , Step = 1 , Instruction = ""},


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

            #region Abdominals && Vitruvian
            new WorkoutEquipment{ WorkoutId = Workouts[60].Id, EquipmentId = vitruvianId },
            #endregion

            #region Abdominals && Recovery
            new WorkoutEquipment{ WorkoutId = Workouts[61].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[62].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[63].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[64].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[65].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[66].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[67].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[68].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[69].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[70].Id, EquipmentId = cardioId },
            #endregion

            #region Abdominals && Bodyweight
            new WorkoutEquipment{ WorkoutId = Workouts[71].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[72].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[73].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[74].Id, EquipmentId = bodyweightId },
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
            new WorkoutEquipment{ WorkoutId = Workouts[95].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[96].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[97].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[98].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[99].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[100].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[101].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[102].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[103].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[104].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[105].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[106].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[107].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[108].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[109].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[110].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[111].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[112].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[113].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[114].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[115].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[116].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[117].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = Workouts[118].Id, EquipmentId = bodyweightId },
            #endregion

            #region Abdominals && Kettlebells
            new WorkoutEquipment{ WorkoutId = Workouts[119].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[120].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[121].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[122].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[123].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[124].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[125].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[126].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[127].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[128].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[129].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[130].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[131].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = Workouts[132].Id, EquipmentId = kettlebellId },
            #endregion

            new WorkoutEquipment{ WorkoutId = Workouts[133].Id, EquipmentId = BandsId },

            new WorkoutEquipment{ WorkoutId = Workouts[134].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = Workouts[135].Id, EquipmentId = yogaId },

            new WorkoutEquipment{ WorkoutId = Workouts[136].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[137].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[138].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[139].Id, EquipmentId = cardioId },

            new WorkoutEquipment{ WorkoutId = Workouts[140].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[141].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = Workouts[142].Id, EquipmentId = cardioId },

            #region Obliques && Barbell
            new WorkoutEquipment{ WorkoutId = Workouts[143].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[144].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[145].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[146].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[147].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[148].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[149].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[150].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[151].Id, EquipmentId = barbellId },
            #endregion

            #region Obliques && Plate
            new WorkoutEquipment{ WorkoutId = Workouts[152].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[153].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[154].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = Workouts[155].Id, EquipmentId = plateId },
            #endregion

            #region Obliques && Bosu-Ball
            new WorkoutEquipment{ WorkoutId = Workouts[156].Id, EquipmentId = bosuballId },
            new WorkoutEquipment{ WorkoutId = Workouts[157].Id, EquipmentId = bosuballId },
            new WorkoutEquipment{ WorkoutId = Workouts[158].Id, EquipmentId = bosuballId },
            new WorkoutEquipment{ WorkoutId = Workouts[159].Id, EquipmentId = bosuballId },
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

            #region Abdominals && Vitruvian
            new WorkoutLevel{ WorkoutId = Workouts[60].Id , Level = Difficulty.Beginner },
            #endregion

            #region Abdominals && Recovery
            new WorkoutLevel{ WorkoutId = Workouts[61].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[62].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[63].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[64].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[65].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[66].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[67].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[68].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[69].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[70].Id , Level = Difficulty.Novice },
            #endregion

            #region Abdominals && Bodyweight
            new WorkoutLevel{ WorkoutId = Workouts[71].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[72].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[73].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[74].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[75].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[76].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[77].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[78].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[79].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[80].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[81].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[82].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[83].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[84].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[85].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[86].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[87].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[88].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[89].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[90].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[91].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[92].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[93].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[94].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[95].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[96].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[97].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[98].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[99].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[100].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[101].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[102].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[103].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[104].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[105].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[106].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[107].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[108].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[109].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[110].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[111].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[112].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[113].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[114].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[115].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[116].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[117].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[118].Id , Level = Difficulty.Intermediate },
            #endregion

            #region Abdominals && Kettlebells
            new WorkoutLevel{ WorkoutId = Workouts[119].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[120].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[121].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[122].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[123].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[124].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[125].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[126].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[127].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[128].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[129].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[130].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[131].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[132].Id , Level = Difficulty.Advanced },
            #endregion

            new WorkoutLevel{ WorkoutId = Workouts[133].Id , Level = Difficulty.Intermediate },

            new WorkoutLevel{ WorkoutId = Workouts[134].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[135].Id , Level = Difficulty.Beginner },

            new WorkoutLevel{ WorkoutId = Workouts[136].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = Workouts[137].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[138].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[139].Id , Level = Difficulty.Beginner },

            new WorkoutLevel{ WorkoutId = Workouts[140].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[141].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[142].Id , Level = Difficulty.Novice },


            #region Obliques && Barbell
            new WorkoutLevel{ WorkoutId = Workouts[143].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[144].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[145].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[146].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[147].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[148].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[149].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[150].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[151].Id , Level = Difficulty.Advanced },
            #endregion

            #region Obliques && Plate
            new WorkoutLevel{ WorkoutId = Workouts[152].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[153].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[154].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = Workouts[155].Id , Level = Difficulty.Beginner },
            #endregion

            #region Obliques && Bosu-Ball
            new WorkoutLevel{ WorkoutId = Workouts[156].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[157].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = Workouts[158].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = Workouts[159].Id , Level = Difficulty.Beginner },
            #endregion



            new WorkoutLevel{ WorkoutId = Workouts[156].Id , Level = Difficulty.Novice },
        };
        await context.WorkoutLevels.AddRangeAsync(workoutLevel);
        await context.SaveChangesAsync();

        // ***************************************************************** //

        var bodyWorkouts = new List<BodyWorkout>();
        var AbdoId = await context.Bodies.Where(z => z.Name == "Abdominals").Select(z => z.Id).FirstOrDefaultAsync();
        var lowAbdoId = await context.Bodies.Where(z => z.Name == "Lower Abdominals").Select(z => z.Id).FirstOrDefaultAsync();
        var UpAbdoId = await context.Bodies.Where(z => z.Name == "Upper Abdominals").Select(z => z.Id).FirstOrDefaultAsync();

        var obliqueId = await context.Bodies.Where(z => z.Name == "Obliques").Select(z => z.Id).FirstOrDefaultAsync();

        bodyWorkouts = new List<BodyWorkout>
        {
            #region Abdominals & Barbell
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[0].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[0].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[0].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[1].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[1].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[2].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[2].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[3].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[4].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[4].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[5].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[6].Id, Target = PriorityTarget.Tertiary },
            #endregion

            #region Abdominals && Machine
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[7].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[7].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[7].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[8].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[8].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[9].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[9].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[10].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[10].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[11].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[11].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Stretches
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[12].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[13].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[13].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[14].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[14].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[15].Id, Target = PriorityTarget.Primary },
            #endregion
            
            #region Abdominals && Plate
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[16].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[17].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[17].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[18].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[18].Id, Target = PriorityTarget.Primary },

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
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[26].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[27].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[27].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[28].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[28].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[29].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Smith-Machine
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[30].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[30].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[31].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[31].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[32].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[32].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Dumbbells
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[33].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[33].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[34].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[35].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[36].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[36].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[37].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[38].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[38].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[39].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[40].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[41].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[42].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Medicine-Ball
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[43].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[44].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[44].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[45].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[45].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[45].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[46].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[46].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[47].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[48].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Cables
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[49].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[49].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[50].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[50].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[51].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[51].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[52].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[52].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && TRX
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[53].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[54].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[55].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[56].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[57].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[57].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[58].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[58].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[59].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[59].Id, Target = PriorityTarget.Primary },

            #endregion

            #region Abdominals && Vitruvian
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[60].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Recovery
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[61].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[62].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[63].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[64].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[65].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[66].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[67].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[68].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[69].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[70].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Bodyweight
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[71].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[71].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[72].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[72].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[73].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[74].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[74].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[75].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[75].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[75].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[76].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[76].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[76].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[77].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[77].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[77].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[78].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[78].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[79].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[80].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[81].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[81].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[81].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[82].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[83].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[84].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[84].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[84].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[85].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[85].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[86].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[86].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[87].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[88].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[89].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[90].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[90].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[91].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[92].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[92].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[93].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[93].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[94].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[94].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[95].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[95].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[96].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[97].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[97].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[98].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[98].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[99].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[100].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[100].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[101].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[102].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[103].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[103].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[104].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[105].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[106].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[107].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[108].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[109].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[110].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[111].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[111].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[112].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[112].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[113].Id, Target = PriorityTarget.Primary },
            
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[114].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[114].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[115].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[115].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[116].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[117].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[118].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Abdominals && Kettlebells
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[119].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[119].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[120].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[121].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[122].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[123].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[124].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[125].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[126].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[127].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[128].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[129].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[130].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[131].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[132].Id, Target = PriorityTarget.Primary },
            #endregion

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[133].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = UpAbdoId, WorkoutId = Workouts[133].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[134].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[135].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[136].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[136].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[137].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[137].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[138].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[138].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[139].Id, Target = PriorityTarget.Primary },

            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[140].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[141].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowAbdoId, WorkoutId = Workouts[142].Id, Target = PriorityTarget.Primary },

            #region Obliques && Barbell
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[143].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[144].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[145].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[146].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[147].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[148].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[149].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[150].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[151].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Obliques && Plate
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[152].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[153].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[154].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[155].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Obliques && Bosu-Ball
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[156].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[157].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[158].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = obliqueId, WorkoutId = Workouts[159].Id, Target = PriorityTarget.Primary },
            #endregion

        };
        await context.BodyWorkouts.AddRangeAsync(bodyWorkouts);
        await context.SaveChangesAsync();
        // ***************************************************************** //
        var workoutSex = new List<WorkoutSex>();
        workoutSex = new List<WorkoutSex>
        {
            new WorkoutSex{ WorkoutId = Workouts[0].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[0].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[1].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[1].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[2].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[2].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[3].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[3].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[4].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[4].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[5].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[5].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[6].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[6].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[7].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[7].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[8].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[8].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[9].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[9].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[10].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[10].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[11].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[11].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[12].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[12].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[13].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[13].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[14].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[14].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[15].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[15].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[16].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[16].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[17].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[17].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[18].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[18].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[19].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[19].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[20].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[20].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[21].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[21].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[22].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[22].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[23].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[23].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[24].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[24].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[25].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[25].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[26].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[26].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[27].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[27].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[28].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[28].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[29].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[29].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[30].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[30].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[31].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[31].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[32].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[32].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[33].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[33].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[34].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[34].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[35].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[35].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[36].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[36].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[37].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[37].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[38].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[38].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[39].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[39].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[40].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[40].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[41].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[41].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[42].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[42].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[43].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[43].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[44].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[44].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[45].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[45].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[46].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[46].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[47].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[47].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[48].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[48].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[49].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[49].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[50].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[50].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[51].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[51].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[52].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[52].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[53].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[53].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[54].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[54].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[55].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[55].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[56].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[56].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[57].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[57].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[58].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[58].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[59].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[59].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[60].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[60].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[61].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[61].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[62].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[62].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[63].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[63].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[64].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[64].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[65].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[65].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[66].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[66].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[67].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[67].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[68].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[68].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[69].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[69].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[70].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[70].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[71].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[71].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[72].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[72].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[73].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[73].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[74].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[74].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[75].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[75].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[76].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[76].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[77].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[77].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[78].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[78].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[79].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[79].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[80].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[80].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[81].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[81].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[82].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[82].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[83].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[83].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[84].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[84].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[85].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[85].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[86].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[86].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[87].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[87].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[88].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[88].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[89].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[89].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[90].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[90].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[91].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[91].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[92].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[92].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[93].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[93].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[94].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[94].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[95].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[95].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[96].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[96].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[97].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[97].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[98].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[98].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[99].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[99].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[100].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[100].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[101].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[101].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[102].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[102].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[103].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[103].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[104].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[104].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[105].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[105].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[106].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[106].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[107].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[107].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[108].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[108].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[109].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[109].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[110].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[110].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[111].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[111].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[112].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[112].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[113].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[113].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[114].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[114].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[115].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[115].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[116].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[116].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[117].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[117].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[118].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[118].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[119].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[119].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[120].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[120].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[121].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[121].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[122].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[122].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[123].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[123].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[124].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[124].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[125].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[125].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[126].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[126].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[127].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[127].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[128].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[128].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[129].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[129].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[130].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[130].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[131].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[131].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[132].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[132].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[133].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[133].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[134].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[134].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[135].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[135].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[136].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[136].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[137].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[137].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[138].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[138].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = Workouts[139].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[139].Id, Sex = Sex.Female},

        };
        await context.WorkoutSex.AddRangeAsync(workoutSex);
        await context.SaveChangesAsync();
    }
}
