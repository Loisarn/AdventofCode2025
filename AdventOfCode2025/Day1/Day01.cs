using System.Runtime.CompilerServices;

namespace AdventOfCode2025;

public static class Day1
{
    public static void Run()
    {
        Console.WriteLine("=== Day 1 ===");

        var lines = File.ReadAllLines("Day1/input.txt");

        int position = 50;
        int zeroCount = 0;

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            continue;

            char dir = line[0];
            int amount = int.Parse(line[1..]);

            if (dir == 'R')
            {
                position = (position + amount) % 100;
            }
            else if (dir == 'L')
            {
                position = (position - amount % 100 + 100) % 100;
            }

            if (position == 0)
            {
                zeroCount++;
            }
            Console.WriteLine($"The password is: {zeroCount}");
        }
    }
}