using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TTClips_API.Models;

namespace TTClips_API.Services.Interfaces
{
    public interface IUserService 
    {
        Task<User> Get(string userName);
    }
}
