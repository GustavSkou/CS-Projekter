using System.Globalization;

class Year
{
    private Month[] months = new Month[12];
    private int yearNum;

    private Calendar calendar;
    private DateTime dateTime;

    public Year (Calendar calendar, DateTime dateTime)
    {
        this.calendar = calendar;
        this.dateTime = dateTime;
        
        for(int month = 0; month < months.Length; month++)
        {
            dateTime.AddMonths(month);
            months[month] = new Month(calendar, dateTime);
        }
    }
}