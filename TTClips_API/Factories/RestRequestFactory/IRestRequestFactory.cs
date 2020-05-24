
using RestSharp;

namespace TTClips_API.Factories.RestRequestFactory
{
    interface IRestRequestFactory
    {
        RestRequest Create(string resource, Method method);
    }
}
