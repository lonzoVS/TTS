using RestSharp;

namespace TTClips_API.Factories.RestClientFactory
{
    public interface IRestClientFactory
    {
        IRestClient Create(string baseUrl);
    }
}
