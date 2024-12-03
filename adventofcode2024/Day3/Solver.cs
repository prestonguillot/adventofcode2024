using System.Text.RegularExpressions;

namespace adventofcode2024.Day3;

public static class Solver
{
    public static long SolvePartOne(string input)
    {
        return Regex.Matches(input, @"mul\((\d+)\,(\d+)\)")
                    .Select(match => (long.Parse(match.Groups[1].Value), long.Parse(match.Groups[2].Value)))
                    .Select(pair => pair.Item1 * pair.Item2)
                    .Sum();
    }
    
    public static long SolvePartTwo(string input)
    {
        var matches = Regex.Matches(input, @"mul\((\d+)\,(\d+)\)|do\(\)|don\'t\(\)");
        var enabled = true;
        var total = 0L;

        foreach (Match match in matches)
        {
            if(match.Value.StartsWith("mul") && enabled) total += long.Parse(match.Groups[1].Value) * long.Parse(match.Groups[2].Value);
            else if (match.Value == @"don't()") enabled = false;
            else if (match.Value == @"do()") enabled = true;
        }
        
        return total;
    }
}