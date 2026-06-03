namespace Application.DTOs;

public record PlanDto
{
    // Question 6: user's height in centimeters.
    public int Height { get; set; }

    // Question 7: user's current weight in kilograms.
    public int Weight { get; set; }

    // Question 8: user's target weight in kilograms.
    public int TargetWeight { get; set; }

    public Period PlanDuration { get; set; }

    // Question 9: user's sex/gender for plan generation.
    public Sex Gender { get; set; }

    public int Age { get; set; }
    public Domain.Enums.Age AgeRange { get; set; }
    public DateOnly DateOfBirth { get; set; }

    // Question 3: current body shape selected by the user (Slim, Average, Big, Heavy).
    public BodyShapeType BodyShapeType { get; set; }

    // Existing somatotype field used by workout generation and athlete persistence.
    public BodyType BodyType { get; set; }

    // Question 4: primary goal selected by the user.
    public FitnessGoal Goal { get; set; }

    // Question 5: desired body selected by the user.
    public DesiredBodyType DesiredBodyType { get; set; }

    public Difficulty Level { get; set; }

    // Question 14: workout location selected by the user (Home, Gym, Mixed).
    public Place Place { get; set; }

    public PhysiqueType PhysiqueType { get; set; }

    // Question 10: how recently the user was in the best shape of their life.
    public BestShapeRecency BestShapeRecency { get; set; }

    // Question 11: user's typical weight-change pattern.
    public WeightChangePattern WeightChangePattern { get; set; }

    // Question 12: daily-life activities that are part of the user's lifestyle.
    public List<LifestyleActivity> LifestyleActivities { get; set; } = new();

    // Question 13: body areas the user struggles with.
    public List<StruggleArea> StruggleAreas { get; set; } = new();

    // Question 15: preferred workout intensity selected by the user.
    public PreferredWorkoutIntensity PreferredWorkoutIntensity { get; set; }

    // Question 16: how often the user trained each week during the last 3 months.
    public RecentTrainingFrequency RecentTrainingFrequency { get; set; }

    // Question 17: user's preferred workout duration.
    public WorkoutDurationPreference WorkoutDurationPreference { get; set; }

    // Question 18: exercises the user likes.
    public List<ExercisePreference> LikedExercises { get; set; } = new();

    // Question 18: exercises the user dislikes.
    public List<ExercisePreference> DislikedExercises { get; set; } = new();

    // Question 19: how often the user eats/drinks sugary foods or beverages.
    public SugaryFoodDrinkFrequency SugaryFoodDrinkFrequency { get; set; }

    // Question 20: how much water the user drinks daily.
    public DailyWaterIntake DailyWaterIntake { get; set; }

    // Question 21: user's average energy level during the day.
    public AverageEnergyLevel AverageEnergyLevel { get; set; }

    // Question 22: how much sleep the user usually gets.
    public SleepDuration SleepDuration { get; set; }

    // Question 23: user's name for user/profile creation before plan persistence.
    public string? Name { get; set; }

    // Question 24: user's phone number for user/profile creation before plan persistence.
    public string? PhoneNumber { get; set; }

    // Injuries
    public List<InjuryDto> Injuries { get; set; } = new();

    // Diseases
    public List<DiseaseDto> Diseases { get; set; } = new();

    // PlanDays
    public List<PlanDaysDto> PlanDays { get; set; } = new();

    // Muscle Priority
    public List<MusclePriorityDto> MusclePriorities { get; set; } = new();

    // EquipmentDto
    public List<PlanEquipmentDto> Equipments { get; set; } = new();

    public void ApplyAgeFromDateOfBirth(DateOnly today)
    {
        Age = CalculateAge(DateOfBirth, today);
        AgeRange = ResolveAgeRange(Age);
    }

    public static int CalculateAge(DateOnly dateOfBirth, DateOnly today)
    {
        var age = today.Year - dateOfBirth.Year;

        if (dateOfBirth > today.AddYears(-age))
        {
            age--;
        }

        return age;
    }

    public static Domain.Enums.Age ResolveAgeRange(int age) => age switch
    {
        < 18 => Domain.Enums.Age.Under_Eighteen,
        <= 29 => Domain.Enums.Age.Eighteen_To_TwentyNine,
        <= 39 => Domain.Enums.Age.Thirty_To_Thirty_Nine,
        <= 49 => Domain.Enums.Age.Fourty_To_Fourty_Nine,
        <= 59 => Domain.Enums.Age.Fifty_To_Fifty_Nine,
        _ => Domain.Enums.Age.Sixty_Plus,
    };
}
