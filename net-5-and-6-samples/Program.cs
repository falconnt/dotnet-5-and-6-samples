using net_5_and_6_samples;

Console.WriteLine("Hello, .NET 5 and 6");

Console.WriteLine("---- Records ----");

Man man1 = new("Peter", "Pan", 12);
Man man2 = new("Captain", "Hook", 42);

Console.WriteLine(man1);
Console.WriteLine(man2);

Man man3 = man1;

Console.WriteLine(man3);

Console.WriteLine(man3 == man1);

Console.WriteLine("---- Pattern matching ----");

Console.WriteLine(man3 is Man);
Console.WriteLine(man3 is Woman);
Console.WriteLine(man3.Age is > 10 and <40);
Console.WriteLine(man3 is Person);