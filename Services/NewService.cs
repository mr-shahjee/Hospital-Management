using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeCrud.Models;

namespace PracticeCrud.Services
{
    public class NewService
    {
        private UserContext _userContext;
        public NewService(UserContext userContext)
        {
            _userContext = userContext;
        }



   public List<User> GetUsers()
    {
        return _userContext.users.ToList();
    }

    }
}