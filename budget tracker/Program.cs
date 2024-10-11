using System.Globalization;

class Program
{
    static void Main()
    {
        Calendar calendar = new GregorianCalendar();
        DateTime dateTime = new DateTime(2024, 1, 1, calendar);

        Year year = new Year(calendar, dateTime);
    }
}