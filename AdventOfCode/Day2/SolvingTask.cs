namespace Day2;

internal class SolvingTask
{
    public (int safeReports, int safeReportsWithDampener) Task(string[] lines)
    {
        int safeReports = 0;
        int safeReportsWithDampener = 0;

        foreach (string line in lines)
        {
            int[] levels = line.Split(' ').Select(int.Parse).ToArray();

            if (IsSafe(levels))
            {
                safeReports++;
                safeReportsWithDampener++;
            }
            else if (IsSafeWithDampener(levels))
            {
                safeReportsWithDampener++;
            }
        }

        return (safeReports, safeReportsWithDampener);
    }

    private bool IsSafe(int[] levels)
    {
        bool isIncreasing = true;
        bool isDecreasing = true;

        for (int i = 1; i < levels.Length; i++)
        {
            int diff = levels[i] - levels[i - 1];

            if (diff < -3 || diff > 3 || diff == 0)
                return false;

            if (diff < 0) isIncreasing = false;
            if (diff > 0) isDecreasing = false;
        }

        return isIncreasing || isDecreasing;
    }

    private bool IsSafeWithDampener(int[] levels)
    {
        for (int i = 0; i < levels.Length; i++)
        {
            var modifiedLevels = levels.Where((_, index) => index != i).ToArray();

            if (IsSafe(modifiedLevels))
                return true;
        }

        return false;
    }
}
