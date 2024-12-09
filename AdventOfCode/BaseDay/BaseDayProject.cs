using Common.Interfaces;
using System.Diagnostics;

namespace Common.Abstracts;

public abstract class BaseDayProject : IDayProject
{
    public string[] DataSource { get; init; }

    protected BaseDayProject(string[] dataSource)
    {
        DataSource = dataSource;
    }

    public void Start()
    {
        var stopwatch = Stopwatch.StartNew();
        Execute();
        stopwatch.Stop();
        var elapsed = stopwatch.Elapsed;
        Console.WriteLine($"Execution time: {elapsed:hh\\:mm\\:ss\\.fff} ms");
    }

    protected abstract void Execute();
}
