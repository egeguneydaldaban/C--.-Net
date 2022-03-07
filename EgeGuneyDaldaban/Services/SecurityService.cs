using EgeGuneyDaldaban.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgeGuneyDaldaban.Services
{
    public class SecurityService
    {
        
        UsersDAO usersDAO = new UsersDAO();
        public SecurityService()
        {
            
        }
        public bool IsValid(User user)
        {

            return usersDAO.FindUserByNameAndPassword(user);
            
        }

    }
}
