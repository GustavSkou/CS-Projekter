using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Year
{
    private Month[] months;
    private int id;
    private double spend;

    public Year (Calendar calendar, DateTime dateTime)
    {
        id = dateTime.Year;
        months = SetMonths(calendar, dateTime);
    }

    public int GetYear()
    {
        return id;
    }

    public Month GetMonth(int date)
    {
        return GetMonths()[date - 1];
    }

    public Month[] GetMonths()
    {
        return months;
    }

    public double Getspend()
    {
        UpdateYearlySpend();
        return spend;
    }

    private void UpdateYearlySpend()
    {
        double amountSpend = 0;
        foreach (Month month in this.months)
        {
            amountSpend = amountSpend + month.GetSpend();
        }
        spend = amountSpend;
    }

    private Month[] SetMonths(Calendar calendar, DateTime dateTime)
    {
        Month[] someYearMonths = new Month[12];

        for(int month = 0; month < someYearMonths.Length; month++)
        {
            someYearMonths[month] = new Month(calendar, dateTime);
            dateTime = dateTime.AddMonths(1);
        }
        return someYearMonths;
    }
}