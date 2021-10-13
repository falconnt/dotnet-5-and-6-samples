namespace net_5_and_6_samples;

public static class DateOnlyExtensions
{
    // check if date is a day in christmas time (Dec, 25th and 26th)
    // the pattern matching shows in the Day, which allows 2 values to be checked at once
    public static bool IsChristmas(this DateOnly date) => date is { Month: 12, Day: 25 or 26 };

    public static string ToHumanString(this DateOnly date) => (date) switch
    {
        { Month: 1, Day: 1 } => "New Year's day",
        { Month: 7, Day: 4 } => "4th of July",
        { Month: 9, Day: 11 } => "9/11",
        { Month: 12, Day: 25 } or { Month: 12, Day: 26 } => "Christmas time",
        _ => date.ToString("MMM d")
    };
}