using Common.Interfaces;
using DataFactory;
using DataFactory.Interfaces;
using Day1;
using Day2;
using Day3;
using DaysFactory.Enums;

namespace DaysFactory;

public class Factory : IFactory
{
    private readonly IDataSourceFactory _dataSource;
    public Factory()
    {
        _dataSource = new DataSourceFactory();
    }

    public IDayProject? CreateProject(DayNumber dayNumber) => dayNumber switch
    {
        DayNumber.DayOne => new DayOne(GetData(dayNumber)),
        DayNumber.DayTwo => new DayTwo(GetData(dayNumber)),
        DayNumber.DayThree => new DayThree(GetData(dayNumber)),
        _ => null
    };

    private string[] GetData(DayNumber dayNumber) =>
       _dataSource.GetData((int)dayNumber) ?? [];
}
