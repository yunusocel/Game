using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    class GamerManager : IGamerService
    {
        IUserValidationService tempUserValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            tempUserValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (tempUserValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
