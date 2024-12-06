using Common.Interfaces;
using DaysFactory.Enums;

namespace DaysFactory
{
    public interface IFactory
    {
        IDayProject CreateProject(DayNumber dayNumber);
    }
}