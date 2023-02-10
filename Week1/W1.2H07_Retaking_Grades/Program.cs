class Program {
    static void Main() {
        var gradebook = new List<double> {
            6.5,
            9.5,
            4,
            5,
            4.5,
            10,
            7.1
        };

        for (int g = 0; g < gradebook.Count; g++) {
            double grade = gradebook[g];
            Console.WriteLine($"Grade: {grade}");
            if (grade <= 5.5) {
                string ans = "";
                while (ans != "y" && ans != "n") {
                    Console.WriteLine("Retake this course? y/n");
                    ans = Console.ReadLine().ToLower();
                };
                if (ans == "y") {
                    gradebook[g] = ++grade;
                }
            };
        };

        Console.WriteLine("Final grades:");

        for (int f = 0; f < gradebook.Count; f++) {
            Console.WriteLine(gradebook[f]);
        };
    }
}