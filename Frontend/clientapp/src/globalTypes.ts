export type Movie = {
    imdbID: string;
    tmdbID: string;
    imdbRating: number;
    imdbVoteCount: number;
    tmdbRating: number;
    backdropPath: string;
    backdropURLs: string[];
    originalTitle: string;
    genres: number[];
    countries: string[];
    year: number;
    runtime: number;
    cast: string[];
    significants: string[];
    title: string;
    overview: string;
    tagline: string;
    video: string;
    posterPath: string;
    posterURLs: PosterURLs;
    age: number;
    streamingInfo: StreamingInfo;
    originalLanguage: string;
  };

export type StreamingInfo = {
    service: string;
    country: string;
    link: string;
    added: number;
    leaving: number;
};

export type PosterURLs = {
    original: string;
};