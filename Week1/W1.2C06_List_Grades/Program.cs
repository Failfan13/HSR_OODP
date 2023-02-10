var gradebook = new List<double> {
    7,
    5.5,
    3.2,
    10,
    4.5
};

int passed = 0, grades = gradebook.Count;

for (var i = 0; i < grades; i++) {
    if (gradebook[i] >= 5.5) {
        passed++;
    }
}

Console.WriteLine($"{passed} out of {grades} students passed");