namespace Domain.Models;

public class Body : BaseEntity<int, Body>
{
    public string Name { get; set; } = null!;
    public string ImgUrl { get; set; } = default!;
    public string Description { get; set; }
    public int? ParentId { get; set; }
    public string GroupName { get; set; }



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
