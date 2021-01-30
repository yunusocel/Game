using Game.Abstract;
using Game.Concrete;
using Game.Entities;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.DateOfBirth = 1999;
            gamer.Name = "Ahmet";
            gamer.Surname = "Akbas";
            gamer.TcNo = "1234567890";

            GamerManager gamerManager = new GamerManager(new NewStateUserValidationManager());
            gamerManager.Add(gamer);

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.Name = "Sims 4";
            campaign.Type = "Small Campaign";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            Gamee game = new Gamee();
            game.Id = 1;
            game.Price = "€12";
            game.Category = "Fight";
            game.Title = "Mortal Combat";

            SaleManager saleManager = new SaleManager();
            saleManager.SellGameWithCampaign(gamer, game, campaign);
            saleManager.SellGameWithoutCampaign(gamer, game);

            Console.WriteLine();

        }
    }
}
