using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using RestSharp;
using System;
using System.Threading.Tasks;
using TTClips_API.Controllers;
using TTClips_API.Factories.RestClientFactory;
using TTClips_API.Factories.RestRequestFactory;
using TTClips_API.Services;
using TTClips_API.Services.Interfaces;
using Xunit;

namespace TTClips_API_Tests.ControllerTests
{
    public class ClipsControllerTests
    {
        ClipsController _controller;
        Mock<IRestClientService> _restClientServiceMock;


        public ClipsControllerTests()
        {
            _restClientServiceMock = new Mock<IRestClientService>();
            _controller = new ClipsController(_restClientServiceMock.Object);
        }

        [Fact]
        public async Task GetChannelClips_Given_ChannelName_ReturnsJsonObject()
        {
            var response = new RestResponse
            {   ContentType = "application/json", 
                ResponseStatus = ResponseStatus.Completed, 
                StatusCode = System.Net.HttpStatusCode.OK 
            };
            _restClientServiceMock.Setup(x => x.ExecuteAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Method>())).ReturnsAsync(
                response).Verifiable();
            // Act
            var result = await _controller.GetChannelClips("lirik");

            // Assert
            result.Should().BeOfType<OkObjectResult>();
        }


        



    }
}
