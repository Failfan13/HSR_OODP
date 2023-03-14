abstract class ChessPiece
{
    public int X, Y;
    public bool IsWhite;
    public ChessPiece(int x, int y, bool isWhite)
    {
        X = x;
        Y = y;
        IsWhite = isWhite;
    }

    abstract public bool CanMove(int x, int y);
}