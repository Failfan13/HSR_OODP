class DayOfWeek {

    public static readonly List<string> Days = new () {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
    public DayOfWeek(int startDay) {

    }
    public static dynamic IndexToDay(int day) {
        var tempDay = (day) switch {
            < 0 => Days[(day & 7) -1],
            > 6 => Days[(day + 6)],
            _ => Convert.ToString(Days[day])
        };
        return tempDay;
    }

    public bool IsWeekend() {
        return true;
    }

    public string CurrentDay() {
        return "";
    }
    public string NextDay() {
        return "";
    }

}