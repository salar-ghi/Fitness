namespace Domain.Models;

public class WorkoutEquipment : BaseEntity<int>
{
    public required int WorkoutId { get; set; } = default(int);
    //public Workout workout { get; set; } = null!;
    public required int EquipmentId { get; set; } = default(int);
    //public Equipment Equipment { get; set; } = null!;
}
