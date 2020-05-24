using FluentAssertions;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using TTClips_API.Factories.RestClientFactory;
using Xunit;

namespace TTClips_API_Tests.FactoriesTests
{
    public class RestFactoryTests
    {
        IRestClientFactory factory;
        public RestFactoryTests()
        {
            factory = new RestClientFactory();
        }


        [Fact]
        public void Create_Given_StringURL_Returns_RestSharpsRestClientObject()
        {
            var result = factory.Create("https://api.twitch.tv");

            result.Should().BeOfType<RestClient>();
        }
    }
}
