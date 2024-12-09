using System.Collections.Immutable;

namespace adventofcode2024.Day8;

public class Solver
{
    private readonly record struct Map(int Height, int Width, ImmutableDictionary<char, ImmutableHashSet<Coordinate>> Antennas)
    {
        public static Map From(string input)
        {
            var lines = input.Split('\n');
            var height = lines.Length;
            var width = lines[0].Length;
            var antennas = new Dictionary<char, List<Coordinate>>();

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    if (lines[i][j] == '.') continue;
                    var antennaType = lines[i][j];
                    var coordinate = new Coordinate(j + 1, height - i);
                    if(!antennas.TryAdd(antennaType, [coordinate])) antennas[antennaType].Add(coordinate);
                }
            }

            return new Map(height, width, antennas.ToImmutableDictionary(x => x.Key, x => x.Value.ToImmutableHashSet()));
        }

        public bool IsInBounds(Coordinate location) => location.X >= 1 && location.X <= Width && location.Y >= 1 && location.Y <= Height;
    }

    private readonly record struct Coordinate(int X, int Y);

    public static long SolvePartOne(string input)
    {
        var map = Map.From(input);
        var antiNodes = new HashSet<Coordinate>();

        foreach (var antennaArray in map.Antennas)
        {
            foreach (var antenna in antennaArray.Value)
            {
                foreach (var otherAntenna in antennaArray.Value.Except([antenna]))
                {
                    var distance = (X: otherAntenna.X - antenna.X, Y:otherAntenna.Y - antenna.Y);
                    var antiNode = new Coordinate(otherAntenna.X + distance.X, otherAntenna.Y + distance.Y);
                    if (map.IsInBounds(antiNode)) antiNodes.Add(antiNode);
                }
            }
        }

        return antiNodes.Count;
    }

    public static long SolvePartTwo(string input)
    {
        var map = Map.From(input);
        var antiNodes = new HashSet<Coordinate>();

        foreach (var antennaArray in map.Antennas)
        {
            foreach (var antenna in antennaArray.Value)
            {
                if (antennaArray.Value.Count > 1) antiNodes.Add(antenna);

                foreach (var otherAntenna in antennaArray.Value.Except([antenna]))
                {
                    var distance = (X: otherAntenna.X - antenna.X, Y:otherAntenna.Y - antenna.Y);
                    var antiNode = new Coordinate(otherAntenna.X + distance.X, otherAntenna.Y + distance.Y);

                    while (map.IsInBounds(antiNode))
                    {
                        antiNodes.Add(antiNode);
                        antiNode = new Coordinate(antiNode.X + distance.X, antiNode.Y + distance.Y);
                    }
                }
            }
        }

        return antiNodes.Count;
    }
}
