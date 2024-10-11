using System.Globalization;
class Month
{
    private int id;
    private string name;
    private Day[] days;
    private int daysInMonth;
    private double spend;

    public Month(Calendar calendar, DateTime dateTime)
    {
        id = calendar.GetMonth(dateTime);
        daysInMonth = calendar.GetDaysInMonth(calendar.GetYear(dateTime), calendar.GetMonth(dateTime));
        name = SetMonthName(dateTime);
        days = SetDaysInMonth(dateTime);
    }

    public int GetMonth()
    {
        return id;
    }

    public Day GetDay(int date)
    {
        return GetDays()[date-1];
    }

    public Day[] GetDays()
    {
        return days;
    }

    public double GetSpend()
    {
        UpdateMonthlySpend();
        return spend;
    }

    private Day[] SetDaysInMonth(DateTime dateTime)
    {
        Day[] someMonthDays = new Day[daysInMonth];

        for (int date = 0; date < daysInMonth; date++)
        {
            someMonthDays[date] = GetCorrespondingDay(dateTime);
            dateTime = dateTime.AddDays(1);
        }
        return someMonthDays;
    }

    private Day GetCorrespondingDay(DateTime dateTime)
    {
        switch(dateTime.DayOfWeek)
        {    
            case DayOfWeek.Monday:
            return new Monday(dateTime);
        
            case DayOfWeek.Tuesday:
            return new Tuesday(dateTime);

            case DayOfWeek.Wednesday:
            return new Wednesday(dateTime);
            
            case DayOfWeek.Thursday:
            return new Thursday(dateTime);
            
            case DayOfWeek.Friday:
            return new Friday(dateTime);
            
            case DayOfWeek.Saturday:
            return new Saturday(dateTime);    
        
            case DayOfWeek.Sunday:
            return new Sunday(dateTime);

            default:
            return null;
        }
    }

    private String SetMonthName(DateTime dateTime)
    {
        string[] dateNamePairs = 
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
        };
        return dateNamePairs[dateTime.Month-1];
    }

    private void UpdateMonthlySpend()  //Calculates the total amount spend in this month
    {
        spend = 0;
        foreach (Day day in days)
        {
            spend = spend + day.GetSpend();
        }
    }

    public string GetName()
    {
        return this.name;
    }
}