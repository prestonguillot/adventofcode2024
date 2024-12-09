namespace adventofcode2024.Day9;

public static class Solver
{
    public static long SolvePartOne(string input)
    {
        var expanded = input.Aggregate((value: string.Empty, fileID: 0, isFreeSpace: false), (cur, c) =>
        {
            var asNum = int.Parse(c.ToString());
            var additive = string.Concat(Enumerable.Repeat(cur.isFreeSpace ? "." : cur.fileID.ToString(), asNum));
            var fileId = cur.isFreeSpace ? cur.fileID : cur.fileID + 1;
            return (cur.value + additive, fileId, !cur.isFreeSpace);
        }).value;

        Console.WriteLine(input);
        Console.WriteLine(expanded);

        var compacted = expanded.Aggregate((value: string.Empty, i: 0, j: expanded.Length - 1), (cur, c) =>
        {
            if (cur.j < cur.i) return cur;
            if (c != '.') return (cur.value + c, cur.i + 1, cur.j);
            var j = cur.j;
            while(expanded[j] == '.') j--;
            return (cur.value + expanded[j], cur.i + 1, j - 1);
        }).value;

        Console.WriteLine(compacted);

        return compacted.Aggregate((value: 0L, i: 0L), (cur, c) => (cur.value + long.Parse(c.ToString()) * cur.i, cur.i + 1)).value;
    }

    public static long SolvePartTwo(string input)
    {
        throw new NotImplementedException();
    }
}
