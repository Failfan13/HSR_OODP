﻿class Program
{
    public static void Main()
    {
        DNA ancestor = new DNA(null, "acgt");
        var dnaLine = new List<DNA>() { ancestor };
        for (int i = 0; i < 25; i++)
        {
            ancestor = ancestor.Replicate();
            Console.WriteLine(ancestor.Ancestor);
            dnaLine.Add(ancestor);
        }

        // while (ancestor.Ancestor != null)
        // {
        //     Console.WriteLine(ancestor.Ancestor.Seq);
        //     ancestor = ancestor.Ancestor;
        // }
        Console.WriteLine(dnaLine[1].Ancestor);
    }
}