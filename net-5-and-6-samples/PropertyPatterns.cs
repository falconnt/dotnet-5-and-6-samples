namespace net_5_and_6_samples;

public static class DateOnlyExtensions
{
    // check if date is a day in christmas time (Dec, 25th and 26th)
    // the pattern matching shows in the Day, which allows 2 values to be checked at once
    public static bool IsChristmas(this DateOnly date) => date is { Month: 11, Day: 25 or 26 };
}