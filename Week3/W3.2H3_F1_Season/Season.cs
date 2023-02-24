class Season
{

    public int Year;
    public List<Race> Races;
    public List<Team> Teams;
    public List<Driver> DriverList = new();
    public List<int> Points = new() { 25, 18, 15, 12, 10, 8, 6, 4, 2, 1 };
    private Random rand = new();
    public Season(int year, List<Race> races, List<Team> teams)
    {
        Year = year;
        Races = races;
        Teams = teams;
    }
    public void RunSeason()
    {
        foreach (var race in Races)
        {
            for (var i = 0; i < 10; i++)
            {
                var driverInfoList = PickRandomDriver();
                var driver = (Driver)driverInfoList[0];
                string teamName = (string)driverInfoList[1];

                if (i == 0)
                {
                    Console.WriteLine($"{driver.Name} of {teamName} has won the {race.Name} Grand Prix!");
                }

                driver.Score += Points[i];
            }
        }
        foreach (var team in Teams)
            foreach (var driver in team.DriverList)
                DriverList.Add(driver);

    }
    public void SeasonResults()
    {
        Console.WriteLine("\n\nSeason results:");
        DriverList = DriverList.OrderByDescending(i => i.Score).ToList();
        for (var i = 0; i < DriverList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {DriverList[i].Name}: {DriverList[i].Score}");
        }
    }

    public List<object> PickRandomDriver()
    {
        Random rand = new();
        Driver? chosenDriver = null;
        string chosenTeam = "";
        var temporaryTeam = Teams[rand.Next(0, Teams.Count)];
        chosenTeam = temporaryTeam.TeamName;
        chosenDriver = temporaryTeam.DriverList[rand.Next(0, 2)];
        return new List<object>() { chosenDriver, chosenTeam };
    }
}