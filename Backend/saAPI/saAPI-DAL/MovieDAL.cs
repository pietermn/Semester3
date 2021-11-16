using System;
using System.Collections.Generic;
using saAPI_enums;
using saAPI_Interface_DAL;
using saAPI_DTO;
using Flurl.Http;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Linq;

namespace saAPI_DAL
{
    public class MovieDAL : IMovieDAL
    {
        string url = "https://streaming-availability.p.rapidapi.com/search/basic?country=nl&service=netflix&type=movie&genre=18&page=1&output_language=en&language=en";
        string host = "streaming-availability.p.rapidapi.com";
        string apikey = "6c7c427870msh77540ee5ce1cf0fp1589f8jsn9777cc8b6bb4";

        public async Task<List<MovieDTO>> GetMoviesAsync(services service, types type)
        {
            List<MovieDTO> movies = new();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "x-rapidapi-host", host },
                    { "x-rapidapi-key", apikey },
                },
            };
            List<int> list = new();
            

            using (var response = await client.SendAsync(request))
            {

                var Result = JsonSerializer.Deserialize<JsonWrapper.Root>(await response.Content.ReadAsStringAsync());
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                foreach(JsonWrapper.Result movie in Result.results)
                {
                    movies.Add(new MovieDTO { imdbID = movie.imdbID, tmdbID = movie.tmdbID, imdbRating = movie.imdbRating, imdbVoteCount = movie.imdbVoteCount, tmdbRating = movie.tmdbRating, backdropPath = movie.backdropPath, originalTitle = movie.originalTitle, genres = movie.genres, countries = movie.countries, year = movie.year, runtime = movie.runtime, cast = movie.cast, significants = movie.significants, title = movie.title, overview = movie.overview, tagline = movie.tagline, video = movie.video, posterPath = movie.posterPath, posterURLs = new PosterURLs { original = movie.posterURLs.original },age = movie.age, streamingInfo = new StreamingInfo { Service = "Netflix", Country = "NL", added = movie.streamingInfo.netflix.nl.added, leaving = movie.streamingInfo.netflix.nl.leaving, link = movie.streamingInfo.netflix.nl.link }, originalLanguage = movie.originalLanguage }); ; ;
                }
                list.Add(1);
            }

            
            

            return movies;
        }

    }
}
