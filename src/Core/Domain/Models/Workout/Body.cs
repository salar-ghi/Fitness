namespace Domain.Models;

public class Body : BaseEntity<int>
{
    public required string Name { get; set; } = null!;
    public string ImgUrl { get; private set; } = default!;
    public int Parent { get; private set; }



    // Chest
    // Forearms
    // Lats
    // Middle Back
    // Lower Back
    // Neck
    // Quadriceps
    // Hamstrings

    // Calves
    // Traps

    // Shoulders
    // Abdominals
    // Glutes
    // Biceps
    // Adductors
    // Abductors


}
