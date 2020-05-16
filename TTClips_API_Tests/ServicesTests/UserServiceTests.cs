using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TTClips_API.Models;
using TTClips_API.Services;
using TTClips_API.Services.Interfaces;
using Xunit;

namespace TTClips_API_Tests.ServicesTests
{
    public class UserServiceTests
    {
        // TODO: Add wrapper around RESTSHARP(for DI)
        // FISTING IS 300$ BUCKS
        IUserService service;
        public UserServiceTests()
        {
            service = new UserService();
        }

        [Theory]
        [InlineData("lirik")]
        public async Task Get_Given_UserName_Returns_UserObject(string userName)
        {
            var result = await service.Get(userName);

            result.Should().BeOfType<User>();
            result.Username.Should().Be(userName);
        }
    }
}
