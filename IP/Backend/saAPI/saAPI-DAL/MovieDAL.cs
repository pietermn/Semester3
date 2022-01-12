using System;
using System.Collections.Generic;
using saAPI_enums;
using saAPI_Interface_DAL;
using saAPI_DTO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Linq;

namespace saAPI_DAL
{
    public class MovieDAL : IMovieDAL
    {
        string host = "streaming-availability.p.rapidapi.com";
        string apikey = "6c7c427870msh77540ee5ce1cf0fp1589f8jsn9777cc8b6bb4";

        public async Task<List<MovieDTO>> GetMoviesAsync(services service, types type, int page)
        {
            string apiUrl = Environment.GetEnvironmentVariable("ApiUrl");
            string url = apiUrl + "?country=nl&order_by=original_title" + "&service=" + service + "&type=" + type + "&page=" + page + "&output_language=en&language=en";
            List<MovieDTO> movies = new();
            string apiKey = Environment.GetEnvironmentVariable("ApiKey");

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "x-rapidapi-host", host },
                    { "x-rapidapi-key", apiKey },
                },
            };

            using (var response = await client.SendAsync(request))
            {

                var Result = JsonSerializer.Deserialize<JsonWrapper.Root>(await response.Content.ReadAsStringAsync());
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                foreach(JsonWrapper.Result movie in Result.results)
                {
                    int add;
                    int leav;
                    string links;

                    switch (service)
                    {
                        case services.netflix:
                            add = movie.streamingInfo.netflix.nl.added;
                            leav = movie.streamingInfo.netflix.nl.leaving;
                            links = movie.streamingInfo.netflix.nl.link;
                            break;

                        case services.prime:
                            add = movie.streamingInfo.prime.nl.added;
                            leav = movie.streamingInfo.prime.nl.leaving;
                            links = movie.streamingInfo.prime.nl.link;
                            break;

                        case services.disney:
                            add = movie.streamingInfo.disney.nl.added;
                            leav = movie.streamingInfo.disney.nl.leaving;
                            links = movie.streamingInfo.disney.nl.link;
                            break;

                        case services.apple:
                            add = movie.streamingInfo.apple.nl.added;
                            leav = movie.streamingInfo.apple.nl.leaving;
                            links = movie.streamingInfo.apple.nl.link;
                            break;

                        default:
                            add = 0;
                            leav = 0;
                            links = "notfound";
                            break;
                    }

                    movies.Add(new MovieDTO {
                        imdbID = movie.imdbID,
                        tmdbID = movie.tmdbID,
                        imdbRating = movie.imdbRating,
                        imdbVoteCount = movie.imdbVoteCount,
                        tmdbRating = movie.tmdbRating,
                        backdropPath = movie.backdropPath,
                        originalTitle = movie.originalTitle,
                        genres = movie.genres,
                        countries = movie.countries,
                        year = movie.year,
                        runtime = movie.runtime,
                        cast = movie.cast,
                        significants = movie.significants,
                        title = movie.title,
                        overview = movie.overview,
                        tagline = movie.tagline,
                        video = movie.video,
                        posterPath = movie.posterPath,
                        posterURLs = new PosterURLs { original = movie.posterURLs.original },
                        age = movie.age,
                        streamingInfo = new StreamingInfo {
                            Service = service.ToString(),
                            Country = "NL",
                            added = add,
                            leaving = leav,
                            link = links },
                            originalLanguage = movie.originalLanguage
                            });
                }
            }

        

            

            return movies;
        }

        public async Task<List<MovieDTO>> GetMoviesSearchAsync(services service, types type, int page, string search)
        {
            string apiUrl = Environment.GetEnvironmentVariable("ApiUrl");
            string url = apiUrl + "?country=nl&order_by=original_title" + "&service=" + service + "&type=" + type + "&page=" + page + "&keyword=" + search + "&output_language=en&language=en";
            List<MovieDTO> movies = new();
            string apiKey = Environment.GetEnvironmentVariable("ApiKey");

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {

                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "x-rapidapi-host", host },
                    { "x-rapidapi-key", apiKey },
                },
            };

            using (var response = await client.SendAsync(request))
            {

                var Result = JsonSerializer.Deserialize<JsonWrapper.Root>(await response.Content.ReadAsStringAsync());
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                foreach (JsonWrapper.Result movie in Result.results)
                {
                    int add;
                    int leav;
                    string links;

                    switch (service)
                    {
                        case services.netflix:
                            add = movie.streamingInfo.netflix.nl.added;
                            leav = movie.streamingInfo.netflix.nl.leaving;
                            links = movie.streamingInfo.netflix.nl.link;
                            break;

                        case services.prime:
                            add = movie.streamingInfo.prime.nl.added;
                            leav = movie.streamingInfo.prime.nl.leaving;
                            links = movie.streamingInfo.prime.nl.link;
                            break;

                        case services.disney:
                            add = movie.streamingInfo.disney.nl.added;
                            leav = movie.streamingInfo.disney.nl.leaving;
                            links = movie.streamingInfo.disney.nl.link;
                            break;

                        case services.apple:
                            add = movie.streamingInfo.apple.nl.added;
                            leav = movie.streamingInfo.apple.nl.leaving;
                            links = movie.streamingInfo.apple.nl.link;
                            break;

                        default:
                            add = 0;
                            leav = 0;
                            links = "notfound";
                            break;
                    }

                    movies.Add(new MovieDTO
                    {
                        imdbID = movie.imdbID,
                        tmdbID = movie.tmdbID,
                        imdbRating = movie.imdbRating,
                        imdbVoteCount = movie.imdbVoteCount,
                        tmdbRating = movie.tmdbRating,
                        backdropPath = movie.backdropPath,
                        originalTitle = movie.originalTitle,
                        genres = movie.genres,
                        countries = movie.countries,
                        year = movie.year,
                        runtime = movie.runtime,
                        cast = movie.cast,
                        significants = movie.significants,
                        title = movie.title,
                        overview = movie.overview,
                        tagline = movie.tagline,
                        video = movie.video,
                        posterPath = movie.posterPath,
                        posterURLs = new PosterURLs { original = movie.posterURLs.original },
                        age = movie.age,
                        streamingInfo = new StreamingInfo
                        {
                            Service = service.ToString(),
                            Country = "NL",
                            added = add,
                            leaving = leav,
                            link = links
                        },
                        originalLanguage = movie.originalLanguage
                    });
                }
            }





            return movies;
        }

    }
}
