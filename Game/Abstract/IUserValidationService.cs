using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
