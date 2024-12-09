using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

namespace adventofcode2024.Day6;

public static class Solver
{
    private enum Direction { Up, Down, Left, Right }

    private readonly record struct Coordinate(int X, int Y)
    {
        public Coordinate NextInDirection(Direction direction)
        {
            return direction switch
            {
                Direction.Up    => this with { Y = Y + 1 },
                Direction.Right => this with { X = X + 1 },
                Direction.Down  => this with { Y = Y - 1 },
                Direction.Left  => this with { X = X - 1 },
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }

    private class Map(int height, int width, IEnumerable<Coordinate> obstacles)
    {
        private int Height => height;
        private int Width => width;
        public ImmutableHashSet<Coordinate> Obstacles { get; } = obstacles.ToImmutableHashSet();

        public bool IsInBounds(Coordinate location) => location.X >= 1 && location.X <= Width && location.Y >= 1 && location.Y <= Height;
    }

    private class Guard(Coordinate initialLocation, Map map, Direction initialDirection = Direction.Up)
    {
        private Coordinate Location { get; set; } = initialLocation;
        private Direction Direction { get; set; } = initialDirection;
        private Map Map => map;

        private void Rotate()
        {
            Direction = Direction switch
            {
                Direction.Up    => Direction.Right,
                Direction.Right => Direction.Down,
                Direction.Down  => Direction.Left,
                Direction.Left  => Direction.Up,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private bool IsFacingObstacle()
        {
            var nextLocation = Location.NextInDirection(Direction);
            return Map.Obstacles.Contains(nextLocation);
        }

        private void Advance()
        {
            Location = Location.NextInDirection(Direction);
        }

        public ImmutableHashSet<Coordinate> Patrol()
        {
            var visited = new HashSet<Coordinate>();

            while (Map.IsInBounds(Location))
            {
                visited.Add(Location);

                while (IsFacingObstacle())
                {
                    Rotate();
                }

                Advance();
            }

            return visited.ToImmutableHashSet();
        }

        public bool IsTrapped()
        {
            var visited = new HashSet<Tuple<Coordinate, Direction>>();

            while (Map.IsInBounds(Location))
            {
                var locationAndDirection = Tuple.Create(Location, Direction);
                if (!visited.Add(locationAndDirection)) return true;
                while (IsFacingObstacle())
                {
                    Rotate();
                }
                Advance();
            }

            return false;
        }
    }

    public static long SolvePartOne(string input)
    {
        var lines = input.Split('\n');
        var height = lines.Length;
        var width = lines[0].Length;
        var obstacles = new List<Coordinate>();
        var guardLocation = new Coordinate(0, 0);

        for (var i = 0; i < height; i++)
        {
            for (var j = 0; j < width; j++)
            {
                switch (lines[i][j])
                {
                    case '#':
                        obstacles.Add(new Coordinate(j + 1, height - i));
                        break;
                    case '^':
                        guardLocation = new Coordinate(j + 1, height - i);
                        break;
                }
            }
        }

        var map = new Map(height, width, obstacles);
        var guard = new Guard(guardLocation, map);

        return guard.Patrol().Count;
    }

    public static int SolvePartTwo(string input)
    {
        var lines = input.Split('\n');
        var height = lines.Length;
        var width = lines[0].Length;
        var trials = new List<Guard>();

        for (var i = 0; i < height; i++)
        {
            for (var j = 0; j < width; j++)
            {
                if (lines[i][j] != '.') continue;

                var newLine = lines[i].ToCharArray();
                newLine[j] = '#';
                var newLines = lines.Take(i).Concat([new string(newLine)]).Concat(lines.Skip(i+1).Select(x => x)).ToArray();

                var obstacles = new List<Coordinate>();
                var guardLocation = new Coordinate(0, 0);

                for (var k = 0; k < height; k++)
                {
                    for (var l = 0; l < width; l++)
                    {
                        switch (newLines[k][l])
                        {
                            case '#':
                                obstacles.Add(new Coordinate(l + 1, height - k));
                                break;
                            case '^':
                                guardLocation = new Coordinate(l + 1, height - k);
                                break;
                        }
                    }
                }

                var map = new Map(height, width, obstacles);
                var guard = new Guard(guardLocation, map);
                trials.Add(guard);
            }
        }

        var counter = 1;
        return trials.Count(guard =>
        {
            Console.WriteLine("trial: {0}", counter++);
            return guard.IsTrapped();
        });
    }
}
