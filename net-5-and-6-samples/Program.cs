// Main program

Console.WriteLine("Hello, .NET 5 and 6");

// global usings
var json = JsonConvert.SerializeObject(new { test = "hi" });

Console.WriteLine("");
Console.WriteLine("---- 5: Records ----");

Man man1 = new("Peter", "Pan", 12);
Man man2 = new("Captain", "Hook", 42);

Console.WriteLine(man1);
Console.WriteLine(man2);

// copy man1 values into new man3 record
Man man3 = man1;
Man man4 = man3 with { Age = man3.Age + 10 };

Console.WriteLine(man3);

// check if records are equal (they should be)
Console.WriteLine($"man3 == man1: {man3 == man1}");
Console.WriteLine($"man3 == man4: {man3 == man4}");

Console.WriteLine("");
Console.WriteLine("---- 5: Pattern matching ----");

Console.WriteLine($"man3 is Man: {man3 is Man}");
Console.WriteLine($"man3 is Woman: {man3 is Woman}");
// check if age (12) is between 10 and 40
Console.WriteLine($"man3.Age is > 10 and <40: {man3.Age is > 10 and <40}");
Console.WriteLine($"man3 is Person: {man3 is Person}");

Console.WriteLine("");
Console.WriteLine("---- 6: Record structs ----");

// copy previous point values with altered values
var p1 = new Point(1, 1, 1);
var p2 = p1 with { X = 2 };
var p3 = p2 with { Y = 2 };
var p4 = p3 with { Z = 2 };

p4.Z += 1;

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);
Console.WriteLine(p4);

Console.WriteLine("");
Console.WriteLine("---- 5/6: Property pattern ----");

DateOnly date = new(2021, 12, 23);
for (int i = date.Day; i <= 31; i++)
{
    Console.WriteLine($"Is christmas day ({date.Day}-{date.Month}): {date.IsChristmas()}");
    date = date.AddDays(1);
}

Console.WriteLine("");
Console.WriteLine("---- 5/6: Switch pattern ----");

date = new(2021, 7, 1);
for (int i = date.Day; i <= 10; i++)
{
    Console.WriteLine(date.ToHumanString());
    date = date.AddDays(1);
}
