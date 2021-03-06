﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

namespace TTClips_API.Factories.RestClientFactory
{
    public class RestClientFactory : IRestClientFactory
    {
        public IRestClient Create(string baseUrl)
        {
            return new RestClient(baseUrl);
        }
    }
}
