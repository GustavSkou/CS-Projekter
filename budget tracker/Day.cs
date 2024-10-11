using System.Globalization;

abstract class Day
{
    protected string name;
    protected double spend;
    protected int id;
    private DateTime dateTime;

    public Day (DateTime dateTime)
    {
        this.dateTime = dateTime;
        id = dateTime.Day;
    }
    public DateTime GetDate()
    {
        return dateTime;
    }

    public string getName()
    {
        return name;
    }

    public int GetDay()
    {
        return id;
    }

    public double GetSpend()
    {
        return spend;
    }
    public void AddToSpend(double amount)
    {
        spend = spend + amount;
    }
}

class Monday : Day
{
    public Monday(DateTime dateTime) : base(dateTime)
    {
        this.name = "Monday";
    }
}

class Tuesday : Day
{
    public Tuesday(DateTime dateTime) : base(dateTime)
    {
        this.name = "Tuesday";
    }
}

class Wednesday : Day
{
    public Wednesday(DateTime dateTime) : base(dateTime)
    {
        this.name = "Wednesday";
    }
}

class Thursday : Day
{
    public Thursday(DateTime dateTime) : base(dateTime)
    {
        this.name = "Thursday";
    }
}

class Friday : Day
{
    public Friday(DateTime dateTime) : base(dateTime)
    {
        this.name = "Friday";
    }
}

class Saturday : Day
{
    public Saturday(DateTime dateTime) : base(dateTime)
    {
        this.name = "Saturday";
    }
}

class Sunday : Day
{
    public Sunday(DateTime dateTime) : base(dateTime)
    {
        this.name = "Sunday";
    }
}