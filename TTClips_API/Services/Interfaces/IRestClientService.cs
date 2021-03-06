﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TTClips_API.Services.Interfaces
{
    public interface IRestClientService 
    {
        IRestResponse Execute(string url, string resource, Method method);
        Task<IRestResponse> ExecuteAsync(string url, string resource, Method method);
        void AddDefaultHeader(string name, string content);
        void AddDefaultQueryParameter(string name, string content);

    }
}
