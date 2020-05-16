using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TTClips_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int TwitchId { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
    }
}
