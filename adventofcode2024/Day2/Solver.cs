namespace adventofcode2024.Day2;

public class Solver
{
    private readonly struct Input(IEnumerable<IEnumerable<int>> report)
    {
        public IReadOnlyList<IReadOnlyList<int>> Report { get; } = report.Select(x => x.ToList()).ToList();

        public static Input ParseFrom(string input) =>
            new Input(input.Split('\n')
                                 .Select(line => line.Split(' ')
                                                          .Select(int.Parse)
                                                          .ToList())
                                 .ToList());
    }
    
    private enum Direction
    {
        Increasing,
        Decreasing,
        Same,
    }

    private readonly struct Difference(Direction direction, uint magnitude)
    {
        public readonly Direction Direction { get; } = direction;
        public readonly uint Magnitude { get; } = magnitude;

        public bool IsSafe(Direction? previousDirection = null) => Direction != Direction.Same && (previousDirection ?? Direction) == Direction && Magnitude <= 3;
        
        public static Difference CalculateDifference(int left, int right)
        {
            Direction direction;

            if (right > left) direction = Direction.Increasing;
            else if (right < left) direction = Direction.Decreasing;
            else direction = Direction.Same;
        
            var magnitude = (uint)int.Abs(right - left);
        
            return new Difference(direction, magnitude);
        }
    }

    public static int SolvePartOne(string input)
    {
        var inputs = Input.ParseFrom(input);

        var results = inputs.Report.Select(readings =>
        {
            Direction? previousDirection = null;
            
            for (var i = 1; i < readings.Count; i++)
            {
                var left = readings[i - 1];
                var right = readings[i];
                var difference = Difference.CalculateDifference(left, right);
                if (!difference.IsSafe(previousDirection)) return 0;
                previousDirection = difference.Direction;
            }

            return 1;
        });

        return results.Sum();
    }

    public static int SolvePartTwo(string input)
    {
        var inputs = Input.ParseFrom(input);
        var safe = 0;
        
        Func<IReadOnlyList<int>, bool> isSafe = readings =>
        {
            Direction? previousDirection = null;
            
            for (var i = 1; i < readings.Count; i++)
            {
                var left = readings[i - 1];
                var right = readings[i];
                var difference = Difference.CalculateDifference(left, right);
                if (!difference.IsSafe(previousDirection)) return false;
                previousDirection = difference.Direction;
            }

            return true;
        };

        foreach (var report in inputs.Report)
        {
            if (isSafe(report)) safe++;
            else
            {
                for (var i = 0; i < report.Count; i++)
                {
                    var reportCopy = report.ToList();
                    reportCopy.RemoveAt(i);
                    if (!isSafe(reportCopy)) continue;
                    Console.WriteLine("{1} - [{0}]", string.Join(", ", report), i);
                    safe++;
                    break;
                }
            }
        }

        return safe;
    }
}