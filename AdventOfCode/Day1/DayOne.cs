using Common.Abstracts;

namespace Day1;

public class DayOne : BaseDayProject
{
    public DayOne(string[] dataSource) : base(dataSource)
    {
    }

    protected override void Execute()
    {
        var task = new SolvingTask(DataSource);
        var result = task.Task();

        if (result is null)
            Console.WriteLine($"Input data is incorrect");
        else
        {
            Console.WriteLine($"Total distance {result?.totalDistance}");
            Console.WriteLine($"Similar score {result?.similarityScore}");
        }
    }
}
