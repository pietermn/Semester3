using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dbAPI_Interface;
using dbAPI_DTO;

namespace dbAPI.Controllers
{
    [ApiController]
    [Route("db")]
    public class WatchListController : ControllerBase
    {
        readonly IWatchListContainer _watchListContainer;
        public WatchListController(IWatchListContainer watchListContainer)
        {
            _watchListContainer = watchListContainer;
        }

        [HttpGet]
        [Route("GetWatchList")]
        public IActionResult Get(string accountId)
        {
            return Ok(_watchListContainer.GetWatchList(accountId));
        }

        [HttpPost]
        [Route("CreateWatchlist")]
        public IActionResult Create(WatchListDTO watchList)
        {
            _watchListContainer.CreateWatchList(watchList);
            return Ok();
        }
    }
}
