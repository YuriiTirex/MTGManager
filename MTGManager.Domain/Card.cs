using MtgApiManager.Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGManagerServer
{
    public class Card 
    {
        public ICard card { get; private set; }

        public Card(ICard card)
        {
            this.card = card;
        }

        public override string ToString()
        {
            return $"Card Name: {card.Name}\n" +
                   $"Mana Cost: {card.ManaCost}\n" +
                   $"Types: {card.Types}\n" +
                   $"Text: {card.Text}\n" +
                   $"Converted Mana Cost: {card.Power}\n" +
                   $"CardId: {card.Number}";
        }
    }
}
