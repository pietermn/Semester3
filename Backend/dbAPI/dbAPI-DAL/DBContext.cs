using System;
using dbAPI_DTO;
using Microsoft.EntityFrameworkCore;

namespace dbAPI_DAL
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<WatchListDTO> WatchList { get; set; }
    }
}
