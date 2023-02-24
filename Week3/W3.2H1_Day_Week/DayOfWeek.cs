class DayOfWeek
{

    public int StartDay;

    public static readonly List<string> Days = new() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    public DayOfWeek(int startDay)
    {
        StartDay = startDay;
    }
    public static string IndexToDay(int day)
    {
        string tempDay = day switch
        {
            < 0 => Days[(day & 7) - 1],
            > 6 => Days[day % 7],
            _ => Days[day]
        };
        return tempDay;
    }

    public bool IsWeekend()
    {
        var tempDay = IndexToDay(StartDay);
        if (tempDay == "Saturday" || tempDay == "Sunday")
        {
            return true;
        }
        return false;
    }

    public string CurrentDay()
    {
        return IndexToDay(StartDay);
    }
    public void NextDay()
    {
        StartDay++;
    }

}