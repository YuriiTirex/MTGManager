using System;
using System.Collections;
using System.Collections.Generic;

namespace MTGManagerServer
{
    public class MTGDecksList : IEnumerable
    {
        public List<Deck> userDecks { get; private set; }

        public MTGDecksList()
        {
            userDecks = new List<Deck>();
        }

        public void AddDeck(Deck deck) => userDecks.Add(deck);
        public void DeleteDeck(Deck deck) => userDecks.Remove(deck);

        public override string ToString()
        {
            string userDecksList = string.Empty;
            foreach (var deck in userDecks)
                userDecksList += $"{deck.Name}\n";

            return userDecksList;
        }

        public IEnumerable GetDecksName()
        {
            foreach (var deck in userDecks)
            {
                yield return deck.Name;
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var deck in userDecks)
            {
                yield return deck;
            }
        }
    }
}
