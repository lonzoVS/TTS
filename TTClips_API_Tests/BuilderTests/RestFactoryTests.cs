using FluentAssertions;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using TTClips_API.Builders;
using TTClips_API.Builders.Interfaces;
using Xunit;

namespace TTClips_API_Tests.BuilderTests
{
    public class RestBuilderTests
    {
        IRestClientBuilder builder;
        public RestBuilderTests()
        {
            builder = new RestClientBuilder();
        }


        [Fact]
        public void Build_Given_BaseUrlAndHeaderAndQueryParameter_Returns_RestSharpsRestClientObjectWihtGivenParameters()
        {
            var result = builder.AddBaseUrl("http://www.baseUrl.com")
                .AddDefaultHeader("header", "headValue")
                .AddDefaultQueryParameter("query", "queryValue")
                .Build();

            result.Should().BeOfType<RestClient>();
            result.BaseUrl.Should().Be("http://www.baseUrl.com");
            result.DefaultParameters.Count.Should().Be(3);
            result.DefaultParameters[1].Name.Should().Be("header");
            result.DefaultParameters[1].Value.Should().Be("headValue");
            result.DefaultParameters[2].Name.Should().Be("query");
            result.DefaultParameters[2].Value.Should().Be("queryValue");
        }

        [Fact]
        public void AddBaseUrl_Given_BaseUrl_Returns_IRestClientBuilderObject()
        {
            var result = builder.AddBaseUrl("http://www.baseUrl.com");

            result.Should().BeOfType<RestClientBuilder>();
        }

        [Fact]
        public void AddDefaultHeader_Given_NameAndValue_Returns_IRestClientBuilderObject()
        {
            var result = builder.AddDefaultHeader("test", "test");

            result.Should().BeOfType<RestClientBuilder>();
        }

        [Fact]
        public void AddDefaultQueryParameter_Given_NameAndValue_Returns_IRestClientBuilderObject()
        {
            var result = builder.AddDefaultQueryParameter("test", "test");

            result.Should().BeOfType<RestClientBuilder>();
        }
    }
}
