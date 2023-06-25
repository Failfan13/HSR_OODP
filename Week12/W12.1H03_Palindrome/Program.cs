public class Program
{
    public static void Main()//string[] args)
    {
        string[] inputStrArr = new string[] { "racecar", "hello", "level", "A man, a plan, a canal, Panama!" };
        //Input strings for first test:
        //"racecar", "hello", "level", "A man, a plan, a canal, Panama!";



        foreach (string str in inputStrArr)
        {
            //Make lowercase and remove non-letters
            string cleanedStr = new string(str.ToLower().Where(c => char.IsLetter(c)).ToArray());

            bool isPalindrome = IsPalindrome(cleanedStr);
            Console.WriteLine($"\"{cleanedStr}\" is {(isPalindrome ? "a palindrome" : "not a palindrome")}");
        }
    }


    //Method Palindrome goes here
    public static bool IsPalindrome(string word)
    {
        if (word.Length <= 1) return true;

        if (word[0].Equals(word[^1]))
        {
            return IsPalindrome(word.Substring(1, word.Length - 2));
        }
        return false;
    }
}