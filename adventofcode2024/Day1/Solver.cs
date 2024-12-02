namespace adventofcode2024.DayOne;

public static partial class Solver
{
    private readonly partial struct Input(IEnumerable<int> left, IEnumerable<int> right)
    {
        public IReadOnlyList<int> Left { get; } = left.ToList();
        public IReadOnlyList<int> Right { get; } = right.ToList();

        public static Input ParseFrom(string input)
        {
            var lefts = new List<int>();
            var rights = new List<int>();
            
            foreach (var line in input.Split('\n'))
            {
                var matches = DigitsRegex().Matches(line);
                if (matches.Count == 0) continue;
                if (matches.Count != 2) throw new Exception("something has gone horribly wrong");
                lefts.Add(int.Parse(matches[0].Value));
                rights.Add(int.Parse(matches[1].Value));
            }

            return new Input(lefts, rights);
        }

        [System.Text.RegularExpressions.GeneratedRegex(@"\d+")]
        private static partial System.Text.RegularExpressions.Regex DigitsRegex();
    }
    
    public static long SolvePartOne(string input)
    {
        var inputs = Input.ParseFrom(input);
        var lefts = inputs.Left.OrderBy(x => x);
        var rights = inputs.Right.OrderBy(x => x);
        return lefts.Zip(rights, (left, right) => int.Abs(left - right)).Sum();
    }

    public static long SolvePartTwo(string input)
    {
        var inputs = Input.ParseFrom(input);
        var rightCounts = new Dictionary<int, int>();

        foreach (var number in inputs.Right)
            if (!rightCounts.TryAdd(number, 1))
                rightCounts[number]++;

        return inputs.Left.Select(x => x * rightCounts.GetValueOrDefault(x, 0)).Sum();
    }
}