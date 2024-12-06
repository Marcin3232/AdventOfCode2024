using Common.Utils;
using DaysFactory.Enums;
using DaysFactory.Models;

namespace DaysFactory.Services;

public class DaysService : IDaysService
{
    public List<Day> GenerateDayList()
    {
        return Enum.GetValues(typeof(DayNumber))
                   .Cast<DayNumber>()
                   .Select(e => new Day((int)e, EnumHelper.GetEnumDescription(e)))
                   .ToList();
    }
}
