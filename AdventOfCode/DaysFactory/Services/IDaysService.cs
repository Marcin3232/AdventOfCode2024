using DaysFactory.Models;

namespace DaysFactory.Services
{
    public interface IDaysService
    {
        List<Day> GenerateDayList();
    }
}