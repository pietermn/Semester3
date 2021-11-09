using System;
using System.Collections.Generic;

namespace saAPI_DAL
{
    public class JsonWrapper
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class BackdropURLs
        {
            public string _1280 { get; set; }
            public string _300 { get; set; }
            public string _780 { get; set; }
            public string original { get; set; }
        }

        public class PosterURLs
        {
            public string _154 { get; set; }
            public string _185 { get; set; }
            public string _342 { get; set; }
            public string _500 { get; set; }
            public string _780 { get; set; }
            public string _92 { get; set; }
            public string original { get; set; }
        }

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

        public class Result
        {
            public string imdbID { get; set; }
            public string tmdbID { get; set; }
            public int imdbRating { get; set; }
            public int imdbVoteCount { get; set; }
            public int tmdbRating { get; set; }
            public string backdropPath { get; set; }
            public BackdropURLs backdropURLs { get; set; }
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
            public PosterURLs posterURLs { get; set; }
            public int age { get; set; }
            public StreamingInfo streamingInfo { get; set; }
            public string originalLanguage { get; set; }
        }

        public class Root
        {
            public List<Result> results { get; set; }
            public int totalpages { get; set; }
        }
    }
}
