int sizeChoice, startLetter;

string board = "";

var layout = new List<string> {"W", "B"};

while (true) {
    sizeChoice = Convert.ToInt32(Console.ReadLine());

    if (sizeChoice >= 2) {
        break;
    }
}

for (var i = sizeChoice; i > 0; i--) {
    startLetter = (i % 2 == 0 ? 1 : 0);

    for (var j = 0; j < sizeChoice; j++) {
        startLetter = (startLetter == 1 ? 0 : 1);

        board += layout[startLetter];
    }
    board += "\n";
}

Console.WriteLine(board);