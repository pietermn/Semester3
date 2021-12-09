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

        [HttpGet]
        [Route("Read")]
        public async Task<ActionResult> Read(services service, types type)
        {
            List<MovieDTO> movies = await _movieContainer.GetMoviesAsync(service, type);
            return Ok(movies);
        }
    }
}
