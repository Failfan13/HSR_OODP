public class QuestList
{
    public List<PlayerQuest> QuestLog;
    public QuestList()
    {
        QuestLog = new List<PlayerQuest>();
    }

    public string Info()
    {
        if (QuestLog.Count == 0)
        {
            return "No quests";
        }
        string s = "";
        foreach (var playerQuest in QuestLog)
        {
            s += playerQuest.Info();
        }
        return s;
    }

    public bool HasQuest(Quest quest)
    {
        // Advanced student: Find + lambda
        // return InventoryList.Find(item => item.Details.ID == searchID && item.Quantity > 0);
        foreach (var item in QuestLog)
        {
            if (item.TheQuest.ID == quest.ID)
            {
                return true;
            }
        }
        return false;
    }

    public PlayerQuest GetQuest(Quest quest)
    {
        foreach (var playerQuest in QuestLog)
        {
            if (playerQuest.TheQuest.ID == quest.ID)
            {
                return playerQuest;
            }
        }
        return null;
    }

    public void AddQuest(Quest quest)
    {
        if (!HasQuest(quest))
        {
            QuestLog.Add(new PlayerQuest(quest));
        }
    }

    public int QuestsComplete()
    {
        int count = 0;
        foreach (var item in QuestLog)
        {
            if (item.IsCompleted)
            {
                count++;
            }
        }
        return count;
    }
}