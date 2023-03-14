class Knight : ChessPiece
{
    public Knight(int x, int y, bool isWhite)
        : base(x, y, isWhite) { }
    public override bool CanMove(int x, int y)
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
        return $"{((base.IsWhite) ? "White" : "Black")} Knight at ({base.X}, {base.Y})";
    }
}