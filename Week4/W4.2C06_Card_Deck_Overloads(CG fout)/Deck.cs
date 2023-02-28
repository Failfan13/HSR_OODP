class Deck
{
    public List<Card> Cards = CreateDeck();
    public static bool AreJokersIncluded;
    private Random rand = new Random();
    public Deck() : this(false) { }
    public Deck(bool jokers) => AreJokersIncluded = jokers;

    // https://stackoverflow.com/questions/273313/randomize-a-listt
    public void Shuffle()
    {
        var lc = Cards.Count;
        while (lc > 1)
        {
            lc--;
            int tempRand = rand.Next(lc + 1);
            var value = Cards[tempRand];
            Cards[tempRand] = Cards[lc];
            Cards[lc] = value;
        }
    }
    public Card Draw()
    {
        var tempCardCount = Cards.Count;
        if (tempCardCount == 0)
        {
            var drawCard = Cards.Last();
            Cards.RemoveAt(tempCardCount - 1);
            return drawCard;
        }
        return null;
    }

    public List<Card> Draw(int amountCards)
    {
        List<Card> cardList = new();
        for (var i = 0; i < amountCards; i++)
        {
            var tempCard = Draw();
            cardList.Add(tempCard);
        }
        return cardList;
    }

    private static List<Card> CreateDeck()
    {
        var deck = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        if (AreJokersIncluded)
            deck.Add("Joker");
        var deckCol = new List<string> { "Red", "Black" };
        var deckType = new List<string> { "Spades", "Hearts", "Diamonds", "Clubs" };
        var tempCards = new List<Card>();

        foreach (var card in deck)
        {
            if (card == "Joker")
            {
                foreach (var color in deckCol)
                    tempCards.Add(new Card(color, card));
                break;
            }

            foreach (var type in deckType)
                tempCards.Add(new Card(type, card));
        }
        return tempCards;
    }
}