public class Board
{
    public ChessPiece[,] PlayBoard = new ChessPiece[8, 8];

    private string ConstBoard = "";

    public void PlacePiece(ChessPiece introPiece) => PlayBoard[introPiece.X, introPiece.Y] = introPiece;

    public void MovePiece(ChessPiece piece, int x, int y)
    {
        if (piece.CanMove(x, y))
        {
            PlayBoard[piece.X, piece.Y] = null;

            piece.X = x;
            piece.Y = y;
            PlacePiece(piece);
        }
        else Console.WriteLine($"Invalid move for {base.ToString()} at ({x}, {y})");
    }

    public void Print()
    {
        ConstructBoard();
        Console.WriteLine(ConstBoard);
    }

    private void ConstructBoard(int row = 0, int col = 0)
    {
        ConstBoard += $"  {((PlayBoard[row, col] == null) ? "-" : PlayBoard[row, col].Symbol)}  ";

        if (row == PlayBoard.GetLength(0) && col == PlayBoard.GetLength(1)) return;

        if (col == PlayBoard.GetLength(1))
        {
            ConstBoard += "\n";
            ConstructBoard(row + 1, col + 1);
        }
        else ConstructBoard(row, col + 1);
    }
}