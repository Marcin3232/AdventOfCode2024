using Common.Interfaces;
using Day1;
using Day2;
using DaysFactory.Enums;

namespace DaysFactory;

public class Factory : IFactory
{

    public IDayProject? CreateProject(DayNumber dayNumber) => dayNumber switch
    {
        DayNumber.DayOne => new DayOne(),
        DayNumber.DayTwo => new DayTwo(),
        _ => null
    };

}
