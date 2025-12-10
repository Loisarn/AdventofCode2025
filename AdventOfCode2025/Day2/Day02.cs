using System.Net.Sockets;

namespace AdventOfCode2025;

public static class Day2
{
    public static void Run()
    {
        string input = File.ReadAllText("Day2/input.txt");
        var ranges = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        long sum = 0;

        foreach (var range in ranges)
        {
            var parts = range.Split('-');
            long start = long.Parse(parts[0]);
            long end = long.Parse(parts[1]);

            for (long id = start; id <= end; id++)
            {
                if (IsRepeatedSequence(id))
                sum += id;
            }
        }
        Console.WriteLine($"Part 2: {sum}");
    }

    private static bool IsRepeatedSequence(long id)
    {
        string s = id.ToString();
        int len = s.Length;

        for (int l = 1; l <= len / 2; l++)
        {
            if (len % l != 0)
                continue;

            string part = s.Substring(0, l);
            string repeated = string.Concat(Enumerable.Repeat(part, len / l));

            if (repeated == s)
                return true;
        }

        return false;
    }
}

    // private static bool IsDouble(long id)
    // {
    //     string s = id.ToString();
    //     if (s.Length % 2 != 0)
    //     return false;

    //     int half = s.Length / 2;
    //     return s.Substring(0, half) == s.Substring(half);
    // }
