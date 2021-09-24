namespace DeckOfCards
{
    public class Card
    {
        public Suits CardSuit {get; set; }
        public int CardValue {get; set; }

        public Card(int cardValue, Suits cardSuit)
        {
            this.CardValue = cardValue;
            this.CardSuit = cardSuit;
        }

        public string CardName => cardStringValue() + " of " + this.CardSuit.ToString();

        private string cardStringValue()
        {

                string cardStringValue;

                switch (this.CardValue)
                {
                    case (11):
                        cardStringValue = "Jack";
                        break;
                    case (12):
                        cardStringValue = "Queen";
                        break;
                    case (13):
                        cardStringValue = "King";
                        break;
                    case (14):
                        cardStringValue = "Ace";
                        break;
                    default:
                        cardStringValue = CardValue.ToString();
                        break;
                }

                return cardStringValue;
        }
    }
}
