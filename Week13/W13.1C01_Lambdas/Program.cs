﻿public class Program
{
    public static void Main()
    {
        // Increment all the grades by 1
        List<int> grades1 = new() { 4, 5, 6, 8, 10 };
        var correctedGrades1 = grades1.Select(g => g += 1);
        Console.WriteLine(string.Join(", ", correctedGrades1));

        // Increment all the grades by 1, but the maximum is 10
        List<int> grades2 = new() { 4, 5, 6, 8, 10 };
        var correctedGrades2 = grades2.Select(g => Math.Min(g += 1, 10));
        Console.WriteLine(string.Join(", ", correctedGrades2));

        // Only keep the grades that are 6 or higher
        var passingGrades = grades2.Where(g => g >= 6);
        Console.WriteLine(string.Join(", ", passingGrades));

        // Sort the students by age, in ascending order
        List<(string, int)> students = new() {
            ("Alice", 23),
            ("Bob", 20),
            ("Charlie", 21)
        };
        var studentsSortedByAge = students.OrderBy(li => li.Item2);
        Console.WriteLine(string.Join(", ", studentsSortedByAge));

        // Get the highest grade of two chances
        int gradeFirstChance = 5;
        int gradeRetake = 8;
        Func<int, int, int> higherGrade = (x, y) => Math.Max(x, y);
        int highestGrade = higherGrade(gradeFirstChance, gradeRetake);
        Console.WriteLine(highestGrade);
    }
}