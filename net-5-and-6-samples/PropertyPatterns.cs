namespace net_5_and_6_samples;

public static class DateOnlyExtensions
{
    public static bool IsChristmas(this DateOnly date) => date is { Month: 11, Day: 25 or 26 };
}