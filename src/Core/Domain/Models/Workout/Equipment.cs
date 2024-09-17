namespace Domain.Models;

public class Equipment : BaseEntity<int, Equipment>
{
    public required string Name { get; set; } = null!;
    public string ImgUrl { get; set; } = default!;
    public EquipmentType EquipmentType { get; set; }

    //public int? WorkoutId { get; private set; }
    //public required Workout Workout { get; set; } = null!;

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
