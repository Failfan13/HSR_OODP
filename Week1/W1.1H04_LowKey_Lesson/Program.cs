double score = 0.0, point = 0.0;
int guess = 0, finalScore = 0;
var list = new [] {"a", "b", "c", "d"};

while (guess <= 3) {
    Console.WriteLine("Answer the following MCQs:");
    Console.WriteLine("Which of the following is NOT a valid type in C#?\nA: bool\nB: int\nC: var\nD: string");
    string? choiceAns = Console.ReadLine()?.ToLower();
    if (choiceAns == "c") {
        score++;
        guess = 0;
        break;
    }else if (list.Contains(choiceAns)){
        break;
    }
    guess++;
}
guess = 0;

while (guess <= 3) {
    Console.WriteLine("What happens if you execute the following line C#?\nint x = 1.23;");
    Console.WriteLine("A: x will be 1.23\nB: x will be 1\nC: x will be 1.0\nD: you will get a compiler error");
    string? choiceAns = Console.ReadLine()?.ToLower();
    if (choiceAns == "d") {
        score++;
        guess = 0;
        break;
    }else if (list.Contains(choiceAns)){
        break;
    }
    guess++;
}
guess = 0;

var ansList = new List<string> { "a", "d" };
while (guess <= 3) {
    Console.WriteLine("Consider the following line:\ndouble d = 1.23;\nWhat are TWO ways to convert variable d to an int?");
    Console.WriteLine("A: int i = (int)d;\nB: int i = int(d)\nC: int i = 0 + d\nD: int i = convert.toint32(d)");
    Console.WriteLine("Your first answer:");
    string? choiceAns = Console.ReadLine()?.ToLower();
    if (ansList.Contains(choiceAns)) {
        point = (double)0.5;
        guess = 0;
        ansList.Remove(choiceAns);
        break;
    }else if (list.Contains(choiceAns)){
        break;
    }
    guess++;
}
guess = 0;

while (guess <= 3) {
    Console.WriteLine("Your second answer:");
    string? choiceAns = Console.ReadLine()?.ToLower();
    if (ansList.Contains(choiceAns)) {
        point = point + (double)0.5;
        guess = 0;
        ansList.Remove(choiceAns);
        break;
    }else if (list.Contains(choiceAns)){
        break;
    }
    guess++;
}

finalScore = (int)score + (int)point;

if (finalScore == 3){
    Console.WriteLine($"Your score: {finalScore} out of 3. Well done!");
}else {
    Console.WriteLine($"Your score: {finalScore} out of 3.");
}

/*
int day, month;
day = month = 0;

Console.WriteLine("What is the month? 1-12");
month = Convert.ToInt32();

Console.WriteLine("What is the day? 1-31");*/