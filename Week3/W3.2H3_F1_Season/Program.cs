class Program
{
    public static void Main()
    {
        var races = AssembleRaces2022();
        var teams = AssembleTeams2022();

        Season season2022 = new(2022, races, teams);
        season2022.RunSeason();
        season2022.SeasonResults();
    }

    public static List<Race> AssembleRaces2022() => new() {
        new Race("Bahrain"),
        new Race("Saudi Arabia"),
        new Race("Australia"),
        new Race("Emilia Romagna"),
        new Race("Miami"),
        new Race("Spain"),
        new Race("Monaco"),
        new Race("Azerbaijan"),
        new Race("Canada"),
        new Race("Great Britain"),
        new Race("Austria"),
        new Race("France"),
        new Race("Hungary"),
        new Race("Belgium"),
        new Race("Netherlands"),
        new Race("Italy"),
        new Race("Singapore"),
        new Race("Japan"),
        new Race("United States"),
        new Race("Mexico"),
        new Race("Brazil"),
        new Race("Abu Dhabi"),
    };

    public static List<Team> AssembleTeams2022()
    {
        Team redbull = new("Red Bull Racing");
        redbull.ContractDriver(new Driver("Max Verstappen"));
        redbull.ContractDriver(new Driver("Sergio Perez"));
        Team ferrari = new("Ferrari");
        ferrari.ContractDriver(new Driver("Charles Leclerc"));
        ferrari.ContractDriver(new Driver("Carlos Sainz Jr."));
        Team mercedes = new("Mercedes-AMG");
        mercedes.ContractDriver(new Driver("Louis Hamilton"));
        mercedes.ContractDriver(new Driver("George Russel"));
        Team alpine = new("Alpine-Renault");
        alpine.ContractDriver(new Driver("Fernando Alonso"));
        alpine.ContractDriver(new Driver("Esteban Ocon"));
        Team mclaren = new("McLaren-Mercedes");
        mclaren.ContractDriver(new Driver("Daniel Ricciardo"));
        mclaren.ContractDriver(new Driver("Lando Norris"));
        Team alfaRomeo = new("Alfa Romeo Racing-Ferrari");
        alfaRomeo.ContractDriver(new Driver("Valtteri Bottas"));
        alfaRomeo.ContractDriver(new Driver("Guanyu Zhou"));
        Team astonMartin = new("Aston Martin-Mercedes");
        astonMartin.ContractDriver(new Driver("Sebastian Vettel"));
        astonMartin.ContractDriver(new Driver("Lance Stroll"));
        Team haas = new("Haas-Ferrari");
        haas.ContractDriver(new Driver("Mick Schumacher"));
        haas.ContractDriver(new Driver("Kevin Magnussen"));
        Team alphatauri = new("AlphaTauri-Red Bull");
        alphatauri.ContractDriver(new Driver("Pierre Gasly"));
        alphatauri.ContractDriver(new Driver("Yuki Tsunoda"));
        Team williams = new("Williams-Mercedes");
        williams.ContractDriver(new Driver("Alex Albon"));
        williams.ContractDriver(new Driver("Nicholas Latifi"));

        return new() { redbull, ferrari, mercedes, alpine, mclaren,
            alfaRomeo, astonMartin, haas, alphatauri, williams };
    }
}