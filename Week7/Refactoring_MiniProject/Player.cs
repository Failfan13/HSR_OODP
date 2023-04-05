public class Player<T>
{
    public static string Name;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public int Gold;
    public int ExperiencePoints;
    public T Level;
    public Weapon CurrentWeapon;
    public Location CurrentLocation;
    public QuestList QuestLog;
    public CountedItemList Inventory;

    public Player(string name, int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, Weapon currentWeapon, Location currentLocation)
    {
        Name = name;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
        Gold = gold;
        IncreaseExperiencePoints(experiencePoints);
        CurrentWeapon = currentWeapon;
        if (!TryMoveTo(currentLocation))
        {
            CurrentLocation = new Location(100, "Abyss", "You are stuck here for eternity", null, null, null);
        }
        Inventory = new CountedItemList();
        QuestLog = new QuestList();
    }

    // Advanced student: properties Level {get => (ExperiencePoints / 100) + 1;}
    public void IncreaseExperiencePoints(int points)
    {
        ExperiencePoints += points;
        (int)Level = (int)(ExperiencePoints / 100) + 1;
    }

    public string Info()
    {
        return "Name: " + Name + "\nHP: " + CurrentHitPoints +
        "\nXP: " + ExperiencePoints + "\nLevel: " + Level +
        "\nGold: " + Gold + "\nWeapon: " + CurrentWeapon.Name +
        "\n\nCurrent location: " + CurrentLocation.Info() +
        "\nInventory: " + Inventory.Info() +
        "\nQuests completed: " + QuestLog.QuestsComplete() + " out of " + World.Quests.Count +
        "\nQuest log: \n" + QuestLog.Info() + "\n";
    }

    public bool TryMoveTo(Location newLocation)
    {
        if (newLocation != null &&
            (newLocation.ItemRequiredToEnter == null ||
            Inventory.HasItem(newLocation.ItemRequiredToEnter.ID)))
        {
            CurrentLocation = newLocation;
            CurrentHitPoints = MaximumHitPoints;
            return true;
        }
        return false;
    }

    public void CompleteQuest(Quest quest, bool newWeapon)
    {
        if (QuestLog.HasQuest(quest))
        {
            QuestLog.GetQuest(quest).IsCompleted = true;
            Inventory.RemoveCountedItemList(quest.QuestCompletionItems);
            if (quest.RewardItem != null)
            {
                Inventory.AddItem(quest.RewardItem);
            }
            if (quest.RewardWeapon != null && newWeapon)
            {
                CurrentWeapon = quest.RewardWeapon;
            }
            Gold += quest.RewardGold;
            IncreaseExperiencePoints(quest.RewardExperiencePoints);
        }
    }

    public int Attack()
    {
        return World.RandomGenerator.Next(
                    CurrentWeapon.MinimumDamage,
                    CurrentWeapon.MaximumDamage + (int)Level
                );
    }
}