using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    interface ISaleService
    {
        public void SellGameWithCampaign(Gamer gamer, Gamee game, Campaign campaign);
        public void SellGameWithoutCampaign(Gamer gamer, Gamee game);
    }
}
