using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TTClips_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClipsController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{name}")]
        public async Task<IActionResult> GetChannelClips(string name)
        {
            var client = new RestClient("https://api.twitch.tv/kraken/clips/top");
            client.AddDefaultHeader("Accept", "application/vnd.twitchtv.v5+json")
                .AddDefaultHeader("Client-ID", "4kx7npmg3oz9prr62i2slbr6reat1w")
                .AddDefaultQueryParameter("channel", name);
            
            var request = new RestRequest(Method.GET);

            var cancellationTokenSource = new CancellationTokenSource();
            IRestResponse response = await client.ExecuteTaskAsync(request, cancellationTokenSource.Token);

            return Ok(response.Content);
            //curl - H 'Accept: application/vnd.twitchtv.v5+json' \
            //-H 'Client-ID: uo6dggojyb8d6soh92zknwmi5ej1q2' \
            //-X GET 'https://api.twitch.tv/kraken/clips/AmazonianEncouragingLyrebirdAllenHuhu'
            //return "value";
        }


    }
}
