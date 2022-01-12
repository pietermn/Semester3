using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<MovieDTO>> GetMoviesAsync(List<services> services, types type, int page)
        {
            List<MovieDTO> Movies = new();
            foreach (services service in services)
            {
                List<MovieDTO> moviestemp = await _movieDAL.GetMoviesAsync(service, type, page);
                Movies.AddRange(moviestemp);
            }

            return Movies;
        }

        public async Task<List<MovieDTO>> GetMoviesSearchAsync(List<services> services, types type, int page, string search)
        {
            List<MovieDTO> Movies = new();
            foreach (services service in services)
            {
                List<MovieDTO> moviestemp = await _movieDAL.GetMoviesSearchAsync(service, type, page, search);
                Movies.AddRange(moviestemp);
            }

            return Movies;
        }
    }
}
