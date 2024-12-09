using DataFactory.Interfaces;
using DataFactory.Services;

namespace DataFactory;

public class DataSourceFactory : IDataSourceFactory
{
    private readonly string _baseDirectory;

    public DataSourceFactory()
    {
        _baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
    }

    public string[]? GetData(int dayNumber)
    {
        var fileName = GetFileName(dayNumber);
        if (string.IsNullOrEmpty(fileName))
            return null;

        IDataSources dataSource = new DataSources();

        return dataSource.GetData(Path.Combine(GetPath(dayNumber), fileName));
    }

    private string GetPath(int dayNumber) =>
        Path.Combine(_baseDirectory, $"Resources/{dayNumber}");

    private string GetFileName(int dayNumber)
    {
        var path = GetPath(dayNumber);
        if (Directory.Exists(path))
        {
            string? file = Directory.GetFiles(path).FirstOrDefault();

            if (file is null)
            {
                Console.WriteLine("Dictionary is empty.");
                return string.Empty;
            }

            return file;
        }
        else
        {
            Console.WriteLine("Dictionary not exist");
            return string.Empty;
        }
    }
}
