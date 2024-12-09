using DataFactory.Interfaces;
using FileManager;

namespace DataFactory.Services;

public class DataSources : IDataSources
{
    public string[]? GetData(string path)
    {
        FileSelector fileSelector = new FileSelector();
        var input = fileSelector.ReadAllLines(path);

        if (input is not string[] lines)
        {
            Console.WriteLine("The data provided is incorrect");
            return null;
        }

        return input;
    }
}
