static class CleaningService
{
    public static void Clean(ICleanable cleanObj)
    {
        cleanObj.Clean();
    }

    public static void Clean(List<ICleanable> listCleanObj)
    {
        foreach (var cleanObj in listCleanObj)
        {
            cleanObj.Clean();
        }
    }
}