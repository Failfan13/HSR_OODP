public enum Month // Change the numbering, so that it starts at 1
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}

public class Calendar
{
    private Month _currentMonth;

    public Calendar(Month initialMonth)
    {
        _currentMonth = initialMonth;
    }

    public void DisplayCurrentMonth()
    {
        Console.WriteLine($"Current month: {_currentMonth} ({(int)_currentMonth})"); // Add the month number
    }

    // SetNextMonth goes here. It updates the current month to the next one.
    public void SetNextMonth()
    {
        _currentMonth = (Month)(((int)_currentMonth % 12) + 1);
    }
}