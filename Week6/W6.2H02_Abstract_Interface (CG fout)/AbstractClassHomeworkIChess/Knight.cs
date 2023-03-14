class Knight : IChessPiece
{
    public int X, Y;
    public bool IsWhite;
    public Knight(int x, int y, bool isWhite)
    {
        X = x;
        Y = y;
        IsWhite = isWhite;
    }

    int IChessPiece.X
    {
        get => X;
        set { }
    }

    int IChessPiece.Y
    {
        get => Y;
        set { }
    }

    bool IChessPiece.IsWhite
    {
        get => IsWhite;
    }

    bool IChessPiece.CanMove(int x, int y)
    {
        if (Math.Abs(X - x) == 1 && Math.Abs(Y - y) == 2)
        {
            return true;
        }
        else if ((Math.Abs(Y - y) == 1 && Math.Abs(X - x) == 2))
        {
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"{((IsWhite) ? "White" : "Black")} Knight at ({X}, {Y})";
    }
}