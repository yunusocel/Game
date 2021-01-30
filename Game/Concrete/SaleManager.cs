using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    class SaleManager : ISaleService
    {
        public void SellGameWithCampaign(Gamer gamer, Gamee game, Campaign campaign)
        {

            Console.WriteLine(game.Title + " sold to " + gamer.Name + " " + gamer.Surname  + " with " + campaign.Name);
        }
        public void SellGameWithoutCampaign(Gamer gamer, Gamee game)
        {
            Console.WriteLine(game.Title + " sold to " + gamer.Name + " " + gamer.Surname);
        }
    }
}
