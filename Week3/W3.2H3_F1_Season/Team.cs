public class Team{
  public string TeamName;
  public List<Driver> DriverList = new ();
  public Team(string team) => TeamName = team;

  public void ContractDriver(Driver newDriver) {
    DriverList.Add(newDriver);
  }
}