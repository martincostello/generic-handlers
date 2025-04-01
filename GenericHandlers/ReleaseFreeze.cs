namespace GenericHandlers;

public sealed class ReleaseFreeze
{
    public string Reason { get; set; } = string.Empty;

    public DayOfWeek Day { get; set; }

    public string TimeZone { get; set; } = string.Empty;

    public TimeOnly From { get; set; }

    public TimeOnly To { get; set; }
}
