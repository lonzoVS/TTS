using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace TTClips_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var client = new RestClient("https://api.twitch.tv/helix/users/follows?from_id=23161357&first=100");
            client.AddDefaultHeader("Authorization", "Bearer 8k5jahjp3b9k7kozh2um7r39wfzfy5");
            client.AddDefaultHeader("Client-ID", "4kx7npmg3oz9prr62i2slbr6reat1w");
            var request = new RestRequest(Method.GET);

            IRestResponse response = await client.ExecuteAsync(request);

           return Ok(response.Content);

        }

        [HttpGet("userName")]
        public async Task<IActionResult> GetUserInfo(string userName)
        {
            //curl - H 'Client-ID: uo6dggojyb8d6soh92zknwmi5ej1q2' \
            //-H 'Authorization: Bearer cfabdegwdoklmawdzdo98xt2fo512y' \
            //-X GET 'https://api.twitch.tv/helix/users?id=44322889'
            var client = new RestClient($"https://api.twitch.tv/helix/users?login={userName}");
            client.AddDefaultHeader("Authorization", "Bearer 8k5jahjp3b9k7kozh2um7r39wfzfy5");
            client.AddDefaultHeader("Client-ID", "4kx7npmg3oz9prr62i2slbr6reat1w");

            var request = new RestRequest(Method.GET);

            IRestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return Ok(response.Content);
            }

            return BadRequest(response.Content);
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
