using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1980 && 
               gamer.FirstName == "John" && 
               gamer.LastName == "Doe") 
            { 
                return true;
            }

            return false;
        }
    }
}

