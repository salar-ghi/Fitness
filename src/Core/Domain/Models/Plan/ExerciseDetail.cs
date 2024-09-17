namespace Domain.Models;

public class ExerciseDetail : BaseEntity<Guid, ExerciseDetail>
{
    public Guid ExerciseId { get; set; }
}
