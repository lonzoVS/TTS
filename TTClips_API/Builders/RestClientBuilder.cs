using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using TTClips_API.Builders.Interfaces;

namespace TTClips_API.Builders
{
    public class RestClientBuilder : IRestClientBuilder
    {

        private RestClient _client;

        public RestClientBuilder()
        {
            _client = new RestClient();
        }

        public IRestClientBuilder AddBaseUrl(string baseUrl)
        {
            _client.BaseUrl = new Uri(baseUrl);
            return this;
        }

        public IRestClientBuilder AddDefaultHeader(string name, string value)
        {
            _client.AddDefaultHeader(name, value);
            return this;
        }

        public IRestClientBuilder AddDefaultQueryParameter(string name, string value)
        {
            _client.AddDefaultHeader(name, value);
            return this;
        }

        public IRestClient Build()
        {
            return _client;
        }
    }
}
