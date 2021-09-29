using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;
using MtgApiManager.Lib.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTGManagerServer
{
    public class MTGService
    {
        private readonly IMtgServiceProvider serviceProvider;
        private ICardService cardService;
        private ISetService setServise;

        public MTGService()
        {
            serviceProvider = new MtgServiceProvider();
            cardService = serviceProvider.GetCardService();
            setServise = serviceProvider.GetSetService();
        }

        public List<ISet> GetAllSets() => setServise.AllAsync().Result.Value;
        public List<ICard> GetAllCards() => cardService.AllAsync().Result.Value;
        public Card FindCard(string Name) => new Card(cardService.Where(x => x.Name, Name).AllAsync().Result.Value.ElementAt(0));
        public Card RandomCard() => new Card(cardService.Where(card => card.Name, GetAllCards().ElementAt(new Random().Next(0, 100)).Name).AllAsync().Result.Value.ElementAt(0));
    }
}
