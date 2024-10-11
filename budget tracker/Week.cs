class Week
{
    public int weekNum;
    public Day[] days = new Day[7];

    public Week(int weekNum)
    {
        this.weekNum = weekNum;
        setWeekDays();
    }

    private void setWeekDays()
    {
        for (int day = 0; day < days.Length; day++)
        {
            //days[day] = new Day(day);
        }
    }
}