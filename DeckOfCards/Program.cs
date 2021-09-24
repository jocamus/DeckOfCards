namespace DeckOfCards
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck  = new Deck();
            deck.shuffle();

            while (true )
            {
                Console.WriteLine("Do you want a card? (Y/N)");

                string line = Console.ReadLine();

                if (line != null && line.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    return; 
                }
                else if (line != null && line.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    Card card = deck.dealOneCard();

                    if (card != null)
                    {
                        Console.WriteLine(card.CardName);
                    }
                    else
                    {
                        Console.WriteLine("There is no cards");
                    }
                }
            }
        }
    }
}
