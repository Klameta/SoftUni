using System;

using System.Globalization;

class HolidaysBetweenTwoDates

{

    static void Main()

    {
        /*var startDate = DateTime.Parse(Console.ReadLine());
        var endDate = DateTime.Parse(Console.ReadLine());
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
        }
        Console.WriteLine(holidaysCount);*/
        var startDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", CultureInfo.InvariantCulture); 
        var holidaysCount = 0;

        for (var date=startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
        }
        Console.WriteLine(holidaysCount);
    }
}