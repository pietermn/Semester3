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
    age: number;
    streamingInfo: StreamingInfo;
    originalLanguage: string;
  };

export type StreamingInfo = {
    netflix: Netflix;
};

export type Netflix = {
    nl: Nl;
};

export type Nl = {
    link: string;
    added: number;
    leaving: number;
};