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

        [Route("Read"), HttpPost]
        public IActionResult Read(List<int> services, types type, int page)
        {
            if(page == 0) { page = 1; }
            List<services> serv = new();
            foreach(int s in services) { serv.Add((services)s); }
            return Ok(_movieContainer.GetMoviesAsync(serv, type, page).Result);
        }

        [Route("ReadSearch"), HttpPost]
        public IActionResult ReadSearch(List<int> services, types type, int page, string search)
        {
            if (page == 0) { page = 1; }
            List<services> serv = new();
            foreach (int s in services) { serv.Add((services)s); }
            return Ok(_movieContainer.GetMoviesSearchAsync(serv, type, page, search).Result);
        }
    }
}
