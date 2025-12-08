using AdventOfCode2025;

Console.WriteLine("Choose day (e.g. 1): ");
var input = Console.ReadLine();

if (int.TryParse(input, out int day))
{
    switch (day)
    {
        case 1: Day1.Run(); break;
        // case 2: Day2.Run(); break;
        // case 3: Day3. Run(); break;
        default: Console.WriteLine("Day not implemented"); break;
    }
}
else
{
    Console.WriteLine("Wrong choice");
}