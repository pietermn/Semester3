using System;
using System.Collections.Generic;
using dbAPI_DTO;
using dbAPI_Interface;
using dbAPI_Interface_DAL;

namespace dbAPI_Logic.Containers
{
    public class WatchListContainer : IWatchListContainer
    {
        readonly IWatchListDAL _watchListDAL;
        public WatchListContainer(IWatchListDAL watchListDAL)
        {
            _watchListDAL = watchListDAL;
        }

        public void CreateWatchList(WatchListDTO watchList)
        {
            _watchListDAL.CreateWatchList(watchList);
        }

        public List<WatchListDTO> GetWatchList(int accountId)
        {
            return _watchListDAL.getWatchList(accountId);
        }
    }
}
