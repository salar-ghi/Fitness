namespace Domain.Models;

public class Equipment : BaseEntity<int, Equipment>
{
    public string Name { get; set; } = null!;
    public string ImgUrl { get; set; } = default!;
    public string Description { get; set; } = default!;
    public EquipmentType EquipmentType { get; set; }

    public int WorkoutEquipmentId { get; private set; }
    public WorkoutEquipment WorkoutEquipment { get; set; } = null!;

    // None
    // Bands
    // Foam Roll
    // Barbell
    // KettleBells
    // Body Only
    // Machine
    // Cable
    // Medicine Ball
    // Dumble
    // E-Z Curl Bar
    // Exercise Ball
    // Other

    // N/A
    // Compound
    // Isolation
}
