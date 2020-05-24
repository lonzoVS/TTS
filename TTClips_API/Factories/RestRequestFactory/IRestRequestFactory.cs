
using RestSharp;

namespace TTClips_API.Factories.RestRequestFactory
{
    public interface IRestRequestFactory
    {
        IRestRequest Create(string resource, Method method);
    }
}
