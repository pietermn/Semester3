using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using saAPI_DTO;
using saAPI_enums;

namespace saAPI_Interfaces
{
    public interface IMovieContainer
    {
        public Task<List<MovieDTO>> GetMoviesAsync(List<services> service, types type, int page);
        public Task<List<MovieDTO>> GetMoviesSearchAsync(List<services> services, types type, int page, string search);
    }
}
