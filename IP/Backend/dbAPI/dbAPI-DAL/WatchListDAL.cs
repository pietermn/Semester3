using System;
using System.Collections.Generic;
using System.Linq;
using dbAPI_DTO;
using dbAPI_Interface_DAL;
using Microsoft.EntityFrameworkCore;

namespace dbAPI_DAL
{
    public class WatchListDAL : IWatchListDAL
    {
        readonly DBContext _Context;

        public WatchListDAL(DBContext context)
        {
            _Context = context;
        }

        public void CreateWatchList(WatchListDTO watchList)
        {
            _Context.WatchList.Add(watchList);
            _Context.SaveChanges();
        }

        public List<WatchListDTO> getWatchList(int accountId)
        {
            return _Context.WatchList
                .Where(w => w.AccountId == accountId)
                    .AsNoTracking()
                .ToList();
        }

    }
}
