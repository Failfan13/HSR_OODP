public class Quest
{
    public int ID;
    public string Name;
    public string Description;
    public int RewardExperiencePoints;
    public int RewardGold;
    public Item RewardItem;
    public Weapon RewardWeapon;
    public CountedItemList QuestCompletionItems;

    public Quest(int iD, string name, string description, int rewardExperiencePoints,
                int rewardGold, Item rewardItem, Weapon rewardWeapon)
    {
        ID = iD;
        Name = name;
        Description = description;
        RewardExperiencePoints = rewardExperiencePoints;
        RewardGold = rewardGold;
        QuestCompletionItems = new CountedItemList();
        RewardItem = rewardItem;
        RewardWeapon = rewardWeapon;
    }

    public string Info()
    {
        string s = "  * Experience points: " + RewardExperiencePoints +
        "\n  * Gold: " + RewardGold + "\n";
        if (RewardItem != null)
        {
            s += "  * Item: " + RewardItem.Name;
        }
        if (RewardWeapon != null)
        {
            s += "  * Weapon: " + RewardWeapon.Name;
        }
        return s;
    }
}