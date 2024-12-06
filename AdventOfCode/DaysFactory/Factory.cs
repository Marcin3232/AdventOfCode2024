using Common.Interfaces;
using Day2;
using DaysFactory.Enums;

namespace DaysFactory;

public class Factory : IFactory
{

    public IDayProject CreateProject(DayNumber dayNumber) => dayNumber switch
    {
        DayNumber.DayOne => null,
        DayNumber.DayTwo => new DayTwo(),
        _ => null
    };

}
