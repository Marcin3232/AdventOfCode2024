using Common.Abstracts;
using FileManager;

namespace Day2;

public class DayTwo : BaseDayProject
{
    protected override void Execute()
    {
        FileSelector fileSelector = new FileSelector();
        var input = fileSelector.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "input.txt"));
        if (input is not string[] lines)
        {
            Console.WriteLine("The data provided is incorrect");
            return;
        }

        var task = new SolvingTask();
        var result = task.Task(lines);
        Console.WriteLine($"Number of safe reports: {result.safeReports}");
        Console.WriteLine($"Number of safe reports with Problem Dampener: {result.safeReportsWithDampener}");

    }
}
