class Card {
    public readonly string Suit;
    public readonly string Rank;
    public Card(string suit, string rank) => (Suit, Rank) = (suit, rank);
    public string GetName() {
        if (Suit != "Joker")
            return $"{Rank} of {Suit}";
        return $"{Rank} {Suit}";
    }
}