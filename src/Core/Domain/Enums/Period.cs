namespace Domain.Enums;

public enum Period
{
    Daily = 1,
    Weekly = 2,     // 7 days
    Monthly = 3,    // 30 days => 4 weeks
    Quarterly = 4,  // 3 months => 16 weeks => 90 days
    custom = 0,  
}
