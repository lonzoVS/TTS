using FluentAssertions;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using TTClips_API.Factories.RestRequestFactory;
using Xunit;

namespace TTClips_API_Tests.FactoriesTests
{
    public class RestRequestFactoryTests
    {
        RestRequestFactory factory;
        public RestRequestFactoryTests()
        {
            factory = new RestRequestFactory();
        }

        [Fact]
        public void Create_Given_URLAndMethod_Returns_RestSharpsRestRequestObject()
        {
            var result = factory.Create("test/1", Method.GET);
            
            result.Should().BeOfType<RestRequest>();
        }
    }
}
