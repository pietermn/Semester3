using System;
using System.Collections.Generic;
using dbAPI_DTO;

namespace dbAPI_Interface
{
    public interface IWatchListContainer
    {
        public List<WatchListDTO> GetWatchList(int accountId);
        public void CreateWatchList(WatchListDTO watchList);
    }
}
