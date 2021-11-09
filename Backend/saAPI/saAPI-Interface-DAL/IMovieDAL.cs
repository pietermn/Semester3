using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using saAPI_DTO;
using saAPI_enums;

namespace saAPI_Interface_DAL
{
    public interface IMovieDAL
    {
        public Task<List<MovieDTO>> GetMoviesAsync(services service, types type);
    }
}
