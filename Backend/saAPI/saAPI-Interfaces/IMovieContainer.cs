using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using saAPI_DTO;
using saAPI_enums;

namespace saAPI_Interfaces
{
    public interface IMovieContainer
    {
        public Task<List<MovieDTO>> GetMovies(services service, types type);
    }
}
