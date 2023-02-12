class Program
{
    public static void Main()
    {
        var pieces = new DominoPiece(1, null);
        Console.WriteLine(pieces.Piece);
        // Game game = new();
        // var hand = new List<DominoPiece>() {
        //     new DominoPiece(2, 1), //This piece has 2 pips on the top and 1 pip at the bottom
        //     new DominoPiece(6, 4),
        //     new DominoPiece(3, 1),
        //     new DominoPiece(1, 0),
        //     new DominoPiece(1, 4),
        // };

        // game.SetDomino(hand, 1); //Piece at index 3 is placed and removed from the hand
        // Flip(hand[3]); //Piece is flipped upside down: 1, 4 becomes 4, 1
        // game.SetDomino(hand, 3);
        // game.SetDomino(hand, 2);
        // game.SetDomino(hand, 0);
        // game.SetDomino(hand, 1); //Invalid move: not placed and not removed from hand
        // game.SetDomino(hand, 2); //Invalid index
        // game.DisplayGame();
    }

    // private static void Flip(DominoPiece piece)
    // {
    //     if (piece == null)
    //         return;
    //     (piece.Pips1, piece.Pips2) = (piece.Pips2, piece.Pips1);
    // }
}