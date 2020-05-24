using RestSharp;

namespace TTClips_API.Factories.RestClientFactory
{
    public interface IRestClientFactroy
    {
        RestClient Create(string baseUrl);
    }
}
