using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using saAPI_DTO;
using saAPI_enums;
using saAPI_Interfaces;

namespace saAPI.Controllers
{
    [ApiController]
    [Route("sa")]
    public class saController : ControllerBase
    {
        readonly IMovieContainer _movieContainer;
        public saController(IMovieContainer movieContainer)
        {
            _movieContainer = movieContainer;
        }

        //[HttpGet]
        //[Route("Read")]
        //public async Task<ActionResult> ReadAsync()
        //{
        //    var client = new HttpClient();
        //    var request = new HttpRequestMessage
        //    {
        //        Method = HttpMethod.Get,
        //        RequestUri = new Uri("https://streaming-availability.p.rapidapi.com/search/basic?country=us&service=netflix&type=movie&genre=18&page=1&output_language=en&language=en"),
        //        Headers =
        //        {
        //            { "x-rapidapi-host", "streaming-availability.p.rapidapi.com" },
        //            { "x-rapidapi-key", "6c7c427870msh77540ee5ce1cf0fp1589f8jsn9777cc8b6bb4" },
        //        },
        //    };
        //    var response = await client.SendAsync(request);
        //    using (response)
        //    {
        //        response.EnsureSuccessStatusCode();
        //        var body = await response.Content.ReadAsStringAsync();
        //        return Ok(body);
        //    }
        //}

        [HttpGet]
        [Route("Read")]
        public IActionResult Read(services service, types type)
        {
            return Ok(_movieContainer.GetMovies(service, type));
        }
    }
}
