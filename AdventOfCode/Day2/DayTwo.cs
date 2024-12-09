using Common.Abstracts;

namespace Day2;

public class DayTwo : BaseDayProject
{
    public DayTwo(string[] dataSource) : base(dataSource)
    {
    }

    protected override void Execute()
    {
        var task = new SolvingTask();
        var result = task.Task(DataSource);
        Console.WriteLine($"Number of safe reports: {result.safeReports}");
        Console.WriteLine($"Number of safe reports with Problem Dampener: {result.safeReportsWithDampener}");

    }
}
