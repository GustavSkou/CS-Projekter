//https://learn.microsoft.com/en-us/dotnet/api/system.globalization.calendar?view=net-8.0
using System.Globalization;


class Program
{
    static void Main()
    {
        Random random = new Random();
        Calendar calendar = new GregorianCalendar();
        DateTime dateTime = new DateTime(2024, 1, 1, calendar);

        Year year = new Year(calendar, dateTime);

        foreach(Month month in year.GetMonths())
        {
            foreach (Day day in month.GetDays())
            {
                day.AddToSpend(random.Next(100));
            }
        }

        foreach(Month month in year.GetMonths())
        {
            foreach (Day day in month.GetDays())
            {
                //Console.WriteLine($"{day.getName()} {day.GetDay()}/{month.GetMonth()}/{year.GetYear()} : {day.GetSpend()}");
                Console.WriteLine( $"{String.Format( "{0:d MMMM, yyyy}", day.GetDate() )} : {day.GetSpend()}" );
            }
            Console.WriteLine(month.GetSpend());
        }
        Console.WriteLine(year.Getspend());
    }
}