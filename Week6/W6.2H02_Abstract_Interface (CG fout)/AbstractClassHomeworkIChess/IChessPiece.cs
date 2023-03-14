interface IChessPiece
{
    int X { get; set; }
    int Y { get; set; }
    bool IsWhite { get; }

    bool CanMove(int x, int y);
}