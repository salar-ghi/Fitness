namespace Application.DTOs;

public record PlanDto
{
    public int Height { get; set; }
    public int Weight { get; set; }

    public Period PlanDuration { get; set; }

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
    public Place Place { get; set; }
    public PhysiqueType PhysiqueType { get; set; }

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
