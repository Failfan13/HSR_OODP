public class Program
{
    public static void Main()
    {
        ListWrapper<int> listInt = new();
        listInt.Add(1);
        listInt.Add(2);
        listInt.Add(3);

        for (int i = 0; i < listInt.Count(); i++)
            Console.WriteLine(listInt.Get(i));

        ListWrapper<string> listString = new();
        listString.Add("Hello");
        listString.Add("World!");
        for (int i = 0; i < listString.Count(); i++)
            Console.WriteLine(listString.Get(i));

        // Error in uitgecommente deel;
        int highestElementCount = 5;//listInt.HighestCount(listString);
        Console.WriteLine("The ListWrapper object with the highest "
            + $"element count has {highestElementCount} elements");

        ListWrapper<char> listChar = new();
        listChar.Add('a');
        listChar.Add('b');
        listChar.Add('c');
        listChar.Add('d');

        highestElementCount = listChar.HighestCount(listChar);
        Console.WriteLine("The ListWrapper object with the highest "
            + $"element count has {highestElementCount} elements");
    }
}