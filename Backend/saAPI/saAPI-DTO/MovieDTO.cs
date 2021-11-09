using System;
using System.Collections.Generic;

namespace saAPI_DTO
{
    public class MovieDTO
    {
        public string imdbID;
        public int tmdbID;
        public int imdbRatingimdbRating;
        public int imdbVoteCount;
        public int tmdbRating;
        public string backdropPath;
        //public List<string> backdropURLs = new();
        public string originalTitle;
        //public List<int> genres = new();
        //public List<string> countries = new();
        public int year;
        public int runtime;
        //public List<string> cast = new();
        //public List<string> significants = new();
        public string title;
        public string overview;
        public string tagline;
        public string video;
        public string posterPath;
        //public List<string> posterUrls = new();
        public int age;
        //public List<List<string>> streamingInfo = new();
        public string originalLanguage;
    }

}