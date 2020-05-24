using FluentAssertions;
using Moq;
using RestSharp;

using System.Threading.Tasks;
using TTClips_API.Factories.RestClientFactory;
using TTClips_API.Factories.RestRequestFactory;
using TTClips_API.Services;
using Xunit;

namespace TTClips_API_Tests.CommandsTests
{
    public class RestClientServiceTests
    {
        RestClientService _service;
        Mock<IRestRequestFactory> _restRequestFactoryMock;
        Mock<IRestClientFactory> _restClientFactoryMock;

        public RestClientServiceTests()
        {
            _restRequestFactoryMock = new Mock<IRestRequestFactory>();
            _restClientFactoryMock = new Mock<IRestClientFactory>();
            _service = new RestClientService(_restClientFactoryMock.Object, _restRequestFactoryMock.Object);
        }

        [Fact]
        public void Execute_Given_ClientAndRequest_Returns_IRestResponseObject()
        {
            var baseUrl = "https://www.test.com";
            var resource = "test/1";
            var method = Method.GET;
            _restClientFactoryMock.Setup(x => x.Create(It.IsAny<string>())).Returns(new RestClient(baseUrl)).Verifiable();
            _restRequestFactoryMock.Setup(x => x.Create(It.IsAny<string>(), It.IsAny<Method>())).Returns(new RestRequest("test/1", method)).Verifiable();

            var result = _service.Execute(baseUrl, resource, method);

            result.Should().BeOfType<RestResponse>();
        }

        [Fact]
        public async Task ExecuteAsync_Given_ClientAndRequest_Returns_IRestResponseObject()
        {
            var baseUrl = "https://www.test.com";
            var resource = "test/1";
            var method = Method.GET;
            _restClientFactoryMock.Setup(x => x.Create(It.IsAny<string>())).Returns(new RestClient(baseUrl)).Verifiable();
            _restRequestFactoryMock.Setup(x => x.Create(It.IsAny<string>(), It.IsAny<Method>())).Returns(new RestRequest("test/1", Method.GET)).Verifiable();

            var result = await _service.ExecuteAsync(baseUrl, resource, method);

            result.Should().BeOfType<RestResponse>();
        }

    }
}
