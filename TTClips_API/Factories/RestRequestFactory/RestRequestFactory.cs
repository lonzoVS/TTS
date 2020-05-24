using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

namespace TTClips_API.Factories.RestRequestFactory
{
    public class RestRequestFactory : IRestRequestFactory
    {
        public RestRequest Create(string resource, Method method)
        {
            return new RestRequest(resource, method);
        }
    }
}
