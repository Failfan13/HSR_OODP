static class RewardGenerator
{
    static Random Rand = new(0);

    public static T GetRandomElement<T>(List<T> randomList)
    {
        int randomSeed = Rand.Next(0, randomList.Count());
        return randomList[randomSeed];
    }
}