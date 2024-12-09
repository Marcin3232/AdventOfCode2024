using Common.Abstracts;
using FileManager;

namespace Day1;

public class DayOne : BaseDayProject
{
    protected override void Execute()
    {
        FileSelector fileSelector = new FileSelector();
        var input = fileSelector.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "data.txt"));
        if (input is not string[] lines)
        {
            Console.WriteLine("The data provided is incorrect");
            return;
        }

        var task = new SolvingTask(input);
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
