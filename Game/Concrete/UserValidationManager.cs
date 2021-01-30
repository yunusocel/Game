using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirth == 1999 && gamer.Name == "Ali"
               && gamer.Surname == "Akbas" && gamer.TcNo == "1234567890")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
