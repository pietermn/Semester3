using System;
using System.Collections.Generic;
using dbAPI_DTO;

namespace dbAPI_Interface_DAL
{
    public interface IWatchListDAL
    {
        public List<WatchListDTO> getWatchList(string accountId);
        public void CreateWatchList(WatchListDTO watchList);
    }
}
