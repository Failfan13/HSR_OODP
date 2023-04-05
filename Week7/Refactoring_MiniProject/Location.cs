public class Location
{
    public readonly int ID;
    public readonly string Name;
    public readonly string Description;
    public Item ItemRequiredToEnter;
    public Quest QuestAvailableHere;
    public Monster MonsterLivingHere;
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;

    // Advanced student: Optional arguments (null)
    public Location(int iD, string name, string description, Item itemRequiredToEnter, Quest questAvailableHere, Monster monsterLivingHere)
    {
        ID = iD;
        Name = name;
        Description = description;
        ItemRequiredToEnter = itemRequiredToEnter;
        QuestAvailableHere = questAvailableHere;
        MonsterLivingHere = monsterLivingHere;
    }

    public string Info()
    {
        string s = Name + " - " + Description + "\n";
        if (MonsterLivingHere != null)
        {
            s += "There are " + MonsterLivingHere.NamePlural + " living here\n";
        }
        else
        {
            s += "There are no monsters here\n";
        }
        return s;
    }

    public string DrawCompass()
    {
        //Settings > Debug > Console: Collapse Identical Lines
        string s = "You are at: " + Name + ". From here you can go:\n";
        if (LocationToNorth != null)
        {
            s += "    N\n    |\n";
        }
        if (LocationToWest != null)
        {
            s += "W---|";
        }
        else
        {
            s += "    |";
        }
        if (LocationToEast != null)
        {
            s += "---E";
        }
        s += "\n";
        if (LocationToSouth != null)
        {
            s += "    |\n    S\n";
        }
        return s;
    }

    public string NextLocationOptions()
    {
        string s = "";
        if (LocationToNorth != null)
        {
            s += "N";
        }
        if (LocationToEast != null)
        {
            s += "E";
        }
        if (LocationToSouth != null)
        {
            s += "S";
        }
        if (LocationToWest != null)
        {
            s += "W";
        }
        return s;
    }

    public Location GetLocationAt(string location)
    {
        switch (location)
        {
            case "N":
                return LocationToNorth;
            case "E":
                return LocationToEast;
            case "S":
                return LocationToSouth;
            case "W":
                return LocationToWest;
            default:
                return null;
        }
    }
}