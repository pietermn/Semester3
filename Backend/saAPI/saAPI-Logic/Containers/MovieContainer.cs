using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using saAPI_DTO;
using saAPI_enums;
using saAPI_Interface_DAL;
using saAPI_Interfaces;

namespace saAPI_Logic.Containers
{
    public class MovieContainer : IMovieContainer
    {
        readonly IMovieDAL _movieDAL;
        public MovieContainer(IMovieDAL movieDAL)
        {
            _movieDAL = movieDAL;
        }

        public async Task<List<MovieDTO>> GetMoviesAsync(services service, types type)
        {
            return await _movieDAL.GetMoviesAsync(service, type);
        }
    }
}
