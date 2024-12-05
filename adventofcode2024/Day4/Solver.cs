namespace adventofcode2024.Day4;

public static class Solver
{
    public static int SolvePartOne(string input)
    {
        var grid = input.Split('\n').Select(x => x.ToCharArray().ToList()).ToList();

        var exes =
            grid.SelectMany((line, i) => line.Select((c, j) =>  (c, i, j)))
                .Where(x => x.c == 'X');

        var xmases =
            exes.SelectMany(x =>
            {
                var (_, i, j) = x;

                var right     = j + 3 < grid[i].Count                       ? string.Concat([grid[i][j], grid[i][j+1], grid[i][j+2], grid[i][j+3]])       : string.Empty;
                var left      = j - 3 >= 0                                  ? string.Concat([grid[i][j], grid[i][j-1], grid[i][j-2], grid[i][j-3]])       : string.Empty;
                var down      = i + 3 < grid.Count                          ? string.Concat(grid[i][j], grid[i+1][j], grid[i+2][j], grid[i+3][j])         : string.Empty;
                var up        = i - 3 >= 0                                  ? string.Concat([grid[i][j], grid[i-1][j], grid[i-2][j], grid[i-3][j]])       : string.Empty;
                var upRight   = i - 3 >= 0 && j + 3 < grid[i].Count         ? string.Concat([grid[i][j], grid[i-1][j+1], grid[i-2][j+2], grid[i-3][j+3]]) : string.Empty;
                var downRight = i + 3 < grid.Count && j + 3 < grid[i].Count ? string.Concat([grid[i][j], grid[i+1][j+1], grid[i+2][j+2], grid[i+3][j+3]]) : string.Empty;
                var upLeft    = i - 3 >= 0 && j - 3 >= 0                    ? string.Concat([grid[i][j], grid[i-1][j-1], grid[i-2][j-2], grid[i-3][j-3]]) : string.Empty;
                var downLeft  = i + 3 < grid.Count && j - 3 >= 0            ? string.Concat([grid[i][j], grid[i+1][j-1], grid[i+2][j-2], grid[i+3][j-3]]) : string.Empty;

                return new[] {right, left, down, up, upRight, downRight, upLeft, downLeft};
            }).Where(word => word == "XMAS");

        return xmases.Count();
    }

    public static int SolvePartTwo(string input)
    {
        var grid = input.Split('\n').Select(x => x.ToCharArray().ToList()).ToList();

        var ayys =
            grid.SelectMany((line, i) => line.Select((c, j) =>  (c, i, j)))
                .Where(x => x.c == 'A');

        var liveMas =
            ayys.Select(x =>
            {
                var (_, i, j) = x;

                var diagonals = i - 1 >= 0 && j - 1 >= 0 && i + 1 < grid.Count && j + 1 < grid.Count
                    ? new []
                    {
                        string.Concat(grid[i-1][j-1], grid[i][j], grid[i+1][j+1]),
                        string.Concat(grid[i-1][j+1], grid[i][j], grid[i+1][j-1])
                    }
                    : Array.Empty<string>();

                return diagonals;
            }).Where(diagonals => diagonals.Count(x => x is "MAS" or "SAM") == 2);

        return liveMas.Count();
    }
}
