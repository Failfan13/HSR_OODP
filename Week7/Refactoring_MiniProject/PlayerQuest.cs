public class PlayerQuest
{
    public Quest TheQuest;
    public bool IsCompleted;

    public PlayerQuest(Quest details)
    {
        TheQuest = details;
        IsCompleted = false;
    }

    public string Info()
    {
        return "Collect " + TheQuest.QuestCompletionItems.TheCountedItemList[0].Info() + ": " +
                (IsCompleted ? "Done" : "To do") + "\n";
    }
}