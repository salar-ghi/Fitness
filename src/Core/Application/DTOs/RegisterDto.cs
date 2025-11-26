namespace Application.DTOs;

public class RegisterDto
{

    // -----User Table Properties
    public string PhoneNumber { get; set; } = default!;
    public string? Email { get; set; }
    public string? FName { get; set; }
    public string? LName { get; set; }


    public int Age { get; set; }


    // -----Athlete Table Properties
    public int Height { get; set; }
    public int Weight { get; set; }

    //public int WorkoutDays { get; set; }
    public Period PlanDuration { get; set; }

    public Sex Gender { get; set; }
    public Age AgeRange { get; set; } // ???
    public DateOnly DateOfBirth { get; set; }
    public BodyType BodyType { get; set; }
    public Difficulty Level { get; set; }


    // Inujuries
    public List<InjuryDto> Injuries { get; set; }

    // Diseases
    public List<DiseaseDto> Diseases { get; set; }

    // PlanDays
    public List<PlanDaysDto> PlanDays { get; set; }

    // Muscle Priority
    public List<MusclePriorityDto> MusclePriorities { get; set; }

    // EquipmentDto
    public List<PlanEquipmentDto> Equipments { get; set; }

    // Exercise 
    //public List<ExerciseDto> Exercises { get; set; }

}
