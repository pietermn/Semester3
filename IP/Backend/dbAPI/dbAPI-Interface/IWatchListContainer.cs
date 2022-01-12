using System;
using System.Collections.Generic;
using dbAPI_DTO;

namespace dbAPI_Interface
{
    public interface IWatchListContainer
    {
        public List<WatchListDTO> GetWatchList(string accountId);
        public void CreateWatchList(WatchListDTO watchList);
    }
}
