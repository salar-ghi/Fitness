namespace Application.DTOs;

public record PlanDto
{
    public int Height { get; set; }
    public int Weight { get; set; }

    public Period PlanDuration { get; set; }

    public Sex Gender { get; set; }

    public int Age { get; set; }
    public Age AgeRange { get; set; } 
    public DateOnly DateOfBirth { get; set; }
    public BodyType BodyType { get; set; }
    public Difficulty Level { get; set; }
    public Place Place { get; set; }

    // Injuries
    public List<InjuryDto> Injuries { get; set; }

    // Diseases
    public List<DiseaseDto> Diseases { get; set; }

    // PlanDays
    public List<PlanDaysDto> PlanDays { get; set; }

    // Muscle Priority
    public List<MusclePriorityDto> MusclePriorities { get; set; }

    // EquipmentDto
    public List<PlanEquipmentDto> Equipments { get; set; }

}
