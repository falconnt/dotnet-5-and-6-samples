// Main program

Console.WriteLine("Hello, .NET 5 and 6");

Console.WriteLine("---- 5: Records ----");

Man man1 = new("Peter", "Pan", 12);
Man man2 = new("Captain", "Hook", 42);

Console.WriteLine(man1);
Console.WriteLine(man2);

Man man3 = man1;

Console.WriteLine(man3);

Console.WriteLine(man3 == man1);

Console.WriteLine("---- 5: Pattern matching ----");

Console.WriteLine(man3 is Man);
Console.WriteLine(man3 is Woman);
Console.WriteLine(man3.Age is > 10 and <40);
Console.WriteLine(man3 is Person);

Console.WriteLine("---- 6: Record structs ----");

var p1 = new Point(1, 1, 1);
var p2 = p1 with { X = 2 };
var p3 = p2 with { Y = 2 };
var p4 = p3 with { Z = 2 };

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);
Console.WriteLine(p4);

Console.WriteLine("---- 5/6: Property pattern ----");

DateOnly date = new(2021, 11, 23);
for (int i = date.Day; i <= 30; i++)
{
    Console.WriteLine($"Is christmas day ({date.Day}-{date.Month+1}): {date.IsChristmas()}");
    date = date.AddDays(1);
}