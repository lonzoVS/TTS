using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using RestSharp;
using System;
using System.Threading.Tasks;
using TTClips_API.Controllers;
using TTClips_API.Factories.RestClientFactory;
using TTClips_API.Factories.RestRequestFactory;
using Xunit;

namespace TTClips_API_Tests.ControllerTests
{
    public class ClipsControllerTests
    {
        ClipsController _controller;
        Mock<RestRequestFactory> _restRequestFactoryMock;
        Mock<RestClientFactory> _restClientFactory;

        public ClipsControllerTests()
        {

            _controller = new ClipsController();
        }

        [Fact]
        public async Task GetChannelClips_Given_ChannelName_ReturnsJsonObject()
        {
            // Act
            var result = await _controller.GetChannelClips("lirik");

            // Assert
            result.Should().BeOfType<OkObjectResult>();
        }


        



    }
}
