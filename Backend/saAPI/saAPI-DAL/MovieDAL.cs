using System;
using System.Collections.Generic;
using saAPI_enums;
using saAPI_Interface_DAL;
using saAPI_DTO;
using Flurl.Http;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace saAPI_DAL
{
    public class MovieDAL : IMovieDAL
    {
        string url = "https://streaming-availability.p.rapidapi.com/search/basic?country=us&service=netflix&type=movie&genre=18&page=1&output_language=en&language=en";
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

                var Result = JsonSerializer.Deserialize<JsonWrapper>(await response.Content.ReadAsStringAsync());
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                
                list.Add(1);
            }

            
            

            return movies;
        }

    }
}
