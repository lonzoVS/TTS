using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TTClips_API.Controllers;
using Xunit;

namespace TTClips_API_Tests
{
    public class ClipsControllerTests
    {
        [Fact]
        public async Task GetChannelClips_Given_ChannelName_ReturnsJsonObject()
        {
            var controller = new ClipsController();

            // Act
            var result = await controller.GetChannelClips("lirik");

            // Assert
            Assert.IsType<OkObjectResult>(result);
         }

    }
}
