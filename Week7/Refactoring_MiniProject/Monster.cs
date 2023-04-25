public class Monster : IDamagePoints
{
    public int ID;
    public string Name;
    public string NamePlural;
    public int MaximumDamage { get; set; }
    public int RewardExperiencePoints;
    public int RewardGold;
    public CountedItemList Loot;
    public int CurrentHitPoints;
    public int MaximumHitPoints;

    public Monster(int id, string name, string namePlural, int maximumDamage, int rewardExperiencePoints, int rewardGold)
    {
        ID = id;
        Name = name;
        NamePlural = namePlural;
        MaximumDamage = maximumDamage;
        RewardExperiencePoints = rewardExperiencePoints;
        RewardGold = rewardGold;
        Loot = new CountedItemList();
        CurrentHitPoints = 100;
        MaximumHitPoints = 20;
    }

    public Monster(int id, string name, string namePlural, int maximumDamage, int rewardExperiencePoints, int rewardGold, int currentHitPoints, int maximumHitPoints)
    {
        ID = id;
        Name = name;
        NamePlural = namePlural;
        MaximumDamage = maximumDamage;
        RewardExperiencePoints = rewardExperiencePoints;
        RewardGold = rewardGold;
        Loot = new CountedItemList();
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }

    public Monster CopyMonster()
    {
        Monster monsterCopy = new Monster(ID, Name, NamePlural, MaximumDamage, RewardExperiencePoints, RewardGold, CurrentHitPoints, MaximumHitPoints);
        monsterCopy.Loot.AddCountedItemList(Loot);
        return monsterCopy;
    }

    public int Attack()
    {
        return World.RandomGenerator.Next(0, MaximumDamage + 1);
    }
}