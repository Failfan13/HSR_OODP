public abstract class ChessPiece
{
    public int X, Y;
    public bool IsWhite;

    public abstract string Symbol { get; }

    public ChessPiece(int x, int y, bool isWhite)
    {
        X = x;
        Y = y;
        IsWhite = isWhite;
    }

    public virtual bool CanMove(int x, int y) => x >= 0 && x <= 7 && y >= 0 && y <= 7;

    public override string ToString()
    {
        return $"{((IsWhite) ? "White" : "Black")} {base.ToString()} at ({X}, {Y})";
    }
}