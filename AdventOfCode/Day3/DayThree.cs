using Common.Abstracts;

namespace Day3;

public class DayThree : BaseDayProject
{
    public DayThree(string[] dataSource) : base(dataSource)
    {
    }

    protected override void Execute()
    {
        var task = new SolvingTask();
        var result = task.Task(DataSource);
        Console.WriteLine($"First task sum: {result.sumOne}");
        Console.WriteLine($"Second task sum: {result.sumTwo}");
    }
}
