namespace DataFactory.Interfaces;

public interface IDataSourceFactory
{
    string[]? GetData(int dayNumber);
}