namespace DeckOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Deck
    {
        public List<Card> Cards = new List<Card>();
        
        public Deck()
        {
             for (int i = 0; i < 52; i++)
             {
                  var suite = (Suits)(Math.Floor((decimal)i / 13));
                  var val = i % 13 + 2;
                  Cards.Add(new Card(val, suite));
             }
        }

        public void shuffle()
        {
            this.Cards = this.Cards.OrderBy(c => Guid.NewGuid())
                .ToList();
        }

        public Card dealOneCard()
        {
            var card = this.Cards.FirstOrDefault();
            this.Cards.Remove(card);
            return card;
        }
    }
}
