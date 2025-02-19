namespace Domain.Models;

public class PlanGoals : BaseEntity<long, PlanGoals>
{
    public Guid PlanId { get; set; }
    //public virtual Plan Plan { get; set; }


    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public float StartWeight { get; set; }
    public float EndWeight { get; set; }
    public float StartOverWeight { get; set; }
    public float EndOverWeight { get; set; }
    public PhysiqueType PhysiqueGoal { get; set; }


    public int StartMeasurements { get; set; } // ???  I don't know why do I set it here
    public int EndMeasurements { get; set; }
}
