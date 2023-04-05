public class SuperAdventure
{
    public Player<int> ThePlayer;
    public Monster CurrentMonster;

    public SuperAdventure()
    {
        GameSetUp();
    }

    private void GameSetUp()
    {
        Console.WriteLine("Welcome to the Super Adventure Game!");
        Console.WriteLine("What is your name?");
        string name;
        try
        {
            name = Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        ThePlayer = new Player<int>(
            name, 10, 10, 20, 0,
            World.WeaponByID(World.WEAPON_ID_RUSTY_SWORD),
            World.LocationByID(World.LOCATION_ID_HOME)
        );
        Console.WriteLine($"\nYour adventure awaits {name}!\n");
        Console.WriteLine("Explore and complete " + World.Quests.Count + " quests to win the game");
        Console.WriteLine("If you need to rejuvenate your health, move to another location\n");
        Console.WriteLine(ThePlayer.Info());
        SetCurrentMonster();
    }

    // Settings > Debug > Console: Collapse Identical Lines
    // https://learn.microsoft.com/en-us/dotnet/core/tutorials/debugging-with-visual-studio-code?pivots=dotnet-6-0
    // "console": "integratedTerminal",
    public void Play()
    {
        var quit = '4';
        var option = 'a';

        while (option != quit && ThePlayer.QuestLog.QuestsComplete() < World.Quests.Count)
        {
            option = WhatWouldYouLikeToDo();
            switch (option)
            {
                case '1':
                    Console.WriteLine(ThePlayer.Info());
                    break;
                case '2':
                    Move();
                    break;
                case '3':
                    if (CurrentMonster == null)
                    {
                        Console.WriteLine("There is nothing to fight here\n");
                    }
                    else
                    {
                        Fight();
                    }
                    break;
                default:
                    break;

            }
        }
        EndGame();
    }

    private static char WhatWouldYouLikeToDo()
    {
        char option = AskForAction();
        while (option < '1' || option > '4')
        {
            Console.WriteLine("I do not understand");
            option = AskForAction();
        }
        //Convert ASCII char to actual int //option - '0'
        return option;
    }

    private static char AskForAction()
    {
        Console.WriteLine("What would you like to do (Enter a number)?");
        Console.WriteLine("1: See game stats\n2: Move\n3: Fight\n4: Quit");
        // var answer = Console.ReadLine();
        // int option = answer.Length > 0 ? answer[0] : -1;
        char option = Console.ReadKey().KeyChar;
        Console.WriteLine("\n");
        return option;
    }

    private void EndGame()
    {
        if (ThePlayer.QuestLog.QuestsComplete() >= World.Quests.Count)
        {
            Console.WriteLine("********************************");
            Console.WriteLine("* You've completed the game!!! *");
            Console.WriteLine("********************************\n");

            Console.WriteLine("Final stats:");
            Console.WriteLine(ThePlayer.Info());
        }
        else
        {
            Console.WriteLine("You never completed the game, try again another time!");
        }
    }

    private void Move()
    {
        string location = WhereWillYouMove();
        var nextLocation = ThePlayer.CurrentLocation.GetLocationAt(location);
        if (ThePlayer.TryMoveTo(nextLocation))
        {
            SetCurrentMonster();
            Console.WriteLine("You moved to:");
            Console.WriteLine(ThePlayer.CurrentLocation.Info());
            CheckForQuest();
        }
        else
        {
            Console.WriteLine("to enter this location, you must have: " +
                nextLocation.ItemRequiredToEnter.Name + "\n");
        }
    }

    private string WhereWillYouMove()
    {
        string location = AskForMovement();
        while (!ThePlayer.CurrentLocation.NextLocationOptions().Contains(location))
        {
            Console.WriteLine("I did not understand that");
            location = AskForMovement();
        }

        return location;
    }

    private string AskForMovement()
    {
        Console.WriteLine("Where would you like to go?");
        Console.WriteLine(ThePlayer.CurrentLocation.DrawCompass());
        Console.WriteLine("Enter one character from these characters: " + ThePlayer.CurrentLocation.NextLocationOptions());
        // var location = Console.ReadLine()[0].ToString().ToUpper();
        var location = Console.ReadKey().KeyChar.ToString().ToUpper();
        Console.WriteLine("\n");
        return location;
    }

    private void SetCurrentMonster()
    {
        if (ThePlayer.CurrentLocation.MonsterLivingHere == null)
        {
            CurrentMonster = null;
        }
        else
        {
            CurrentMonster = ThePlayer.CurrentLocation.MonsterLivingHere.CopyMonster();
        }
    }

    private void CheckForQuest()
    {
        var questHere = ThePlayer.CurrentLocation.QuestAvailableHere;
        if (questHere != null)
        {
            TryPutQuestInQuestLog(questHere);
            TryCompleteQuest(questHere);
        }
        else
        {
            Console.WriteLine("No quest to be found here\n");
        }
    }

    private void TryCompleteQuest(Quest questHere)
    {
        //Check if the player already has the items needed to complete the quest
        if (!ThePlayer.QuestLog.GetQuest(questHere).IsCompleted &&
        ThePlayer.Inventory.HasAllItems(questHere.QuestCompletionItems)
        )
        {
            Console.WriteLine("You completed the \"" + questHere.Name +
                    "\" quest.\nYou receive:\n" + questHere.Info());
            bool newWeapon = CheckNewWeapon(questHere);
            Console.WriteLine();
            ThePlayer.CompleteQuest(questHere, newWeapon);
        }
        //Otherwise state what they need
        else
        {
            Console.WriteLine("To complete it, return with: " + questHere.QuestCompletionItems.Info());
        }
    }

    private void TryPutQuestInQuestLog(Quest questHere)
    {
        if (!ThePlayer.QuestLog.HasQuest(questHere))
        {
            ThePlayer.QuestLog.AddQuest(questHere);
            Console.WriteLine("You receive the \"" + questHere.Name + "\" quest.\n" +
                questHere.Description + "\nRewards:\n" + questHere.Info());
        }
        else
        {
            Console.WriteLine("The \"" + questHere.Name + "\" quest is already in your to do list.\n");
        }
    }

    private bool CheckNewWeapon(Quest questHere)
    {
        if (questHere.RewardWeapon != null)
        {
            Console.WriteLine("Current weapon:\n" + ThePlayer.CurrentWeapon.Info());
            Console.WriteLine("\nNew weapon:\n" + questHere.RewardWeapon.Info());
            Console.WriteLine("\nWould you like to equip the new weapon? Y/N");
            var response = Console.ReadKey().KeyChar.ToString().ToUpper();
            Console.WriteLine();
            return response == "Y";
        }
        return false;
    }

    private void Fight()
    {
        if (CurrentMonster == null)
        {
            return;
        }
        PlayerAttacks();

        if (CurrentMonster.CurrentHitPoints > 0)
        {
            MonsterAttacks();
        }
        else
        {
            SetCurrentMonster();
        }
    }

    private void PlayerAttacks()
    {
        int damageToMonster = ThePlayer.Attack();
        CurrentMonster.CurrentHitPoints -= damageToMonster;
        if (damageToMonster > 0)
        {
            Console.WriteLine("You hit the " + CurrentMonster.Name + " and did " + damageToMonster + " points of damage!");
        }
        else
        {
            Console.WriteLine("You missed the " + CurrentMonster.Name + "!");
        }
        if (CurrentMonster.CurrentHitPoints <= 0)
        {
            MonsterKOConsequences();
        }
        else
        {
            Console.WriteLine("The " + CurrentMonster.Name + " has " + CurrentMonster.CurrentHitPoints
                    + " out of " + CurrentMonster.MaximumHitPoints + " HP left\n");
        }
    }

    private void MonsterKOConsequences()
    {
        Console.WriteLine("You defeated a " + CurrentMonster.Name + "!");
        ThePlayer.IncreaseExperiencePoints(CurrentMonster.RewardExperiencePoints);
        var rewardItems = CurrentMonster.Loot.SelectMultipleRandomItems();
        ThePlayer.Inventory.AddCountedItemList(rewardItems);
        ThePlayer.Gold += CurrentMonster.RewardGold;
        Console.WriteLine("You receive " + CurrentMonster.RewardGold
            + " gold and these reward items:" + rewardItems.Info());
    }

    private void MonsterAttacks()
    {
        int damageToPlayer = CurrentMonster.Attack();
        ThePlayer.CurrentHitPoints -= damageToPlayer;
        if (damageToPlayer > 0)
        {
            Console.WriteLine("The " + CurrentMonster.Name + " did " + damageToPlayer + " points of damage!");
        }
        else
        {
            Console.WriteLine("The " + CurrentMonster.Name + " missed!!!");
        }

        if (ThePlayer.CurrentHitPoints <= 0)
        {
            PlayerKOConsequences();
        }
        else
        {
            Console.WriteLine("You have " + ThePlayer.CurrentHitPoints
                    + " out of " + ThePlayer.MaximumHitPoints + " HP left\n");
        }
    }

    private void PlayerKOConsequences()
    {
        Console.WriteLine("The " + CurrentMonster.Name + " knocked you out!");
        var item = ThePlayer.Inventory.SelectRandomItem();
        if (item != null)
        {
            Console.WriteLine("Then the " + CurrentMonster.Name + " steals a " + item.Name + " from you!");
            ThePlayer.Inventory.RemoveCountedItem(new CountedItem(item, 1));
        }
        ThePlayer.TryMoveTo(World.LocationByID(World.LOCATION_ID_HOME));
        Console.WriteLine("You run home to recover\n");
    }
}