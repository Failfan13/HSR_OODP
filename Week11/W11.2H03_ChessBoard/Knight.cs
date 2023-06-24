public class Knight : ChessPiece
{

    public override string Symbol => (base.IsWhite) ? "WKn" : "Bkn";
    public Knight(int x, int y, bool isWhite)
        : base(x, y, isWhite) { }

    public override bool CanMove(int x, int y)
    {
        if (!base.CanMove(x, y)) return false;

        // moet nog L shape check

        return true;
    }
}