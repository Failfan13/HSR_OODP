class Program {
    static void Main() {
        bool pass = true, retakes = false;

        Dictionary<string, List<double>> grades = new Dictionary<string, List<double>> ();
        grades.Add("English", new List<double>{5});
        grades.Add("Math", new List<double>{6.5});

        foreach (KeyValuePair<string, List<double>> grade in grades) {
            
            while (grades[grade.Key][grades[grade.Key].Count-1] < 5.5) {
                grades[grade.Key].Add(grades[grade.Key][grades[grade.Key].Count-1]+1);
                retakes = true;
                if (grades[grade.Key].Count >= 3) {
                    break;
                }
            };

            if (grades[grade.Key][(grades[grade.Key].Count-1)] < 5.5) {
                pass = false;
                Console.WriteLine($"Did you pass {grade.Key}? false");
            } else {
                Console.WriteLine($"Did you pass {grade.Key}? true");
            }
        };

        Console.WriteLine($@"Did you need to do any retakes? {retakes.ToString().ToLower()}
Did you pass this semester? {pass.ToString().ToLower()}");
    }
}
