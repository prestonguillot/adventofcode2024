using System.Collections.Immutable;

namespace adventofcode2024.Day5;

public static class Solver
{
    private static InputData _input;
    private readonly struct InputData(ImmutableDictionary<int, ImmutableHashSet<int>> orderingRules, ImmutableList<ImmutableList<int>> pageLists)
    {
        public ImmutableDictionary<int, ImmutableHashSet<int>> OrderingRules { get; } = orderingRules;
        public ImmutableList<ImmutableList<int>> PageLists { get; } = pageLists;

        public static InputData From(string input)
        {
            var lines = input.Split('\n');
            var ruleLines = lines.Where(line => line.Contains('|'));
            var instructionLines = lines.Where(line => line.Contains(','));

           var rules = ruleLines
                .Select(line => line.Split('|'))
                .Select(chars => (preceedingPageNumber: int.Parse(chars[0]), followingPageNumber: int.Parse(chars[1])))
                .GroupBy(rule => rule.preceedingPageNumber)
                .ToImmutableDictionary(group => group.Key,
                                       group => group.Select(rule => rule.followingPageNumber).ToImmutableHashSet());

            var instructions = instructionLines.Select(line => line.Split(',').Select(int.Parse).ToImmutableList()).ToImmutableList();

            return new InputData(rules, instructions);
        }
    }

    public static long SolvePartOne(string input)
    {
        _input = InputData.From(input);

        return _input.PageLists
                     .Where(PageListIsValid)
                     .Select(pageList => pageList[pageList.Count / 2])
                     .Sum();
    }

    public static long SolvePartTwo(string input)
    {
        _input = InputData.From(input);

        var badPageLists = _input.PageLists.Where(pageList => !PageListIsValid(pageList));

       return badPageLists.Select(badList =>
        {
            var workingCopy = badList.ToList();

            for (var i = 0; i < badList.Count; )
            {
                var curPage = workingCopy[i];
                var badPages = workingCopy.Skip(i+1).ToHashSet().Except(_input.OrderingRules.GetValueOrDefault(curPage, ImmutableHashSet<int>.Empty)).ToList();

                if (badPages.Any())
                {
                    var newPosition = badPages.Select(x => workingCopy.IndexOf(x)).Max();
                    workingCopy.RemoveAt(i);
                    workingCopy.Insert(newPosition, curPage);
                }
                else
                {
                    i++;
                }
            }

            return workingCopy;
        })
                    .Select(pageList => pageList[pageList.Count / 2])
                    .Sum();

       return 1;
    }

    private static bool PageListIsValid(IList<int> pageList)
    {
        return pageList.Where((pageNumber, i) => i == pageList.Count - 1 ||
                                                       _input.OrderingRules.ContainsKey(pageNumber) &&
                                                       _input.OrderingRules[pageNumber].IsSupersetOf(pageList.Skip(i+1)))
                       .Count() == pageList.Count;
    }
}
