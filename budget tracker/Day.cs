class Day
{
    private string name ;

    public Day (DayOfWeek dayOfWeek)
    {
        this.name = SetDayName(dayOfWeek);
    }

    public string getName()
    {
        return this.name;
    }

    private string SetDayName (DayOfWeek dayOfWeek)
    {
        switch(dayOfWeek)
        {    
            case DayOfWeek.Monday:
            return "monday";
        
            case DayOfWeek.Tuesday:
            return "tuesday";

            case DayOfWeek.Wednesday:
            return "wednesday";

            case DayOfWeek.Thursday:
            return "thursday";

            case DayOfWeek.Friday:
            return "friday";

            case DayOfWeek.Saturday:
            return "saturday";    
        
            case DayOfWeek.Sunday:
            return "sunday";

            default:
            return "";
        }
    }
}