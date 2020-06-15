using RestSharp;

namespace TTClips_API.Builders.Interfaces
{
    public interface IRestClientBuilder
    {
        IRestClient Build();
        IRestClientBuilder AddDefaultHeader(string name, string value);
        IRestClientBuilder AddDefaultQueryParameter(string name, string value);
        IRestClientBuilder AddBaseUrl(string baseUrl);

    }
}
