class DominoPiece {
    public string Piece;
    public int? Pips1;
    public int? Pips2;

    public DominoPiece(int? p1, int? p2) {
        Pips1 = p1;
        Pips2 = p2;
        Piece = CreatePiece();
    }

    private string CreatePiece() {
        return $"+---+\n| {(Pips1 == null ? " " : Pips1)} |\n|   |\n| {(Pips2 == null ? " " : Pips2)} |\n+---+";
    }
}