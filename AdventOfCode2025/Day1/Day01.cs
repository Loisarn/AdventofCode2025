using System.Runtime.CompilerServices;

namespace AdventOfCode2025;

public static class Day1
{
    public static void Run()
    {
        Console.WriteLine("=== Day 1 ===");

        var lines = File.ReadAllLines("Day1/input.txt");

        int position = 50;
        long zeroCount = 0;

        foreach (var line in lines)
        {
            char dir = line[0];
            int amount = int.Parse(line[1..]);

           for (int i = 0; i < amount; i++)
            {
                position = dir == 'R'
                ? (position + 1) % 100 :
                (position - 1 + 100) % 100;

                if (position == 0)
                zeroCount++;
            }
        }

        Console.WriteLine($"Part two: {zeroCount}");
    }
}