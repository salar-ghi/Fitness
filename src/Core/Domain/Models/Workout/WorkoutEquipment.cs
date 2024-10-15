namespace Domain.Models;

public class WorkoutEquipment : BaseEntity<int, WorkoutEquipment>
{
    public int WorkoutId { get; set; } = default(int);
    //public Workout workout { get; set; } = null!;

    public int EquipmentId { get; set; } = default(int);
    //public Equipment Equipment { get; set; } = null!;
}
