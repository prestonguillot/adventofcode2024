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
                Direction.Right => this with { X = X + 1},
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
        public ImmutableHashSet<Coordinate> Obstacles => obstacles.ToImmutableHashSet();

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

    public static long SolvePartTwo(string input)
    {
        throw new NotImplementedException();
    }
}
