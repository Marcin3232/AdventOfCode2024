
using DaysFactory;
using DaysFactory.Enums;
using DaysFactory.Services;
using FileManager;

IDaysService dayService = new DaysService();
Factory factory = new Factory();

var dayList = dayService.GenerateDayList();


int selectedIndex = 0;

ConsoleKey key;
do
{
    Console.Clear();
    dayList.ForEach(item =>
    {
        if (item.Id == selectedIndex)
        {
            Console.Write("->\t");
        }
        else
        {
            Console.Write("\t");
        }

        Console.WriteLine(item.Name);
    });

    key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.UpArrow)
    {
        selectedIndex = (selectedIndex > 0) ? selectedIndex - 1 : dayList.Count - 1;
    }
    else if (key == ConsoleKey.DownArrow)
    {
        selectedIndex = (selectedIndex < dayList.Count - 1) ? selectedIndex + 1 : 0;
    }

} while (key != ConsoleKey.Enter);

Console.Clear();
Console.WriteLine($"Choice: {dayList[selectedIndex].Name}");
factory.CreateProject((DayNumber)dayList[selectedIndex].Id - 1).Start();
