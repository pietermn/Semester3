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
    [Route("watchList")]
    public class WatchListController : ControllerBase
    {
        readonly IWatchListContainer _watchListContainer;
        public WatchListController(IWatchListContainer watchListContainer)
        {
            _watchListContainer = watchListContainer;
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult Get(int accountId)
        {
            return Ok(_watchListContainer.GetWatchList(accountId));
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(WatchListDTO watchList)
        {
            _watchListContainer.CreateWatchList(watchList);
            return Ok();
        }
    }
}
