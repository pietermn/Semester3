﻿using System;
namespace dbAPI_Logic.Models
{
    public class WatchList
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int imdbId { get; set; }
        public string Title { get; set; }
        public bool Watched { get; set; }

        public WatchList(int id, int acountid, int imdbid, string title, bool watched)
        {
            Id = id;
            AccountId = acountid;
            imdbId = imdbid;
            Title = title;
            Watched = watched;
        }
    }
}
