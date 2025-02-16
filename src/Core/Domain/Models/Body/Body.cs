namespace Domain.Models;

public class Body : BaseEntity<int, Body>
{
    public string MuscleName { get; set; } = null!;
    public string ImgUrl { get; set; } = default!;
    public int? ParentId { get; set; }



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
