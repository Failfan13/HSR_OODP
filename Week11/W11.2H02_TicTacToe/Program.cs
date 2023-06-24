class Program
{
    public static int[,] Board = new int[3, 3];

    private static string _board = "";

    private static bool turn = false;

    public static void Main()
    {
        int timesAsked = 0;
        ShowBoard();

        while (!CheckWinStance(Board))
        {
            turn = !turn;
            bool rightAns = false;

            while (!rightAns)
            {
                Console.WriteLine($"{((turn) ? "X" : "O")}, please enter your move (row, column)");
                string ans = Console.ReadLine();

                if (ans == "q") return;
                string[] newAns = new string[2];

                if (ans != null)
                {
                    newAns = ans.Split(',');

                }
                else { continue; }

                if (Int32.TryParse(newAns.First(), out int num1) &&
                    num1 <= Board.GetLength(0) &&
                    num1 > 0 &&
                    Int32.TryParse(newAns.Last(), out int num2) &&
                    num2 <= Board.GetLength(1) &&
                    num2 > 0 &&
                    Board[num1 - 1, num2 - 1] == 0)
                {
                    rightAns = true;

                    Board[num1 - 1, num2 - 1] = (!turn) ? 1 : 2;
                }
            }

            timesAsked++;

            if (CheckWinStance(Board))
            {
                ShowBoard();
                Console.WriteLine($"{((turn) ? "X" : "O")} wins!");
                return;
            }

            if (timesAsked == 9)
            {
                ShowBoard();
                Console.WriteLine("It's a tie!"); ;
                return;
            }

            ShowBoard();
        }
    }

    private static void ShowBoard()
    {
        _board = "";
        ShowBoard(0, 0);
        Console.Write(_board);
    }

    private static void ShowBoard(int row, int col)
    {
        if (row == 2 && col == 2) return;

        if (col != 2) _board += $" {(Board[row, col] == 0 ? " " : (Board[row, col] == 1) ? "O" : "X")} |";

        if (col == 1)
        {
            _board += $" {(Board[row, col + 1] == 0 ? " " : (Board[row, col + 1] == 1) ? "O" : "X")} \n";

            if (row != 2) _board += "---+---+---\n";
        }

        if (col == 2) ShowBoard(row + 1, 0);
        else ShowBoard(row, col + 1);
    }

    private static bool FuncChecker(int num1, int num2) => num1 != 0 && num1 == num2;

    public static bool CheckWinStance(int[,] board)
    {
        bool checkCols = CheckWithFunction(board, (f, r, c) => FuncChecker(f[c, r], f[c + 1, r]));
        bool checkRows = CheckWithFunction(board, (f, r, c) => FuncChecker(f[r, c], f[r, c + 1])); ;
        bool checkDiagonalL = CheckWithFunction(board, (f, r, c) => FuncChecker(f[c, c], f[c + 1, c + 1]));
        bool checkDiagonalR = CheckWithFunction(board, (f, r, c) => FuncChecker(f[c, board.GetLength(0) - 1 - c], f[c + 1, board.GetLength(0) - 1 - (c + 1)])); ;

        return checkCols || checkRows || checkDiagonalL || checkDiagonalR;
    }

    private static bool CheckWithFunction(int[,] board, Func<int[,], int, int, bool> check)
    {
        bool winState = false;

        for (int i = 0; !winState && i < board.GetLength(0); i++)
        {
            bool same = true;

            for (int j = 0; same && j < board.GetLength(1) - 1; j++)
            {
                same = check(board, i, j);
                if (j == 5) break;
            }
            if (i == 5) break;
            winState = same;
        }

        return winState;
    }
}
