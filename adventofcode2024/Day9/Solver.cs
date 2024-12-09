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
            if (str != ".") return (cur.value.Concat([str]), cur.i + 1, cur.j);
            return (cur.value.Concat([expanded[cur.j]]), cur.i + 1, expanded.Take(cur.j).ToList().FindLastIndex(x => x != "."));
        }).value.ToArray();
        Console.WriteLine(string.Join("", compacted));

        return compacted.Aggregate((value: 0L, i: 0L), (cur, c) => (cur.value + long.Parse(c) * cur.i, cur.i + 1)).value;
    }

    public static long SolvePartTwo(string input)
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

        for (var i = expanded.Count; i >= 0;)
        {
            var remaining = expanded.Take(i).ToList();
            var fileBlackLastIndex = remaining.FindLastIndex(x => x != ".");
            if (fileBlackLastIndex == -1) break;
            var fileBlockFirstIndex = remaining.FindIndex(x => x == expanded[fileBlackLastIndex]);
            var fileLength = fileBlackLastIndex - fileBlockFirstIndex + 1;
            int? contiguousFreeSpaces = null;
            int? freeSpaceFirstIndex = null;

            for (var j = 0; j < fileBlockFirstIndex; j++)
            {
                if (expanded[j] == ".")
                {
                    contiguousFreeSpaces = (contiguousFreeSpaces ?? 0) + 1;
                    freeSpaceFirstIndex ??= j;

                    if (contiguousFreeSpaces != fileLength) continue;

                    for (int k = freeSpaceFirstIndex.Value, l = fileBlockFirstIndex; k <= j; l++, k++)
                    {
                        expanded[k] = expanded[l];
                        expanded[l] = ".";
                    }

                    break;
                }

                contiguousFreeSpaces = null;
                freeSpaceFirstIndex = null;
            }

            i =  expanded.Count - (expanded.Count - fileBlockFirstIndex);
        }

        Console.WriteLine(string.Join("", expanded));

        return expanded.Aggregate((value: 0L, i: 0L), (cur, c) => long.TryParse(c, out _) ? (cur.value + long.Parse(c) * cur.i, cur.i + 1) : (cur.value, cur.i + 1)).value;
    }
}
