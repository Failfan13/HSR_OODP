public class Bishop : ChessPiece
{

    public override string Symbol => (base.IsWhite) ? "WBi" : "BBi";
    public Bishop(int x, int y, bool isWhite)
        : base(x, y, isWhite) { }

    public override bool CanMove(int x, int y)
    {
        if (!base.CanMove(x, y)) return false;

        // moet nog L shape check

        return true;
    }
}