using System.Collections;
using System.Collections.Generic;

namespace MTGManagerServer
{
    public class Deck : IEnumerable
    {
        private static int deckIndex { get; set; }
        public string Name { get; set; }
        private List<Card> userDeck { get; set; }

        public Deck()
        {
            Name = $"Deck{deckIndex}";
        }

        public Deck(string name)
        {
            Name = name;
        }

        public void ChangeName(string newName) => Name = newName;
        public void AddCard(Card card) => userDeck.Add(card);
        public void DeleteCard(Card card) => userDeck.Remove(card);
        
        public Card this[int index]
        {
            get
            {
                return userDeck[index];
            }
            set
            {
                userDeck[index] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var card in userDeck)
            {
                yield return card;
            }
        }
    }
}
