using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TTClips_API.Models;
using TTClips_API.Services.Interfaces;

namespace TTClips_API.Services
{
    public class UserService : IUserService
    {
        public async Task<User> Get(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
