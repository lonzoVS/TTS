using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using TTClips_API.Factories.RestClientFactory;
using TTClips_API.Factories.RestRequestFactory;
using TTClips_API.Services.Interfaces;

namespace TTClips_API.Services
{
    public class RestClientService : IRestClientService
    {
        private readonly IRestClientFactory _restClientFactory;
        private readonly IRestRequestFactory _restRequestFactory;
        private IRestClient _client;

        public RestClientService(IRestClientFactory restClientFactory, IRestRequestFactory restRequestFactory)
        {
            _restClientFactory = restClientFactory;
            _restRequestFactory = restRequestFactory;
        }

        public void AddDefaultHeader(string name, string content)
        {
            throw new NotImplementedException();
        }

        public void AddDefaultQueryParameter(string name, string content)
        {
            throw new NotImplementedException();
        }

        public IRestResponse Execute(string baseUrl, string resource, Method method)
        {
            var _client = _restClientFactory.Create(baseUrl);
            var request = _restRequestFactory.Create(resource, method);

            return _client.Execute(request);
        }

        public async Task<IRestResponse> ExecuteAsync(string baseUrl, string resource, Method method)
        {
            _client = _restClientFactory.Create(baseUrl);
            var request = _restRequestFactory.Create(resource, method);

            return await _client.ExecuteAsync(request);
        }
    }
}
