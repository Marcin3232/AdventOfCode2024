using System.Text.RegularExpressions;

namespace Day3;

internal class SolvingTask
{
    private readonly string _patternTaskOne = @"mul\(\s*(\d{1,3})\s*,\s*(\d{1,3})\s*\)";
    private readonly string _patternTaskTwo = @"mul\((\d+),(\d+)\)|do\(\)|don't\(\)";

    public (int sumOne, int sumTwo) Task(string[] data)
    {
        var memory = string.Join(string.Empty, data);
        var matchesTaskOne = GetMatches(_patternTaskOne, memory);
        var matchesTaskTwo = GetMatches(_patternTaskTwo, memory);


        return (MultiplicationSum(matchesTaskOne), MultiplicationSum(matchesTaskTwo));
    }

    private MatchCollection GetMatches(string _pattern, string data)
    {
        var regex = new Regex(_pattern);
        return regex.Matches(data);
    }

    private int MultiplicationSum(MatchCollection matches)
    {
        int sum = 0;
        bool? isEnabled = null;

        foreach (Match match in matches)
        {
            if (match.Value.StartsWith("do()"))
                isEnabled = true;
            else if (match.Value.StartsWith("don't()"))
                isEnabled = false;
            else if (match.Groups[1].Success && match.Groups[2].Success)
            {
                if (isEnabled == true || isEnabled is null)
                {
                    int x = int.Parse(match.Groups[1].Value);
                    int y = int.Parse(match.Groups[2].Value);

                    sum += x * y;
                }
            }
        }

        return sum;
    }
}
