using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TTClips_API.Controllers;
using Xunit;

namespace TTClips_API_Tests.ControllerTests
{
    public class UsersControllerTests
    {
        [Theory]
        [InlineData("lirik")]
        public async Task GetUserInfo_Given_UserName_Returns_JsonObject(string userName)
        {
            var controller = new UsersController();

            var result = await controller.GetUserInfo(userName);

            result.Should().BeOfType<OkObjectResult>();
        }

        [Theory]
        [InlineData("")]
        [InlineData("''''''''")]
        [InlineData("▒▒▒▒▒▒▒▒▒")]
        public async Task GetUserInfo_Given_InvalidUserName_Returns_400StatusCode(string userName)
        {
            var controller = new UsersController();

            var result = await controller.GetUserInfo(userName);
           
            result.Should().BeOfType<BadRequestObjectResult>();
        }
    }
}
