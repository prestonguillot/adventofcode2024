namespace adventofcode2024.Day9;

public static class Solver
{
    public static long SolvePartOne(string input)
    {
        Console.WriteLine(input);

        var expanded = input.Aggregate((value: Enumerable.Empty<string>(), fileID: 0, isFreeSpace: false), (cur, c) =>
        {
            var asNum = int.Parse(c.ToString());
            var additive = Enumerable.Repeat(cur.isFreeSpace ? "." : cur.fileID.ToString(), asNum);
            var fileId = cur.isFreeSpace ? cur.fileID : cur.fileID + 1;
            return (cur.value.Concat(additive) , fileId, !cur.isFreeSpace);
        }).value.ToList();
        Console.WriteLine(string.Join("", expanded));

        var compacted = expanded.Aggregate((value: Enumerable.Empty<string>(), i: 0, j: expanded.FindLastIndex(x => x != ".")), (cur, str) =>
        {
            if (cur.j < cur.i) return cur;
            else if (str != ".") return (cur.value.Concat([str]), cur.i + 1, cur.j);
            else return (cur.value.Concat([expanded[cur.j]]), cur.i + 1, expanded.Take(cur.j).ToList().FindLastIndex(x => x != "."));
        }).value.ToArray();
        Console.WriteLine(string.Join("", compacted));

        return compacted.Aggregate((value: 0L, i: 0L), (cur, c) => (cur.value + long.Parse(c) * cur.i, cur.i + 1)).value;
    }

    public static long SolvePartTwo(string input)
    {
        throw new NotImplementedException();
    }
}
