//https://learn.microsoft.com/en-us/dotnet/api/system.globalization.calendar?view=net-8.0
using System.Globalization;
class Month
{
    private int id;
    private string name;
    private Day[] days;
    private int daysInMonth;

    public Month(Calendar calendar, DateTime dateTime)
    {
        id = calendar.GetMonth(dateTime);
        daysInMonth = calendar.GetDaysInMonth(calendar.GetYear(dateTime), calendar.GetMonth(dateTime));
        
        name = SetMonthName(dateTime);
        days = SetDaysInMonth(dateTime);
    }

    private Day[] SetDaysInMonth(DateTime dateTime)
    {
        Day[] someMonthDays = new Day[daysInMonth];

        for (int date = 0; date < daysInMonth; date++)
        {
            someMonthDays[date] = new Day(dateTime.DayOfWeek);
            dateTime = dateTime.AddDays(1);
        }
        return someMonthDays;
    }

    private String SetMonthName(DateTime dateTime)
    {
        string[] dateNamePairs = 
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
        };
        return dateNamePairs[dateTime.Month-1];
    }

    public string getName()
    {
        return this.name;
    }
}