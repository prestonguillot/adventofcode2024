using System.Collections.Immutable;

namespace adventofcode2024.Day7;

public static class Solver
{
    private readonly record struct Equation(long Result, ImmutableList<long> Operands)
    {
        public static Equation GenerateFrom(string line)
        {
            var result = long.Parse(new string(line.TakeWhile(x => x != ':').ToArray()));
            var operands = new string(line.SkipWhile(x => x != ':').Skip(2).ToArray()).Split(' ').Select(long.Parse);
            return new Equation(result, operands.ToImmutableList());
        }

        private long Apply(IList<Operator> operators)
        {
            //yucky
            var i = 0;
            return Operands.Aggregate((x, y) =>
            {
                return operators[i++] switch
                {
                    Operator.Plus =>  x + y,
                    Operator.Times => x * y,
                    Operator.Concatenate => long.Parse(x.ToString() + y.ToString()),
                };
            });
        }

        public bool IsCorrectFor(IEnumerable<Operator> operators) => Apply(operators.ToList()) == Result;
    };

    private enum Operator
    {
        Plus,
        Times,
        Concatenate
    }

    private static IEnumerable<IEnumerable<Operator>> GenerateOperators(long num, ImmutableList<Operator> operators)
    {
        if (num == 1)
            foreach (var op in operators) yield return [op];
        else
        {
            foreach (var rec in GenerateOperators(num - 1, operators))
            {
                var ops = rec.ToArray();
                foreach (var op in operators) yield return new[] {op}.Concat(ops);
            }
        }
    }

    public static long SolvePartOne(string input)
    {
        var equations = input.Split('\n').Select(Equation.GenerateFrom);
        var validOperators = new[] {Operator.Plus, Operator.Times}.ToImmutableList();

        return equations.Where(equation => GenerateOperators(equation.Operands.Count - 1, validOperators).Any(equation.IsCorrectFor))
                        .Select(x => x.Result)
                        .Sum();
    }

    public static long SolvePartTwo(string input)
    {
        var equations = input.Split('\n').Select(Equation.GenerateFrom);
        var validOperators = new[] {Operator.Plus, Operator.Times, Operator.Concatenate}.ToImmutableList();

        return equations.Where(equation => GenerateOperators(equation.Operands.Count - 1, validOperators).Any(equation.IsCorrectFor))
                        .Select(x => x.Result)
                        .Sum();
    }
}
