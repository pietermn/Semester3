using System;
using System.Collections.Generic;

namespace saAPI_DTO
{
    public class Nl
    {
        public string link { get; set; }
        public int added { get; set; }
        public int leaving { get; set; }
    }

    public class Netflix
    {
        public Nl nl { get; set; }
    }

    public class StreamingInfo
    {
        public Netflix netflix { get; set; }
    }

    public class MovieDTO
    {
        public string imdbID { get; set; }
        public string tmdbID { get; set; }
        public int imdbRating { get; set; }
        public int imdbVoteCount { get; set; }
        public int tmdbRating { get; set; }
        public string backdropPath { get; set; }
        public List<string> backdropURLs { get; set; }
        public string originalTitle { get; set; }
        public List<int> genres { get; set; }
        public List<string> countries { get; set; }
        public int year { get; set; }
        public int runtime { get; set; }
        public List<string> cast { get; set; }
        public List<string> significants { get; set; }
        public string title { get; set; }
        public string overview { get; set; }
        public string tagline { get; set; }
        public string video { get; set; }
        public string posterPath { get; set; }
        public int age { get; set; }
        public StreamingInfo streamingInfo { get; set; }
        public string originalLanguage { get; set; }
    }

}